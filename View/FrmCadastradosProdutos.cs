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
        public FrmCadastradosProdutos()
        {
            InitializeComponent();
            Carregar();
        }
        void Carregar()
        {
            dgvProduto.DataSource = controllerCadastroProduto.Carregar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            modelCadastroProduto.Codigo = null;
            FrmCadastrarProduto frmCadastrarProduto = new FrmCadastrarProduto(modelCadastroProduto);
            frmCadastrarProduto.ShowDialog();
            Carregar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
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

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            modelCadastroProduto.NomeProduto = dgvProduto.CurrentRow.Cells["nomeProduto"].Value.ToString();
            var result = MessageBox.Show(modelCadastroProduto.NomeProduto + " será excluido", "DELETAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                modelCadastroProduto.Codigo = dgvProduto.CurrentRow.Cells["codigo"].Value.ToString();

                controllerCadastroProduto.Deletar(modelCadastroProduto);
                Carregar();
            }
        }
    }
}
