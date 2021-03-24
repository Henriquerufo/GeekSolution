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
    public partial class FrmSaida : Form
    {
        ControllerSaida controllerSaida = new ControllerSaida();
        public FrmSaida()
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxFiltro.Text == "CODIGO")
                {
                    dgvSaida.DataSource = controllerSaida.CarregarPorCodigo(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                }
                else if (cbxFiltro.Text == "VENDEDOR")
                {
                    dgvSaida.DataSource = controllerSaida.CarregarPorNomeVendedor(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
