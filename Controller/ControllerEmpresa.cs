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
    public class ControllerEmpresa
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarEntradaPorCodigo(string codigo, string NomeEmpresa)
        {
            string instrucao = string.Format(@"SELECT * FROM tbEntradaProdutoItens WHERE NomeEmpresa = '" + NomeEmpresa + "' AND Codigo = '" + codigo + "'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable CarregarEntradaPorCodigoPedido(string codigo, string NomeEmpresa)
        {
            string instrucao = string.Format(@"SELECT * FROM tbEntradaProdutoItens WHERE NomeEmpresa = '" + NomeEmpresa + "' AND CodigoEntradaProduto = '" + codigo + "'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable CarregarEmpresaPorCodigo(string codigo)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbEmpresa WHERE Codigo = '" + codigo + "'");
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
        public DataTable CarregarEmpresaPorNome(string nome)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbEmpresa WHERE NomeEmpresa LIKE '%" + nome + "%'");
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
        public bool Cadastrar(ModelEmpresa modelEmpresa)
        {
            try
            {
                string instrucao = string.Format(@"INSERT INTO tbEmpresa (NomeEmpresa, CNPJ, DataCadastro, Telefone, Endereco, Numero, Complemento, Bairro, CEP, Email) VALUES (@NomeEmpresa, @CNPJ, @DataCadastro, @Telefone, @Endereco, @Numero, @Complemento, @Bairro, @CEP, @Email)");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@NomeEmpresa", modelEmpresa.NomeEmpresa);
                command.Parameters.AddWithValue("@CNPJ", modelEmpresa.CNPJ);
                command.Parameters.AddWithValue("@DataCadastro", modelEmpresa.DataCadastro);
                command.Parameters.AddWithValue("@Telefone", modelEmpresa.Telefone);
                command.Parameters.AddWithValue("@Endereco", modelEmpresa.Endereco);
                command.Parameters.AddWithValue("@Numero", modelEmpresa.Numero);
                command.Parameters.AddWithValue("@Complemento", modelEmpresa.Complemento);
                command.Parameters.AddWithValue("@Bairro", modelEmpresa.Bairro);
                command.Parameters.AddWithValue("@CEP", modelEmpresa.CEP);
                command.Parameters.AddWithValue("@Email", modelEmpresa.Email);
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
        public bool Editar(ModelEmpresa modelEmpresa)
        {
            try
            {
                string instrucao = string.Format(@"UPDATE tbEmpresa SET NomeEmpresa = @NomeEmpresa, CNPJ = @CNPJ, Telefone = @Telefone, Endereco = @Endereco, Numero = @Numero, Complemento = @Complemento, Bairro = @Bairro, CEP = @CEP, Email = @Email WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelEmpresa.Codigo);
                command.Parameters.AddWithValue("@NomeEmpresa", modelEmpresa.NomeEmpresa);
                command.Parameters.AddWithValue("@CNPJ", modelEmpresa.CNPJ);
                command.Parameters.AddWithValue("@Telefone", modelEmpresa.Telefone);
                command.Parameters.AddWithValue("@Endereco", modelEmpresa.Endereco);
                command.Parameters.AddWithValue("@Numero", modelEmpresa.Numero);
                command.Parameters.AddWithValue("@Complemento", modelEmpresa.Complemento);
                command.Parameters.AddWithValue("@Bairro", modelEmpresa.Bairro);
                command.Parameters.AddWithValue("@CEP", modelEmpresa.CEP);
                command.Parameters.AddWithValue("@Email", modelEmpresa.Email);
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
        public bool Deletar(ModelEmpresa modelEmpresa)
        {
            try
            {
                string instrucao = string.Format(@"DELETE FROM tbEmpresa WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelEmpresa.Codigo);
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
