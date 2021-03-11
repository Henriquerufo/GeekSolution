using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerConfiguracaoSQLCentral
    {
        string parametrosSQL = string.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};",
            Properties.SettingsSQLCentral.Default.ServidorBD,
            Properties.SettingsSQLCentral.Default.NomeBD,
            Properties.SettingsSQLCentral.Default.IDBD,
            Properties.SettingsSQLCentral.Default.SenhaBD);

        SqlConnection conexao = null;

        public SqlConnection Conectar()
        {
            try
            {
                conexao = new SqlConnection(parametrosSQL);
                conexao.Open();
                return conexao;
            }
            catch
            {
                throw new Exception();
            }
        }
        public bool Conectar(ModelConfiguracaoSQLCentral modelConfiguracaoSQLCentral)
        {
            try
            {
                Properties.SettingsSQLCentral.Default.ServidorBD = modelConfiguracaoSQLCentral.ServidorBD;
                Properties.SettingsSQLCentral.Default.NomeBD = modelConfiguracaoSQLCentral.NomeBD;
                Properties.SettingsSQLCentral.Default.IDBD = modelConfiguracaoSQLCentral.IDBD;
                Properties.SettingsSQLCentral.Default.SenhaBD = modelConfiguracaoSQLCentral.SenhaBD;
                Properties.SettingsSQLCentral.Default.IDTecSistemas = modelConfiguracaoSQLCentral.IDTecSistemas;
                Properties.SettingsSQLCentral.Default.SenhaTecSistemas = modelConfiguracaoSQLCentral.SenhaTecSistemas;
                Properties.SettingsSQLCentral.Default.Save();

                return true;
            }
            catch
            {

                throw new Exception();
            }
        }
        public ModelConfiguracaoSQLCentral Carregar()
        {
            ModelConfiguracaoSQLCentral modelConfiguracaoSQLCentral = new ModelConfiguracaoSQLCentral();
            modelConfiguracaoSQLCentral.ServidorBD = Properties.SettingsSQLCentral.Default.ServidorBD;
            modelConfiguracaoSQLCentral.NomeBD = Properties.SettingsSQLCentral.Default.NomeBD;
            modelConfiguracaoSQLCentral.IDBD = Properties.SettingsSQLCentral.Default.IDBD;
            modelConfiguracaoSQLCentral.SenhaBD = Properties.SettingsSQLCentral.Default.SenhaBD;
            modelConfiguracaoSQLCentral.IDTecSistemas = Properties.SettingsSQLCentral.Default.IDTecSistemas;
            modelConfiguracaoSQLCentral.SenhaTecSistemas = Properties.SettingsSQLCentral.Default.SenhaTecSistemas;

            return modelConfiguracaoSQLCentral;
        }
    }
}
