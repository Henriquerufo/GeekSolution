using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmCadastrarTema : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        ColorDialog colorDialog1 = new ColorDialog();
        OpenFileDialog OpenFileDialog2 = new OpenFileDialog();
        ModelTema modelTema = new ModelTema();
        ControllerTema controllerTema = new ControllerTema();
        int codigo;
        bool cadastrar = true;
        bool fotoFundoAlterada = false;
        bool fotoAlterada = false;
        public FrmCadastrarTema(ModelTema modelTema)
        {
            InitializeComponent();
            if (modelTema != null && !modelTema.Consultar)
            {
                lblCadastrar.Text = "Editar";
                pnlCadastrarTema.Enabled = false;
                btnSalvar.Text = "Editar";
                btnCancelar.Text = "Fechar";
                codigo = modelTema.Codigo;
                txtNome.Text = modelTema.Nome;
                txtEnderecoImagemFundo.Text = modelTema.EnderecoImagemFundo;
                txtImagemEndereco.Text = modelTema.ImagemEndereco;
                txtColorR.Text = modelTema.R;
                txtColorG.Text = modelTema.G;
                txtColorB.Text = modelTema.B;
                ptnPrevia.BackColor = Color.FromArgb(Convert.ToInt32(txtColorR.Text), Convert.ToInt32(txtColorG.Text), Convert.ToInt32(txtColorB.Text));
                txtNome.Enabled = false;
                ptnPrevia.BackgroundImage = Image.FromFile(txtEnderecoImagemFundo.Text);
            }
            if (modelTema != null && modelTema.Consultar)
            {
                lblCadastrar.Text = "Consultar";
                pnlCadastrarTema.Enabled = false;
                btnCancelar.Text = "Fechar";
                btnSalvar.Visible = false;
                codigo = modelTema.Codigo;
                txtNome.Text = modelTema.Nome;
                txtEnderecoImagemFundo.Text = modelTema.EnderecoImagemFundo;
                txtImagemEndereco.Text = modelTema.ImagemEndereco;
                txtColorR.Text = modelTema.R;
                txtColorG.Text = modelTema.G;
                txtColorB.Text = modelTema.B;
                ptnPrevia.BackColor = Color.FromArgb(Convert.ToInt32(txtColorR.Text), Convert.ToInt32(txtColorG.Text), Convert.ToInt32(txtColorB.Text));
                ptnPrevia.BackgroundImage = Image.FromFile(txtEnderecoImagemFundo.Text);
            }
        }
        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ptnPrevia.BackgroundImage.Dispose();
                fotoFundoAlterada = true;
                txtEnderecoImagemFundo.Text = openFileDialog1.FileName;
                ptnPrevia.BackgroundImage = Image.FromFile(txtEnderecoImagemFundo.Text);
            }
        }
        private void btnSelecionarFundo_Click(object sender, EventArgs e)
        {
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ptnPrevia.BackColor = Color.White;
                txtColorR.Text = colorDialog1.Color.R.ToString();
                txtColorG.Text = colorDialog1.Color.G.ToString();
                txtColorB.Text = colorDialog1.Color.B. ToString();
                ptnPrevia.BackColor = Color.FromArgb(Convert.ToInt32(txtColorR.Text), Convert.ToInt32(txtColorG.Text), Convert.ToInt32(txtColorB.Text));
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Editar")
            {
                btnSalvar.Text = "Salvar";
                btnCancelar.Text = "Cancelar";
                pnlCadastrarTema.Enabled = true;
                cadastrar = false;
                fotoFundoAlterada = false;
            }
            else if (cadastrar == false)
            {
                txtImagemEndereco.Text = OpenFileDialog2.FileName;
                string FileName2 = Path.Combine(@"C:\Users\henri\source\repos\ProjetoPIM\View\Resources\" + txtNome.Text + "Foto.jpg");
                if (File.Exists(FileName2) && fotoAlterada)
                {
                    File.Delete(FileName2);
                    File.Copy(txtImagemEndereco.Text, FileName2);
                }
                modelTema.ImagemEndereco = FileName2;
                txtEnderecoImagemFundo.Text = openFileDialog1.FileName;
                string FileName = Path.Combine(@"C:\Users\henri\source\repos\ProjetoPIM\View\Resources\" + txtNome.Text + "FotoTema.jpg");
                if (File.Exists(FileName) && fotoFundoAlterada)
                { 
                    File.Delete(FileName);
                    File.Copy(txtEnderecoImagemFundo.Text, FileName);
                }
                modelTema.Codigo = codigo;
                modelTema.Nome = txtNome.Text;
                modelTema.EnderecoImagemFundo = FileName;
                modelTema.R = txtColorR.Text;
                modelTema.G = txtColorG.Text;
                modelTema.B = txtColorB.Text;
                modelTema.status = false;
                if (controllerTema.AlterarTema(modelTema))
                {
                    MessageBox.Show("Tema alterado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ptnPrevia.BackgroundImage.Dispose();
                    this.Close();
                }
            }
            else if (cadastrar && ValidarCampos())
            {
                string FileName2 = Path.Combine(@"C:\Users\henri\source\repos\ProjetoPIM\View\Resources\" + txtNome.Text + "Foto.jpg");
                File.Copy(txtImagemEndereco.Text, FileName2);
                modelTema.ImagemEndereco = FileName2;

                string FileName = Path.Combine(@"C:\Users\henri\source\repos\ProjetoPIM\View\Resources\" + txtNome.Text + "FotoTema.jpg");
                File.Copy(txtEnderecoImagemFundo.Text, FileName);
                modelTema.Nome = txtNome.Text;
                modelTema.EnderecoImagemFundo = FileName;
                modelTema.R = txtColorR.Text;
                modelTema.G = txtColorG.Text;
                modelTema.B = txtColorB.Text;
                modelTema.status = false;
                if (controllerTema.InserirTema(modelTema))
                {
                    MessageBox.Show("Tema cadastrado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ptnPrevia.BackgroundImage.Dispose();
                    this.Close();
                }
            }
        }
        public bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome inválido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEnderecoImagemFundo.Text))
            {
                MessageBox.Show("Endereço da imagem inválido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnderecoImagemFundo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtColorR.Text))
            {
                MessageBox.Show("Cor R inválido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtColorR.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtColorG.Text))
            {
                MessageBox.Show("Cor G inválido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtColorG.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtColorB.Text))
            {
                MessageBox.Show("Cor B inválido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtColorB.Focus();
                return false;
            }
            return true;
        }
        private void FrmCadastrarTema_FormClosing(object sender, FormClosingEventArgs e)
        {
            ptnPrevia.BackgroundImage.Dispose();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog2.ShowDialog() == DialogResult.OK)
            {
                fotoAlterada = true;
                txtImagemEndereco.Text = OpenFileDialog2.FileName;
            }
        }
    }
}
