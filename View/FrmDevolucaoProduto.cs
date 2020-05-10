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
using System.Windows.Forms.VisualStyles;

namespace View
{
    public partial class FrmDevolucaoProduto : Form
    {
        ControllerDevolucaoProduto controllerDevolucaoProduto = new ControllerDevolucaoProduto();
        ModelDevolucaoPedido modelDevolucaoPedido = new ModelDevolucaoPedido();
        public FrmDevolucaoProduto()
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
        }
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Carregar(string Procurar)
        {
            if (cbxFiltro.Text == "PEDIDO")
            {
                dgvProduto.DataSource = controllerDevolucaoProduto.CarregarPedido(Procurar);
            }
            if (cbxFiltro.Text == "ITEM")
            {
                dgvProduto.DataSource = controllerDevolucaoProduto.CarregarItem(Procurar);
            }
            lblExibidosTotal.Text = "Exibidos total: " + dgvProduto.Rows.Count;
        }
        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            Carregar(txtProcurar.Text);
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            if (cbxFiltro.Text == "PEDIDO")
            {
                ModelFinanceiro modelFinanceiro = new ModelFinanceiro();
                modelFinanceiro.CodigoPedido = dgvProduto.CurrentRow.Cells["Codigo"].Value.ToString();
                FrmConsultarPedidoItens frmConsultarPedidoItens = new FrmConsultarPedidoItens(modelFinanceiro);
                frmConsultarPedidoItens.ShowDialog();
            }
        }

        private void cbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvProduto.DataSource = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            modelDevolucaoPedido.Codigo = dgvProduto.CurrentRow.Cells["Codigo"].Value.ToString();
            var result = MessageBox.Show("Codigo: " + modelDevolucaoPedido.Codigo + " será excluido", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (cbxFiltro.Text == "PEDIDO")
                {
                    controllerDevolucaoProduto.DeletarPedido(modelDevolucaoPedido);
                    Carregar(txtProcurar.Text);
                }
                if (cbxFiltro.Text == "ITEM")
                {
                    controllerDevolucaoProduto.DeletarPedidoItem(modelDevolucaoPedido);
                    Carregar(txtProcurar.Text);
                }
            }
        }
    }
}
