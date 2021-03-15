using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerCadastro
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable Carregar()
        {
            string instrucao = string.Format("SELECT TOP(1000) * FROM tbCadastro");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataTable CarregarPorCodigo(string codigo)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbCadastro WHERE Codigo = " + codigo);

                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable CarregarPorNome(string nome)
        {
            string instrucao = string.Format("SELECT * FROM tbCadastro WHERE Nome LIKE '%" + nome + "%'");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable CarregarPedidosItensCodigoPedido(string nome, string Procurar)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente = '" + nome + "'AND CodigoPedido = '" + Procurar + "' AND statusVenda = 'Finalizada';");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable CarregarPedidosItensNomeProduto(string nome, string Procurar)
        {
            string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente = '" + nome + "' AND NomeProduto LIKE '%" + Procurar + "%' AND statusVenda = 'Finalizada';");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable CarregarPedidosItensCanceladosCodigoPedido(string nome, string Procurar)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente = '" + nome + "' AND CodigoPedido = '" + Procurar + "' AND statusVenda = 'Cancelada';");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable CarregarPedidosItensCanceladosNomeProduto(string nome, string Procurar)
        {
            string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente = '" + nome + "' AND NomeProduto LIKE '%" + Procurar + "%' AND statusVenda = 'Cancelada';");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Cadastrar(ModelCadastro modelCadastro)
        {
            string instrucao = string.Format("INSERT INTO tbCadastro (RG, CPF, Nome, dtCadastro, Endereco, Telefone, Email) VALUES (@RG, @CPF, @Nome, @dtCadastro, @Endereco, @Telefone, @Email); SELECT SCOPE_IDENTITY();");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@RG", modelCadastro.RG);
            command.Parameters.AddWithValue("@CPF", modelCadastro.CPF);
            command.Parameters.AddWithValue("@Nome", modelCadastro.Nome);
            command.Parameters.AddWithValue("@dtCadastro", modelCadastro.dtCadastro);
            command.Parameters.AddWithValue("@Endereco", modelCadastro.Endereco);
            command.Parameters.AddWithValue("@Telefone", modelCadastro.Telefone);
            command.Parameters.AddWithValue("@Email", modelCadastro.Email);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool Editar(ModelCadastro modelCadastro)
        {
            string instrucao = string.Format("UPDATE tbCadastro SET RG = @RG, CPF = @CPF, Nome = @Nome, dtCadastro = @dtCadastro, Endereco = @Endereco, Telefone = @Telefone, Email = @Email WHERE Codigo = @Codigo; SELECT @Codigo;");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelCadastro.Codigo);
            command.Parameters.AddWithValue("@RG", modelCadastro.RG);
            command.Parameters.AddWithValue("@CPF", modelCadastro.CPF);
            command.Parameters.AddWithValue("@Nome", modelCadastro.Nome);
            command.Parameters.AddWithValue("@dtCadastro", modelCadastro.dtCadastro);
            command.Parameters.AddWithValue("@Endereco", modelCadastro.Endereco);
            command.Parameters.AddWithValue("@Telefone", modelCadastro.Telefone);
            command.Parameters.AddWithValue("@Email", modelCadastro.Email);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool Deletar(ModelCadastro modelCadastro)
        {
            string instrucao = string.Format("DELETE FROM tbCadastro WHERE Codigo = @Codigo");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelCadastro.Codigo);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
