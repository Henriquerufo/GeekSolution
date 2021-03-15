using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;
using MySqlX.XDevAPI.Relational;

namespace View
{
    public partial class FrmCaixa : Form
    {
        ModelCaixa modelCaixa = new ModelCaixa();
        ControllerCaixa controllerCaixa = new ControllerCaixa();
        ControllerTema controllerTema = new ControllerTema();
        int QuantidadeAdicionada = 1;
        int valorTotal = 0;
        public FrmCaixa()
        {
            InitializeComponent();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
        }

        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            //Adiciona o protudo na lista pelo codigo de barras
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 1; i <= txtQuantidade.Value; i++)
                {
                    QuantidadeAdicionada = 1;
                    foreach (DataGridViewRow row in dgvCaixa.Rows)
                    {
                        if (row.Cells["CodigoBarras"].Value != null && (string)row.Cells["CodigoBarras"].Value == txtCodigoBarras.Text)
                        {
                            QuantidadeAdicionada++;
                        }
                    }
                    modelCaixa = controllerCaixa.VerificarProduto(txtCodigoBarras.Text);
                    if (controllerCaixa.VerificarProduto(txtCodigoBarras.Text) == null || QuantidadeAdicionada > controllerCaixa.VerificarQuantidade(txtCodigoBarras.Text))
                    {
                        txtCodigoBarras.ForeColor = Color.Red;
                        MessageBox.Show("Produto não existe no estoque!");
                        txtCodigoBarras.Text = null;
                        txtCodigoBarras.ForeColor = Color.Black;
                        txtCodigoBarras.Focus();
                        txtQuantidade.Value = 1;
                    }
                    else
                    {
                        dgvCaixa.Rows.Insert(0, modelCaixa.Codigo, modelCaixa.NomeProduto, modelCaixa.Categoria, modelCaixa.Fabricante, modelCaixa.CodigoBarras, modelCaixa.ValorProduto);
                        valorTotal = valorTotal + Convert.ToInt32(modelCaixa.ValorProduto);
                        txtValorTotal.Text = valorTotal.ToString("C");
                        int valorUnitario;
                        valorUnitario = Convert.ToInt32(modelCaixa.ValorProduto);
                        txtValorUnitario.Text = valorUnitario.ToString("C");
                        txtNomeProduto.Text = modelCaixa.NomeProduto;
                        dgvCaixa.Rows[0].Selected = true;
                        
                    }
                }
            }
            //Finalza a venda na função dinheiro
            else if (e.KeyCode == Keys.F1)
            {

            }
        }
    }
}
