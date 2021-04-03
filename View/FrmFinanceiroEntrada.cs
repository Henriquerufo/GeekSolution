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
    public partial class FrmFinanceiroEntrada : Form
    {
        ControllerEntradaProduto controllerEntradaProduto = new ControllerEntradaProduto();
        ModelEntradaProduto modelEntradaProduto = new ModelEntradaProduto();
        public FrmFinanceiroEntrada()
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
        }
        void Carregar()
        {
            try
            {
                if (cbxFiltro.Text == "CODIGO")
                {
                    dgvFinanceiro.DataSource = controllerEntradaProduto.CarregarPedidoPorCodigo(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                }
                else if (cbxFiltro.Text == "NOME EMPRESA")
                {
                    dgvFinanceiro.DataSource = controllerEntradaProduto.CarregarPedidoPorNomeEmpresa(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvFinanceiro.Rows.Count;
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

        private void dgvFinanceiro_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFinanceiro.Rows.Count > 0)
            {
                modelEntradaProduto.CodigoEntradaProduto = Convert.ToInt32(dgvFinanceiro.CurrentRow.Cells["Codigo"].Value.ToString());
                modelEntradaProduto.NomeEmpresa = dgvFinanceiro.CurrentRow.Cells["NomeEmpresa"].Value.ToString();
                modelEntradaProduto.DataRecebido = dgvFinanceiro.CurrentRow.Cells["dataRecebido"].Value.ToString();
                FrmConsultarEntradaProdutoItens frmConsultarEntradaProdutoItens = new FrmConsultarEntradaProdutoItens(modelEntradaProduto);
                frmConsultarEntradaProdutoItens.ShowDialog();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
