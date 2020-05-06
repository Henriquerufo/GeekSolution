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
        public FrmCadastrarProduto(ModelCadastroProduto modelCadastroProduto)
        {
            InitializeComponent();
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
                txtQuantidade.Text = modelCadastroProduto.Quantidade;
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
                txtQuantidade.Text = modelCadastroProduto.Quantidade;
                txtValorProduto.Text = modelCadastroProduto.ValorProduto;
                txtPlataforma.Text = modelCadastroProduto.Plataforma;
                txtGarantia.Text = modelCadastroProduto.Garantia;
            }
        }
        bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBarras.Text))
            {
                errorProvider.SetError(txtCodigoBarras, "Informe o codigo de barras do produto");
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
            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                errorProvider.SetError(txtQuantidade, "Informe a quantidade do produto");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtValorProduto.Text))
            {
                errorProvider.SetError(txtValorProduto, "Informe o valor do produto");
                return false;
            }
            if (chbJogosAcessorios.Checked == true)
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
                        modelCadastroProduto.Quantidade = txtQuantidade.Text;
                        modelCadastroProduto.ValorProduto = txtValorProduto.Text;
                        modelCadastroProduto.Plataforma = txtPlataforma.Text;
                        modelCadastroProduto.Garantia = txtGarantia.Text;

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
                        modelCadastroProduto.Quantidade = txtQuantidade.Text;
                        modelCadastroProduto.ValorProduto = txtValorProduto.Text;
                        modelCadastroProduto.Plataforma = txtPlataforma.Text;
                        modelCadastroProduto.Garantia = txtGarantia.Text;

                        bool retorno = controllerCadastroProduto.Cadastrar(modelCadastroProduto);
                        if (retorno)
                        {
                            MessageBox.Show("Cadastrado com sucesso!");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void chbJogosAcessorios_CheckedChanged(object sender, EventArgs e)
        {
            if (chbJogosAcessorios.Checked == true)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
