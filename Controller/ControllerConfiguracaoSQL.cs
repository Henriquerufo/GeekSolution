using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerConfiguracaoSQL
    {
        ModelConfiguracaoSQL modelConfiguracaoSQL = new ModelConfiguracaoSQL();
        string parametrosSQL = string.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};",
            Properties.SettingsSQL.Default.ServidorBD,
            Properties.SettingsSQL.Default.NomeBD,
            Properties.SettingsSQL.Default.IDBD,
            Properties.SettingsSQL.Default.SenhaBD);
        SqlConnection conexao = null;
        public bool VerificarInternet()
        {
            try
            {
                using (var client = new WebClient())
                {
                    WebProxy wp = new WebProxy();
                    client.Proxy = wp;
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public SqlConnection Conectar()
        {
            if (true/*VerificarInternet()*/)
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
            else
            {
                return null;
            }
        }
        public SqlConnection Fechar()
        {
            conexao.Close();
            conexao.Dispose();
            return conexao;
        }
        public bool SalvarConexao(ModelConfiguracaoSQL modelConfiguracaoSQL)
        {
            try
            {
                Properties.SettingsSQL.Default.ServidorBD = modelConfiguracaoSQL.ServidorBD;
                Properties.SettingsSQL.Default.NomeBD = modelConfiguracaoSQL.NomeBD;
                Properties.SettingsSQL.Default.IDBD = modelConfiguracaoSQL.IDBD;
                Properties.SettingsSQL.Default.SenhaBD = modelConfiguracaoSQL.SenhaBD;
                Properties.SettingsSQL.Default.Save();

                return true;
            }
            catch
            {

                throw new Exception();
            }
        }
        public ModelConfiguracaoSQL Carregar()
        { 
            modelConfiguracaoSQL.ServidorBD = Properties.SettingsSQL.Default.ServidorBD;
            modelConfiguracaoSQL.NomeBD = Properties.SettingsSQL.Default.NomeBD;
            modelConfiguracaoSQL.IDBD = Properties.SettingsSQL.Default.IDBD;
            modelConfiguracaoSQL.SenhaBD = Properties.SettingsSQL.Default.SenhaBD;

            return modelConfiguracaoSQL;
        }
    }
}
