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
        ControllerCadastro ControllerCadastro = new ControllerCadastro();
        public FrmConsultarPedidoItens(ModelFinanceiro modelFinanceiro)
        {
            InitializeComponent();
            string codigo = modelFinanceiro.CodigoPedido;
            dgvPedidoItens.DataSource = ControllerCadastro.CarregarPedidosItensCodigo(codigo);
            lblExibidosTotal.Text = "Exibidos total: " + dgvPedidoItens.Rows.Count.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
