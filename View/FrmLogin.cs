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
            if (retornoADM)
            {
                modelLogin.Nivel = "Administrador";
                FrmPrincipal frmPrincipal = new FrmPrincipal(modelLogin);
                frmPrincipal.ShowDialog();
            }
            bool retornoVendedor = controllerLogin.VerificarLoginVendedor(txtID.Text, txtSenha.Text);
            if (retornoVendedor)
            {
                modelLogin.Nivel = "Vendedor";
                FrmPrincipal frmPrincipal = new FrmPrincipal(modelLogin);
                frmPrincipal.ShowDialog();
            }
            bool retornoSupervisor = controllerLogin.VerificarLoginSupervisor(txtID.Text, txtSenha.Text);
            if (retornoSupervisor)
            {
                modelLogin.Nivel = "Supervisor";
                FrmPrincipal frmPrincipal = new FrmPrincipal(modelLogin);
                frmPrincipal.ShowDialog();
            }
            bool retornoEstoquista = controllerLogin.VerificarLoginEstoquista(txtID.Text, txtSenha.Text);
            if (retornoEstoquista)
            {
                modelLogin.Nivel = "Estoquista";
                FrmPrincipal frmPrincipal = new FrmPrincipal(modelLogin);
                frmPrincipal.ShowDialog();
            }
        }
        public string Autenticacao()
        {
            ControllerLogin controllerLogin = new ControllerLogin();
            bool retornoADM = controllerLogin.VerificarLoginADM(txtID.Text, txtSenha.Text);
            if (retornoADM)
            {             
                return "Administrador";
            }
            bool retornoVendedor = controllerLogin.VerificarLoginVendedor(txtID.Text, txtSenha.Text);
            if (retornoVendedor)
            {
                return "Vendedor";
            }
            bool retornoSupervisor = controllerLogin.VerificarLoginSupervisor(txtID.Text, txtSenha.Text);
            if (retornoSupervisor)
            {
                return "Supervisor";
            }
            bool retornoEstoquista = controllerLogin.VerificarLoginEstoquista(txtID.Text, txtSenha.Text);
            if (retornoEstoquista)
            {
                return "Estoquista";
            }
            return "Erro";
        }
    }
}
