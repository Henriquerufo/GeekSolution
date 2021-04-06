using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerRelacaoProduto
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable CarregarVendidosPorNome(string nome, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT TOP (1000) CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, Garantia, COUNT(NomeProduto) as TotalVendido from tbPedidoItens WHERE StatusVenda = 'Finalizada' AND NomeProduto LIKE '%" + nome + "%' AND DataRecebimento BETWEEN '" + dataDe + "' AND '" + dataAte + "'group by CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, Garantia;");
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
        public DataTable CarregarVendidosPorCodigo(string codigo, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT TOP (1000) CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, Garantia, COUNT(NomeProduto) as TotalVendido from tbPedidoItens WHERE StatusVenda = 'Finalizada' AND CodigoBarras = '" + codigo + "' AND DataRecebimento BETWEEN '" + dataDe + "' AND '" + dataAte + "'group by CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, Garantia;");
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
        public DataTable CarregarCanceladosPorNome(string nome, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT TOP (1000) CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, Garantia, COUNT(NomeProduto) as TotalCancelados from tbPedidoItens WHERE StatusVenda = 'Cancelada' AND NomeProduto LIKE '%" + nome + "%' AND DataRecebimento BETWEEN '" + dataDe + "' AND '" + dataAte + "'group by CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, Garantia;");
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
        public DataTable CarregarCanceladosPorCodigo(string codigo, string dataDe, string dataAte)
        {
            try
            {
                string instrucao = string.Format(@"SELECT TOP (1000) CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, Garantia, COUNT(NomeProduto) as TotalCancelados from tbPedidoItens WHERE StatusVenda = 'Cancelada' AND CodigoBarras = '" + codigo + "' AND DataRecebimento BETWEEN '" + dataDe + "' AND '" + dataAte + "'group by CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, Garantia;");
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
    }
}
