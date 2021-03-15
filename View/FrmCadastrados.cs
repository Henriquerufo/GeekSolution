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
    public partial class FrmCadastrados : Form
    {
        string valorVenda;
        ControllerCadastro controllerCadastro = new ControllerCadastro();
        ModelCadastro modelCadastro = new ModelCadastro();
        ModelFinanceiro modelFinanceiro = new ModelFinanceiro();
        ControllerFinanceiro controllerFinanceiro = new ControllerFinanceiro();
        public FrmCadastrados(ModelFinanceiro ModelFinanceiro)
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(ModelFinanceiro.valorVenda))
            {
                valorVenda = ModelFinanceiro.valorVenda;
                btnCadastrar.Visible = false;
                btnSalvar.Visible = false;
                btnDeletar.Visible = false;
                btnConsultar.Location = new Point(12, 352);
                Text = "Selecionar Cliente";
            }
            cbxFiltro.SelectedIndex = 0;
        }
        void Carregar()
        {
            dgvCadastrados.DataSource = controllerCadastro.Carregar();
            lblExibidosTotal.Text = "Exibidos total: " + dgvCadastrados.Rows.Count;
            if (dgvCadastrados.Rows.Count > 0)
            {
                btnConsultar.Enabled = true;
                btnDeletar.Enabled = true;
                btnSalvar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
                btnDeletar.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }
        void CarregarPorCodigo(string codigo)
        {
            dgvCadastrados.DataSource = controllerCadastro.CarregarPorCodigo(codigo);
        }
        void CarregarPorNome(string nome)
        {
            dgvCadastrados.DataSource = controllerCadastro.CarregarPorNome(nome);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvCadastrados.Rows.Count == 0){ }
            else
            {
                modelCadastro.consulta = false;
                modelCadastro.Codigo = dgvCadastrados.CurrentRow.Cells["codigo"].Value.ToString();
                modelCadastro.RG = dgvCadastrados.CurrentRow.Cells["rg"].Value.ToString();
                modelCadastro.CPF = dgvCadastrados.CurrentRow.Cells["cpf"].Value.ToString();
                modelCadastro.Nome = dgvCadastrados.CurrentRow.Cells["nome"].Value.ToString();
                modelCadastro.dtCadastro = dgvCadastrados.CurrentRow.Cells["dtCadastro"].Value.ToString();
                modelCadastro.Telefone = dgvCadastrados.CurrentRow.Cells["telefone"].Value.ToString();
                modelCadastro.Endereco = dgvCadastrados.CurrentRow.Cells["endereco"].Value.ToString();
                modelCadastro.Email = dgvCadastrados.CurrentRow.Cells["email"].Value.ToString();

                FrmCadastro frmCadastro = new FrmCadastro(modelCadastro);
                frmCadastro.ShowDialog();
                Carregar();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvCadastrados.Rows.Count == 0){ }
            else
            {
                string nome = dgvCadastrados.CurrentRow.Cells["nome"].Value.ToString();
                var Result = MessageBox.Show(nome + " será excluido", "DELETAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (Result == DialogResult.OK)
                {
                    modelCadastro.Codigo = dgvCadastrados.CurrentRow.Cells["codigo"].Value.ToString();
                    controllerCadastro.Deletar(modelCadastro);
                    Carregar();
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            modelCadastro.consulta = false;
            modelCadastro.Codigo = null;
            FrmCadastro frmCadastro = new FrmCadastro(modelCadastro);
            frmCadastro.ShowDialog();
            Carregar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvCadastrados.Rows.Count == 0){ }
            else
            {
                modelCadastro.consulta = true;
                modelCadastro.Codigo = dgvCadastrados.CurrentRow.Cells["codigo"].Value.ToString();
                modelCadastro.RG = dgvCadastrados.CurrentRow.Cells["rg"].Value.ToString();
                modelCadastro.CPF = dgvCadastrados.CurrentRow.Cells["cpf"].Value.ToString();
                modelCadastro.Nome = dgvCadastrados.CurrentRow.Cells["nome"].Value.ToString();
                modelCadastro.dtCadastro = dgvCadastrados.CurrentRow.Cells["dtCadastro"].Value.ToString();
                modelCadastro.Telefone = dgvCadastrados.CurrentRow.Cells["telefone"].Value.ToString();
                modelCadastro.Endereco = dgvCadastrados.CurrentRow.Cells["endereco"].Value.ToString();
                modelCadastro.Email = dgvCadastrados.CurrentRow.Cells["email"].Value.ToString();

                FrmCadastro frmCadastro = new FrmCadastro(modelCadastro);
                frmCadastro.ShowDialog();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consultar: Utilizado para consultar o cliente selecionado\nCadastrar: Cadastra um novo cliente\nEditar: Edita um cliente selecionado\nDeletar: Deleta um cliente Selecionado", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbxFiltro.Text == "CODIGO" && !string.IsNullOrWhiteSpace(txtProcurar.Text))
            {
                CarregarPorCodigo(txtProcurar.Text);
            }
            else if (cbxFiltro.Text == "NOME" && !string.IsNullOrWhiteSpace(txtProcurar.Text))
            {
                CarregarPorNome(txtProcurar.Text);
            }
            lblExibidosTotal.Text = "Exibidos total: " + dgvCadastrados.Rows.Count;
        }
    }
}
