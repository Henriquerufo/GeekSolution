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
    public partial class FrmPrincipal : Form
    {
        ModelCaixa modelCaixa = new ModelCaixa();
        ModelLogin modelLogin = new ModelLogin();
        ModelCadastro modelCadastro = new ModelCadastro();
        ModelCadastroProduto modelCadastroProduto = new ModelCadastroProduto();
        ControllerFechamento controllerFechamento = new ControllerFechamento();
        ModelFechamento modelFechamento = new ModelFechamento();
        ControllerTema controllerTema = new ControllerTema();
        void CarregarTema()
        {
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
                BackColor = Color.FromArgb(controllerTema.CarregarColorR(), controllerTema.CarregarColorG(), controllerTema.CarregarColorB());
            }
        }
        public FrmPrincipal(ModelLogin modelLogin)
        {
            InitializeComponent();
            CarregarTema();
            if (modelLogin != null && modelLogin.Nivel == "Vendedor")
            {
                caixaToolStripMenuItem.Visible = true;
                clientesToolStripMenuItem.Visible = false;
                produtosToolStripMenuItem.Visible = false;
                financeiroToolStripMenuItem.Visible = false;
                sobreToolStripMenuItem.Visible = true;
                conexãoSQLToolStripMenuItem.Visible = false;
                administradorToolStripMenuItem.Visible = false;
            }
            else if (modelLogin != null && modelLogin.Nivel == "Administrador")
            {
                caixaToolStripMenuItem.Visible = true;
                clientesToolStripMenuItem.Visible = true;
                produtosToolStripMenuItem.Visible = true;
                financeiroToolStripMenuItem.Visible = true;
                sobreToolStripMenuItem.Visible = true;
                conexãoSQLToolStripMenuItem.Visible = true;
                administradorToolStripMenuItem.Visible = true;
            }
            else if (modelLogin != null && modelLogin.Nivel == "Supervisor")
            {
                caixaToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem.Visible = true;
                produtosToolStripMenuItem.Visible = false;
                financeiroToolStripMenuItem.Visible = true;
                sobreToolStripMenuItem.Visible = true;
                conexãoSQLToolStripMenuItem.Visible = false;
                administradorToolStripMenuItem.Visible = false;
            }
            else if (modelLogin != null && modelLogin.Nivel == "Estoquista")
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
            FrmCadastrados frmCadastrados = new FrmCadastrados(modelCaixa = null);
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

            modelLogin.Consultar = false;
            modelLogin.Codigo = null;
            FrmCadastroLogin frmCadastroLogin = new FrmCadastroLogin(modelLogin);
            frmCadastroLogin.Show();
        }
        private void abrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modelFechamento.Vendedor = Properties.SettingsLogado.Default.Nome;
            modelFechamento.Data = DateTime.Now.ToString();
            if (controllerFechamento.VerificarFechamento(modelFechamento))
            {
                MessageBox.Show("Fechamento já registrado!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmCaixa frmCaixa = new FrmCaixa();
                frmCaixa.Show();
            }

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
            BackgroundImage.Dispose();
        }
        private void devoluçãoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDevolucaoProduto frmDevolucaoProduto = new FrmDevolucaoProduto();
            frmDevolucaoProduto.Show();
        }
        private void gerenciarTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerenciadorTema frmGerenciadorTema = new FrmGerenciadorTema();
            frmGerenciadorTema.Show();
        }
        private void adicionarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntradaProduto frmEntradaProduto = new FrmEntradaProduto();
            frmEntradaProduto.Show();
        }
        private void saidaDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modelFechamento.Vendedor = Properties.SettingsLogado.Default.Nome;
            modelFechamento.Data = DateTime.Now.ToString();
            if (controllerFechamento.VerificarFechamento(modelFechamento))
            {
                MessageBox.Show("Fechamento já registrado!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmSaidaValor frmSaidaValor = new FrmSaidaValor();
                frmSaidaValor.ShowDialog();
            }

        }
        private void saidaDeValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaida frmSaida = new FrmSaida();
            frmSaida.Show();
        }
        private void fechamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modelFechamento.Vendedor = Properties.SettingsLogado.Default.Nome;
            modelFechamento.Data = DateTime.Now.ToString();
            if (controllerFechamento.VerificarFechamento(modelFechamento))
            {
                MessageBox.Show("Fechamento já registrado!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmRegistrarFechamento frmFechamento = new FrmRegistrarFechamento();
                frmFechamento.ShowDialog();
            }
        }
        private void fechamentoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFechamento frmFechamento = new FrmFechamento();
            frmFechamento.Show();
        }

        private void gerarTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerarTicket frmGerarTicket = new FrmGerarTicket();
            frmGerarTicket.Show();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTicket frmTicket = new FrmTicket();
            frmTicket.Show();
        }
    }
}
