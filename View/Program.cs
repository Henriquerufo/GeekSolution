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
            ModelConfiguracaoSQLCentral modelConfiguracaoSQLCentral = controllerConfiguracaoSQLCentral.Carregar();
            string instrucao = string.Format(@"SELECT * FROM tbCadastro WHERE idTecSistemas = '" + modelConfiguracaoSQLCentral.IDTecSistemas + "' AND senhaTecSistemas = '" + modelConfiguracaoSQLCentral.SenhaTecSistemas + "' AND status = '1' AND dataVencimento > CURRENT_TIMESTAMP");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQLCentral.Conectar());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                ModelLogin modelLogin = new ModelLogin();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmLogin(modelLogin));
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
