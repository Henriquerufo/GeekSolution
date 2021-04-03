using Model;
using Controller;
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
    public partial class FrmCadastrarProduto : Form
    {
        string codigo;
        ModelCadastroProduto modelCadastroProduto = new ModelCadastroProduto();
        ControllerCadastroProduto controllerCadastroProduto = new ControllerCadastroProduto();
        ControllerTema controllerTema = new ControllerTema();
        public FrmCadastrarProduto(ModelCadastroProduto modelCadastroProduto)
        {
            InitializeComponent();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
            if (!string.IsNullOrWhiteSpace(modelCadastroProduto.Codigo))
            {
                Text = "Editar Produto";
                btnSalvar.Text = "Editar";
                pnlCadastroProduto.Enabled = false;
                lblCadastrar.Text = "Editar";
                codigo = modelCadastroProduto.Codigo;
                txtCodigoBarras.Text = modelCadastroProduto.CodigoBarras;
                txtNomeProduto.Text = modelCadastroProduto.NomeProduto;
                txtCategoria.Text = modelCadastroProduto.Categoria;
                txtFabricante.Text = modelCadastroProduto.Fabricante;
                txtQuantidade.Value = Convert.ToInt32(modelCadastroProduto.Quantidade);
                txtValorProduto.Text = modelCadastroProduto.ValorProduto;
                txtPlataforma.Text = modelCadastroProduto.Plataforma;
                txtGarantia.Text = modelCadastroProduto.Garantia;
            }
            if (modelCadastroProduto.Consultar == true)
            {
                Text = "Consultar Produto";
                btnCancelar.Text = "Fechar";
                btnSalvar.Visible = false;
                lblCadastrar.Text = "Consultar";
                pnlCadastroProduto.Enabled = false;
                txtCodigoBarras.Text = modelCadastroProduto.CodigoBarras;
                txtNomeProduto.Text = modelCadastroProduto.NomeProduto;
                txtCategoria.Text = modelCadastroProduto.Categoria;
                txtFabricante.Text = modelCadastroProduto.Fabricante;
                txtQuantidade.Value = Convert.ToInt32(modelCadastroProduto.Quantidade);
                txtValorProduto.Text = modelCadastroProduto.ValorProduto;
                txtPlataforma.Text = modelCadastroProduto.Plataforma;
                txtGarantia.Text = modelCadastroProduto.Garantia;
            }
        }
        bool Validar()
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtCodigoBarras.Text))
            {
                errorProvider.SetError(txtCodigoBarras, "Informe o codigo de barras do produto");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNomeEmpresa.Text))
            {
                errorProvider.SetError(txtNomeEmpresa, "Informe o nome da empresa");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                errorProvider.SetError(txtNomeProduto, "Informe o nome do produto");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                errorProvider.SetError(txtCategoria, "Informe a categoria do produto");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFabricante.Text))
            {
                errorProvider.SetError(txtFabricante, "Informe o fabricante do produto");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCodigoBarras.Text))
            {
                errorProvider.SetError(txtCodigoBarras, "Informe a quantidade do produto");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtValorProduto.Text))
            {
                errorProvider.SetError(txtValorProduto, "Informe o valor do produto");
                return false;
            }
            if (txtCategoria.Text == "Acessórios" || txtCategoria.Text == "Jogos")
            {
                if (string.IsNullOrWhiteSpace(txtPlataforma.Text))
                {
                    errorProvider.SetError(txtPlataforma, "Informe a plataforma do produto");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtGarantia.Text))
                {
                    errorProvider.SetError(txtGarantia, "Informe a garantia do produto");
                    return false;
                }
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
                    pnlCadastroProduto.Enabled = true;
                }
                else
                {
                    if (Validar())
                    {
                        if (!string.IsNullOrWhiteSpace(codigo))
                        {
                            modelCadastroProduto.Codigo = codigo;
                            modelCadastroProduto.CodigoBarras = txtCodigoBarras.Text;
                            modelCadastroProduto.NomeProduto = txtNomeProduto.Text;
                            modelCadastroProduto.Categoria = txtCategoria.Text;
                            modelCadastroProduto.Fabricante = txtFabricante.Text;
                            modelCadastroProduto.Quantidade = txtQuantidade.Value.ToString();
                            modelCadastroProduto.ValorProduto = txtValorProduto.Text;
                            modelCadastroProduto.Plataforma = txtPlataforma.Text;
                            modelCadastroProduto.Garantia = txtGarantia.Text;
                            modelCadastroProduto.NomeEmpresa = txtNomeEmpresa.Text;
                            bool retorno = controllerCadastroProduto.Editar(modelCadastroProduto);
                            if (retorno)
                            {
                                MessageBox.Show("Editado com sucesso!");
                                this.Close();
                            }
                        }
                        else
                        {
                            modelCadastroProduto.CodigoBarras = txtCodigoBarras.Text;
                            modelCadastroProduto.NomeProduto = txtNomeProduto.Text;
                            modelCadastroProduto.Categoria = txtCategoria.Text;
                            modelCadastroProduto.Fabricante = txtFabricante.Text;
                            modelCadastroProduto.Quantidade = txtQuantidade.Value.ToString();
                            modelCadastroProduto.ValorProduto = txtValorProduto.Text;
                            modelCadastroProduto.Plataforma = txtPlataforma.Text;
                            modelCadastroProduto.Garantia = txtGarantia.Text;
                            modelCadastroProduto.NomeEmpresa = txtNomeEmpresa.Text;
                            if (controllerCadastroProduto.VerificarProdutoCadastrado(modelCadastroProduto))
                            {
                                bool retorno = controllerCadastroProduto.Cadastrar(modelCadastroProduto);
                                if (retorno)
                                {
                                    MessageBox.Show("Cadastrado com sucesso!");
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Código de barras já cadastrado!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCodigoBarras.Focus();
                            }
                        }
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
        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "Acessórios" || txtCategoria.Text == "Jogos")
            {
                txtPlataforma.Enabled = true;
                txtGarantia.Enabled = true;
            }
            else
            {
                txtPlataforma.Enabled = false;
                txtGarantia.Enabled = false;
            }
        }
        private void FrmCadastrarProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.BackgroundImage.Dispose();
        }

        private void btnSelecionarEmpresa_Click(object sender, EventArgs e)
        {
            FrmGerenciarEmpresa frmGerenciarEmpresa = new FrmGerenciarEmpresa(true);
            frmGerenciarEmpresa.ShowDialog();
            if (frmGerenciarEmpresa.RetornoNomeEmpresa != "")
            {
                txtNomeEmpresa.Text = frmGerenciarEmpresa.RetornoNomeEmpresa;
            }
        }
    }
}
