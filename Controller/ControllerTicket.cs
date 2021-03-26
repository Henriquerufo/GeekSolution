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
    public class ControllerTicket
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarItensCanceladosPorCodigoItem(string codigoItem, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbPedidoItens WHERE Ticket = 'Em Aberto' AND Codigo = " + codigoItem + " AND DataTicket BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public DataTable CarregarItensCanceladosPorCodigoPedido(string codigoItem, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbPedidoItens WHERE Ticket = 'Em Aberto' AND CodigoPedido = " + codigoItem + " AND DataTicket BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public DataTable CarregarTicketEmAbertoPorCodigo(string codigoItem, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTicket WHERE Status = 'Em Aberto' AND Codigo = " + codigoItem + " AND Data BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public DataTable CarregarTicketEmAbertoPorVendedor(string geradoPor, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTicket WHERE Status = 'Em Aberto' AND GeradoPor = " + geradoPor + " AND Data BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public DataTable CarregarTicketFinalizadoPorCodigo(string codigoItem, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTicket WHERE Status = 'Finalizado' AND Codigo = " + codigoItem + " AND Data BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public DataTable CarregarTicketFinalizadoPorVendedor(string geradoPor, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTicket WHERE Status = 'Finalizado' AND GeradoPor = " + geradoPor + " AND Data BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public bool GerarTicket(ModelTicket modelTicket)
        {
            try
            {
                string instrucao = string.Format(@"INSERT INTO tbTicket (GeradoPor, Data, Valor, Status) VALUES (@GeradoPor, @Data, @Valor, @Status)");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@GeradoPor", modelTicket.GeradoPor);
                command.Parameters.AddWithValue("@Data", modelTicket.Data);
                command.Parameters.AddWithValue("@Valor", modelTicket.Valor);
                command.Parameters.AddWithValue("@Status", modelTicket.Status);
                return Convert.ToBoolean(command.ExecuteNonQuery());
            }
            catch
            {
                throw;
            }
        }
        public bool AlterarStatusTicket(ModelTicket modelTicket)
        {
            string instrucao = string.Format(@"UPDATE tbPedidoItens SET Ticket = 'Gerado' WHERE Codigo = @Codigo");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelTicket.Codigo);
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
