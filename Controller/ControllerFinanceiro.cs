using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerFinanceiro
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarPorCodigoPagamentoRecebido(string codigo, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = "SELECT * FROM tbPedido WHERE Codigo = " + codigo + " AND statusPagamento = 'Recebido' AND dataVenda BETWEEN '" + dataDe + "' AND '" + dataAte + "'";
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable CarregarPorNomeClientePagamentoRecebido(string nomeCliente, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = "SELECT * FROM tbPedido WHERE NomeCliente LIKE '%" + nomeCliente + "%' AND statusPagamento = 'Recebido' AND dataVenda BETWEEN '" + dataDe + "' AND '" + dataAte + "'";
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable CarregarPorCodigoPagamentoEmAberto(string codigo, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = "SELECT * FROM tbPedido WHERE Codigo = " + codigo + " AND statusPagamento = 'Em Aberto' AND dataVenda BETWEEN '" + dataDe + "' and '" + dataAte + "'";
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable CarregarPorNomeClientePagamentoEmAberto(string nomeCliente, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = "SELECT * FROM tbPedido WHERE NomeCliente LIKE '%" + nomeCliente + "%' AND statusPagamento = 'Em Aberto' AND dataVenda BETWEEN '" + dataDe + "' AND '" + dataAte + "'";
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public bool Cadastrar(ModelFinanceiro modelFinanceiro)
        {
            try
            {
                string instrucao = string.Format("INSERT INTO tbPedido (nomeCliente, dataVenda, valorVenda, opcaoPagamento, statusPagamento, statusVenda) VALUES (@nomeCliente, @dataVenda, @valorVenda, @opcaoPagamento, @statusPagamento, @statusVenda); SELECT SCOPE_IDENTITY();");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@nomeCliente", modelFinanceiro.nomeCliente);
                command.Parameters.AddWithValue("@dataVenda", modelFinanceiro.dataVenda);
                command.Parameters.AddWithValue("@valorVenda", modelFinanceiro.valorVenda);
                command.Parameters.AddWithValue("@opcaoPagamento", modelFinanceiro.opcaoPagamento);
                command.Parameters.AddWithValue("@statusPagamento", modelFinanceiro.statusPagamento);
                command.Parameters.AddWithValue("@statusVenda", modelFinanceiro.statusVenda);
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
        public int RecuperarCodigo(ModelFinanceiro modelFinanceiro)
        {
            try
            {
                string instrucao = string.Format("SELECT Codigo FROM tbPedido WHERE dataVenda = @dataVenda");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@dataVenda", modelFinanceiro.dataVenda);
                SqlDataReader dr;
                dr = command.ExecuteReader();
                dr.Read();
                return dr.GetInt32(0);
            }
            catch
            {
                controllerConfiguracaoSQL.Fechar();
                return -1;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool CadastrarItens(ModelFinanceiro modelFinanceiro)
        {
            try
            {
                string instrucao = string.Format("INSERT INTO tbPedidoItens (CodigoPedido, NomeCliente, CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, Garantia, statusPagamento, statusVenda) SELECT (@Codigo), (@NomeCliente), CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, PrazoGarantia, (@statusPagamento), (@statusVenda) FROM tbCarrinho");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelFinanceiro.CodigoPedido);
                command.Parameters.AddWithValue("@NomeCliente", modelFinanceiro.nomeCliente);
                command.Parameters.AddWithValue("@statusPagamento", modelFinanceiro.statusPagamento);
                command.Parameters.AddWithValue("@statusVenda", modelFinanceiro.statusVenda);
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
        public bool CancelarPedido(ModelFinanceiro modelFinanceiro)
        {
            try
            {
                string instrucao = string.Format("UPDATE tbPedido SET statusPagamento = @statusPagamento, statusVenda = statusVenda WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelFinanceiro.Codigo);
                command.Parameters.AddWithValue("@statusPagamento", modelFinanceiro.statusPagamento);
                command.Parameters.AddWithValue("@statusVenda", modelFinanceiro.statusVenda);
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
    }
}
