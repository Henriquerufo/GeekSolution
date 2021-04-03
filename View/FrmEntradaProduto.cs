using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmEntradaProduto : Form
    {
        ControllerEntradaProduto controllerEntradaProduto = new ControllerEntradaProduto();
        ModelEntradaProduto modelEntradaProduto = new ModelEntradaProduto();
        ControllerTema controllerTema = new ControllerTema();
        private Font printFont;
        Pen pen = new Pen(Color.Black);
        int linhasPorPagina = 65;
        int i;
        int i2;
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
                if (controllerEntradaProduto.CarregarCodigoBarras(txtCodigoBarras.Text) == null)
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
                    for (int i = 1; i <= txtQuantidade.Value; i++)
                    {
                        modelEntradaProduto = controllerEntradaProduto.CarregarCodigoBarras(txtCodigoBarras.Text);
                        dgvEntrada.Rows.Insert(0, modelEntradaProduto.Codigo, modelEntradaProduto.NomeProduto, modelEntradaProduto.Categoria, modelEntradaProduto.Fabricante, modelEntradaProduto.CodigoBarras, modelEntradaProduto.Plataforma, modelEntradaProduto.Garantia,modelEntradaProduto.NomeEmpresa, modelEntradaProduto.ValorProduto);
                        int valorUnitario;
                        valorUnitario = Convert.ToInt32(modelEntradaProduto.ValorProduto);
                        txtQuantidadeEstoque.Text = modelEntradaProduto.Quantidade;
                        txtValorUnitario.Text = valorUnitario.ToString("C");
                        txtNomeProduto.Text = modelEntradaProduto.NomeProduto;
                        dgvEntrada.Rows[0].Selected = true;
                    }
                }
            }
            if (e.KeyCode == Keys.F1)
            {
                if (dgvEntrada.Rows.Count > 0)
                {
                    try
                    {
                        var result = MessageBox.Show("Finalizar?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            modelEntradaProduto.NomeEmpresa = dgvEntrada.CurrentRow.Cells["NomeEmpresa"].Value.ToString();
                            modelEntradaProduto.Estoquista = Properties.SettingsLogado.Default.Nome;
                            modelEntradaProduto.DataRecebido = DateTime.Now.ToString();
                            modelEntradaProduto.QuantidadeItens = dgvEntrada.Rows.Count.ToString();
                            int CodigoEntradaProduto = controllerEntradaProduto.InserirEntradaProduto(modelEntradaProduto);
                            foreach (DataGridViewRow row in dgvEntrada.Rows)
                            {
                                modelEntradaProduto.CodigoEntradaProduto = CodigoEntradaProduto;
                                modelEntradaProduto.NomeProduto = row.Cells["NomeProduto"].Value.ToString();
                                modelEntradaProduto.NomeEmpresa = row.Cells["NomeEmpresa"].Value.ToString();
                                modelEntradaProduto.Estoquista = Properties.SettingsLogado.Default.Nome;
                                modelEntradaProduto.DataRecebido = DateTime.Now.ToString();
                                modelEntradaProduto.CodigoBarras = row.Cells["CodigoBarras"].Value.ToString();
                                modelEntradaProduto.Categoria = row.Cells["Categoria"].Value.ToString();
                                modelEntradaProduto.Fabricante = row.Cells["Fabricante"].Value.ToString();
                                modelEntradaProduto.ValorProduto = row.Cells["ValorProduto"].Value.ToString();
                                modelEntradaProduto.Plataforma = row.Cells["Plataforma"].Value.ToString();
                                modelEntradaProduto.Garantia = row.Cells["Garantia"].Value.ToString();
                                controllerEntradaProduto.InserirEntradaProdutoItens(modelEntradaProduto);
                                controllerEntradaProduto.MaisQuantidadeEstoque(modelEntradaProduto);
                            }
                            var result2 = MessageBox.Show("Finalizado com sucesso!\nDeseja realizar a impressão?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result2 == DialogResult.Yes)
                            {
                                if (dgvEntrada.Rows.Count > 0)
                                {
                                    try
                                    {
                                        printFont = new Font("Arial", 9);
                                        PrintDocument pd = new PrintDocument();
                                        printDialog1.Document = pd;
                                        var result3 = printDialog1.ShowDialog();
                                        if (result3 == DialogResult.OK)
                                        {
                                            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                                            pd.Print();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                ZerarCampos();
                            }
                            else
                            {
                                ZerarCampos();
                            }
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void FrmEntradaProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.BackgroundImage.Dispose();
        }
        void ZerarCampos()
        {
            txtCodigoBarras.Text = null;
            txtQuantidade.Value = 1;
            dgvEntrada.Rows.Clear();
            txtValorUnitario.Text = null;
            txtQuantidadeEstoque.Text = null;
            txtNomeProduto.Text = null;
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float x = ev.MarginBounds.Left;
            float y = 0;
            float count = 0;

            ev.Graphics.DrawString("TEC SISTEMAS - COMPROVANTE", printFont, Brushes.Black, 320, 10, new StringFormat());
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, 30, ev.MarginBounds.Right, 30);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, 30, ev.MarginBounds.Left, ev.MarginBounds.Top + 11);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Right, 30, ev.MarginBounds.Right, ev.MarginBounds.Top + 11);
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Codigo: " + modelEntradaProduto.CodigoEntradaProduto, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Empresa: " + modelEntradaProduto.NomeEmpresa, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Data: " + DateTime.Now.ToString(), printFont, Brushes.Black, ev.MarginBounds.Left + 300, y, new StringFormat());
            ev.Graphics.DrawString("Item Total: " + dgvEntrada.Rows.Count.ToString(), printFont, Brushes.Black, ev.MarginBounds.Right - 153, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 75);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, y, ev.MarginBounds.Right, y);
            count++;
            ev.Graphics.DrawString("CÓD       " + "NOME ", printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            ev.Graphics.DrawString("VALOR UNITÁRIO ", printFont, Brushes.Black, ev.MarginBounds.Right - 110, y, new StringFormat());

            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 75);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, y, ev.MarginBounds.Right, y);

            for (i2 = 0; i2 < linhasPorPagina; i2++)
            {
                if (i < dgvEntrada.Rows.Count)
                {
                    string linha = ".  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .";
                    y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 70);
                    ev.Graphics.DrawString(linha, printFont, Brushes.Black, 340, y, new StringFormat());

                    string Cod = dgvEntrada.Rows[i].Cells["Codigo"].Value.ToString();
                    string NomeProduto = dgvEntrada.Rows[i].Cells["NomeProduto"].Value.ToString();
                    y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 70);
                    ev.Graphics.DrawString(Cod + "...    " + NomeProduto, printFont, Brushes.Black, ev.MarginBounds.Left + 2, y, new StringFormat());

                    int ValorTotal = Convert.ToInt32(dgvEntrada.Rows[i].Cells["ValorProduto"].Value.ToString());
                    y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 70);
                    ev.Graphics.DrawString(ValorTotal.ToString("C"), printFont, Brushes.Black, ev.MarginBounds.Right - 85, y, new StringFormat());
                    count++;
                    i++;
                }
                else
                {

                    ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, ev.MarginBounds.Bottom, ev.MarginBounds.Right, ev.MarginBounds.Bottom);
                    ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, ev.MarginBounds.Bottom + 70, ev.MarginBounds.Right, ev.MarginBounds.Bottom + 70);
                    //Zera o contador do dgv
                    i = 0;
                    //força a saida do For se os itens do dgv acabar
                    i2 = 100;
                }
            }
            //se o for chegar no tanto de linha, ele entra no if
            if (i2 == linhasPorPagina)
            {
                ev.HasMorePages = true;
                return;
            }
            else
            {
                ev.HasMorePages = false;
            }
        }
    }
}