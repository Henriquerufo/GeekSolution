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
            string instrucao = string.Format("SELECT * FROM tbPedido WHERE NomeCliente LIKE '%" + nomeCliente + "%'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable CarregarItem(string nomeCliente)
        {
            string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente LIKE '%" + nomeCliente + "%'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool DeletarPedido(ModelDevolucaoPedido modelDevolucaoPedido)
        {
            string instrucao = string.Format("DELETE FROM tbPedido WHERE Codigo = @Codigo; DELETE FROM tbPedidoItens WHERE CodigoPedido = @Codigo");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelDevolucaoPedido.Codigo);
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool DeletarPedidoItem(ModelDevolucaoPedido modelDevolucaoPedido)
        {
            string instrucao = string.Format("DELETE FROM tbPedidoItens WHERE Codigo = @Codigo");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelDevolucaoPedido.Codigo);
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
