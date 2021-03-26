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
        ControllerFechamento controllerFechamento = new ControllerFechamento();
        ModelFechamento modelFechamento = new ModelFechamento();
        bool VendaFinalizada = false;
        int QuantidadeAdicionada = 1;
        int valorTotal = 0;
        decimal RetornoTroco = 0;
        decimal DinheiroPago = 0;
        decimal valorVenda = 0;
        decimal valorTicket = 0;
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
            //Adiciona o protudo na lista pelo codigo de barras
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
            //Deleta o item selecionado
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
            //Finaliza a venda na função dinheiro
            else if (e.KeyCode == Keys.F1)
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
                            RetornoTroco = Convert.ToDecimal(frmCaixaDinheiro.Retorno.Replace("R$ ", "").ToString());
                            DinheiroPago = DinheiroPago + Convert.ToDecimal(frmCaixaDinheiro.Dinheiro);
                            if (RetornoTroco >= 0)
                            {
                                if (valorTicket == 0)
                                {
                                    modelCaixa.Dinheiro = valorVenda.ToString("C");
                                }
                                else
                                {
                                    modelCaixa.Dinheiro = txtValorTotal.Text;
                                }
                                modelCaixa.StatusPagamento = "Recebido";
                                modelCaixa.StatusVenda = "Finalizada";
                                modelCaixa.DataVenda = DateTime.Now.ToString();
                                modelCaixa.Ticket = valorTicket.ToString("C");
                                modelCaixa.Cartao = "R$ 0,00";
                                modelCaixa.Cheque = "R$ 0,00";
                                modelCaixa.NomeCliente = "CAIXA-DINHEIRO";
                                modelCaixa.OpcaoPagamento = "DINHEIRO";
                                modelCaixa.ChequeDias = "----------";
                                modelCaixa.Vendedor = Properties.SettingsLogado.Default.Nome;
                                modelCaixa.Conveniado = "R$ 0,00";
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
                                    modelCaixa.StatusPagamento = "Recebido";
                                    modelCaixa.StatusVenda = "Finalizada";
                                    modelCaixa.DataRecebimento = DateTime.Now.ToString();
                                    modelCaixa.RecebidoPor = Properties.SettingsLogado.Default.Nome;
                                    controllerCaixa.MenosQuantidadeEstoque(modelCaixa);
                                    controllerCaixa.InserirPedidoItens(modelCaixa);
                                }
                                ZerarCaixa();
                            }
                            else if (RetornoTroco < valorVenda)
                            {
                                txtValorTotal.Text = RetornoTroco.ToString("C").Replace("-", "");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            //Finaliza a venda na função cartão
            else if (e.KeyCode == Keys.F2)
            {
                if (dgvCaixa.Rows.Count > 0)
                {
                    try
                    {
                        if (valorVenda == 0)
                        {
                            modelCaixa.Dinheiro = "R$ 0,00";
                            modelCaixa.ValorVenda = txtValorTotal.Text;
                        }
                        else
                        {
                            modelCaixa.ValorVenda = valorVenda.ToString("C");
                            modelCaixa.Dinheiro = DinheiroPago.ToString("C").Replace("-", "");
                        }
                        modelCaixa.NomeCliente = "CAIXA-CARTÃO";
                        modelCaixa.DataVenda = DateTime.Now.ToString();
                        modelCaixa.OpcaoPagamento = "CARTÃO";
                        modelCaixa.StatusPagamento = "Recebido";
                        modelCaixa.StatusVenda = "Finalizada";
                        modelCaixa.Cartao = txtValorTotal.Text;
                        modelCaixa.Cheque = "R$ 0,00";
                        modelCaixa.Ticket = valorTicket.ToString("C");
                        modelCaixa.ChequeDias = "----------";
                        modelCaixa.Vendedor = Properties.SettingsLogado.Default.Nome;
                        modelCaixa.Conveniado = "R$ 0,00";
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
                            modelCaixa.StatusPagamento = "Recebido";
                            modelCaixa.StatusVenda = "Finalizada";
                            modelCaixa.DataRecebimento = DateTime.Now.ToString();
                            modelCaixa.RecebidoPor = Properties.SettingsLogado.Default.Nome;
                            controllerCaixa.MenosQuantidadeEstoque(modelCaixa);
                            controllerCaixa.InserirPedidoItens(modelCaixa);
                        }
                        ZerarCaixa();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            //Finaliza a venda na função convenio
            else if (e.KeyCode == Keys.F3 && !VendaFinalizada)
            {
                try
                {
                    if (dgvCaixa.Rows.Count > 0)
                    {
                        modelCaixa.ValorVenda = txtValorTotal.Text;
                        modelCaixa.DataVenda = DateTime.Now.ToString();
                        modelCaixa.OpcaoPagamento = "CONVENIADO";
                        modelCaixa.StatusPagamento = "Em Aberto";
                        modelCaixa.StatusVenda = "Finalizada";
                        modelCaixa.Dinheiro = "R$ 0,00";
                        modelCaixa.Ticket = valorTicket.ToString("C");
                        modelCaixa.Cartao = "0,00";
                        modelCaixa.Cheque = "R$ 0,00";
                        modelCaixa.ChequeDias = "----------";
                        modelCaixa.Vendedor = Properties.SettingsLogado.Default.Nome;
                        modelCaixa.Conveniado = txtValorTotal.Text;
                        FrmCadastrados frmCadastrados = new FrmCadastrados(modelCaixa);
                        frmCadastrados.ShowDialog();
                        if (frmCadastrados.Retorno != null)
                        {
                            modelCaixa.NomeCliente = frmCadastrados.Retorno;
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
                                modelCaixa.StatusPagamento = "Em Aberto";
                                modelCaixa.StatusVenda = "Finalizada";
                                modelCaixa.RecebidoPor = "";
                                modelCaixa.DataRecebimento = "";
                                controllerCaixa.MenosQuantidadeEstoque(modelCaixa);
                                controllerCaixa.InserirPedidoItens(modelCaixa);
                            }
                            ZerarCaixa();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Realiza o orçamento com uma impressão dos itens
            else if (e.KeyCode == Keys.F4 && !VendaFinalizada)
            {
                if (dgvCaixa.Rows.Count > 0)
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
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            //Finaliza a venda na função ticket
            else if (e.KeyCode == Keys.F5 && !VendaFinalizada)
            {
                try
                {
                    FrmCaixaTicket frmCaixaTicket = new FrmCaixaTicket();
                    frmCaixaTicket.ShowDialog();
                    if (frmCaixaTicket.Retorno != "")
                    {
                        VendaFinalizada = true;
                        if (valorVenda == 0)
                        {
                            valorVenda = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", ""));
                            modelCaixa.ValorVenda = valorVenda.ToString("C");
                        }
                        valorTicket = frmCaixaTicket.RetornoTicket;
                        decimal ticketRestante = valorTicket - valorVenda;
                        if (valorTicket >= valorVenda)
                        {
                            modelCaixa.Dinheiro = "R$ 0,00";
                            modelCaixa.StatusPagamento = "Recebido";
                            modelCaixa.StatusVenda = "Finalizada";
                            modelCaixa.DataVenda = DateTime.Now.ToString();
                            modelCaixa.Ticket = valorVenda.ToString("C");
                            modelCaixa.Cartao = "R$ 0,00";
                            modelCaixa.Cheque = "R$ 0,00";
                            modelCaixa.NomeCliente = "CAIXA-DINHEIRO";
                            modelCaixa.OpcaoPagamento = "DINHEIRO";
                            modelCaixa.ChequeDias = "----------";
                            modelCaixa.Vendedor = Properties.SettingsLogado.Default.Nome;
                            modelCaixa.Conveniado = "R$ 0,00";
                            modelCaixa.CodigoTicket = frmCaixaTicket.Retorno;
                            modelCaixa.TicketRestante = ticketRestante.ToString("C");
                            controllerCaixa.TicketRestante(modelCaixa);
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
                                modelCaixa.StatusPagamento = "Recebido";
                                modelCaixa.StatusVenda = "Finalizada";
                                modelCaixa.DataRecebimento = DateTime.Now.ToString();
                                modelCaixa.RecebidoPor = Properties.SettingsLogado.Default.Nome;
                                controllerCaixa.MenosQuantidadeEstoque(modelCaixa);
                                controllerCaixa.InserirPedidoItens(modelCaixa);
                            }
                            ZerarCaixa();
                        }
                        else
                        {
                            modelCaixa.CodigoTicket = frmCaixaTicket.Retorno;
                            modelCaixa.TicketRestante = "R$ 0,00";
                            controllerCaixa.TicketRestante(modelCaixa);
                            decimal resto = valorVenda - valorTicket;
                            txtValorTotal.Text = resto.ToString("C");
                        }
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
            DinheiroPago = 0;
            RetornoTroco = 0;
            valorTicket = 0;
            QuantidadeAdicionada = 1;
        }
    }
}
