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
            try
            {
                string instrucao = string.Format("SELECT TOP(1000) * FROM tbCadastro");
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
        public DataTable CarregarPorCodigo(string codigo)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbCadastro WHERE Codigo = '" + codigo + "'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable CarregarPorNome(string nome)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbCadastro WHERE Nome LIKE '%" + nome + "%'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable CarregarPedidosItensCodigoPedidoPagamentoRecebido(string nome, string Procurar)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente = '" + nome + "'AND CodigoPedido = '" + Procurar + "' AND statusVenda = 'Finalizada' AND statusPagamento = 'Recebido';");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable CarregarPedidosItensNomeProdutoPagamentoRecebido(string nome, string Procurar)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente = '" + nome + "' AND NomeProduto LIKE '%" + Procurar + "%' AND statusVenda = 'Finalizada' AND statusPagamento = 'Recebido';");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable CarregarPedidosItensCodigoPedidoPagamentoEmAberto(string nome, string Procurar)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente = '" + nome + "'AND CodigoPedido = '" + Procurar + "' AND statusVenda = 'Finalizada' AND statusPagamento = 'Em Aberto';");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public DataTable CarregarPedidosItensNomeProdutoPagamentoEmAberto(string nome, string Procurar)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente = '" + nome + "' AND NomeProduto LIKE '%" + Procurar + "%' AND statusVenda = 'Finalizada' AND statusPagamento = 'Em Aberto';");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public DataTable CarregarPedidosItensCanceladosNomeProduto(string nome, string Procurar)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE NomeCliente = '" + nome + "' AND NomeProduto LIKE '%" + Procurar + "%' AND statusVenda = 'Cancelada';");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
        public bool VerificarPedidoEmAberto(ModelCadastro modelCadastro)
        {
            try
            {
                string instrucao = string.Format("SELECT * FROM tbPedidoItens WHERE CodigoPedido = @CodigoPedido AND statusPagamento = 'Em Aberto'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@CodigoPedido", modelCadastro.CodigoPedido);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool AlterarStatusPagamentoPedido(ModelCadastro modelCadastro)
        {
            try
            {
                string instrucao = string.Format("UPDATE tbPedido SET statusPagamento = 'Recebido' WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelCadastro.CodigoPedido);
                return Convert.ToBoolean(command.ExecuteNonQuery());
            }
            catch
            {
                return false;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool ReceberItemEmAberto(ModelCadastro modelCadastro)
        {
            try
            {
                string instrucao = string.Format("UPDATE tbPedidoItens SET statusPagamento = 'Recebido', RecebidoPor = @RecebidoPor, DataRecebimento = @DataRecebimento WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelCadastro.Codigo);
                command.Parameters.AddWithValue("@RecebidoPor", modelCadastro.RecebidoPor);
                command.Parameters.AddWithValue("@DataRecebimento", modelCadastro.DataRecebimento);
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
        public bool Cadastrar(ModelCadastro modelCadastro)
        {
            try
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
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool Editar(ModelCadastro modelCadastro)
        {
            try
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
            catch
            {
                throw;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool Deletar(ModelCadastro modelCadastro)
        {
            try
            {
                string instrucao = string.Format("DELETE FROM tbCadastro WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelCadastro.Codigo);
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
