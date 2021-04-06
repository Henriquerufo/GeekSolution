using Controller;
using Model;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmLogin : Form
    {
        ControllerLogin controllerLogin = new ControllerLogin();
        ModelLogin modelLogin = new ModelLogin();
        public String Retorno
        {
            get 
            {
                return modelLogin.Nivel;
            }
        }
        public FrmLogin(ModelLogin modelLogin)
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(modelLogin.Nivel))
            {
                btnLogar.Text = "OK";
            }
        }
        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (btnLogar.Text == "Logar")
            {
                modelLogin.ID = txtID.Text;
                Properties.SettingsLogado.Default.Nome = modelLogin.ID;
                modelLogin.Senha = txtSenha.Text;
                modelLogin.Status = "Conectado";
                modelLogin.UltimoLog = DateTime.Now.ToString();
                lblInvalido.Visible = false;
                modelLogin.Nivel = controllerLogin.VerificarLogin(modelLogin);
                if (modelLogin.Nivel != null)
                {
                    this.Hide();
                    controllerLogin.InserirLog(modelLogin);
                    controllerLogin.AlterarStatus(modelLogin);
                    FrmPrincipal frmPrincipal = new FrmPrincipal(modelLogin);
                    frmPrincipal.ShowDialog();
                }
                else
                {
                    txtID.Focus();
                    lblInvalido.Visible = true;
                    return;
                }
                modelLogin.Status = "Desconectado";
                modelLogin.UltimoLog = DateTime.Now.ToString();
                controllerLogin.InserirLog(modelLogin);
                controllerLogin.AlterarStatus(modelLogin);
                Application.Exit();
            }
            else if(btnLogar.Text == "OK")
            {
                modelLogin.ID = txtID.Text;
                modelLogin.Senha = txtSenha.Text;
                modelLogin.Nivel = controllerLogin.VerificarLogin(modelLogin);
                this.Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                this.Hide();
                FrmConfiguracaoSQL frmConfiguracaoSQL = new FrmConfiguracaoSQL();
                frmConfiguracaoSQL.ShowDialog();
                Application.Exit();
            }
        }
    }
}
