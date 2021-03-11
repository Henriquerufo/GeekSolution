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
    public partial class FrmCadastroLogin : Form
    {
        ControllerConfiguracaoSQLCentral controllerConfiguracaoSQLCentral = new ControllerConfiguracaoSQLCentral();
        ModelConfiguracaoSQLCentral modelConfiguracaoSQLCentral = new ModelConfiguracaoSQLCentral();
        string Codigo;
        int loginsCadastrados;
        int loginsContratados;
        ModelLogin modelLogin = new ModelLogin();
        ControllerLogin controllerLogin = new ControllerLogin();
        public FrmCadastroLogin(ModelLogin modelLogin)
        {
            InitializeComponent();
            loginsCadastrados = controllerLogin.VerificarLoginsCadastrados();
            lblLoginsCadastrados.Text = "Cadastrados: " + loginsCadastrados.ToString();
            loginsContratados = controllerLogin.VerificarLoginsContratados();
            lblLoginsContratados.Text = "Contratados: " + loginsContratados.ToString();

            if (!string.IsNullOrWhiteSpace(modelLogin.Codigo))
            {
                btnCadastrar.Text = "Editar";
                Text = "Editar Login";
                lblCadastrar.Text = "Editar";
                pnlLogin.Enabled = false;
                Codigo = modelLogin.Codigo;
                txtID.Text = modelLogin.ID;
                txtSenha.Text = modelLogin.Senha;
                if (modelLogin.Nivel == "Administrador")
                {
                    rbAdministrador.Checked = true;
                }
                if (modelLogin.Nivel == "Vendedor")
                {
                    rbVendedor.Checked = true;
                }
                if (modelLogin.Nivel == "Estoquista")
                {
                    rbEstoquista.Checked = true;
                }
                if (modelLogin.Nivel == "Supervisor")
                {
                    rbSupervisor.Checked = true;
                }
            }
            if (modelLogin.Consultar == true)
            {
                Text = "Consultar Login";
                lblCadastrar.Text = "Consultar";
                btnCadastrar.Visible = false;
                btnCancelar.Text = "Fechar";
                txtConfirmarSenha.Visible = false;
                lblConfirmarSenha.Visible = false;
                pnlLogin.Enabled = false;
                txtID.Text = modelLogin.ID;
                txtSenha.Text = modelLogin.Senha;
                if (modelLogin.Nivel == "Administrador")
                {
                    rbAdministrador.Checked = true;
                }
                if (modelLogin.Nivel == "Vendedor")
                {
                    rbVendedor.Checked = true;
                }
                if (modelLogin.Nivel == "Estoquista")
                {
                    rbEstoquista.Checked = true;
                }
                if (modelLogin.Nivel == "Supervisor")
                {
                    rbSupervisor.Checked = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (btnCadastrar.Text == "Editar")
            {
                pnlLogin.Enabled = true;
                btnCadastrar.Text = "Salvar";
            }
            else
            {
                //Salva o usuario editado
                if (!string.IsNullOrWhiteSpace(Codigo) && loginsCadastrados < loginsContratados)
                {
                    loginsCadastrados++;
                    modelLogin.Codigo = Codigo;
                    modelLogin.ID = txtID.Text;
                    if (txtSenha.Text == txtConfirmarSenha.Text)
                    {
                        modelLogin.Senha = txtSenha.Text;
                    }
                    else
                    {
                        MessageBox.Show("Senhas diferentes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    
                    if (rbAdministrador.Checked == true)
                    {
                        modelLogin.Nivel = "Administrador";
                    }
                    if (rbVendedor.Checked == true)
                    {
                        modelLogin.Nivel = "Vendedor";
                    }
                    if (rbEstoquista.Checked == true)
                    {
                        modelLogin.Nivel = "Estoquista";
                    }
                    if (rbSupervisor.Checked == true)
                    {
                        modelLogin.Nivel = "Supervisor";
                    }
                    modelConfiguracaoSQLCentral = controllerConfiguracaoSQLCentral.Carregar();
                    modelLogin.IDTecSistemas = modelConfiguracaoSQLCentral.IDTecSistemas;
                    controllerLogin.Editar(modelLogin);
                }
                //Cadastra um novo usuario
                else
                {
                    if (loginsCadastrados < loginsContratados)
                    {
                        loginsCadastrados++;
                        modelLogin.ID = txtID.Text;
                        if (txtSenha.Text == txtConfirmarSenha.Text)
                        {
                            modelLogin.Senha = txtSenha.Text;
                        }
                        else
                        {
                            MessageBox.Show("Senhas diferentes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (rbAdministrador.Checked == true)
                        {
                            modelLogin.Nivel = "Administrador";
                        }
                        if (rbVendedor.Checked == true)
                        {
                            modelLogin.Nivel = "Vendedor";
                        }
                        if (rbEstoquista.Checked == true)
                        {
                            modelLogin.Nivel = "Estoquista";
                        }
                        if (rbSupervisor.Checked == true)
                        {
                            modelLogin.Nivel = "Supervisor";
                        }
                        modelConfiguracaoSQLCentral = controllerConfiguracaoSQLCentral.Carregar();
                        modelLogin.IDTecSistemas = modelConfiguracaoSQLCentral.IDTecSistemas;
                        if (controllerLogin.VerificarLoginExistente(modelLogin))
                        {
                            controllerLogin.Cadastrar(modelLogin);
                        }
                        else
                        {
                            MessageBox.Show("O ID: " + modelLogin.ID + " já está cadastrado!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
