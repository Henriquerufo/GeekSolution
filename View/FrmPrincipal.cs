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
    public partial class FrmPrincipal : Form
    {
        ModelCadastro modelCadastro = new ModelCadastro();
        ModelCadastroProduto modelCadastroProduto = new ModelCadastroProduto();
        public FrmPrincipal(ModelLogin modelLogin)
        {
            InitializeComponent();
            if (modelLogin.Nivel == "Vendedor")
            {
                caixaToolStripMenuItem.Visible = true;
                clientesToolStripMenuItem.Visible = false;
                produtosToolStripMenuItem.Visible = false;
                financeiroToolStripMenuItem.Visible = false;
                sobreToolStripMenuItem.Visible = true;
                conexãoSQLToolStripMenuItem.Visible = false;
                administradorToolStripMenuItem.Visible = false;
            }
            if (modelLogin.Nivel == "Administrador")
            {
                caixaToolStripMenuItem.Visible = true;
                clientesToolStripMenuItem.Visible = true;
                produtosToolStripMenuItem.Visible = true;
                financeiroToolStripMenuItem.Visible = true;
                sobreToolStripMenuItem.Visible = true;
                conexãoSQLToolStripMenuItem.Visible = true;
                administradorToolStripMenuItem.Visible = true;
            }
            if (modelLogin.Nivel == "Supervisor")
            {
                caixaToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem.Visible = true;
                produtosToolStripMenuItem.Visible = false;
                financeiroToolStripMenuItem.Visible = true;
                sobreToolStripMenuItem.Visible = true;
                conexãoSQLToolStripMenuItem.Visible = false;
                administradorToolStripMenuItem.Visible = false;
            }
            if (modelLogin.Nivel == "Estoquista")
            {
                caixaToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem.Visible = false;
                produtosToolStripMenuItem.Visible = true;
                financeiroToolStripMenuItem.Visible = false;
                sobreToolStripMenuItem.Visible = true;
                conexãoSQLToolStripMenuItem.Visible = false;
                administradorToolStripMenuItem.Visible = false;
            }
        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modelCadastro.Codigo = null;
            FrmCadastro frmCadastro = new FrmCadastro(modelCadastro);
            frmCadastro.Show();
        }

        private void consultarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelFinanceiro modelFinanceiro = new ModelFinanceiro();
            modelFinanceiro.valorVenda = null;
            FrmCadastrados frmCadastrados = new FrmCadastrados(modelFinanceiro);
            frmCadastrados.Show();
        }

        private void cadastrarNovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modelCadastroProduto.Codigo = null;
            FrmCadastrarProduto frmCadastrarProduto = new FrmCadastrarProduto(modelCadastroProduto);
            frmCadastrarProduto.Show();
        }

        private void consultarListaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastradosProdutos frmCadastradosProdutos = new FrmCadastradosProdutos("");
            frmCadastradosProdutos.Show();
        }

        private void conexãoSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfiguracaoSQL frmConfiguracaoSQL = new FrmConfiguracaoSQL();
            frmConfiguracaoSQL.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.ShowDialog();
        }

        private void consultarListaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmGerenciadorLogins frmGerenciadorLogins = new FrmGerenciadorLogins();
            frmGerenciadorLogins.Show();
        }

        private void cadastrarNovoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ModelLogin modelLogin = new ModelLogin();
            modelLogin.Codigo = null;
            FrmCadastroLogin frmCadastroLogin = new FrmCadastroLogin(modelLogin);
            frmCadastroLogin.Show();
        }

        private void abrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas frmVendas = new FrmVendas();
            frmVendas.Show();
        }

        private void consultarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastradosProdutos frmCadastradosProdutos = new FrmCadastradosProdutos("Caixa");
            frmCadastradosProdutos.Show();
        }

        private void consultarPorPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFinanceiro frmFinanceiro = new FrmFinanceiro();
            frmFinanceiro.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void devoluçãoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDevolucaoProduto frmDevolucaoProduto = new FrmDevolucaoProduto();
            frmDevolucaoProduto.Show();
        }
    }
}
