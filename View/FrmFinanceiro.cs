using Controller;
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
        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            Carregar(txtProcurar.Text);
        }
    }
}
