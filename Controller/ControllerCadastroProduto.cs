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
    public class ControllerCadastroProduto
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarPorCodigo(string Codigo)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbProduto WHERE Codigo = " + Codigo);
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable CarregarPorNome(string Nome)
        {
            string instrucao = string.Format("SELECT * FROM tbProduto WHERE NomeProduto LIKE '%" + Nome + "%'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool VerificarProdutoCadastrado(ModelCadastroProduto modelCadastroProduto)
        {
            string instrucao = string.Format(@"SELECT * FROM tbProduto WHERE CodigoBarras = @CodigoBarras");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@CodigoBarras", modelCadastroProduto.CodigoBarras);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                return false;
            }
            return true;
        }
        public bool Cadastrar(ModelCadastroProduto modelCadastroProduto)
        {
            string instrucao = string.Format("INSERT INTO tbProduto (CodigoBarras, NomeProduto, Categoria, Fabricante, Quantidade, ValorProduto, Plataforma, PrazoGarantia) VALUES (@CodigoBarras, @NomeProduto, @Categoria, @Fabricante, @Quantidade, @ValorProduto, @Plataforma, @PrazoGarantia); SELECT SCOPE_IDENTITY();");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@CodigoBarras", modelCadastroProduto.CodigoBarras);
            command.Parameters.AddWithValue("@NomeProduto", modelCadastroProduto.NomeProduto);
            command.Parameters.AddWithValue("@Categoria", modelCadastroProduto.Categoria);
            command.Parameters.AddWithValue("@Fabricante", modelCadastroProduto.Fabricante);
            command.Parameters.AddWithValue("@Quantidade", modelCadastroProduto.Quantidade);
            command.Parameters.AddWithValue("@ValorProduto", modelCadastroProduto.ValorProduto);
            command.Parameters.AddWithValue("@Plataforma", modelCadastroProduto.Plataforma);
            command.Parameters.AddWithValue("@PrazoGarantia", modelCadastroProduto.Garantia);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool Editar(ModelCadastroProduto modelCadastroProduto)
        {
            string instrucao = string.Format("UPDATE tbProduto SET CodigoBarras = @CodigoBarras, NomeProduto = @NomeProduto, Categoria = @Categoria, Fabricante = @Fabricante, Quantidade = @Quantidade, ValorProduto = @ValorProduto, Plataforma = @Plataforma, PrazoGarantia = @PrazoGarantia WHERE Codigo = @Codigo; SELECT @Codigo;");
            
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelCadastroProduto.Codigo);
            command.Parameters.AddWithValue("@CodigoBarras", modelCadastroProduto.CodigoBarras);
            command.Parameters.AddWithValue("@NomeProduto", modelCadastroProduto.NomeProduto);
            command.Parameters.AddWithValue("@Categoria", modelCadastroProduto.Categoria);
            command.Parameters.AddWithValue("@Fabricante", modelCadastroProduto.Fabricante);
            command.Parameters.AddWithValue("@Quantidade", modelCadastroProduto.Quantidade);
            command.Parameters.AddWithValue("@ValorProduto", modelCadastroProduto.ValorProduto);
            command.Parameters.AddWithValue("@Plataforma", modelCadastroProduto.Plataforma);
            command.Parameters.AddWithValue("@PrazoGarantia", modelCadastroProduto.Garantia);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool Deletar(ModelCadastroProduto modelCadastroProduto)
        {
            string instrucao = string.Format("DELETE FROM tbProduto WHERE Codigo = @Codigo");
            
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelCadastroProduto.Codigo);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
