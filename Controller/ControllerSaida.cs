using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerSaida
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarPorCodigo(string codigo, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbSaida WHERE Codigo = '" + codigo + "' AND DataSaida BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public DataTable CarregarPorNomeVendedor(string vendedor, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbSaida WHERE Vendedor LIKE '%" + vendedor + "%' AND DataSaida BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public decimal CarregarValorTotalRecebido(ModelSaida modelSaida)
        {
            try
            {
                string instrucao = string.Format(@"SELECT ValorProduto FROM tbPedidoItens WHERE RecebidoPor = @Vendedor AND DataRecebimento = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelSaida.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelSaida.DataSaida);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                decimal valorTotal = 0;
                while (sqlDataReader.Read())
                {
                    valorTotal += Convert.ToDecimal(sqlDataReader["ValorProduto"].ToString().Replace("R$ ", ""));
                }
                return valorTotal;
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public decimal CarregarTicket(ModelSaida modelSaida)
        {
            try
            {
                string instrucao = string.Format(@"SELECT Ticket FROM tbPedido WHERE Vendedor = @Vendedor AND dataVenda = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelSaida.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelSaida.DataSaida);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                decimal valorTotal = 0;
                while (sqlDataReader.Read())
                {
                    valorTotal += Convert.ToDecimal(sqlDataReader["Ticket"].ToString().Replace("R$ ", ""));
                }
                return valorTotal;
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public decimal CarregarValorSaida(ModelSaida modelSaida)
        {
            try
            {
                string instrucao = string.Format(@"SELECT Valor FROM tbSaida WHERE Vendedor = @Vendedor AND DataSaida = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelSaida.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelSaida.DataSaida);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                decimal valorTotal = 0;
                while (sqlDataReader.Read())
                {
                    valorTotal += Convert.ToDecimal(sqlDataReader["Valor"].ToString().Replace("R$ ", ""));
                }
                return valorTotal;
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool InserirSaida(ModelSaida modelSaida)
        {
            try
            {
                string instrucao = string.Format(@"INSERT INTO tbSaida (Vendedor, DataSaida, Valor) VALUES (@Vendedor, @DataSaida, @Valor)");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelSaida.Vendedor);
                command.Parameters.AddWithValue("@DataSaida", modelSaida.DataSaida);
                command.Parameters.AddWithValue("@Valor", modelSaida.Valor);
                return Convert.ToBoolean(command.ExecuteNonQuery());
            }
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
    }
}
