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
        bool VendaFinalizada = false;
        int QuantidadeAdicionada = 1;
        int valorTotal = 0;
        decimal dinheiroPago = 0;
        decimal cartaoPago = 0;
        decimal ticketPago = 0;
        decimal conveniadoValor = 0;
        decimal valortotalPago = 0;
        decimal valorVenda = 0;
        private Font printFont;
        Pen pen = new Pen(Color.Black);
        int linhasPorPagina = 65;
        int i;
        int i2;
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
            //Adiciona o item na lista
            if (e.KeyCode == Keys.Enter && !VendaFinalizada)
            {
                try
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
                            dgvCaixa.Rows.Insert(0, modelCaixa.Codigo, modelCaixa.NomeProduto, modelCaixa.Categoria, modelCaixa.Fabricante, modelCaixa.CodigoBarras, modelCaixa.Plataforma, modelCaixa.Garantia, modelCaixa.ValorProduto);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Deleta o item da lista
            else if (e.KeyCode == Keys.Delete && !VendaFinalizada)
            {
                if (dgvCaixa.Rows.Count > 0)
                {
                    try
                    {
                        valorTotal = valorTotal - Convert.ToInt32(dgvCaixa.CurrentRow.Cells["ValorProduto"].Value.ToString());
                        dgvCaixa.Rows.RemoveAt(dgvCaixa.CurrentRow.Index);
                        txtValorTotal.Text = valorTotal.ToString("C");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //Finalizar venda
            if (dgvCaixa.Rows.Count > 0 && e.KeyCode == Keys.F1)
            {
                FrmCaixaOpcaoPagamento frmCaixaOpcaoPagamento = new FrmCaixaOpcaoPagamento();
                frmCaixaOpcaoPagamento.ShowDialog();
                if (frmCaixaOpcaoPagamento.RetornoOpcaoPagamento == "DINHEIRO")
                {
                    if (dgvCaixa.Rows.Count > 0)
                    {
                        try
                        {
                            FrmCaixaDinheiro frmCaixaDinheiro = new FrmCaixaDinheiro(txtValorTotal.Text);
                            frmCaixaDinheiro.ShowDialog();
                            if (frmCaixaDinheiro.Retorno != "")
                            {
                                VendaFinalizada = true;
                                if (valorVenda == 0)
                                {
                                    valorVenda = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", ""));
                                    modelCaixa.ValorVenda = valorVenda.ToString("C");
                                }
                                dinheiroPago = dinheiroPago + Convert.ToDecimal(frmCaixaDinheiro.Dinheiro);
                                valortotalPago = valortotalPago + Convert.ToDecimal(frmCaixaDinheiro.Dinheiro);
                                modelCaixa.NomeCliente = "CAIXA-" + frmCaixaOpcaoPagamento.RetornoOpcaoPagamento;
                                modelCaixa.StatusPagamento = "Recebido";
                                modelCaixa.DataRecebimento = DateTime.Now.ToString();
                                modelCaixa.RecebidoPor = Properties.SettingsLogado.Default.Nome;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (frmCaixaOpcaoPagamento.RetornoOpcaoPagamento == "CARTAO")
                {
                    if (dgvCaixa.Rows.Count > 0)
                    {
                        try
                        {
                            FrmCaixaCartaoDebito frmCaixaCartaoDebito = new FrmCaixaCartaoDebito();
                            frmCaixaCartaoDebito.ShowDialog();
                            if (frmCaixaCartaoDebito.Retorno != "")
                            {
                                VendaFinalizada = true;
                                if (valorVenda == 0)
                                {
                                    valorVenda = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", ""));
                                    modelCaixa.ValorVenda = valorVenda.ToString("C");
                                }
                                cartaoPago = cartaoPago + Convert.ToDecimal(frmCaixaCartaoDebito.Retorno);
                                valortotalPago = valortotalPago + Convert.ToDecimal(frmCaixaCartaoDebito.Retorno);
                                modelCaixa.NomeCliente = "CAIXA-" + frmCaixaOpcaoPagamento.RetornoOpcaoPagamento;
                                modelCaixa.StatusPagamento = "Recebido";
                                modelCaixa.DataRecebimento = DateTime.Now.ToString();
                                modelCaixa.RecebidoPor = Properties.SettingsLogado.Default.Nome;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (frmCaixaOpcaoPagamento.RetornoOpcaoPagamento == "TICKET")
                {
                    if (dgvCaixa.Rows.Count > 0)
                    {
                        try
                        {
                            FrmCaixaTicket frmCaixaTicket = new FrmCaixaTicket(Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ","")));
                            frmCaixaTicket.ShowDialog();
                            if (frmCaixaTicket.Retorno != "")
                            {
                                VendaFinalizada = true;
                                if (valorVenda == 0)
                                {
                                    valorVenda = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", ""));
                                    modelCaixa.ValorVenda = valorVenda.ToString("C");
                                }
                                ticketPago = ticketPago + frmCaixaTicket.RetornoTicket;
                                valortotalPago = valortotalPago + frmCaixaTicket.RetornoTicket;
                                modelCaixa.NomeCliente = "CAIXA-" + frmCaixaOpcaoPagamento.RetornoOpcaoPagamento;
                                modelCaixa.StatusPagamento = "Recebido";
                                modelCaixa.DataRecebimento = DateTime.Now.ToString();
                                modelCaixa.RecebidoPor = Properties.SettingsLogado.Default.Nome;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (frmCaixaOpcaoPagamento.RetornoOpcaoPagamento == "CONVENIADO" && !VendaFinalizada)
                {
                    if (dgvCaixa.Rows.Count > 0)
                    {
                        try
                        {
                            modelCaixa.Conveniado = "?";
                            FrmCadastrados frmCadastrados = new FrmCadastrados(modelCaixa);
                            frmCadastrados.ShowDialog();
                            if (frmCadastrados.Retorno != null)
                            {
                                VendaFinalizada = true;
                                if (valorVenda == 0)
                                {
                                    valorVenda = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", ""));
                                    modelCaixa.ValorVenda = valorVenda.ToString("C");
                                }
                                modelCaixa.NomeCliente = frmCadastrados.Retorno;
                                conveniadoValor = valorVenda;
                                valortotalPago = valorVenda;
                                modelCaixa.StatusPagamento = "Em Aberto";
                                modelCaixa.DataRecebimento = "";
                                modelCaixa.RecebidoPor = "";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (VendaFinalizada)
                {
                    try
                    {
                        if (valortotalPago >= valorVenda)
                        {
                            modelCaixa.OpcaoPagamento = frmCaixaOpcaoPagamento.RetornoOpcaoPagamento;
                            modelCaixa.Dinheiro = dinheiroPago.ToString("C");
                            modelCaixa.Cartao = cartaoPago.ToString("C");
                            modelCaixa.Ticket = ticketPago.ToString("C");
                            modelCaixa.Conveniado = conveniadoValor.ToString("C");
                            modelCaixa.Cheque = "R$ 0,00";
                            modelCaixa.ChequeDias = "----------";
                            modelCaixa.StatusVenda = "Finalizada";
                            modelCaixa.DataVenda = DateTime.Now.ToString();
                            modelCaixa.Vendedor = Properties.SettingsLogado.Default.Nome;
                            int CodigoPedido = controllerCaixa.InserirPedido(modelCaixa);
                            foreach (DataGridViewRow row in dgvCaixa.Rows)
                            {
                                modelCaixa.CodigoPedido = CodigoPedido;
                                modelCaixa.CodigoBarras = row.Cells["CodigoBarras"].Value.ToString();
                                modelCaixa.NomeProduto = row.Cells["NomeProduto"].Value.ToString();
                                modelCaixa.Categoria = row.Cells["Categoria"].Value.ToString();
                                modelCaixa.Fabricante = row.Cells["Fabricante"].Value.ToString();
                                modelCaixa.ValorProduto = row.Cells["ValorProduto"].Value.ToString();
                                modelCaixa.Plataforma = row.Cells["Plataforma"].Value.ToString();
                                modelCaixa.Garantia = row.Cells["Garantia"].Value.ToString();
                                controllerCaixa.MenosQuantidadeEstoque(modelCaixa);
                                controllerCaixa.InserirPedidoItens(modelCaixa);
                            }
                            ZerarCaixa();
                        }
                        else
                        {
                            decimal resto = valorVenda - valortotalPago;
                            txtValorTotal.Text = resto.ToString("C");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //Gera um orçamento dos itens listados
            if (dgvCaixa.Rows.Count > 0 && e.KeyCode == Keys.F12)
            {
                try
                {
                    printFont = new Font("Arial", 9);
                    PrintDocument pd = new PrintDocument();
                    printDialog1.Document = pd;
                    var result = printDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                        pd.Print();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FrmCaixa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvCaixa.Rows.Count > 0)
            {
                var result = MessageBox.Show("Existe " + dgvCaixa.Rows.Count.ToString() + " itens no Caixa\nDeseja realmente sair?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
            pictureBox1.BackgroundImage.Dispose();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float x = ev.MarginBounds.Left;
            float y = 0;
            float count = 0;

            ev.Graphics.DrawString("TEC SISTEMAS - ORÇAMENTO", printFont, Brushes.Black, 320, 10, new StringFormat());
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, 30, ev.MarginBounds.Right, 30);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, 30, ev.MarginBounds.Left, ev.MarginBounds.Top + 11);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Right, 30, ev.MarginBounds.Right, ev.MarginBounds.Top + 11);
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Codigo: ", printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Nome: ORÇAMENTO", printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Opção de Pagamento: ", printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            ev.Graphics.DrawString("Data: " + DateTime.Now.Date.ToString("dd/mm/yyyy"), printFont, Brushes.Black, ev.MarginBounds.Left + 300, y, new StringFormat());
            ev.Graphics.DrawString("Valor Total: " + txtValorTotal.Text, printFont, Brushes.Black, ev.MarginBounds.Right - 153, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Dinheiro : ", printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            ev.Graphics.DrawString("Cartão: ", printFont, Brushes.Black, ev.MarginBounds.Left + 150, y, new StringFormat());
            ev.Graphics.DrawString("Cheque: ", printFont, Brushes.Black, ev.MarginBounds.Left + 300, y, new StringFormat());
            ev.Graphics.DrawString("Cheque Pré datado: ", printFont, Brushes.Black, ev.MarginBounds.Left + 460, y, new StringFormat());
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
                if (i < dgvCaixa.Rows.Count)
                {
                    string linha = ".  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .";
                    y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 70);
                    ev.Graphics.DrawString(linha, printFont, Brushes.Black, 340, y, new StringFormat());

                    string Cod = dgvCaixa.Rows[i].Cells["CodigoBarras"].Value.ToString();
                    string NomeProduto = dgvCaixa.Rows[i].Cells["NomeProduto"].Value.ToString();
                    y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 70);
                    ev.Graphics.DrawString(Cod + "...    " + NomeProduto, printFont, Brushes.Black, ev.MarginBounds.Left + 2, y, new StringFormat());

                    int ValorTotal = Convert.ToInt32(dgvCaixa.Rows[i].Cells["ValorProduto"].Value.ToString());
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
        void ZerarCaixa()
        {
            VendaFinalizada = false;
            dgvCaixa.Rows.Clear();
            txtCodigoBarras.Text = null;
            txtNomeProduto.Text = null;
            txtQuantidade.Value = 1;
            txtValorTotal.Text = null;
            txtValorUnitario.Text = null;
            valorTotal = 0;
            valorVenda = 0;
            dinheiroPago = 0;
            cartaoPago = 0;
            ticketPago = 0;
            conveniadoValor = 0;
            valortotalPago = 0;
            QuantidadeAdicionada = 1;
        }
    }
}