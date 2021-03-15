using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerCaixa
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        ModelCaixa modelCaixa = new ModelCaixa();
        public ModelCaixa VerificarProduto(string codigo)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbProduto WHERE CodigoBarras = '" + codigo + "'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    modelCaixa.Codigo = sqlDataReader["Codigo"].ToString();
                    modelCaixa.CodigoBarras = sqlDataReader["CodigoBarras"].ToString();
                    modelCaixa.NomeProduto = sqlDataReader["NomeProduto"].ToString();
                    modelCaixa.Categoria = sqlDataReader["Categoria"].ToString();
                    modelCaixa.Fabricante = sqlDataReader["Fabricante"].ToString();
                    modelCaixa.ValorProduto = sqlDataReader["ValorProduto"].ToString();
                    return modelCaixa;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public int VerificarQuantidade(string codigo)
        {
            string instrucao = string.Format(@"SELECT Quantidade FROM tbProduto WHERE CodigoBarras = '" + codigo + "'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            sqlDataReader.Read();
            int total = Convert.ToInt32(sqlDataReader["Quantidade"].ToString());
            return total;
        }
    }
}
