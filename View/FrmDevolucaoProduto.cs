using Controller;
using Model;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        ModelLogin modelLogin = new ModelLogin();
        ModelFinanceiro modelFinanceiro = new ModelFinanceiro();
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
                
                modelFinanceiro.CodigoPedido = dgvProduto.CurrentRow.Cells["Codigo"].Value.ToString();
                modelFinanceiro.nomeCliente = dgvProduto.CurrentRow.Cells["NomeCliente"].Value.ToString();
                modelFinanceiro.dataVenda = dgvProduto.CurrentRow.Cells["dataVenda"].Value.ToString();
                modelFinanceiro.valorVenda = dgvProduto.CurrentRow.Cells["valorVenda"].Value.ToString();
                modelFinanceiro.statusPagamento = dgvProduto.CurrentRow.Cells["statusPagamento"].Value.ToString();
                modelFinanceiro.opcaoPagamento = dgvProduto.CurrentRow.Cells["opcaoPagamento"].Value.ToString();
                modelFinanceiro.Dinheiro = dgvProduto.CurrentRow.Cells["Dinheiro"].Value.ToString();
                modelFinanceiro.Cartao = dgvProduto.CurrentRow.Cells["Cartao"].Value.ToString();
                modelFinanceiro.Cheque = dgvProduto.CurrentRow.Cells["Cheque"].Value.ToString();
                modelFinanceiro.ChequeDias = dgvProduto.CurrentRow.Cells["ChequeDias"].Value.ToString();
                modelFinanceiro.statusVenda = dgvProduto.CurrentRow.Cells["statusVenda"].Value.ToString();
                FrmConsultarPedidoItens frmConsultarPedidoItens = new FrmConsultarPedidoItens(modelFinanceiro);
                frmConsultarPedidoItens.ShowDialog();
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                modelLogin.Nivel = "?";
                FrmLogin frmLogin = new FrmLogin(modelLogin);
                frmLogin.ShowDialog();
                /*Verifica se o usuario está na lista e, se este usuario tem o nivel de Supervisor*/
                if (frmLogin.Retorno == "Supervisor" && dgvProduto.Rows.Count > 0)
                {
                    modelDevolucaoPedido.Codigo = dgvProduto.CurrentRow.Cells["Codigo"].Value.ToString();
                    var result = MessageBox.Show("O " + cbxFiltro.Text + "\nCodigo: " + modelDevolucaoPedido.Codigo + " será cancelado", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        /*Se o cbxFiltro for Pedido, ele passa o CancelarPedido como verdadeiro, passa o codigo para a frmConsultarPedidoItens e, lá é rodado um foreath
                         ele deleta item por item baseado no codigoPedido*/
                        if (cbxFiltro.Text == "PEDIDO")
                        {
                            controllerDevolucaoProduto.CancelarPedido(modelDevolucaoPedido);
                            modelFinanceiro.CodigoPedido = dgvProduto.CurrentRow.Cells["Codigo"].Value.ToString();
                            modelFinanceiro.cancelarProduto = true;
                            FrmConsultarPedidoItens frmConsultarPedidoItens = new FrmConsultarPedidoItens(modelFinanceiro);
                            modelFinanceiro.cancelarProduto = false;
                            Carregar(txtProcurar.Text);
                        }
                        /*se o cbxFiltro for ITEM, ele pega os dados do dgv e passa para a controller para cancelar o item*/
                        if (cbxFiltro.Text == "ITEM")
                        {
                            modelDevolucaoPedido.Ticket = "Em Aberto";
                            modelDevolucaoPedido.DataTicket = DateTime.Now.ToString();
                            modelDevolucaoPedido.statusVenda = dgvProduto.CurrentRow.Cells["statusVenda"].Value.ToString();
                            modelDevolucaoPedido.statusPegamento = dgvProduto.CurrentRow.Cells["statusPagamento"].Value.ToString();
                            modelDevolucaoPedido.CodigoBarras = dgvProduto.CurrentRow.Cells["CodigoBarras"].Value.ToString();
                            controllerDevolucaoProduto.CancelarPedidoItem(modelDevolucaoPedido);
                            Carregar(txtProcurar.Text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
        private void dgvProdutoCancelados_DoubleClick(object sender, EventArgs e)
        {
            /*Ao realizar um duplo clique no dgv com o CbxFiltro com o text em PEDIDO, o codigo passa pela ModelFinanceiro porque a FrmFinanceiro também
                 usa a tela de ConsultarPedidoItens*/
            if (cbxFiltro.Text == "PEDIDO")
            {
                modelFinanceiro.CodigoPedido = dgvProdutoCancelados.CurrentRow.Cells["Codigo"].Value.ToString();
                modelFinanceiro.nomeCliente = dgvProdutoCancelados.CurrentRow.Cells["NomeCliente"].Value.ToString();
                modelFinanceiro.dataVenda = dgvProdutoCancelados.CurrentRow.Cells["dataVenda"].Value.ToString();
                modelFinanceiro.valorVenda = dgvProdutoCancelados.CurrentRow.Cells["valorVenda"].Value.ToString();
                modelFinanceiro.statusPagamento = dgvProdutoCancelados.CurrentRow.Cells["statusPagamento"].Value.ToString();
                modelFinanceiro.opcaoPagamento = dgvProdutoCancelados.CurrentRow.Cells["opcaoPagamento"].Value.ToString();
                modelFinanceiro.Dinheiro = dgvProdutoCancelados.CurrentRow.Cells["Dinheiro"].Value.ToString();
                modelFinanceiro.Cartao = dgvProdutoCancelados.CurrentRow.Cells["Cartao"].Value.ToString();
                modelFinanceiro.Cheque = dgvProdutoCancelados.CurrentRow.Cells["Cheque"].Value.ToString();
                modelFinanceiro.ChequeDias = dgvProdutoCancelados.CurrentRow.Cells["ChequeDias"].Value.ToString();
                modelFinanceiro.statusVenda = dgvProdutoCancelados.CurrentRow.Cells["statusVenda"].Value.ToString();
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
