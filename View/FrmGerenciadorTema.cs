using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmGerenciadorTema : Form
    {
        ControllerTema controllerTema = new ControllerTema();
        ModelTema modelTema = new ModelTema();
        public FrmGerenciadorTema()
        {
            InitializeComponent();
            cbxFiltro.SelectedIndex = 0;
            CarregarTemas();
        }
        void CarregarTemas()
        {
            dgvTemaAtivo.DataSource = controllerTema.CarregarTemaAtivo();
            if (cbxFiltro.Text == "CODIGO")
            {
                DgvTema.DataSource = controllerTema.CarregarTemasPorCodigo(txtPesquisar.Text);
            }
            if (cbxFiltro.Text == "NOME")
            {
                DgvTema.DataSource = controllerTema.CarregarTemasPorNome(txtPesquisar.Text);
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            modelTema.Consultar = false;
            FrmCadastrarTema frmCadastrarTema = new FrmCadastrarTema(null);
            frmCadastrarTema.ShowDialog();
            CarregarTemas();
        }
        private void btnDesativarTema_Click(object sender, EventArgs e)
        {
            if (dgvTemaAtivo.Rows.Count > 0)
            {
                modelTema.Codigo = Convert.ToInt32(dgvTemaAtivo.CurrentRow.Cells["Codigo"].Value.ToString());
                var result = MessageBox.Show("Ao desativar o tema atual, é necessário reiniciar o sistema\nDeseja desativar o tema agora?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes && controllerTema.DesativarTema(modelTema))
                {
                    CarregarTemas();
                    MessageBox.Show("Tema atual foi desativado, o sistema será reiniciado.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
        }
        private void btnAtivarTema_Click(object sender, EventArgs e)
        {
            if (dgvTemaAtivo.Rows.Count == 0 && DgvTema.Rows.Count > 0)
            {
                modelTema.Codigo = Convert.ToInt32(DgvTema.CurrentRow.Cells["Codigo"].Value.ToString());
                if (controllerTema.AtivarTema(modelTema))
                {
                    CarregarTemas();
                    MessageBox.Show("Tema atual definido com sucesso!\nReinicie o sistema para aplicar", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DgvTema.Rows.Count > 0)
            {
                modelTema.Codigo = Convert.ToInt32(DgvTema.CurrentRow.Cells["Codigo"].Value.ToString());
                modelTema.Nome = DgvTema.CurrentRow.Cells["Nome"].Value.ToString();
                modelTema.EnderecoImagem = DgvTema.CurrentRow.Cells["EnderecoImagem"].Value.ToString();
                modelTema.R = DgvTema.CurrentRow.Cells["R"].Value.ToString();
                modelTema.G = DgvTema.CurrentRow.Cells["G"].Value.ToString();
                modelTema.B = DgvTema.CurrentRow.Cells["B"].Value.ToString();
                modelTema.Consultar = false;
                FrmCadastrarTema frmCadastrarTema = new FrmCadastrarTema(modelTema);
                frmCadastrarTema.ShowDialog();
                CarregarTemas();
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (DgvTema.Rows.Count > 0)
            {
                modelTema.Codigo = Convert.ToInt32(DgvTema.CurrentRow.Cells["Codigo"].Value.ToString());
                modelTema.Nome = DgvTema.CurrentRow.Cells["Nome"].Value.ToString();
                var result = MessageBox.Show("O Codigo: " + modelTema.Codigo + " será excluído", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    string FileName = @"C:\Users\henri\source\repos\ProjetoPIM\View\Resources\" + modelTema.Nome + "FotoTema.jpg";
                    if (File.Exists(FileName))
                    {
                        File.Delete(FileName);
                    }
                    if (controllerTema.DeletarTema(modelTema))
                    {
                        MessageBox.Show("Tema excluído com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarTemas();
                    }
                }
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarTemas();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DgvTema_DoubleClick(object sender, EventArgs e)
        {
            if (DgvTema.Rows.Count > 0)
            {
                modelTema.Codigo = Convert.ToInt32(DgvTema.CurrentRow.Cells["Codigo"].Value.ToString());
                modelTema.Nome = DgvTema.CurrentRow.Cells["Nome"].Value.ToString();
                modelTema.EnderecoImagem = DgvTema.CurrentRow.Cells["EnderecoImagem"].Value.ToString();
                modelTema.R = DgvTema.CurrentRow.Cells["R"].Value.ToString();
                modelTema.G = DgvTema.CurrentRow.Cells["G"].Value.ToString();
                modelTema.B = DgvTema.CurrentRow.Cells["B"].Value.ToString();
                modelTema.Consultar = true;
                FrmCadastrarTema frmCadastrarTema = new FrmCadastrarTema(modelTema);
                frmCadastrarTema.ShowDialog();
            }
        }
        private void dgvTemaAtivo_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTemaAtivo.Rows.Count > 0)
            {
                modelTema.Codigo = Convert.ToInt32(dgvTemaAtivo.CurrentRow.Cells["Codigo"].Value.ToString());
                modelTema.Nome = dgvTemaAtivo.CurrentRow.Cells["Nome"].Value.ToString();
                modelTema.EnderecoImagem = dgvTemaAtivo.CurrentRow.Cells["EnderecoImagem"].Value.ToString();
                modelTema.R = dgvTemaAtivo.CurrentRow.Cells["R"].Value.ToString();
                modelTema.G = dgvTemaAtivo.CurrentRow.Cells["G"].Value.ToString();
                modelTema.B = dgvTemaAtivo.CurrentRow.Cells["B"].Value.ToString();
                modelTema.Consultar = true;
                FrmCadastrarTema frmCadastrarTema = new FrmCadastrarTema(modelTema);
                frmCadastrarTema.ShowDialog();
            }
        }
    }
}
