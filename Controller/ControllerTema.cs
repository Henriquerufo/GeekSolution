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
            string instrucao = string.Format(@"SELECT * FROM tbTema WHERE Status = '1'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
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
                return null;
            }
        }
        public DataTable CarregarTemasPorNome(string Nome)
        {
            string instrucao = string.Format(@"SELECT * FROM tbTema WHERE Status = '0' AND Nome LIKE '%" + Nome + "%'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public string CarregarEnderecoImagem()
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
        public int CarregarColorR()
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
            return 0;
        }
        public int CarregarColorG()
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
            return 0;
        }
        public int CarregarColorB()
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
            return 0;
        }
        public bool InserirTema(ModelTema modelTema)
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
        public bool AlterarTema(ModelTema modelTema)
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
        public bool DeletarTema(ModelTema modelTema)
        {
            string instrucao = string.Format(@"DELETE FROM tbTema WHERE Codigo = @Codigo");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelTema.Codigo);
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool DesativarTema(ModelTema modelTema)
        {
            string instrucao = string.Format(@"UPDATE tbTema SET Status = '0' WHERE Codigo = @Codigo");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelTema.Codigo);
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool AtivarTema(ModelTema modelTema)
        {
            string instrucao = string.Format(@"UPDATE tbTema SET Status = '1' WHERE Codigo = @Codigo");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("Codigo", modelTema.Codigo);
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
