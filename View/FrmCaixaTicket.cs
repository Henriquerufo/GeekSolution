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
        decimal valorVenda;
        decimal valorTicketPago;
        ControllerCaixa controllerCaixa = new ControllerCaixa();
        ControllerTema controllerTema = new ControllerTema();
        public String Retorno
        {
            get
            {
                return txtTicketCodigo.Text;
            }
        }
        public Decimal RetornoTicket
        {
            get
            {
                return valorTicketPago;
            }
        }
        public FrmCaixaTicket(decimal ValorVenda)
        {
            InitializeComponent();
            valorVenda = ValorVenda;
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
                    modelCaixa.Codigo = Convert.ToInt32(txtTicketCodigo.Text);
                    if (controllerCaixa.VerificarTicket(modelCaixa) != 0)
                    {
                        if (controllerCaixa.VerificarTicket(modelCaixa) >= Convert.ToDecimal(txtTicketDinheiro.Text) && valorVenda >= Convert.ToDecimal(txtTicketDinheiro.Text))
                        {
                            valorTicketPago = Convert.ToDecimal(txtTicketDinheiro.Text);
                            modelCaixa.valorTicketPago = valorTicketPago;
                            controllerCaixa.valorTicketPago(modelCaixa);
                            if (controllerCaixa.VerificarTicketZerado(modelCaixa))
                            {
                                controllerCaixa.TicketAlterarStatus(modelCaixa);
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Valor Invalido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
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
