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
        string NomeCliente;
        ControllerCadastro controllerCadastro = new ControllerCadastro();
        ModelCadastro modelCadastro = new ModelCadastro();
        public String Retorno
        {
            get { return NomeCliente; }
        }
        public FrmCadastrados(ModelCaixa modelCaixa)
        {
            InitializeComponent();
            if (modelCaixa != null)
            {
                btnCadastrar.Visible = false;
                btnSalvar.Visible = false;
                btnDeletar.Visible = false;
                btnConsultar.Location = new Point(576, 441);
                Text = "Selecionar Cliente";
            }
            cbxFiltro.SelectedIndex = 0;
        }
        void Carregar()
        {
            try
            {
                if (cbxFiltro.Text == "CODIGO" && !string.IsNullOrWhiteSpace(txtProcurar.Text))
                {
                    dgvCadastrados.DataSource = controllerCadastro.CarregarPorCodigo(txtProcurar.Text);
                }
                else if (cbxFiltro.Text == "NOME" && !string.IsNullOrWhiteSpace(txtProcurar.Text))
                {
                    dgvCadastrados.DataSource = controllerCadastro.CarregarPorNome(txtProcurar.Text);
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvCadastrados.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvCadastrados.Rows.Count > 0)
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
            if (dgvCadastrados.Rows.Count > 0)
            {
                try
                {
                    string nome = dgvCadastrados.CurrentRow.Cells["nome"].Value.ToString();
                    var Result = MessageBox.Show("O cliente: " + nome + " será excluido", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (Result == DialogResult.OK)
                    {
                        modelCadastro.Codigo = dgvCadastrados.CurrentRow.Cells["codigo"].Value.ToString();
                        controllerCadastro.Deletar(modelCadastro);
                        Carregar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvCadastrados.Rows.Count > 0)
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
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregar();
        }
        private void dgvCadastrados_DoubleClick(object sender, EventArgs e)
        {
            if (Text == "Selecionar Cliente")
            {
                NomeCliente = dgvCadastrados.CurrentRow.Cells["Nome"].Value.ToString();
                this.Close();
            }
            else if (Text == "Tec Sistemas: Consultar Lista de Clientes")
            {
                if (dgvCadastrados.Rows.Count > 0)
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
        }
    }
}
