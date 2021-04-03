using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerEntradaProduto
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        ModelEntradaProduto modelEntradaProduto = new ModelEntradaProduto();
        public DataTable CarregarPedidoPorCodigo(string codigo, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbEntradaProduto WHERE Codigo = '" + codigo + "' AND dataRecebido BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public DataTable CarregarPedidoPorNomeEmpresa(string NomeEmpresa, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbEntradaProduto WHERE NomeEmpresa LIKE '%" + NomeEmpresa + "%' AND dataRecebido BETWEEN '" + dataDe + "' AND '" + dataAte + "'");
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
        public DataTable CarregarPedidoItens(ModelEntradaProduto modelEntradaProduto)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbEntradaProdutoItens WHERE CodigoEntradaProduto = @CodigoEntradaProduto");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@CodigoEntradaProduto", modelEntradaProduto.CodigoEntradaProduto);
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
        public ModelEntradaProduto CarregarCodigoBarras(string codigo)
        {
            try
            {
                string instrucao = string.Format(@"SELECT * FROM tbProduto WHERE CodigoBarras = '" + codigo + "'");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    modelEntradaProduto.Codigo = Convert.ToInt32(sqlDataReader["Codigo"].ToString());
                    modelEntradaProduto.NomeEmpresa = sqlDataReader["NomeEmpresa"].ToString();
                    modelEntradaProduto.CodigoBarras = sqlDataReader["CodigoBarras"].ToString();
                    modelEntradaProduto.NomeProduto = sqlDataReader["NomeProduto"].ToString();
                    modelEntradaProduto.Categoria = sqlDataReader["Categoria"].ToString();
                    modelEntradaProduto.Fabricante = sqlDataReader["Fabricante"].ToString();
                    modelEntradaProduto.ValorProduto = sqlDataReader["ValorProduto"].ToString();
                    modelEntradaProduto.Plataforma = sqlDataReader["Plataforma"].ToString();
                    modelEntradaProduto.Garantia = sqlDataReader["PrazoGarantia"].ToString();
                    modelEntradaProduto.Quantidade = sqlDataReader["Quantidade"].ToString();
                    return modelEntradaProduto;
                }
                return null;
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
        public bool MaisQuantidadeEstoque(ModelEntradaProduto modelEntradaProduto)
        {
            try
            {
                string instrucao = string.Format(@"UPDATE tbProduto SET Quantidade = Quantidade + 1 WHERE CodigoBarras = @CodigoBarras");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@CodigoBarras", modelEntradaProduto.CodigoBarras);
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
        public int InserirEntradaProduto(ModelEntradaProduto modelEntradaProduto)
        {
            try
            {
                string instrucao = string.Format(@"INSERT INTO tbEntradaProduto (NomeEmpresa, Estoquista, dataRecebido, QuantidadeItens) VALUES (@NomeEmpresa, @Estoquista, @dataRecebido, @QuantidadeItens); SELECT @@IDENTITY;");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@NomeEmpresa", modelEntradaProduto.NomeEmpresa);
                command.Parameters.AddWithValue("@Estoquista", modelEntradaProduto.Estoquista);
                command.Parameters.AddWithValue("@dataRecebido", modelEntradaProduto.DataRecebido);
                command.Parameters.AddWithValue("@QuantidadeItens", modelEntradaProduto.QuantidadeItens);
                return Convert.ToInt32(command.ExecuteScalar());
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
        public bool InserirEntradaProdutoItens(ModelEntradaProduto modelEntradaProduto)
        {
            try
            {
                string instrucao = string.Format(@"INSERT INTO tbEntradaProdutoItens (CodigoEntradaProduto, NomeProduto, NomeEmpresa, Estoquista, DataRecebido, CodigoBarras, Categoria, Fabricante, ValorProduto, Plataforma, Garantia) VALUES (@CodigoEntradaProduto, @NomeProduto, @NomeEmpresa, @Estoquista, @DataRecebido, @CodigoBarras, @Categoria, @Fabricante, @ValorProduto, @Plataforma, @Garantia)");
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                command.Parameters.AddWithValue("@CodigoEntradaProduto", modelEntradaProduto.CodigoEntradaProduto);
                command.Parameters.AddWithValue("@NomeProduto", modelEntradaProduto.NomeProduto);
                command.Parameters.AddWithValue("@NomeEmpresa", modelEntradaProduto.NomeEmpresa);
                command.Parameters.AddWithValue("@Estoquista", modelEntradaProduto.Estoquista);
                command.Parameters.AddWithValue("@DataRecebido", modelEntradaProduto.DataRecebido);
                command.Parameters.AddWithValue("@CodigoBarras", modelEntradaProduto.CodigoBarras);
                command.Parameters.AddWithValue("@Categoria", modelEntradaProduto.Categoria);
                command.Parameters.AddWithValue("@Fabricante", modelEntradaProduto.Fabricante);
                command.Parameters.AddWithValue("@ValorProduto", modelEntradaProduto.ValorProduto);
                command.Parameters.AddWithValue("@Plataforma", modelEntradaProduto.Plataforma);
                command.Parameters.AddWithValue("@Garantia", modelEntradaProduto.Garantia);
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
