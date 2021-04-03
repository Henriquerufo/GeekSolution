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
                    modelCaixa.Codigo = Convert.ToInt32(sqlDataReader["Codigo"].ToString());
                    modelCaixa.CodigoBarras = sqlDataReader["CodigoBarras"].ToString();
                    modelCaixa.NomeProduto = sqlDataReader["NomeProduto"].ToString();
                    modelCaixa.Categoria = sqlDataReader["Categoria"].ToString();
                    modelCaixa.Fabricante = sqlDataReader["Fabricante"].ToString();
                    modelCaixa.ValorProduto = sqlDataReader["ValorProduto"].ToString();
                    modelCaixa.Plataforma = sqlDataReader["Plataforma"].ToString();
                    modelCaixa.Garantia = sqlDataReader["PrazoGarantia"].ToString();
                    return modelCaixa;
                }
                return null;
            }
            catch
            {
                controllerConfiguracaoSQL.Fechar();
                return null;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public int VerificarQuantidade(string codigo)
        {
            try
            {
                string instrucao = string.Format(@"SELECT Quantidade FROM tbProduto WHERE CodigoBarras = '" + codigo + "'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataReader sqlDataReader = command.ExecuteReader();
                sqlDataReader.Read();
                int total = Convert.ToInt32(sqlDataReader["Quantidade"].ToString());
                return total;
            }
            catch (Exception)
            {
                controllerConfiguracaoSQL.Fechar();
                return -1;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public int InserirPedido(ModelCaixa modelCaixa)
        {
            try
            {
                string instrucao = string.Format(@"INSERT INTO tbPedido (NomeCliente, Vendedor, dataVenda, valorVenda, opcaoPagamento, statusPagamento, statusVenda, Dinheiro, Cartao, Ticket, Conveniado, Cheque, ChequeDias) VALUES (@NomeCliente, @Vendedor, @dataVenda, @valorVenda, @opcaoPagamento, @statusPagamento, @statusVenda, @Dinheiro, @Cartao, @Ticket, @Conveniado, @Cheque, @ChequeDias); SELECT @@IDENTITY;");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@NomeCliente", modelCaixa.NomeCliente);
                command.Parameters.AddWithValue("@Vendedor", modelCaixa.Vendedor);
                command.Parameters.AddWithValue("@dataVenda", modelCaixa.DataVenda);
                command.Parameters.AddWithValue("@valorVenda", modelCaixa.ValorVenda);
                command.Parameters.AddWithValue("@opcaoPagamento", modelCaixa.OpcaoPagamento);
                command.Parameters.AddWithValue("@statusPagamento", modelCaixa.StatusPagamento);
                command.Parameters.AddWithValue("@statusVenda", modelCaixa.StatusVenda);
                command.Parameters.AddWithValue("@Dinheiro", modelCaixa.Dinheiro);
                command.Parameters.AddWithValue("@Ticket", modelCaixa.Ticket);
                command.Parameters.AddWithValue("@Cartao", modelCaixa.Cartao);
                command.Parameters.AddWithValue("@Conveniado", modelCaixa.Conveniado);
                command.Parameters.AddWithValue("@Cheque", modelCaixa.Cheque);
                command.Parameters.AddWithValue("@ChequeDias", modelCaixa.ChequeDias);
                return Convert.ToInt32(command.ExecuteScalar());
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
        public bool InserirPedidoItens(ModelCaixa modelCaixa)
        {
            try
            {
                string instrucao = string.Format(@"INSERT INTO tbPedidoItens (CodigoPedido, NomeCliente, RecebidoPor, DataRecebimento, CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, Garantia, statusPagamento, statusVenda) VALUES (@CodigoPedido, @NomeCliente, @RecebidoPor, @DataRecebimento, @CodigoBarras, @NomeProduto, @Categoria, @Fabricante, @ValorProduto, @Plataforma, @Garantia, @statusPagamento, @statusVenda)");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@CodigoPedido", modelCaixa.CodigoPedido);
                command.Parameters.AddWithValue("@NomeCliente", modelCaixa.NomeCliente);
                command.Parameters.AddWithValue("@RecebidoPor", modelCaixa.RecebidoPor);
                command.Parameters.AddWithValue("@DataRecebimento", modelCaixa.DataRecebimento);
                command.Parameters.AddWithValue("@CodigoBarras", modelCaixa.CodigoBarras);
                command.Parameters.AddWithValue("@NomeProduto", modelCaixa.NomeProduto);
                command.Parameters.AddWithValue("@Categoria", modelCaixa.Categoria);
                command.Parameters.AddWithValue("@Fabricante", modelCaixa.Fabricante);
                command.Parameters.AddWithValue("@ValorProduto", modelCaixa.ValorProduto);
                command.Parameters.AddWithValue("@Plataforma", modelCaixa.Plataforma);
                command.Parameters.AddWithValue("@Garantia", modelCaixa.Garantia);
                command.Parameters.AddWithValue("@statusPagamento", modelCaixa.StatusPagamento);
                command.Parameters.AddWithValue("@statusVenda", modelCaixa.StatusVenda);
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
        public bool MenosQuantidadeEstoque(ModelCaixa modelCaixa)
        {
            try
            {
                string instrucao = string.Format(@"UPDATE tbProduto SET Quantidade = Quantidade - 1 WHERE CodigoBarras = @CodigoBarras");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@CodigoBarras", modelCaixa.CodigoBarras);
                return Convert.ToBoolean(command.ExecuteNonQuery());
            }
            catch
            {
                controllerConfiguracaoSQL.Fechar();
                return false;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public string VerificarTicket(ModelCaixa modelCaixa)
        {
            string instrucao = string.Format(@"SELECT * FROM tbTicket WHERE Codigo = @Codigo AND Status = 'Em Aberto'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelCaixa.Codigo);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Read();
                return sqlDataReader["Valor"].ToString();
            }
            return null;
        }
        public bool VerificarTicketZerado(ModelCaixa modelCaixa)
        {
            string instrucao = string.Format(@"SELECT * FROM tbTicket WHERE Codigo = @Codigo AND Valor = 'R$ 0,00'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelCaixa.CodigoTicket);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                return true;
            }
            return false;
        }
        public bool TicketAlterarStatus(ModelCaixa modelCaixa)
        {
            string instrucao = string.Format(@"UPDATE tbTicket SET Status = 'Finalizado' WHERE Codigo = @Codigo");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelCaixa.CodigoTicket);
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool TicketRestante(ModelCaixa modelCaixa)
        {
            try
            {
                string instrucao = string.Format(@"UPDATE tbTicket SET Valor = @Valor WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelCaixa.CodigoTicket);
                command.Parameters.AddWithValue("@Valor", modelCaixa.TicketRestante);
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