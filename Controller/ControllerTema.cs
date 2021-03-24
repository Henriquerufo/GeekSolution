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
    public class ControllerTema
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarTemaAtivo()
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTema WHERE Status = '1'");
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
        public DataTable CarregarTemasPorCodigo(string Codigo)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTema WHERE Status = '0' AND Codigo = '" + Codigo + "'");
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
        public DataTable CarregarTemasPorNome(string Nome)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTema WHERE Status = '0' AND Nome LIKE '%" + Nome + "%'");
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
        public string CarregarEnderecoImagem()
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTema WHERE Status = '1'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    string endereco = sqlDataReader["EnderecoImagem"].ToString();
                    return endereco;
                }
                return null;
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
        public int CarregarColorR()
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTema WHERE Status = '1'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    int endereco = Convert.ToInt32(sqlDataReader["R"].ToString());
                    return endereco;
                }
                return -1;
            }
            catch
            {
                controllerConfiguracaoSQL.Fechar();
                return -1;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public int CarregarColorG()
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTema WHERE Status = '1'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    int endereco = Convert.ToInt32(sqlDataReader["G"].ToString());
                    return endereco;
                }
                return -1;
            }
            catch
            {
                controllerConfiguracaoSQL.Fechar();
                return -1;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public int CarregarColorB()
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbTema WHERE Status = '1'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    int endereco = Convert.ToInt32(sqlDataReader["B"].ToString());
                    return endereco;
                }
                return -1;
            }
            catch
            {
                controllerConfiguracaoSQL.Fechar();
                return -1;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool InserirTema(ModelTema modelTema)
        {
            try
            {
                string instrucao = string.Format("INSERT INTO tbTema (Nome, EnderecoImagem, R, G, B, Status) VALUES (@Nome, @EnderecoImagem, @R, @G, @B, @Status)");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Nome", modelTema.Nome);
                command.Parameters.AddWithValue("@EnderecoImagem", modelTema.EnderecoImagem);
                command.Parameters.AddWithValue("@R", modelTema.R);
                command.Parameters.AddWithValue("@G", modelTema.G);
                command.Parameters.AddWithValue("@B", modelTema.B);
                command.Parameters.AddWithValue("@Status", modelTema.status);
                return Convert.ToBoolean(command.ExecuteNonQuery());
            }
            catch
            {
                controllerConfiguracaoSQL.Fechar();
                return false;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool AlterarTema(ModelTema modelTema)
        {
            try
            {
                string instrucao = string.Format(@"UPDATE tbTema SET EnderecoImagem = @EnderecoImagem, R = @R, G = @G, B = @B WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelTema.Codigo);
                command.Parameters.AddWithValue("@EnderecoImagem", modelTema.EnderecoImagem);
                command.Parameters.AddWithValue("@R", modelTema.R);
                command.Parameters.AddWithValue("@G", modelTema.G);
                command.Parameters.AddWithValue("@B", modelTema.B);
                return Convert.ToBoolean(command.ExecuteNonQuery());
            }
            catch
            {
                controllerConfiguracaoSQL.Fechar();
                return false;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool DeletarTema(ModelTema modelTema)
        {
            try
            {
                string instrucao = string.Format(@"DELETE FROM tbTema WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelTema.Codigo);
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
        public bool DesativarTema(ModelTema modelTema)
        {
            try
            {
                string instrucao = string.Format(@"UPDATE tbTema SET Status = '0' WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@Codigo", modelTema.Codigo);
                return Convert.ToBoolean(command.ExecuteNonQuery());
            }
            catch
            {
                controllerConfiguracaoSQL.Fechar();
                return false;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
        public bool AtivarTema(ModelTema modelTema)
        {
            try
            {
                string instrucao = string.Format(@"UPDATE tbTema SET Status = '1' WHERE Codigo = @Codigo");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("Codigo", modelTema.Codigo);
                return Convert.ToBoolean(command.ExecuteNonQuery());
            }
            catch
            {
                controllerConfiguracaoSQL.Fechar();
                return false;
            }
            finally
            {
                controllerConfiguracaoSQL.Fechar();
            }
        }
    }
}
