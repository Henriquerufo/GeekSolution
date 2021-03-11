using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class FrmCadastro : Form
    {
        string codigo;
        ModelCadastro modelCadastro = new ModelCadastro();
        ControllerCadastro controllerCadastro = new ControllerCadastro();
        public FrmCadastro(ModelCadastro modelCadastro)
        {
            InitializeComponent();
            Height = 496;
            Width = 405;
            dgvPedidoItens.Visible = false;
            dgvPedidoItensCancelados.Visible = false;
            lblExibidosTotal.Visible = false;
            lblExibidosTotalCancelados.Visible = false;
            txtDtCadastro.Text = DateTime.Now.ToString();
            if (!string.IsNullOrWhiteSpace(modelCadastro.Codigo))
            {
                Text = "Editar Cliente";
                btnSalvar.Text = "Editar";
                pnlCadastro.Enabled = false;
                lblCadastrar.Text = "Editar";
                codigo = modelCadastro.Codigo;
                txtRG.Text = modelCadastro.RG;
                txtCPF.Text = modelCadastro.CPF;
                txtNome.Text = modelCadastro.Nome;
                txtDtCadastro.Text = modelCadastro.dtCadastro;
                txtEndereco.Text = modelCadastro.Endereco;
                txtTelefone.Text = modelCadastro.Telefone;
                txtEmail.Text = modelCadastro.Email;
            }
            if (modelCadastro.consulta == true)
            {
                Height = 496;
                Width = 1013;
                lblExibidosTotal.Visible = true;
                lblExibidosTotalCancelados.Visible = true;
                dgvPedidoItens.Visible = true;
                dgvPedidoItensCancelados.Visible = true;
                Text = "Consultar Cliente";
                btnCancelar.Text = "Fechar";
                btnSalvar.Visible = false;
                pnlCadastro.Enabled = false;
                lblCadastrar.Text = "Consultar";
                codigo = modelCadastro.Codigo;
                txtRG.Text = modelCadastro.RG;
                txtCPF.Text = modelCadastro.CPF;
                txtNome.Text = modelCadastro.Nome;
                txtDtCadastro.Text = modelCadastro.dtCadastro;
                txtEndereco.Text = modelCadastro.Endereco;
                txtTelefone.Text = modelCadastro.Telefone;
                txtEmail.Text = modelCadastro.Email;
                dgvPedidoItens.DataSource = controllerCadastro.CarregarPedidosItens(txtNome.Text);
                dgvPedidoItensCancelados.DataSource = controllerCadastro.CarregarPedidosItensCancelados(txtNome.Text);
                lblExibidosTotal.Text = "Exibidos total: " + dgvPedidoItens.Rows.Count;
                lblExibidosTotalCancelados.Text = "Exibidos total: " + dgvPedidoItensCancelados.Rows.Count;
            }
        }
        public bool Validar()
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                errorProvider.SetError(txtNome, "Informe o nome do cliente");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRG.Text))
            {
                errorProvider.SetError(txtRG, "Informe o RG do cliente");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                errorProvider.SetError(txtCPF, "Informe o CPF do cliente");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDtCadastro.Text))
            {
                errorProvider.SetError(txtDtCadastro, "Informe a data de cadastro do cliente");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                errorProvider.SetError(txtTelefone, "Informe o telefone do cliente");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Informe o email do cliente");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                errorProvider.SetError(txtEndereco, "Informe o endereço do cliente");
                return false;
            }
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Editar")
            {
                btnSalvar.Text = "Salvar";
                pnlCadastro.Enabled = true;
            }
            else if (btnSalvar.Text == "Salvar" && Validar() && !string.IsNullOrWhiteSpace(codigo))
            {
                modelCadastro.Codigo = codigo;
                modelCadastro.Nome = txtNome.Text;
                modelCadastro.RG = txtRG.Text;
                modelCadastro.CPF = txtCPF.Text;
                modelCadastro.dtCadastro = txtDtCadastro.Text;
                modelCadastro.Email = txtEmail.Text;
                modelCadastro.Endereco = txtEndereco.Text;
                modelCadastro.Telefone = txtTelefone.Text;

                bool retorno = controllerCadastro.Editar(modelCadastro);
                if (retorno)
                {
                    MessageBox.Show("Editado com sucesso!");
                    this.Close();
                }
            }
            else if (btnSalvar.Text == "Salvar" && Validar())
            {
                modelCadastro.Nome = txtNome.Text;
                modelCadastro.RG = txtRG.Text;
                modelCadastro.CPF = txtCPF.Text;
                modelCadastro.dtCadastro = txtDtCadastro.Text;
                modelCadastro.Email = txtEmail.Text;
                modelCadastro.Endereco = txtEndereco.Text;
                modelCadastro.Telefone = txtTelefone.Text;
                bool retorno = controllerCadastro.Cadastrar(modelCadastro);
                if (retorno)
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
