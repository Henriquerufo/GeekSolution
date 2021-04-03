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
    public partial class FrmGerenciarEmpresa : Form
    {
        ControllerEmpresa controllerEmpresa = new ControllerEmpresa();
        ModelEmpresa modelEmpresa = new ModelEmpresa();
        string empresaSelecionada;
        bool pesquisarEmpresa = false;
        public FrmGerenciarEmpresa(bool PesquisarEmpresa)
        {
            pesquisarEmpresa = PesquisarEmpresa;
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
            if (PesquisarEmpresa)
            {
                btnCadastrar.Visible = false;
                btnSalvar.Visible = false;
                btnDeletar.Visible = false;
                btnConsultar.Location = new Point(577,443);
            }
        }
        public String RetornoNomeEmpresa
        {
            get
            {
                return empresaSelecionada;
            }
        }
        void Carregar()
        {
            try
            {
                if (cbxFiltro.Text == "CODIGO")
                {
                    dgvEmpresa.DataSource = controllerEmpresa.CarregarEmpresaPorCodigo(txtProcurar.Text);
                }
                else if (cbxFiltro.Text == "NOME")
                {
                    dgvEmpresa.DataSource = controllerEmpresa.CarregarEmpresaPorNome(txtProcurar.Text);
                }
                lblExibidosTotal.Text = "Exibidos total: " + dgvEmpresa.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvEmpresa.Rows.Count > 0)
            {
                try
                {
                    modelEmpresa.Codigo = Convert.ToInt32(dgvEmpresa.CurrentRow.Cells["Codigo"].Value.ToString());
                    modelEmpresa.NomeEmpresa = dgvEmpresa.CurrentRow.Cells["NomeEmpresa"].Value.ToString();
                    var result = MessageBox.Show("O produto: " + modelEmpresa.NomeEmpresa + " será excluido", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        controllerEmpresa.Deletar(modelEmpresa);
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
            modelEmpresa.Consultar = false;
            modelEmpresa.Editar = false;
            modelEmpresa.Cadasrar = true;
            FrmCadastrarEmpresa frmCadastrarEmpresa = new FrmCadastrarEmpresa(modelEmpresa);
            frmCadastrarEmpresa.ShowDialog();
            Carregar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvEmpresa.Rows.Count > 0)
            {
                try
                {
                    modelEmpresa.Consultar = false;
                    modelEmpresa.Editar = true;
                    modelEmpresa.Cadasrar = false;
                    modelEmpresa.Codigo = Convert.ToInt32(dgvEmpresa.CurrentRow.Cells["Codigo"].Value.ToString());
                    modelEmpresa.NomeEmpresa = dgvEmpresa.CurrentRow.Cells["NomeEmpresa"].Value.ToString();
                    modelEmpresa.CNPJ = dgvEmpresa.CurrentRow.Cells["CNPJ"].Value.ToString();
                    modelEmpresa.DataCadastro = dgvEmpresa.CurrentRow.Cells["DataCadastro"].Value.ToString();
                    modelEmpresa.Telefone = dgvEmpresa.CurrentRow.Cells["Telefone"].Value.ToString();
                    modelEmpresa.Email = dgvEmpresa.CurrentRow.Cells["Email"].Value.ToString();
                    modelEmpresa.Endereco = dgvEmpresa.CurrentRow.Cells["Endereco"].Value.ToString();
                    modelEmpresa.Numero = dgvEmpresa.CurrentRow.Cells["Numero"].Value.ToString();
                    modelEmpresa.Complemento = dgvEmpresa.CurrentRow.Cells["Complemento"].Value.ToString();
                    modelEmpresa.Bairro = dgvEmpresa.CurrentRow.Cells["Bairro"].Value.ToString();
                    modelEmpresa.CEP = dgvEmpresa.CurrentRow.Cells["CEP"].Value.ToString();
                    FrmCadastrarEmpresa frmCadastrarEmpresa = new FrmCadastrarEmpresa(modelEmpresa);
                    frmCadastrarEmpresa.ShowDialog();
                    Carregar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvEmpresa_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmpresa.Rows.Count > 0 && pesquisarEmpresa)
            {
                empresaSelecionada = dgvEmpresa.CurrentRow.Cells["NomeEmpresa"].Value.ToString();
                this.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            modelEmpresa.Consultar = true;
            modelEmpresa.Editar = false;
            modelEmpresa.Cadasrar = false;
            FrmCadastrarEmpresa frmCadastrarEmpresa = new FrmCadastrarEmpresa(modelEmpresa);
            frmCadastrarEmpresa.ShowDialog();
        }
    }
}
