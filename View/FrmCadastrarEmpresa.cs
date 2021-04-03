using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmCadastrarEmpresa : Form
    {
        string codigo;
        ControllerEmpresa controllerEmpresa = new ControllerEmpresa();
        ControllerTema controllerTema = new ControllerTema();
        ModelEmpresa modelEmpresa = new ModelEmpresa();
        public FrmCadastrarEmpresa(ModelEmpresa modelEmpresa)
        {
            InitializeComponent();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
            if (modelEmpresa.Editar)
            {
                codigo = modelEmpresa.Codigo.ToString();
                txtNomeEmpresa.Text = modelEmpresa.NomeEmpresa;
                txtCNPJ.Text = modelEmpresa.CNPJ;
                txtDtCadastro.Text = modelEmpresa.DataCadastro;
                txtTelefone.Text = modelEmpresa.Telefone;
                txtEmail.Text = modelEmpresa.Email;
                txtEndereco.Text = modelEmpresa.Endereco;
                txtNumero.Text = modelEmpresa.Numero;
                txtComplemento.Text = modelEmpresa.Complemento;
                txtBairro.Text = modelEmpresa.Bairro;
                txtCEP.Text = modelEmpresa.CEP;
                pnlCadastrarEmpresa.Enabled = false;
                btnSalvar.Text = "Editar";
                btnCancelar.Text = "Fechar";
                Width = 396;
                Height = 509;
                lblCadastrar.Text = "Editar";
                
            }
            else if (modelEmpresa.Cadasrar)
            {
                Width = 396;
                Height = 509;
                txtDtCadastro.Text = DateTime.Now.ToString();
            }
            else if (modelEmpresa.Consultar)
            {
                txtNomeEmpresa.Text = modelEmpresa.NomeEmpresa;
                txtCNPJ.Text = modelEmpresa.CNPJ;
                txtDtCadastro.Text = modelEmpresa.DataCadastro;
                txtTelefone.Text = modelEmpresa.Telefone;
                txtEmail.Text = modelEmpresa.Email;
                txtEndereco.Text = modelEmpresa.Endereco;
                txtNumero.Text = modelEmpresa.Numero;
                txtComplemento.Text = modelEmpresa.Complemento;
                txtBairro.Text = modelEmpresa.Bairro;
                txtCEP.Text = modelEmpresa.CEP;
                pnlCadastrarEmpresa.Enabled = false;
                pnlConsultar.Visible = true;
                btnSalvar.Visible = false;
                btnCancelar.Text = "Fechar";
                cbxFiltroPedido.SelectedIndex = 0;
                lblCadastrar.Text = "Consultar";
            }
        }
        void Carregar()
        {
            try
            {
                if (cbxFiltroPedido.Text == "CODIGO")
                {
                    dgvEntrada.DataSource = controllerEmpresa.CarregarEntradaPorCodigo(txtProcurarPedido.Text, txtNomeEmpresa.Text);
                }
                else if (cbxFiltroPedido.Text == "CODIGO PEDIDO")
                {
                    dgvEntrada.DataSource = controllerEmpresa.CarregarEntradaPorCodigoPedido(txtProcurarPedido.Text, txtNomeEmpresa.Text);
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvEntrada.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                modelEmpresa.NomeEmpresa = txtNomeEmpresa.Text;
                modelEmpresa.DataCadastro = txtDtCadastro.Text;
                modelEmpresa.CNPJ = txtCNPJ.Text;
                modelEmpresa.Telefone = txtTelefone.Text;
                modelEmpresa.Email = txtEmail.Text;
                modelEmpresa.Endereco = txtEndereco.Text;
                modelEmpresa.Numero = txtNumero.Text;
                modelEmpresa.Bairro = txtBairro.Text;
                modelEmpresa.Complemento = txtComplemento.Text;
                modelEmpresa.CEP = txtCEP.Text;
                if (controllerEmpresa.Cadastrar(modelEmpresa))
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if (!string.IsNullOrWhiteSpace(codigo))
            {
                if (btnSalvar.Text == "Editar")
                {
                    btnSalvar.Text = "Salvar";
                    btnCancelar.Text = "Cancelar";
                    pnlCadastrarEmpresa.Enabled = true;
                }
                else if (btnSalvar.Text == "Salvar")
                {
                    modelEmpresa.Codigo = Convert.ToInt32(codigo);
                    modelEmpresa.NomeEmpresa = txtNomeEmpresa.Text;
                    modelEmpresa.DataCadastro = txtDtCadastro.Text;
                    modelEmpresa.CNPJ = txtCNPJ.Text;
                    modelEmpresa.Telefone = txtTelefone.Text;
                    modelEmpresa.Email = txtEmail.Text;
                    modelEmpresa.Endereco = txtEndereco.Text;
                    modelEmpresa.Numero = txtNumero.Text;
                    modelEmpresa.Bairro = txtBairro.Text;
                    modelEmpresa.Complemento = txtComplemento.Text;
                    modelEmpresa.CEP = txtCEP.Text;
                    if (controllerEmpresa.Editar(modelEmpresa))
                    {
                        MessageBox.Show("Editado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisarPedido_Click(object sender, EventArgs e)
        {
            Carregar();
        }

        private void FrmCadastrarEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.BackgroundImage.Dispose();
        }
    }
}
