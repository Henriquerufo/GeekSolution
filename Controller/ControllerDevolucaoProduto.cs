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
            string instrucao = string.Format("SELECT * FROM tbPedido WHERE NomeCliente LIKE '%" + nomeCliente + "%' AND statusVenda = 'Finalizada'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable CarregarPedidoCancelados(string nomeCliente)
        {
            string instrucao = string.Format("SELECT * FROM tbPedido WHERE NomeCliente LIKE '%" + nomeCliente + "%' AND statusVenda = 'Cancelada'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable CarregarItem(string nomeCliente)
        {
            string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente LIKE '%" + nomeCliente + "%' AND statusVenda = 'Finalizada'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable CarregarItemCancelados(string nomeCliente)
        {
            string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente LIKE '%" + nomeCliente + "%' AND statusVenda = 'Cancelada'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool CancelarPedido(ModelDevolucaoPedido modelDevolucaoPedido)
        {
            string instrucao = string.Format("UPDATE tbPedido SET statusPagamento = 'Abonado', statusVenda = 'Cancelada' WHERE Codigo = @Codigo AND statusVenda = 'Finalizada' AND statusPagamento = 'Recebido';");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelDevolucaoPedido.Codigo);
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool CancelarPedidoItem(ModelDevolucaoPedido modelDevolucaoPedido)
        {
            string instrucao = string.Format("UPDATE tbPedidoItens SET statusPagamento = 'Abonado', statusVenda = 'Cancelada' WHERE Codigo = @Codigo AND statusVenda = 'Finalizada' AND statusPagamento = 'Recebido'; UPDATE tbProduto SET Quantidade = Quantidade + 1 WHERE CodigoBarras = @CodigoBarras");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelDevolucaoPedido.Codigo);
            command.Parameters.AddWithValue("@CodigoBarras", modelDevolucaoPedido.CodigoBarras);
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
