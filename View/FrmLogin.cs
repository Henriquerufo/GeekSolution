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
    public partial class FrmLogin : Form
    {
        ModelLogin modelLogin = new ModelLogin();
        string retorno;
        public String Retorno 
        {
            get { return retorno; }
            set { retorno = value; } 
        }
        public FrmLogin(ModelLogin modelLOgin)
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(modelLOgin.Nivel))
            {
                btnLogar.Text = "TESTE";
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (btnLogar.Text == "Logar")
            {
                PrimeiroLogin();
            }
            else
            {
                retorno = Autenticacao();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void PrimeiroLogin()
        {
            ControllerLogin controllerLogin = new ControllerLogin();
            bool retornoADM = controllerLogin.VerificarLoginADM(txtID.Text, txtSenha.Text);
            bool retornoVendedor = controllerLogin.VerificarLoginVendedor(txtID.Text, txtSenha.Text);
            bool retornoSupervisor = controllerLogin.VerificarLoginSupervisor(txtID.Text, txtSenha.Text);
            bool retornoEstoquista = controllerLogin.VerificarLoginEstoquista(txtID.Text, txtSenha.Text);
            if (retornoADM)
            {
                lblInvalido.Visible = false;
                this.Hide();
                modelLogin.Nivel = "Administrador";
                FrmPrincipal frmPrincipal = new FrmPrincipal(modelLogin);
                frmPrincipal.ShowDialog();
                this.Show();
            }           
            else if (retornoVendedor)
            {
                lblInvalido.Visible = false;
                this.Hide();
                modelLogin.Nivel = "Vendedor";
                FrmPrincipal frmPrincipal = new FrmPrincipal(modelLogin);
                frmPrincipal.ShowDialog();
                this.Show();
            }           
            else if (retornoSupervisor)
            {
                lblInvalido.Visible = false;
                this.Hide();
                modelLogin.Nivel = "Supervisor";
                FrmPrincipal frmPrincipal = new FrmPrincipal(modelLogin);
                frmPrincipal.ShowDialog();
                this.Show();
            }           
            else if (retornoEstoquista)
            {
                lblInvalido.Visible = false;
                this.Hide();
                modelLogin.Nivel = "Estoquista";
                FrmPrincipal frmPrincipal = new FrmPrincipal(modelLogin);
                frmPrincipal.ShowDialog();
                this.Show();
            }
            else
            {
                txtID.Focus();
                lblInvalido.Visible = true;
            }
        }
        public string Autenticacao()
        {
            ControllerLogin controllerLogin = new ControllerLogin();
            bool retornoADM = controllerLogin.VerificarLoginADM(txtID.Text, txtSenha.Text);
            bool retornoVendedor = controllerLogin.VerificarLoginVendedor(txtID.Text, txtSenha.Text);
            bool retornoSupervisor = controllerLogin.VerificarLoginSupervisor(txtID.Text, txtSenha.Text);
            bool retornoEstoquista = controllerLogin.VerificarLoginEstoquista(txtID.Text, txtSenha.Text);
            if (retornoADM)
            {             
                return "Administrador";
            }            
            else if (retornoVendedor)
            {
                return "Vendedor";
            }           
            else if (retornoSupervisor)
            {
                return "Supervisor";
            }            
            else if (retornoEstoquista)
            {
                return "Estoquista";
            }
            else
            {
                txtID.Focus();
                lblInvalido.Visible = true;
                return "ERRO";
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                this.Hide();
                FrmConfiguracaoSQL frmConfiguracaoSQL = new FrmConfiguracaoSQL();
                frmConfiguracaoSQL.ShowDialog();
                this.Show();
            }
        }
    }
}
