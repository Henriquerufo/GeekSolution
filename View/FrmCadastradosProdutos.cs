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
    public partial class FrmCadastradosProdutos : Form
    {
        ControllerCadastroProduto controllerCadastroProduto = new ControllerCadastroProduto();
        ModelCadastroProduto modelCadastroProduto = new ModelCadastroProduto();
        public FrmCadastradosProdutos(string Verificar)
        {
            InitializeComponent();
            if (Verificar == "Caixa")
            {
                btnCadastrar.Visible = false;
                btnDeletar.Visible = false;
                btnSalvar.Visible = false;
                btnConsultar.Location = new Point(576, 441);
                Text = "Consultar Produtos";
            }
            cbxFiltro.SelectedIndex = 0;
        }
        void Carregar()
        {
            try
            {
                if (cbxFiltro.Text == "CODIGO" && !string.IsNullOrWhiteSpace(txtProcurar.Text))
                {
                    dgvProduto.DataSource = controllerCadastroProduto.CarregarPorCodigo(txtProcurar.Text);
                }
                else if (cbxFiltro.Text == "NOME" && !string.IsNullOrWhiteSpace(txtProcurar.Text))
                {
                    dgvProduto.DataSource = controllerCadastroProduto.CarregarPorNome(txtProcurar.Text);
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvProduto.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            modelCadastroProduto.Consultar = false;
            modelCadastroProduto.Codigo = null;
            FrmCadastrarProduto frmCadastrarProduto = new FrmCadastrarProduto(modelCadastroProduto);
            frmCadastrarProduto.ShowDialog();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvProduto.Rows.Count > 0)
            {
                modelCadastroProduto.Consultar = false;
                modelCadastroProduto.Codigo = dgvProduto.CurrentRow.Cells["codigo"].Value.ToString();
                modelCadastroProduto.CodigoBarras = dgvProduto.CurrentRow.Cells["codigoBarras"].Value.ToString();
                modelCadastroProduto.NomeProduto = dgvProduto.CurrentRow.Cells["nomeProduto"].Value.ToString();
                modelCadastroProduto.Categoria = dgvProduto.CurrentRow.Cells["categoria"].Value.ToString();
                modelCadastroProduto.Fabricante = dgvProduto.CurrentRow.Cells["fabricante"].Value.ToString();
                modelCadastroProduto.Quantidade = dgvProduto.CurrentRow.Cells["quantidade"].Value.ToString();
                modelCadastroProduto.ValorProduto = dgvProduto.CurrentRow.Cells["valorProduto"].Value.ToString();
                modelCadastroProduto.Plataforma = dgvProduto.CurrentRow.Cells["plataforma"].Value.ToString();
                modelCadastroProduto.Garantia = dgvProduto.CurrentRow.Cells["prazoGarantia"].Value.ToString();

                FrmCadastrarProduto frmCadastrarProduto = new FrmCadastrarProduto(modelCadastroProduto);
                frmCadastrarProduto.ShowDialog();
                Carregar();
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvProduto.Rows.Count > 0)
            {
                try
                {
                    modelCadastroProduto.NomeProduto = dgvProduto.CurrentRow.Cells["nomeProduto"].Value.ToString();
                    var result = MessageBox.Show("O produto: " + modelCadastroProduto.NomeProduto + " será excluido", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        modelCadastroProduto.Codigo = dgvProduto.CurrentRow.Cells["codigo"].Value.ToString();
                        controllerCadastroProduto.Deletar(modelCadastroProduto);
                        Carregar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void Consultar()
        {
            if (dgvProduto.Rows.Count > 0)
            {
                modelCadastroProduto.Consultar = true;
                modelCadastroProduto.Codigo = dgvProduto.CurrentRow.Cells["codigo"].Value.ToString();
                modelCadastroProduto.CodigoBarras = dgvProduto.CurrentRow.Cells["codigoBarras"].Value.ToString();
                modelCadastroProduto.NomeProduto = dgvProduto.CurrentRow.Cells["nomeProduto"].Value.ToString();
                modelCadastroProduto.Categoria = dgvProduto.CurrentRow.Cells["categoria"].Value.ToString();
                modelCadastroProduto.Fabricante = dgvProduto.CurrentRow.Cells["fabricante"].Value.ToString();
                modelCadastroProduto.Quantidade = dgvProduto.CurrentRow.Cells["quantidade"].Value.ToString();
                modelCadastroProduto.ValorProduto = dgvProduto.CurrentRow.Cells["valorProduto"].Value.ToString();
                modelCadastroProduto.Plataforma = dgvProduto.CurrentRow.Cells["plataforma"].Value.ToString();
                modelCadastroProduto.Garantia = dgvProduto.CurrentRow.Cells["prazoGarantia"].Value.ToString();

                FrmCadastrarProduto frmCadastrarProduto = new FrmCadastrarProduto(modelCadastroProduto);
                frmCadastrarProduto.ShowDialog();
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregar();
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
