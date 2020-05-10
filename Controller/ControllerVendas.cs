using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerVendas
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable Carregar()
        {
            string instrucao = string.Format("SELECT * FROM tbCarrinho");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Carregar2()
        {
            string instrucao = string.Format("SELECT * FROM tbCarrinhoTemporario");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Verificar(string CodigoBarras)
        {
            string instrucao = string.Format(@"SELECT * FROM tbProduto WHERE CodigoBarras = '" + CodigoBarras + "'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataReader dt;
            dt = command.ExecuteReader();
            if (dt.HasRows)
            {
                return true;
            }
            return false;
        }
        public bool Inserir2(string CodigoBarras)
        {
            string instrucao = string.Format("INSERT  INTO tbCarrinhoTemporario (CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, PrazoGarantia) SELECT CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, PrazoGarantia FROM tbProduto WHERE CodigoBarras LIKE '" + CodigoBarras + "'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool Inserir()
        {
            string instrucao = string.Format("INSERT  INTO tbCarrinho (CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, PrazoGarantia) SELECT CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, PrazoGarantia FROM tbCarrinhoTemporario");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            return Convert.ToBoolean(command.ExecuteNonQuery());

        }
        public bool Deletar2()
        {
            string instrucao = string.Format(@"DELETE FROM tbCarrinhoTemporario");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool Deletar()
        {
            string instrucao = string.Format(@"DELETE FROM tbCarrinho");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool DeletarLinha(ModelVendas modelVendas)
        {
            string instrucao = string.Format(@"DELETE FROM TbCarrinho WHERE Codigo = " + modelVendas.Codigo);
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool MenosQuatidade(ModelVendas modelVendas)
        {
            string instrucao = string.Format(@"UPDATE tbProduto SET Quantidade = Quantidade - @Quantidade WHERE CodigoBarras = @CodigoBarras");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@CodigoBarras", modelVendas.CodigoBarras);
            command.Parameters.AddWithValue("@Quantidade", modelVendas.quantidade);
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
