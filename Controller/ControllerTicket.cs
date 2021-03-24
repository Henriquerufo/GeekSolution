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
    }
}
