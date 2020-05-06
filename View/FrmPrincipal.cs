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
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modelCadastro.Codigo = null;
            FrmCadastro frmCadastro = new FrmCadastro(modelCadastro);
            frmCadastro.Show();
        }

        private void consultarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrados frmCadastrados = new FrmCadastrados();
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
            FrmCadastradosProdutos frmCadastradosProdutos = new FrmCadastradosProdutos();
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
    }
}
