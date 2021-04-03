using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerFechamento
    {
        
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarFechamentosRegistradosPorCodigo(string codigo, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbFechamento WHERE Codigo = " + codigo + " AND Data BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public DataTable CarregarFechamentosRegistradosPorVendedor(string vendedor, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbFechamento WHERE Vendedor = " + vendedor + " AND Data BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public bool VerificarFechamento(ModelFechamento modelFechamento)
        {
            string instrucao = string.Format(@"SELECT * FROM tbFechamento WHERE Vendedor = @Vendedor AND Data = @Data");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Vendedor", modelFechamento.Vendedor);
            command.Parameters.AddWithValue("@Data", modelFechamento.Data);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                return true;
            }
            return false;
        }
        public decimal CarregarValorTotalVendido(ModelFechamento modelFechamento)
        {
            try
            {
                string instrucao = string.Format(@"SELECT valorVenda FROM tbPedido WHERE Vendedor = @Vendedor AND dataVenda = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelFechamento.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelFechamento.Data);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                decimal valorTotal = 0;
                while (sqlDataReader.Read())
                {
                    valorTotal += Convert.ToDecimal(sqlDataReader["valorVenda"].ToString().Replace("R$ ", ""));
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
        public decimal CarregarValorTotalRecebido(ModelFechamento modelFechamento)
        {
            try
            {
                string instrucao = string.Format(@"SELECT ValorProduto FROM tbPedidoItens WHERE RecebidoPor = @Vendedor AND DataRecebimento = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelFechamento.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelFechamento.Data);
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
        public decimal CarregarValorSaida(ModelFechamento modelFechamento)
        {
            try
            {
                string instrucao = string.Format(@"SELECT Valor FROM tbSaida WHERE Vendedor = @Vendedor AND DataSaida = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelFechamento.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelFechamento.Data);
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
        public int CarregarItensVendidos(ModelFechamento modelFechamento)
        {
            try
            {
                string instrucao = string.Format(@"Select COUNT (valorVenda) from tbPedido WHERE Vendedor = @Vendedor AND dataVenda = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelFechamento.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelFechamento.Data);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                sqlDataReader.Read();
                int total = (int)sqlDataReader[""];
                return total;
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
        public int CarregarItensRecebidos(ModelFechamento modelFechamento)
        {
            try
            {
                string instrucao = string.Format(@"Select COUNT (RecebidoPor) from tbPedidoItens WHERE RecebidoPor = @Vendedor AND DataRecebimento = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelFechamento.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelFechamento.Data);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                sqlDataReader.Read();
                int total = (int)sqlDataReader[""];
                return total;
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
        public decimal CarregarDinheiro(ModelFechamento modelFechamento)
        {
            try
            {
                string instrucao = string.Format(@"SELECT Dinheiro FROM tbPedido WHERE Vendedor = @Vendedor AND dataVenda = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelFechamento.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelFechamento.Data);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                decimal valorTotal = 0;
                while (sqlDataReader.Read())
                {
                    valorTotal += Convert.ToDecimal(sqlDataReader["Dinheiro"].ToString().Replace("R$ ", ""));
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
        public decimal CarregarCartao(ModelFechamento modelFechamento)
        {
            try
            {
                string instrucao = string.Format(@"SELECT Cartao FROM tbPedido WHERE Vendedor = @Vendedor AND dataVenda = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelFechamento.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelFechamento.Data);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                decimal valorTotal = 0;
                while (sqlDataReader.Read())
                {
                    valorTotal += Convert.ToDecimal(sqlDataReader["Cartao"].ToString().Replace("R$ ", ""));
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
        public decimal CarregarTicket(ModelFechamento modelFechamento)
        {
            try
            {
                string instrucao = string.Format(@"SELECT Ticket FROM tbPedido WHERE Vendedor = @Vendedor AND dataVenda = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelFechamento.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelFechamento.Data);
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
        public decimal CarregarCheque(ModelFechamento modelFechamento)
        {
            try
            {
                string instrucao = string.Format(@"SELECT Cheque FROM tbPedido WHERE Vendedor = @Vendedor AND dataVenda = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelFechamento.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelFechamento.Data);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                decimal valorTotal = 0;
                while (sqlDataReader.Read())
                {
                    valorTotal += Convert.ToDecimal(sqlDataReader["Cheque"].ToString().Replace("R$ ", ""));
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
        public decimal CarregarConvenio(ModelFechamento modelFechamento)
        {

            try
            {
                string instrucao = string.Format(@"SELECT Conveniado FROM tbPedido WHERE Vendedor = @Vendedor AND dataVenda = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelFechamento.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelFechamento.Data);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                decimal valorTotal = 0;
                while (sqlDataReader.Read())
                {
                    valorTotal += Convert.ToDecimal(sqlDataReader["Conveniado"].ToString().Replace("R$ ", ""));
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
        public bool InserirFechamento(ModelFechamento modelFechamento)
        {
            try
            {
                string instrucao = string.Format(@"INSERT INTO tbFechamento (Vendedor, Data, ValorTotalVendido, ValorTotalRecebido, PedidosFinalizados, ItensRecebidos, Dinheiro, Cartao, Conveniado, Ticket, ValorSaida, Cheque, ValorCaixa) VALUES (@Vendedor, @Data, @ValorTotalVendido, @ValorTotalRecebido, @PedidosFinalizados, @ItensRecebidos, @Dinheiro, @Cartao, @Conveniado, @Ticket, @ValorSaida, @Cheque, @ValorCaixa)");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Vendedor", modelFechamento.Vendedor);
                command.Parameters.AddWithValue("@Data", modelFechamento.Data);
                command.Parameters.AddWithValue("@ValorTotalVendido", modelFechamento.ValorTotalVendido);
                command.Parameters.AddWithValue("@ValorTotalRecebido", modelFechamento.ValorTotalRecebido);
                command.Parameters.AddWithValue("@PedidosFinalizados", modelFechamento.PedidosFinalizados);
                command.Parameters.AddWithValue("@ItensRecebidos", modelFechamento.ItensRecebidos);
                command.Parameters.AddWithValue("@Dinheiro", modelFechamento.Dinheiro);
                command.Parameters.AddWithValue("@Cartao", modelFechamento.Cartao);
                command.Parameters.AddWithValue("@Conveniado", modelFechamento.Conveniado);
                command.Parameters.AddWithValue("@Ticket", modelFechamento.Ticket);
                command.Parameters.AddWithValue("@ValorSaida", modelFechamento.ValorSaida);
                command.Parameters.AddWithValue("@Cheque", modelFechamento.Cheque);
                command.Parameters.AddWithValue("@ValorCaixa", modelFechamento.ValorCaixa);
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
