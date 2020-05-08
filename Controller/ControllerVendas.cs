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
        public bool Inserir(string CodigoBarras)
        {
            string instrucao = string.Format("INSERT  INTO tbCarrinho (CodigoBarras, NomeProduto, Categoria, Fabricante, Quantidade, ValorProduto, Plataforma, PrazoGarantia) SELECT CodigoBarras, NomeProduto, Categoria, Fabricante, Quantidade, ValorProduto, Plataforma, PrazoGarantia FROM tbProduto WHERE CodigoBarras LIKE " + CodigoBarras);
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool Deletar()
        {
            string instrucao = string.Format(@"DELETE FROM TbCarrinho");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool DeletarLinha(ModelVendas modelVendas)
        {
            string instrucao = string.Format(@"DELETE FROM TbCarrinho WHERE Codigo = " + modelVendas.Codigo);
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
