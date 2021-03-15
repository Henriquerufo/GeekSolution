using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace View
{
    public partial class FrmLoginLog : Form
    {
        ControllerLogin controllerLogin = new ControllerLogin();
        string idTec;
        string id;
        public FrmLoginLog(ModelLogin modelLogin)
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
            idTec = modelLogin.IDTecSistemas;
            id = modelLogin.ID;
            dgvLog.DataSource = controllerLogin.CarregarLogs(modelLogin, id);
            lblExibidosTotal.Text = "Exibidos total: " + dgvLog.Rows.Count;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbxFiltro.Text == "CODIGO" && !string.IsNullOrWhiteSpace(txtProcurar.Text))
            {
                dgvLog.DataSource = controllerLogin.CarregarLogPorCodigo(idTec, id, txtProcurar.Text);
            }
            if (cbxFiltro.Text == "ULTIMO LOG" && !string.IsNullOrWhiteSpace(txtProcurar.Text))
            {
                dgvLog.DataSource = controllerLogin.CarregarLogPorNome(idTec, id, txtProcurar.Text);
            }
            lblExibidosTotal.Text = "Exibidos total: " + dgvLog.Rows.Count;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
