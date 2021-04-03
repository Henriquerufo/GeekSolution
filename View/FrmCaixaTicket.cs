using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmCaixaTicket : Form
    {
        decimal valorTicket;
        ControllerCaixa controllerCaixa = new ControllerCaixa();
        ControllerTema controllerTema = new ControllerTema();
        public String Retorno
        {
            get
            {
                return txtDinheiro.Text;
            }
        }
        public Decimal RetornoTicket
        {
            get
            {
                return valorTicket;
            }
        }
        public FrmCaixaTicket()
        {
            InitializeComponent();
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
        }
        private void txtDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ModelCaixa modelCaixa = new ModelCaixa();
                    modelCaixa.Codigo = Convert.ToInt32(txtDinheiro.Text);
                    if (!string.IsNullOrWhiteSpace(controllerCaixa.VerificarTicket(modelCaixa)))
                    {
                        valorTicket = Convert.ToDecimal(controllerCaixa.VerificarTicket(modelCaixa).Replace("R$ ",""));
                        this.Close();
                    } 
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCaixaTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.BackgroundImage.Dispose();
        }
    }
}
