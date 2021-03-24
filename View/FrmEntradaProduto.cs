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
    public partial class FrmEntradaProduto : Form
    {
        ControllerCadastroProduto controllerCadastroProduto = new ControllerCadastroProduto();
        ModelCadastroProduto modelCadastroProduto = new ModelCadastroProduto();
        ControllerTema controllerTema = new ControllerTema();
        public FrmEntradaProduto()
        {
            InitializeComponent();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
        }
        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 1; i <= txtQuantidade.Value; i++)
                {
                    modelCadastroProduto.CodigoBarras = txtCodigoBarras.Text;
                    if (!controllerCadastroProduto.VerificarProdutoCadastrado(modelCadastroProduto))
                    {
                        if (controllerCadastroProduto.MaisQuantidadeEstoque(modelCadastroProduto))
                        {
                            modelCadastroProduto = controllerCadastroProduto.CarregarCodigoBarras(txtCodigoBarras.Text, modelCadastroProduto);
                            txtNomeProduto.Text = modelCadastroProduto.NomeProduto;
                            txtQuantidadeEstoque.Text = modelCadastroProduto.Quantidade;
                            int valorProduto = Convert.ToInt32(modelCadastroProduto.ValorProduto);
                            txtValorUnitario.Text = valorProduto.ToString("C");
                            pnlCodigoEncontrado.Visible = true;
                            pnlCodigoNaoEncontrado.Visible = false;
                        }
                    }
                    else
                    {
                        txtNomeProduto.Text = null;
                        txtQuantidadeEstoque.Text = null;
                        txtValorUnitario.Text = null;
                        pnlCodigoNaoEncontrado.Visible = true;
                        pnlCodigoEncontrado.Visible = false;
                        txtQuantidade.Value = 1;
                    }
                }
            }
        }

        private void FrmEntradaProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.BackgroundImage.Dispose();
        }
    }
}