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
    public partial class FrmGerenciadorLogins : Form
    {
        ModelLogin modelLogin = new ModelLogin();
        ControllerLogin controllerLogin = new ControllerLogin();
        public FrmGerenciadorLogins()
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
        }
        void CarregarTodos(string Procurar)
        {
            dgvLogin.DataSource = controllerLogin.CarregarTodos(Procurar);
        }
        void Carregar(string Nivel, string ID)
        {
            dgvLogin.DataSource = controllerLogin.Carregar(Nivel, ID);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            modelLogin.Consultar = false;
            modelLogin.Codigo = null;
            FrmCadastroLogin frmCadastroLogin = new FrmCadastroLogin(modelLogin);
            frmCadastroLogin.ShowDialog();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvLogin.Rows.Count == 0) { }
            else
            {
                modelLogin.Codigo = dgvLogin.CurrentRow.Cells["codigo"].Value.ToString();
                modelLogin.ID = dgvLogin.CurrentRow.Cells["id"].Value.ToString();

                var result = MessageBox.Show(modelLogin.ID + " será excluido", "Deletar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    controllerLogin.Deletar(modelLogin);
                    if (cbxFiltro.Text == "ADM")
                    {
                        Carregar("Administrador", txtProcurar.Text);
                    }
                    if (cbxFiltro.Text == "VENDEDOR")
                    {
                        Carregar("Vendedor", txtProcurar.Text);
                    }
                    if (cbxFiltro.Text == "ESTOQUISTA")
                    {
                        Carregar("Estoquista", txtProcurar.Text);
                    }
                    if (cbxFiltro.Text == "SUPERVISOR")
                    {
                        Carregar("Supervisor", txtProcurar.Text);
                    }
                    if (cbxFiltro.Text == "TODOS")
                    {
                        CarregarTodos(txtProcurar.Text);
                    }
                    lblExibidosTotal.Text = "Exibidos total: " + dgvLogin.Rows.Count;
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvLogin.Rows.Count == 0){ }
            else
            {
                modelLogin.Consultar = true;
                modelLogin.ID = dgvLogin.CurrentRow.Cells["id"].Value.ToString();
                modelLogin.Senha = dgvLogin.CurrentRow.Cells["senha"].Value.ToString();
                modelLogin.Nivel = dgvLogin.CurrentRow.Cells["nivel"].Value.ToString();
                FrmCadastroLogin frmCadastroLogin = new FrmCadastroLogin(modelLogin);
                frmCadastroLogin.ShowDialog();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvLogin.Rows.Count == 0) { }
            else
            {
                modelLogin.Consultar = false;
                modelLogin.Codigo = dgvLogin.CurrentRow.Cells["codigo"].Value.ToString();
                modelLogin.ID = dgvLogin.CurrentRow.Cells["id"].Value.ToString();
                modelLogin.Senha = dgvLogin.CurrentRow.Cells["senha"].Value.ToString();
                modelLogin.Nivel = dgvLogin.CurrentRow.Cells["nivel"].Value.ToString();
                FrmCadastroLogin frmCadastroLogin = new FrmCadastroLogin(modelLogin);
                frmCadastroLogin.ShowDialog();
                if (cbxFiltro.Text == "ADM")
                {
                    Carregar("Administrador", txtProcurar.Text);
                }
                if (cbxFiltro.Text == "VENDEDOR")
                {
                    Carregar("Vendedor", txtProcurar.Text);
                }
                if (cbxFiltro.Text == "ESTOQUISTA")
                {
                    Carregar("Estoquista", txtProcurar.Text);
                }
                if (cbxFiltro.Text == "SUPERVISOR")
                {
                    Carregar("Supervisor", txtProcurar.Text);
                }
                if (cbxFiltro.Text == "TODOS")
                {
                    CarregarTodos(txtProcurar.Text);
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvLogin.Rows.Count;
            }        
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbxFiltro.Text == "ADM")
            {
                Carregar("Administrador", txtProcurar.Text);
            }
            if (cbxFiltro.Text == "VENDEDOR")
            {
                Carregar("Vendedor", txtProcurar.Text);
            }
            if (cbxFiltro.Text == "ESTOQUISTA")
            {
                Carregar("Estoquista", txtProcurar.Text);
            }
            if (cbxFiltro.Text == "SUPERVISOR")
            {
                Carregar("Supervisor", txtProcurar.Text);
            }
            if (cbxFiltro.Text == "TODOS")
            {
                CarregarTodos(txtProcurar.Text);
            }
            lblExibidosTotal.Text = "Exibidos total: " + dgvLogin.Rows.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvLogin.Rows.Count == 0){ }
            else
            {
                modelLogin.IDTecSistemas = dgvLogin.CurrentRow.Cells["IDTecSistemas"].Value.ToString();
                modelLogin.ID = dgvLogin.CurrentRow.Cells["ID"].Value.ToString();
                FrmLoginLog frmLoginLog = new FrmLoginLog(modelLogin);
                frmLoginLog.ShowDialog();
            }
        }
    }
}
