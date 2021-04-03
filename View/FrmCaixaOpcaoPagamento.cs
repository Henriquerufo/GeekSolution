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
    public partial class FrmCaixaOpcaoPagamento : Form
    {
        string opcaoSelecionada;
        public String RetornoOpcaoPagamento
        {
            get
            {
                return opcaoSelecionada;
            }
        }
        public FrmCaixaOpcaoPagamento()
        {
            InitializeComponent();
            dgvOpcaoPagamento.Rows.Insert(0, "DINHEIRO");
            dgvOpcaoPagamento.Rows.Insert(1, "CARTAO");
            dgvOpcaoPagamento.Rows.Insert(2, "CONVENIADO");
            dgvOpcaoPagamento.Rows.Insert(3, "TICKET");
            dgvOpcaoPagamento.Rows.Insert(4, "ORCAMENTO");
        }
        void Selecionar()
        {
            opcaoSelecionada = dgvOpcaoPagamento.CurrentRow.Cells["opcaoPagamento"].Value.ToString();
            this.Close();
        }

        private void dgvOpcaoPagamento_DoubleClick(object sender, EventArgs e)
        {
            Selecionar();
        }

        private void dgvOpcaoPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Selecionar();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
