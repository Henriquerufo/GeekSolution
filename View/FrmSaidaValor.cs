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
    public partial class FrmSaidaValor : Form
    {
        decimal valorCaixa;
        ModelSaida modelSaida = new ModelSaida();
        ControllerSaida controllerSaida = new ControllerSaida();
        ControllerTema controllerTema = new ControllerTema();
        public FrmSaidaValor()
        {
            InitializeComponent();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
            Carregar();
        }
        void Carregar()
        {
            try
            {
                modelSaida.DataSaida = DateTime.Now.ToString();
                modelSaida.Vendedor = Properties.SettingsLogado.Default.Nome;
                txtDataSaida.Text = modelSaida.DataSaida;
                txtVendedor.Text = modelSaida.Vendedor;
                valorCaixa = controllerSaida.CarregarValorTotalRecebido(modelSaida) - controllerSaida.CarregarValorSaida(modelSaida);
                txtValorCaixa.Text = valorCaixa.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtValor.Text))
                {
                    ModelLogin modelLogin = new ModelLogin();
                    modelLogin.Nivel = "?";
                    FrmLogin frmLogin = new FrmLogin(modelLogin);
                    frmLogin.ShowDialog();
                    if (frmLogin.Retorno == "Supervisor")
                    {
                        modelSaida.Vendedor = txtVendedor.Text;
                        modelSaida.DataSaida = txtDataSaida.Text;
                        modelSaida.Valor = txtValor.Text;
                        decimal valorRetirada = Convert.ToDecimal(txtValor.Text);
                        if (valorCaixa >= valorRetirada && controllerSaida.InserirSaida(modelSaida))
                        {
                            MessageBox.Show("Valor: " + valorRetirada.ToString("C") + " foi retirado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FrmSaidaValor_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.BackgroundImage.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
