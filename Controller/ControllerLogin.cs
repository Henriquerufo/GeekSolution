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
    public class ControllerLogin
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        ControllerConfiguracaoSQLCentral controllerConfiguracaoSQLCentral = new ControllerConfiguracaoSQLCentral();
        public DataTable CarregarTodos(string Procurar)
        {
            string instrucao = string.Format("SELECT * FROM tbLogin WHERE ID = '" + Procurar + "'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataTable Carregar(string nivel, string ID)
        {
            string instrucao = string.Format("SELECT * FROM tbLogin WHERE Nivel = '" + nivel + "' and ID = '" + ID + "'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public bool VerificarLoginExistente(ModelLogin modelLogin)
        {
            string instrucao = string.Format(@"SELECT * FROM tbLogin WHERE ID = @ID");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@ID", modelLogin.ID);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                return false;
            }
            return true;
        }
        public bool VerificarLoginADM(string ID, string Senha)
        {
            string instrucao = string.Format("SELECT * FROM tbLogin WHERE ID = '" + ID + "' AND Senha = '" + Senha + "' AND Nivel = 'Administrador'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataReader dr;

            dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            return false;
        }
        public bool VerificarLoginVendedor(string ID, string Senha)
        {
            string instrucao = string.Format("SELECT * FROM tbLogin WHERE ID = '" + ID + "' AND Senha = '" + Senha + "' AND Nivel = 'Vendedor'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataReader dr;

            dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            return false;
        }
        public bool VerificarLoginSupervisor(string ID, string Senha)
        {
            string instrucao = string.Format("SELECT * FROM tbLogin WHERE ID = '" + ID + "' AND Senha = '" + Senha + "' AND Nivel = 'Supervisor'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataReader dr;

            dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            return false;
        }
        public bool VerificarLoginEstoquista(string ID, string Senha)
        {
            string instrucao = string.Format("SELECT * FROM tbLogin WHERE ID = '" + ID + "' AND Senha = '" + Senha + "' AND Nivel = 'Estoquista'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataReader dr;

            dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            return false;
        }
        public bool InserirLog(ModelLogin modelLogin)
        {
            string instrucao = string.Format(@"INSERT INTO tbLogLogin (idTecSistemas, Nome, Nivel, UltimoLog, Status) VALUES (@idTecSistemas, @Nome, @Nivel, @UltimoLog, @Status)");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@idTecSistemas", Properties.SettingsSQLCentral.Default.IDTecSistemas);
            command.Parameters.AddWithValue("@Nome", modelLogin.ID);
            command.Parameters.AddWithValue("@Nivel", modelLogin.Nivel);
            command.Parameters.AddWithValue("@UltimoLog", modelLogin.UltimoLog);
            command.Parameters.AddWithValue("@Status", modelLogin.Status);
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public int VerificarLoginsContratados()
        {
            string instrucao = string.Format(@"select loginsContratados from tbCadastro Where idTecSistemas = '" + Properties.SettingsSQLCentral.Default.IDTecSistemas + "'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQLCentral.Conectar());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            sqlDataReader.Read();
            int total = (int)sqlDataReader["loginsContratados"];
            return total;
        }
        public int VerificarLoginsCadastrados()
        {
            string instrucao = string.Format(@"select COUNT (id) from tbLogin");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            sqlDataReader.Read();
            int total = (int)sqlDataReader[""];
            return total;            
        } 
        public bool Cadastrar(ModelLogin modelLogin)
        {
            string instrucao = string.Format("INSERT INTO tbLogin (ID, Senha, Nivel, IDTecSistemas) VALUES (@ID, @Senha, @Nivel, @IDTecSistemas); SELECT SCOPE_IDENTITY();");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@ID", modelLogin.ID);
            command.Parameters.AddWithValue("@Senha", modelLogin.Senha);
            command.Parameters.AddWithValue("@Nivel", modelLogin.Nivel);
            command.Parameters.AddWithValue("@IDTecSistemas", modelLogin.IDTecSistemas);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool Editar(ModelLogin modelLogin)
        {
            string instrucao = string.Format("UPDATE tbLogin SET ID = @ID, Senha = @Senha, Nivel = @Nivel, IDTecSistemas = @IDTecSistemas WHERE Codigo = @Codigo; SELECT @Codigo;");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelLogin.Codigo);
            command.Parameters.AddWithValue("@ID", modelLogin.ID);
            command.Parameters.AddWithValue("@Senha", modelLogin.Senha);
            command.Parameters.AddWithValue("@Nivel", modelLogin.Nivel);
            command.Parameters.AddWithValue("@IDTecSistemas", modelLogin.IDTecSistemas);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool Deletar(ModelLogin modelLogin)
        {
            string instrucao = string.Format("DELETE FROM tbLogin WHERE Codigo = @Codigo");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelLogin.Codigo);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
