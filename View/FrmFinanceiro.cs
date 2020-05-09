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
    public partial class FrmFinanceiro : Form
    {
        ControllerFinanceiro controllerFinanceiro = new ControllerFinanceiro();
        public FrmFinanceiro()
        {
            InitializeComponent();
        }
        void Carregar(string codigo)
        {
            dgvFinanceiro.DataSource = controllerFinanceiro.Carregar(codigo);
            lblExibidosTotal.Text = "Exibidos total: " + dgvFinanceiro.Rows.Count.ToString();
        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            Carregar(txtProcurar.Text);
        }

        private void dgvFinanceiro_DoubleClick(object sender, EventArgs e)
        {
            ModelFinanceiro modelFinanceiro = new ModelFinanceiro();
            modelFinanceiro.CodigoPedido = dgvFinanceiro.CurrentRow.Cells["codigo"].Value.ToString();
            FrmConsultarPedidoItens frmConsultarPedidoItens = new FrmConsultarPedidoItens(modelFinanceiro);
            frmConsultarPedidoItens.ShowDialog();
        }
    }
}
