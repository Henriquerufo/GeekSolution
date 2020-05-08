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
    public partial class FrmVendas : Form
    {
        decimal totalValor = 0;
        int totalitens = 0;

        ControllerVendas controllerVendas = new ControllerVendas();
        ModelVendas modelVendas = new ModelVendas();
        public FrmVendas()
        {
            InitializeComponent();
        }
        void Carregar()
        {
            dgvProduto.DataSource = controllerVendas.Carregar();
        }
        void Inserir()
        {
            for (int i = 0; i < NudQuantidade.Value; i++)
            {
                controllerVendas.Inserir(txtCodigoBarras.Text);
            }
        }
        void Total()
        {
            decimal total = 0;

            decimal ValorUnitario = 0;
            foreach (DataGridViewRow row in dgvProduto.Rows)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["valorProduto"].Value)))
                {
                    total += Convert.ToDecimal(row.Cells["valorProduto"].Value);
                    ValorUnitario = Convert.ToDecimal(row.Cells["valorProduto"].Value);
                }

                dgvProduto.CurrentCell = dgvProduto.Rows[dgvProduto.Rows.Count - 1].Cells["valorProduto"];
                totalValor = total;
                txtTotal.Text = Convert.ToDouble(totalValor).ToString("C");
                TxtValorUnitario.Text = Convert.ToDouble(ValorUnitario).ToString("C");
            }
            totalitens = dgvProduto.Rows.Count;

            //lblTotalItens.Text = "Total Itens: " + totalitens.ToString();
            string ultimoVenda = dgvProduto.CurrentRow.Cells["nomeProduto"].Value.ToString();
            txtNome.Text = ultimoVenda;
        }
    private void txtProcurar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dgvProduto_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProduto.RowCount == 0)
            {
                txtCodigoBarras.Focus();
            }
            else
            {
                txtCodigoBarras.Text = dgvProduto.CurrentRow.Cells["nomeProduto"].Value.ToString();
                TxtValorUnitario.Text = dgvProduto.CurrentRow.Cells["valorProduto"].Value.ToString();
            }
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProduto.RowCount == 0)
            {
                txtCodigoBarras.Focus();
            }
            else
            {
                modelVendas.Codigo = dgvProduto.CurrentRow.Cells["codigo"].Value.ToString();
                modelVendas.NomeProduto = dgvProduto.CurrentRow.Cells["nomeProduto"].Value.ToString();
            }
            ModelLogin modelLogin = new ModelLogin();
            modelLogin.Nivel = "?";
            FrmLogin frmLogin = new FrmLogin(modelLogin);
            frmLogin.ShowDialog();
            if (frmLogin.Retorno == "Supervisor")
            {
                var Result = MessageBox.Show(modelVendas.NomeProduto + " será removido.", "Caixa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Result == DialogResult.OK)
                {
                    decimal removerValor = Convert.ToDecimal(dgvProduto.CurrentRow.Cells["valorProduto"].Value);
                    totalValor -= removerValor;
                    txtTotal.Text = totalValor.ToString("C");
                    controllerVendas.DeletarLinha(modelVendas);
                    Carregar();
                    totalitens = dgvProduto.Rows.Count;
                    //lblTotaExibidos.Text = "Total Itens: " + totalitens.ToString();
                }
            }

        }

        private void FrmVendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                var Result = MessageBox.Show("Deseja realmente fechar?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtCodigoBarras.ForeColor = Color.Black;
                if (!string.IsNullOrWhiteSpace(txtCodigoBarras.Text) && controllerVendas.Verificar(txtCodigoBarras.Text))
                {
                    Inserir();
                    Carregar();
                    Total();
                    txtCodigoBarras.Text = null;
                    txtCodigoBarras.Focus();
                    NudQuantidade.Value = 1;
                }
                else
                {
                    this.txtCodigoBarras.ForeColor = Color.Red;
                    MessageBox.Show("Codigo de barras invalido!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigoBarras.Text = null;
                    txtCodigoBarras.Focus();
                    this.txtCodigoBarras.ForeColor = Color.Black;
                }
            }
        }
    }
}
