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
        ModelConfiguracaoSQLCentral modelConfiguracaoSQLCentral = new ModelConfiguracaoSQLCentral();
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        ControllerConfiguracaoSQLCentral controllerConfiguracaoSQLCentral = new ControllerConfiguracaoSQLCentral();
        
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
                gbConexaoSQLCentral.Enabled = true;
            }
            else
            {
                modelConfiguracaoSQL.ServidorBD = txtServidorBD.Text.Trim();
                modelConfiguracaoSQL.NomeBD = txtNomeBD.Text.Trim();
                modelConfiguracaoSQL.IDBD = txtIDBD.Text.Trim();
                modelConfiguracaoSQL.SenhaBD = txtSenhaBD.Text.Trim();

                modelConfiguracaoSQLCentral.ServidorBD = txtServidorBDCentral.Text.Trim();
                modelConfiguracaoSQLCentral.NomeBD = txtNomeBDCentral.Text.Trim();
                modelConfiguracaoSQLCentral.IDBD = txtIDBDCentral.Text.Trim();
                modelConfiguracaoSQLCentral.SenhaBD = txtSenhaBDCentral.Text.Trim();
                modelConfiguracaoSQLCentral.IDTecSistemas = txtIDTecSistemas.Text.Trim();
                modelConfiguracaoSQLCentral.SenhaTecSistemas = txtSenhaTecSistemas.Text.Trim();

                bool returno = Convert.ToBoolean(controllerConfiguracaoSQL.SalvarConexao(modelConfiguracaoSQL) && controllerConfiguracaoSQLCentral.Conectar(modelConfiguracaoSQLCentral));
                if (returno)
                {
                    MessageBox.Show("Configurações salvas com sucesso!");
                    Application.Exit();
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

            modelConfiguracaoSQLCentral = controllerConfiguracaoSQLCentral.Carregar();
            txtServidorBDCentral.Text = modelConfiguracaoSQLCentral.ServidorBD;
            txtNomeBDCentral.Text = modelConfiguracaoSQLCentral.NomeBD;
            txtIDBDCentral.Text = modelConfiguracaoSQLCentral.IDBD;
            txtSenhaBDCentral.Text = modelConfiguracaoSQLCentral.SenhaBD;
            txtIDTecSistemas.Text = modelConfiguracaoSQLCentral.IDTecSistemas;
            txtSenhaTecSistemas.Text = modelConfiguracaoSQLCentral.SenhaTecSistemas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
