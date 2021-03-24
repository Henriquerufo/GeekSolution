using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmConsultarPedidoItens : Form
    {
        ControllerConsultarPedidoItens controllerConsultarPedidoItens = new ControllerConsultarPedidoItens();
        ControllerDevolucaoProduto controllerDevolucaoProduto = new ControllerDevolucaoProduto();
        ModelDevolucaoPedido modelDevolucaoPedido = new ModelDevolucaoPedido();
        private Font printFont;
        Pen pen = new Pen(Color.Black);
        int linhasPorPagina = 65;
        int i;
        int i2;
        public FrmConsultarPedidoItens(ModelFinanceiro modelFinanceiro)
        {
            InitializeComponent();
            string codigo = modelFinanceiro.CodigoPedido;
            txtCodigo.Text = codigo;
            txtNomeCliente.Text = modelFinanceiro.nomeCliente;
            txtDataVenda.Text = modelFinanceiro.dataVenda;
            txtValorTotal.Text = modelFinanceiro.valorVenda;
            txtStatusPagamento.Text = modelFinanceiro.statusPagamento;
            txtOpcaoPagamento.Text = modelFinanceiro.opcaoPagamento;
            txtDinheiro.Text = modelFinanceiro.Dinheiro;
            txtCartao.Text = modelFinanceiro.Cartao;
            txtCheque.Text = modelFinanceiro.Cheque;
            txtChequeDias.Text = modelFinanceiro.ChequeDias;
            txtStatusVenda.Text = modelFinanceiro.statusVenda;
            //Carrega os pedidos finalizados e cancelados e coloca nos devidos dgv
            dgvPedidoItens.DataSource = controllerConsultarPedidoItens.CarregarPedidosItensCodigo(codigo);
            dgvPedidoItensCancelados.DataSource = controllerConsultarPedidoItens.CarregarPedidosItensCodigoCancelados(codigo);
            lblExibidosTotal.Text = "Exibidos total: " + dgvPedidoItens.Rows.Count.ToString();
            lblExibidosTotalCancelados.Text = "Exibidos total: " + dgvPedidoItensCancelados.Rows.Count.ToString();
            //Verifica se o cancelarProtudo é verdadeiro e executa
            if (modelFinanceiro.cancelarProduto)
            {
                //lista item por item e executa o a Controller.CancelarPedidoItem
                foreach (DataGridViewRow row in dgvPedidoItens.Rows)
                {
                    modelDevolucaoPedido.Codigo = row.Cells["Cod"].Value.ToString();
                    modelDevolucaoPedido.CodigoBarras = row.Cells["CodigoBarras"].Value.ToString();
                    modelDevolucaoPedido.statusPegamento = row.Cells["statusPagamento"].Value.ToString();
                    modelDevolucaoPedido.statusVenda = row.Cells["statusVenda"].Value.ToString();

                    controllerDevolucaoProduto.CancelarPedidoItem(modelDevolucaoPedido);
                }
                MessageBox.Show("Todos os itens desse pedido foram cancelados com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvPedidoItens.Rows.Count > 0)
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
            ev.Graphics.DrawString("Codigo: " + txtCodigo.Text, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Nome: " + txtNomeCliente.Text, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Opção de Pagamento: " + txtOpcaoPagamento.Text, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            ev.Graphics.DrawString("Data: " + txtDataVenda.Text, printFont, Brushes.Black, ev.MarginBounds.Left + 300, y, new StringFormat());
            ev.Graphics.DrawString("Valor Total: " + txtValorTotal.Text, printFont, Brushes.Black, ev.MarginBounds.Right - 153, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Dinheiro : " + txtDinheiro.Text, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            ev.Graphics.DrawString("Cartão: " + txtCartao.Text, printFont, Brushes.Black, ev.MarginBounds.Left + 150, y, new StringFormat());
            ev.Graphics.DrawString("Cheque: " + txtCheque.Text, printFont, Brushes.Black, ev.MarginBounds.Left + 300, y, new StringFormat());
            ev.Graphics.DrawString("Cheque Pré datado: " + txtChequeDias.Text, printFont, Brushes.Black, ev.MarginBounds.Left + 460, y, new StringFormat());
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
                if (i < dgvPedidoItens.Rows.Count)
                {
                    string linha = ".  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .  .";
                    y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 70);
                    ev.Graphics.DrawString(linha, printFont, Brushes.Black, 340, y, new StringFormat());

                    string Cod = dgvPedidoItens.Rows[i].Cells["Cod"].Value.ToString();
                    string NomeProduto = dgvPedidoItens.Rows[i].Cells["NomeProduto"].Value.ToString();
                    y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 70);
                    ev.Graphics.DrawString(Cod + "...    " + NomeProduto, printFont, Brushes.Black, ev.MarginBounds.Left + 2, y, new StringFormat());

                    int ValorTotal = Convert.ToInt32(dgvPedidoItens.Rows[i].Cells["ValorProduto"].Value.ToString());
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
        private void btnImprimirCancelados_Click(object sender, EventArgs e)
        {
            if (dgvPedidoItens.Rows.Count > 0)
            {
                try
                {
                    printFont = new Font("Arial", 9);
                    PrintDocument pd = new PrintDocument();
                    printDialog1.Document = pd;
                    var result = printDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        pd.PrintPage += new PrintPageEventHandler(printDocument2_PrintPage);
                        pd.Print();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void printDocument2_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float x = ev.MarginBounds.Left;
            float y = 0;
            float count = 0;
            //linhasPorPagina = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            ev.Graphics.DrawString("TEC SISTEMAS - RELATÓRIO", printFont, Brushes.Black, 320, 10, new StringFormat());
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, 30, ev.MarginBounds.Right, 30);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, 30, ev.MarginBounds.Left, ev.MarginBounds.Top + 11);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Right, 30, ev.MarginBounds.Right, ev.MarginBounds.Top + 11);
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Codigo: " + txtCodigo.Text, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Nome: " + txtNomeCliente.Text, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Opção de Pagamento: " + txtOpcaoPagamento.Text, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            ev.Graphics.DrawString("Data: " + txtDataVenda.Text, printFont, Brushes.Black, ev.MarginBounds.Left + 300, y, new StringFormat());
            ev.Graphics.DrawString("Valor Total: " + txtValorTotal.Text, printFont, Brushes.Black, ev.MarginBounds.Right - 153, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 80);
            ev.Graphics.DrawString("Dinheiro : " + txtDinheiro.Text, printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            ev.Graphics.DrawString("Cartão: " + txtCartao.Text, printFont, Brushes.Black, ev.MarginBounds.Left + 150, y, new StringFormat());
            ev.Graphics.DrawString("Cheque: " + txtCheque.Text, printFont, Brushes.Black, ev.MarginBounds.Left + 300, y, new StringFormat());
            ev.Graphics.DrawString("Cheque Pré datado: " + txtChequeDias.Text, printFont, Brushes.Black, ev.MarginBounds.Left + 460, y, new StringFormat());
            count++;
            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 75);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, y, ev.MarginBounds.Right, y);
            count++;
            ev.Graphics.DrawString("NOME ", printFont, Brushes.Black, ev.MarginBounds.Left, y, new StringFormat());
            ev.Graphics.DrawString("VALOR UNITÁRIO ", printFont, Brushes.Black, ev.MarginBounds.Right - 110, y, new StringFormat());

            y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 75);
            ev.Graphics.DrawLine(pen, ev.MarginBounds.Left, y, ev.MarginBounds.Right, y);

            for (i2 = 0; i2 < linhasPorPagina; i2++)
            {
                if (i < dgvPedidoItensCancelados.Rows.Count)
                {
                    string linha = "...............................................................................................................";
                    y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 70);
                    ev.Graphics.DrawString(linha, printFont, Brushes.Black, 255, y, new StringFormat());

                    string Cod = dgvPedidoItensCancelados.Rows[i].Cells["Codigo2"].Value.ToString();
                    string NomeProduto = dgvPedidoItensCancelados.Rows[i].Cells["NomeProduto2"].Value.ToString();
                    y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 70);
                    ev.Graphics.DrawString(Cod + "... " + NomeProduto, printFont, Brushes.Black, ev.MarginBounds.Left + 2, y, new StringFormat());

                    int ValorProduto = Convert.ToInt32(dgvPedidoItensCancelados.Rows[i].Cells["ValorProduto2"].Value.ToString());
                    y = ev.MarginBounds.Top + (count * printFont.GetHeight(ev.Graphics) - 70);
                    ev.Graphics.DrawString(ValorProduto.ToString("C"), printFont, Brushes.Black, ev.MarginBounds.Right - 85, y, new StringFormat());
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
