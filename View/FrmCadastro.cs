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
        ControllerTema controllerTema = new ControllerTema();
        public FrmCadastro(ModelCadastro modelCadastro)
        {
            InitializeComponent();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
            Height = 638;
            Width = 405;
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
                cbxFiltroPedido.SelectedIndex = 0;
                cbxFiltroPedidoCancelado.SelectedIndex = 0;
                Height = 638;
                Width = 1190;
                pnlConsultar.Visible = true;
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPesquisarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxFiltroPedido.Text == "CODIGO PEDIDO")
                {
                    if (rbRecebido.Checked)
                    {
                        dgvPedidoItens.DataSource = controllerCadastro.CarregarPedidosItensCodigoPedidoPagamentoRecebido(txtNome.Text, txtProcurarPedido.Text);
                    }
                    else if (rbEmAberto.Checked)
                    {
                        dgvPedidoItens.DataSource = controllerCadastro.CarregarPedidosItensCodigoPedidoPagamentoEmAberto(txtNome.Text, txtProcurarPedido.Text);
                    }
                }
                if (cbxFiltroPedido.Text == "NOME PRODUTO")
                {
                    if (rbRecebido.Checked)
                    {
                        dgvPedidoItens.DataSource = controllerCadastro.CarregarPedidosItensNomeProdutoPagamentoRecebido(txtNome.Text, txtProcurarPedido.Text);
                    }
                    else if (rbEmAberto.Checked)
                    {
                        dgvPedidoItens.DataSource = controllerCadastro.CarregarPedidosItensNomeProdutoPagamentoEmAberto(txtNome.Text, txtProcurarPedido.Text);
                    }
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvPedidoItens.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPesquisarPedidoCancelado_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxFiltroPedidoCancelado.Text == "CODIGO PEDIDO")
                {
                    dgvPedidoItensCancelados.DataSource = controllerCadastro.CarregarPedidosItensCanceladosCodigoPedido(txtNome.Text, txtProcurarPedidoCancelado.Text);
                }
                if (cbxFiltroPedidoCancelado.Text == "NOME PRODUTO")
                {
                    dgvPedidoItensCancelados.DataSource = controllerCadastro.CarregarPedidosItensCanceladosNomeProduto(txtNome.Text, txtProcurarPedidoCancelado.Text);
                }
                lblExibidosTotalCancelados.Text = "Exibidos total: " + dgvPedidoItensCancelados.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.BackgroundImage.Dispose();
        }
        private void dgvPedidoItens_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPedidoItens.Rows.Count > 0 && dgvPedidoItens.CurrentRow.Cells["statusPagamento"].Value.ToString() == "Em Aberto")
            {
                modelCadastro.RecebidoPor = Properties.SettingsLogado.Default.Nome;
                modelCadastro.CodigoPedido = dgvPedidoItens.CurrentRow.Cells["codigoPedido"].Value.ToString();
                modelCadastro.Codigo = dgvPedidoItens.CurrentRow.Cells["Cod"].Value.ToString();
                modelCadastro.DataRecebimento = DateTime.Now.ToString();
                var result = MessageBox.Show("Esse item: " + dgvPedidoItens.CurrentRow.Cells["NomeProduto"].Value.ToString() + " no valor: R$" + dgvPedidoItens.CurrentRow.Cells["ValorProduto"].Value.ToString() + " foi recebido?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (controllerCadastro.ReceberItemEmAberto(modelCadastro))
                    {
                        if (!controllerCadastro.VerificarPedidoEmAberto(modelCadastro))
                        {
                            controllerCadastro.AlterarStatusPagamentoPedido(modelCadastro);
                        }
                        MessageBox.Show("Recebido com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
