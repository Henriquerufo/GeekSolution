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
                panel1.Visible = false;
                btnConsultar.Location = new Point(12, 352);
            }
            cbxFiltro.SelectedIndex = 0;
        }
        void CarregarPorCodigo(string Codigo)
        {
            dgvProduto.DataSource = controllerCadastroProduto.CarregarPorCodigo(Codigo);
        }
        void CarregarPorNome(string Nome)
        {
            dgvProduto.DataSource = controllerCadastroProduto.CarregarPorNome(Nome);
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
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            modelCadastroProduto.NomeProduto = dgvProduto.CurrentRow.Cells["nomeProduto"].Value.ToString();
            var result = MessageBox.Show(modelCadastroProduto.NomeProduto + " será excluido", "DELETAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                modelCadastroProduto.Codigo = dgvProduto.CurrentRow.Cells["codigo"].Value.ToString();

                controllerCadastroProduto.Deletar(modelCadastroProduto);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
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

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.Text == "CODIGO")
            {
                CarregarPorCodigo(txtProcurar.Text);
            }
            else if (cbxFiltro.Text == "NOME")
            {
                CarregarPorNome(txtProcurar.Text);
            }
            
            lblExibidosTotal.Text = "Exibidos total: " + dgvProduto.Rows.Count;
            if (dgvProduto.Rows.Count > 0)
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
