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
    public partial class FrmCaixaDinheiro : Form
    {
        ControllerTema controllerTema = new ControllerTema();
        decimal valorTotal;
        decimal dinheiro;
        decimal troco;
        public String Retorno
        {
            get
            {
                return txtTroco.Text;
            }
        }
        public String Dinheiro
        {
            get
            {
                return txtDinheiro.Text.Replace("R$", "");
            }
        }
        public FrmCaixaDinheiro(string ValorVenda)
        {
            InitializeComponent();
            valorTotal = Convert.ToDecimal(ValorVenda.Replace("R$",""));
            if (controllerTema.CarregarEnderecoImagem() != null)
            {
                pictureBox1.BackgroundImage = Image.FromFile(controllerTema.CarregarEnderecoImagem());
            }
        }

        private void txtValorUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dinheiro = Convert.ToDecimal(txtDinheiro.Text);
                lblValorInvalido.Visible = false;
                txtTroco.Visible = true;
                lblTroco.Visible = true;
                troco = dinheiro - valorTotal;
                txtTroco.Text = troco.ToString("C");
                Width = 319;
                Height = 446;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (txtTroco.Text == null)
                {
                    txtTroco.Text = null;
                }
                this.Close();
                
            }
        }

        private void FrmCaixaDinheiro_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.BackgroundImage.Dispose();
        }
    }
}
