using Model;
using Controller;
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
    public partial class FrmConfiguracaoSQL : Form
    {
        ModelConfiguracaoSQL modelConfiguracaoSQL = new ModelConfiguracaoSQL();
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public FrmConfiguracaoSQL()
        {
            
            InitializeComponent();
            Carregar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Editar")
            {
                btnSalvar.Text = "Salvar";
                txtServidorBD.Enabled = true;
                txtNomeBD.Enabled = true;
                txtIDBD.Enabled = true;
                txtSenhaBD.Enabled = true;
            }
            else
            {
                modelConfiguracaoSQL.ServidorBD = txtServidorBD.Text.Trim();
                modelConfiguracaoSQL.NomeBD = txtNomeBD.Text.Trim();
                modelConfiguracaoSQL.IDBD = txtIDBD.Text.Trim();
                modelConfiguracaoSQL.SenhaBD = txtSenhaBD.Text.Trim();

                bool returno = Convert.ToBoolean(controllerConfiguracaoSQL.Conectar(modelConfiguracaoSQL));
                if (returno)
                {
                    MessageBox.Show("Configurações salvas com sucesso!");
                }
            }
        }
        void Carregar()
        {
            modelConfiguracaoSQL = controllerConfiguracaoSQL.Carregar();
            txtServidorBD.Text = modelConfiguracaoSQL.ServidorBD;
            txtNomeBD.Text = modelConfiguracaoSQL.NomeBD;
            txtIDBD.Text = modelConfiguracaoSQL.IDBD;
            txtSenhaBD.Text = modelConfiguracaoSQL.SenhaBD;
        }
    }
}
