using Controller;
using Model;
using System;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace View
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ControllerConfiguracaoSQLCentral controllerConfiguracaoSQLCentral = new ControllerConfiguracaoSQLCentral();
            ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
            ModelConfiguracaoSQLCentral modelConfiguracaoSQLCentral = new ModelConfiguracaoSQLCentral();
            ModelConfiguracaoSQL modelConfiguracaoSQL = new ModelConfiguracaoSQL();
            modelConfiguracaoSQLCentral = controllerConfiguracaoSQLCentral.Carregar();
            string instrucao = string.Format(@"SELECT * FROM tbCadastro WHERE idTecSistemas = '" + modelConfiguracaoSQLCentral.IDTecSistemas + "' AND senhaTecSistemas = '" + modelConfiguracaoSQLCentral.SenhaTecSistemas + "' AND status = '1' AND dataVencimento > CURRENT_TIMESTAMP");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQLCentral.Conectar());
            SqlDataReader sqlDataReader;
            sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                string conexaoBanco = string.Format(@"SELECT servidorBD, nomeBD, idBD, senhaBD FROM tbCadastro WHERE idTecSistemas = '" + modelConfiguracaoSQLCentral.IDTecSistemas + "'");
                SqlCommand command1 = new SqlCommand(conexaoBanco, controllerConfiguracaoSQLCentral.Conectar());
                SqlDataReader sqlDataReader1 = command1.ExecuteReader();
                sqlDataReader1.Read();

                modelConfiguracaoSQL.ServidorBD = sqlDataReader1["servidorBD"].ToString();
                modelConfiguracaoSQL.NomeBD = sqlDataReader1["nomeBD"].ToString();
                modelConfiguracaoSQL.IDBD = sqlDataReader1["idBD"].ToString();
                modelConfiguracaoSQL.SenhaBD = sqlDataReader1["senhaBD"].ToString();
                controllerConfiguracaoSQL.SalvarConexao(modelConfiguracaoSQL);

                ModelLogin modelLogin = new ModelLogin();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmPrincipal(modelLogin));
            }
            else
            {
                MessageBox.Show("O sistema está desativado ou vencido, entre em contato com o desenvolvedor.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmConfiguracaoSQL frmConfiguracaoSQL = new FrmConfiguracaoSQL();
                frmConfiguracaoSQL.ShowDialog();
            }
        }
    }
}
