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
    public partial class FrmFinanceiroSaida : Form
    {
        ControllerFinanceiro controllerFinanceiro = new ControllerFinanceiro();
        ModelFinanceiro modelFinanceiro = new ModelFinanceiro();
        public FrmFinanceiroSaida()
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
        }
        private void dgvFinanceiro_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFinanceiro.Rows.Count > 0)
            {
                
                modelFinanceiro.CodigoPedido = dgvFinanceiro.CurrentRow.Cells["codigo"].Value.ToString();
                modelFinanceiro.nomeCliente = dgvFinanceiro.CurrentRow.Cells["NomeCliente"].Value.ToString();
                modelFinanceiro.dataVenda = dgvFinanceiro.CurrentRow.Cells["dataVenda"].Value.ToString();
                modelFinanceiro.valorVenda = dgvFinanceiro.CurrentRow.Cells["valorVenda"].Value.ToString();
                modelFinanceiro.opcaoPagamento = dgvFinanceiro.CurrentRow.Cells["opcaoPagamento"].Value.ToString();
                modelFinanceiro.Dinheiro = dgvFinanceiro.CurrentRow.Cells["Dinheiro"].Value.ToString();
                modelFinanceiro.Cartao = dgvFinanceiro.CurrentRow.Cells["Cartao"].Value.ToString();
                modelFinanceiro.Cheque = dgvFinanceiro.CurrentRow.Cells["Cheque"].Value.ToString();
                modelFinanceiro.ChequeDias = dgvFinanceiro.CurrentRow.Cells["ChequeDias"].Value.ToString();
                modelFinanceiro.statusPagamento = dgvFinanceiro.CurrentRow.Cells["statusPagamento"].Value.ToString();
                modelFinanceiro.statusVenda = dgvFinanceiro.CurrentRow.Cells["statusVenda"].Value.ToString();

                FrmConsultarPedidoItens frmConsultarPedidoItens = new FrmConsultarPedidoItens(modelFinanceiro);
                frmConsultarPedidoItens.ShowDialog();
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxFiltro.Text == "CODIGO" && !string.IsNullOrWhiteSpace(txtProcurar.Text))
                {
                    if (rbRecebido.Checked)
                    {
                        dgvFinanceiro.DataSource = controllerFinanceiro.CarregarPorCodigoPagamentoRecebido(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                    else if (rbEmAberto.Checked)
                    {
                        dgvFinanceiro.DataSource = controllerFinanceiro.CarregarPorCodigoPagamentoEmAberto(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                }
                else if (cbxFiltro.Text == "NOME CLIENTE" && !string.IsNullOrWhiteSpace(txtProcurar.Text))
                {
                    if (rbRecebido.Checked)
                    {
                        dgvFinanceiro.DataSource = controllerFinanceiro.CarregarPorNomeClientePagamentoRecebido(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                    else if (rbEmAberto.Checked)
                    {
                        dgvFinanceiro.DataSource = controllerFinanceiro.CarregarPorNomeClientePagamentoEmAberto(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvFinanceiro.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
