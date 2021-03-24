using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerConsultarPedidoItens
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarPedidosItensCodigo(string Codigo)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE CodigoPedido = '" + Codigo + "' AND statusVenda = 'Finalizada';");
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
        public DataTable CarregarPedidosItensCodigoCancelados(string Codigo)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE CodigoPedido = '" + Codigo + "' AND statusVenda = 'Cancelada';");
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
    }
}
