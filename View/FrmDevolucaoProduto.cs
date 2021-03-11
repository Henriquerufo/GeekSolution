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
            //Carrega os PEDIDOS finalizado e cancelados e passa para os devidos dgv
            if (cbxFiltro.Text == "PEDIDO")
            {
                dgvProduto.DataSource = controllerDevolucaoProduto.CarregarPedido(Procurar);
                dgvProdutoCancelados.DataSource = controllerDevolucaoProduto.CarregarPedidoCancelados(Procurar);
            }
            //Carrega os ITENS finalizados e cancelados e passa para os devidos dgv
            if (cbxFiltro.Text == "ITEM")
            {
                dgvProduto.DataSource = controllerDevolucaoProduto.CarregarItem(Procurar);
                dgvProdutoCancelados.DataSource = controllerDevolucaoProduto.CarregarItemCancelados(Procurar);
            }
            lblExibidosTotal.Text = "Exibidos total: " + dgvProduto.Rows.Count;
            lblExibidosTotalCancelados.Text = "Exibidos total: " + dgvProdutoCancelados.Rows.Count;
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            //se o cbxFiltro for PEDIDO, permite explorar os itens desse pedido
            if (cbxFiltro.Text == "PEDIDO")
            {
                ModelFinanceiro modelFinanceiro = new ModelFinanceiro();
                modelFinanceiro.CodigoPedido = dgvProduto.CurrentRow.Cells["Codigo"].Value.ToString();
                FrmConsultarPedidoItens frmConsultarPedidoItens = new FrmConsultarPedidoItens(modelFinanceiro);
                frmConsultarPedidoItens.ShowDialog();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ModelLogin modelLogin = new ModelLogin();
            modelLogin.Nivel = "?";
            FrmLogin frmLogin = new FrmLogin(modelLogin);
            frmLogin.ShowDialog();

            /*Verifica se o usuario está na lista e, se este usuario tem o nivel de Supervisor*/
            if (frmLogin.Retorno == "Supervisor")
            {
                modelDevolucaoPedido.Codigo = dgvProduto.CurrentRow.Cells["Codigo"].Value.ToString();

                var result = MessageBox.Show("O " + cbxFiltro.Text + "\nCodigo: " + modelDevolucaoPedido.Codigo + " será cancelado", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    /*Se o cbxFiltro for Pedido, ele passa o CancelarPedido como verdadeiro, passa o codigo para a frmConsultarPedidoItens e, lá é rodado um foreath
                     ele deleta item por item baseado no codigoPedido*/
                    if (cbxFiltro.Text == "PEDIDO")
                    {
                        controllerDevolucaoProduto.CancelarPedido(modelDevolucaoPedido);
                        ModelFinanceiro modelFinanceiro = new ModelFinanceiro();
                        modelFinanceiro.CodigoPedido = dgvProduto.CurrentRow.Cells["Codigo"].Value.ToString();
                        modelFinanceiro.cancelarProduto = true;
                        FrmConsultarPedidoItens frmConsultarPedidoItens = new FrmConsultarPedidoItens(modelFinanceiro);
                        modelFinanceiro.cancelarProduto = false;
                        Carregar(txtProcurar.Text);
                    }
                    /*se o cbxFiltro for ITEM, ele pega os dados do dgv e passa para a controller para cancelar o item*/
                    if (cbxFiltro.Text == "ITEM")
                    {
                        modelDevolucaoPedido.statusVenda = dgvProduto.CurrentRow.Cells["statusVenda"].Value.ToString();
                        modelDevolucaoPedido.statusPegamento = dgvProduto.CurrentRow.Cells["statusPagamento"].Value.ToString();
                        modelDevolucaoPedido.CodigoBarras = dgvProduto.CurrentRow.Cells["CodigoBarras"].Value.ToString();
                        controllerDevolucaoProduto.CancelarPedidoItem(modelDevolucaoPedido);
                        Carregar(txtProcurar.Text);
                    }
                }
            }    
        }

        private void dgvProdutoCancelados_DoubleClick(object sender, EventArgs e)
        {
            /*Ao realizar um duplo clique no dgv com o CbxFiltro com o text em PEDIDO, o codigo passa pela ModelFinanceiro porque a FrmFinanceiro também
                 usa a tela de ConsultarPedidoItens*/
            if (cbxFiltro.Text == "PEDIDO")
            {
                ModelFinanceiro modelFinanceiro = new ModelFinanceiro();
                modelFinanceiro.CodigoPedido = dgvProdutoCancelados.CurrentRow.Cells["Codigo"].Value.ToString();
                FrmConsultarPedidoItens frmConsultarPedidoItens = new FrmConsultarPedidoItens(modelFinanceiro);
                frmConsultarPedidoItens.ShowDialog();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregar(txtProcurar.Text);
        }

        private void cbxFiltro_TextChanged(object sender, EventArgs e)
        {
            //Limpa os dgv caso o filtro sejá alterado
            dgvProduto.DataSource = null;
            dgvProdutoCancelados.DataSource = null;
        }
    }
}
