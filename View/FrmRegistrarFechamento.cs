﻿using Controller;
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
    public partial class FrmRegistrarFechamento : Form
    {
        decimal valorCaixa;
        decimal valorTotalRecebidoSemTicket;
        decimal valorTotalVendidoSemTicket;
        ModelFechamento modelFechamento = new ModelFechamento();
        ControllerFechamento controllerFechamento = new ControllerFechamento();
        ControllerTema controllerTema = new ControllerTema();
        public FrmRegistrarFechamento()
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
                modelFechamento.Vendedor = Properties.SettingsLogado.Default.Nome;
                modelFechamento.Data = DateTime.Now.ToString();

                valorTotalVendidoSemTicket = controllerFechamento.CarregarValorTotalVendido(modelFechamento) - controllerFechamento.CarregarTicket(modelFechamento);
                txtValorTotalVendido.Text = valorTotalVendidoSemTicket.ToString("C");

                valorTotalRecebidoSemTicket = controllerFechamento.CarregarValorTotalRecebido(modelFechamento) - controllerFechamento.CarregarTicket(modelFechamento);
                txtValorTotalRecebido.Text = valorTotalRecebidoSemTicket.ToString("C");
      
                txtVendedor.Text = modelFechamento.Vendedor;
                txtData.Text = modelFechamento.Data;
                txtTicket.Text = controllerFechamento.CarregarTicket(modelFechamento).ToString("C");
                txtPedidosFinalizados.Text = controllerFechamento.CarregarItensVendidos(modelFechamento).ToString();
                txtItensRecebidos.Text = controllerFechamento.CarregarItensRecebidos(modelFechamento).ToString();
                txtDinheiro.Text = controllerFechamento.CarregarDinheiro(modelFechamento).ToString("C");
                txtCartao.Text = controllerFechamento.CarregarCartao(modelFechamento).ToString("C");
                txtCheque.Text = controllerFechamento.CarregarCheque(modelFechamento).ToString("C");
                txtConvenio.Text = controllerFechamento.CarregarConvenio(modelFechamento).ToString("C");
                txtValorSaida.Text = controllerFechamento.CarregarValorSaida(modelFechamento).ToString("C");
                valorCaixa = valorTotalRecebidoSemTicket - controllerFechamento.CarregarValorSaida(modelFechamento);
                txtValorCaixa.Text = valorCaixa.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRealizarSaida_Click(object sender, EventArgs e)
        {
            if (valorCaixa > 0)
            {
                FrmSaidaValor frmSaidaValor = new FrmSaidaValor();
                frmSaidaValor.ShowDialog();
                Carregar();
            }
        }
        private void FrmFechamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBox1.BackgroundImage.Dispose();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRegistrarFechamento_Click(object sender, EventArgs e)
        {
            try
            {
                modelFechamento.Vendedor = txtVendedor.Text;
                modelFechamento.Data = txtData.Text;
                ModelLogin modelLogin = new ModelLogin();
                modelLogin.Nivel = "?";
                FrmLogin frmLogin = new FrmLogin(modelLogin);
                frmLogin.ShowDialog();
                if (txtValorCaixa.Text == "R$ 0,00" && frmLogin.Retorno == "Supervisor" && !controllerFechamento.VerificarFechamento(modelFechamento))
                {
                    modelFechamento.Vendedor = txtVendedor.Text;
                    modelFechamento.Data = txtData.Text;
                    modelFechamento.ValorTotalVendido = txtValorTotalVendido.Text;
                    modelFechamento.ValorTotalRecebido = txtValorTotalRecebido.Text;
                    modelFechamento.PedidosFinalizados = txtPedidosFinalizados.Text;
                    modelFechamento.ItensRecebidos = txtItensRecebidos.Text;
                    modelFechamento.Dinheiro = txtDinheiro.Text;
                    modelFechamento.Cartao = txtCartao.Text;
                    modelFechamento.Conveniado = txtConvenio.Text;
                    modelFechamento.ValorSaida = txtValorSaida.Text;
                    modelFechamento.Cheque = txtCheque.Text;
                    modelFechamento.ValorCaixa = txtValorCaixa.Text;
                    modelFechamento.Ticket = txtTicket.Text;
                    if (controllerFechamento.InserirFechamento(modelFechamento))
                    {
                        MessageBox.Show("Fechamento registrado com sucesso!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
