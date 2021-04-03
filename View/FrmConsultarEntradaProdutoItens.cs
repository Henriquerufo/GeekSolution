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
    public partial class FrmConsultarEntradaProdutoItens : Form
    {
        ControllerEntradaProduto controllerEntradaProduto = new ControllerEntradaProduto();
        public FrmConsultarEntradaProdutoItens(ModelEntradaProduto modelEntradaProduto)
        {
            InitializeComponent();
            txtCodigo.Text = modelEntradaProduto.CodigoEntradaProduto.ToString();
            txtNomeEmpresa.Text = modelEntradaProduto.NomeEmpresa;
            txtDataRecebido.Text = modelEntradaProduto.DataRecebido;
            dgvEntradaProdutoItens.DataSource = controllerEntradaProduto.CarregarPedidoItens(modelEntradaProduto);
            lblExibidosTotal.Text = "Exibidos total: " + dgvEntradaProdutoItens.Rows.Count;
        }
    }
}
