﻿using Controller;
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
    public partial class FrmFechamento : Form
    {
        ControllerFechamento controllerFechamento = new ControllerFechamento();
        public FrmFechamento()
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
        }
        void Carregar()
        {
            try
            {
                if (cbxFiltro.Text == "CODIGO")
                {
                    dgvFechamento.DataSource = controllerFechamento.CarregarFechamentosRegistradosPorCodigo(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                }
                else if (cbxFiltro.Text == "VENDEDOR")
                {
                    dgvFechamento.DataSource = controllerFechamento.CarregarFechamentosRegistradosPorVendedor(txtProcurar.Text, dtpDe.Value.ToString(), dtpAte.Value.ToString());
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvFechamento.Rows.Count;
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
    }
}
