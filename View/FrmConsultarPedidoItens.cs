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
    public partial class FrmConsultarPedidoItens : Form
    {
        ControllerConsultarPedidoItens controllerConsultarPedidoItens = new ControllerConsultarPedidoItens();
        ControllerDevolucaoProduto controllerDevolucaoProduto = new ControllerDevolucaoProduto();
        ModelDevolucaoPedido modelDevolucaoPedido = new ModelDevolucaoPedido();
        public FrmConsultarPedidoItens(ModelFinanceiro modelFinanceiro)
        {
            InitializeComponent();
            string codigo = modelFinanceiro.CodigoPedido;
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
    }
}
