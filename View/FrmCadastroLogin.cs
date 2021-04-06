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
using System.Windows.Forms.VisualStyles;

namespace View
{
    public partial class FrmCadastroLogin : Form
    {
        string Codigo;
        int loginsCadastrados;
        int loginsContratados;
        ModelLogin modelLogin = new ModelLogin();
        ControllerLogin controllerLogin = new ControllerLogin();
        ControllerTema controllerTema = new ControllerTema();
        public FrmCadastroLogin(ModelLogin modelLogin)
        {
            InitializeComponent();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
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
                txtID.Enabled = false;
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
                if (!string.IsNullOrWhiteSpace(Codigo) /*&& loginsCadastrados < loginsContratados*/)
                {
                    //loginsCadastrados++;
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
                    if (controllerLogin.Editar(modelLogin))
                    {
                        MessageBox.Show("O ID: " + txtID.Text + " foi editado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnlLogin.Enabled = false;
                        btnCadastrar.Text = "Editar";
                    }

                }
                //Cadastra um novo usuario
                else
                {
                    if (loginsCadastrados < loginsContratados)
                    {
                        //loginsCadastrados++;
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
                        if (controllerLogin.VerificarLogin(modelLogin) == null && !string.IsNullOrWhiteSpace(txtSenha.Text))
                        {
                            controllerLogin.Cadastrar(modelLogin);
                            MessageBox.Show("O ID: " + txtID.Text + " foi cadastrado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro, verifique os dados e tente novamente!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
