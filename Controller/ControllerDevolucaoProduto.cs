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
    public class ControllerDevolucaoProduto
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarPedido(string nomeCliente)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedido WHERE NomeCliente LIKE '%" + nomeCliente + "%' AND statusVenda = 'Finalizada'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable CarregarPedidoCancelados(string nomeCliente)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedido WHERE NomeCliente LIKE '%" + nomeCliente + "%' AND statusVenda = 'Cancelada'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable CarregarItem(string nomeCliente)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente LIKE '%" + nomeCliente + "%' AND statusVenda = 'Finalizada'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable CarregarItemCancelados(string nomeCliente)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente LIKE '%" + nomeCliente + "%' AND statusVenda = 'Cancelada'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public bool CancelarPedido(ModelDevolucaoPedido modelDevolucaoPedido)
        {
            try
            {
                string instrucao = string.Format("UPDATE tbPedido SET statusVenda = 'Cancelada' WHERE Codigo = @Codigo AND statusVenda = 'Finalizada' AND statusPagamento = 'Recebido';");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelDevolucaoPedido.Codigo);
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
        public bool CancelarPedidoItem(ModelDevolucaoPedido modelDevolucaoPedido)
        {
            try
            {
                string instrucao = string.Format("UPDATE tbPedidoItens SET statusVenda = 'Cancelada', Ticket = @Ticket, DataTicket = @DataTicket WHERE Codigo = @Codigo AND statusVenda = 'Finalizada' AND statusPagamento = 'Recebido'; UPDATE tbProduto SET Quantidade = Quantidade + 1 WHERE CodigoBarras = @CodigoBarras");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelDevolucaoPedido.Codigo);
                command.Parameters.AddWithValue("@CodigoBarras", modelDevolucaoPedido.CodigoBarras);
                command.Parameters.AddWithValue("@Ticket", modelDevolucaoPedido.Ticket);
                command.Parameters.AddWithValue("@DataTicket", modelDevolucaoPedido.DataTicket);
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
