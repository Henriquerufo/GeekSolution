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
    public partial class FrmCadastrados : Form
    {
        ControllerCadastro controllerCadastro = new ControllerCadastro();
        ModelCadastro modelCadastro = new ModelCadastro();
        public FrmCadastrados()
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
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
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string nome = dgvCadastrados.CurrentRow.Cells["nome"].Value.ToString();
            var Result = MessageBox.Show(nome + " será excluido", "DELETAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (Result == DialogResult.OK)
            {
                modelCadastro.Codigo = dgvCadastrados.CurrentRow.Cells["codigo"].Value.ToString();
                controllerCadastro.Deletar(modelCadastro);
            }        
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            modelCadastro.consulta = false;
            modelCadastro.Codigo = null;
            FrmCadastro frmCadastro = new FrmCadastro(modelCadastro);
            frmCadastro.ShowDialog();
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

        private void btnConsultar_Click(object sender, EventArgs e)
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
