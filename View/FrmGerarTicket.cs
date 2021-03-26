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
    public partial class FrmGerarTicket : Form
    {
        ControllerTicket controllerTicket = new ControllerTicket();
        ModelTicket modelTicket = new ModelTicket();
        
        public FrmGerarTicket()
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
        }
        void Carregar()
        {
            try
            {
                if (cbxFiltro.Text == "COD PEDIDO")
                {
                    dgvTicket.DataSource = controllerTicket.CarregarItensCanceladosPorCodigoPedido(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                }
                else if (cbxFiltro.Text == "CODIGO ITEM")
                {
                    dgvTicket.DataSource = controllerTicket.CarregarItensCanceladosPorCodigoItem(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvTicket.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregar();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarTicket_Click(object sender, EventArgs e)
        {
            if (dgvTicket.Rows.Count > 0)
            {
                try
                {
                    decimal valorTotal = 0;
                    foreach (DataGridViewRow Rows in dgvTicket.Rows)
                    {
                        if (Rows.Selected)
                        {
                            valorTotal = valorTotal + Convert.ToDecimal(Rows.Cells["ValorProduto"].Value.ToString());
                            modelTicket.Codigo = Convert.ToInt32(Rows.Cells["Codigo"].Value.ToString());
                            controllerTicket.AlterarStatusTicket(modelTicket);
                        }
                    }
                    modelTicket.Valor = valorTotal.ToString("C");
                    modelTicket.Data = DateTime.Now.ToString();
                    modelTicket.GeradoPor = Properties.SettingsLogado.Default.Nome;
                    modelTicket.Status = "Em Aberto";
                    controllerTicket.GerarTicket(modelTicket);
                    Carregar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
