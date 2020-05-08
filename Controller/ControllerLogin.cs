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
        public DataTable Carregar(string nivel, string ID)
        {
            string instrucao = string.Format("SELECT * FROM tbLogin WHERE Nivel = '" + nivel + "' and ID LIKE '%" + ID + "%'");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
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
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public bool Cadastrar(ModelLogin modelLogin)
        {
            string instrucao = string.Format("INSERT INTO tbLogin (ID, Senha, Nivel) VALUES (@ID, @Senha, @Nivel); SELECT SCOPE_IDENTITY();");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@ID", modelLogin.ID);
            command.Parameters.AddWithValue("@Senha", modelLogin.Senha);
            command.Parameters.AddWithValue("@Nivel", modelLogin.Nivel);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool Editar(ModelLogin modelLogin)
        {
            string instrucao = string.Format("UPDATE tbLogin SET ID = @ID, Senha = @Senha, Nivel = @Nivel WHERE Codigo = @Codigo; SELECT @Codigo;");

            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelLogin.Codigo);
            command.Parameters.AddWithValue("@ID", modelLogin.ID);
            command.Parameters.AddWithValue("@Senha", modelLogin.Senha);
            command.Parameters.AddWithValue("@Nivel", modelLogin.Nivel);

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
