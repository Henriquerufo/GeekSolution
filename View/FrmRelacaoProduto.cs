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
    public partial class FrmRelacaoProduto : Form
    {
        ControllerRelacaoProduto controllerRelacaoProduto = new ControllerRelacaoProduto();
        public FrmRelacaoProduto()
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
        }
        void Carregar()
        {
            try
            {
                if (cbxFiltro.Text == "CODIGO BARRAS")
                {
                    if (rbVendidos.Checked)
                    {
                        dgvRelacaoProduto.DataSource = controllerRelacaoProduto.CarregarVendidosPorCodigo(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                    if (rbCancelados.Checked)
                    {
                        dgvRelacaoProduto.DataSource = controllerRelacaoProduto.CarregarCanceladosPorCodigo(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                }
                else if (cbxFiltro.Text == "NOME PRODUTO")
                {
                    if (rbVendidos.Checked)
                    {
                        dgvRelacaoProduto.DataSource = controllerRelacaoProduto.CarregarVendidosPorNome(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                    if (rbCancelados.Checked)
                    {
                        dgvRelacaoProduto.DataSource = controllerRelacaoProduto.CarregarCanceladosPorNome(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                    }
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvRelacaoProduto.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregar();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}