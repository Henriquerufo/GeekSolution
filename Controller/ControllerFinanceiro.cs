﻿using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerFinanceiro
    {
        ControllerConfiguracaoSQL controllerConfiguracaoSQL = new ControllerConfiguracaoSQL();
        public DataTable Carregar(string codigo)
        {
            try
            {
                string instrucao = "SELECT * FROM tbPedido WHERE Codigo = " + codigo;
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                string instrucao = "SELECT * FROM tbPedido";
                SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool Cadastrar(ModelFinanceiro modelFinanceiro)
        {
            string instrucao = string.Format("INSERT INTO tbPedido (nomeCliente, dataVenda, valorVenda, opcaoPagamento, statusPagamento, statusVenda) VALUES (@nomeCliente, @dataVenda, @valorVenda, @opcaoPagamento, @statusPagamento, @statusVenda); SELECT SCOPE_IDENTITY();");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@nomeCliente", modelFinanceiro.nomeCliente);
            command.Parameters.AddWithValue("@dataVenda", modelFinanceiro.dataVenda);
            command.Parameters.AddWithValue("@valorVenda", modelFinanceiro.valorVenda);
            command.Parameters.AddWithValue("@opcaoPagamento", modelFinanceiro.opcaoPagamento);
            command.Parameters.AddWithValue("@statusPagamento", modelFinanceiro.statusPagamento);
            command.Parameters.AddWithValue("@statusVenda", modelFinanceiro.statusVenda);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
        public bool CadastrarItens(ModelFinanceiro modelFinanceiro)
        {
            string instrucao = string.Format("INSERT INTO tbPedidoItens (CodigoPedido, CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, Garantia) SELECT Codigo FROM tbPedido; SELECT CodigoBarras, NomeProduto, Categoria, Fabricante, ValorProduto, Plataforma, Garantia FROM tbCarrinho; ");
        }
        public bool CancelarPedido(ModelFinanceiro modelFinanceiro)
        {
            string instrucao = string.Format("UPDATE tbPedido SET statusPagamento = @statusPagamento, statusVenda = statusVenda WHERE Codigo = @Codigo");
            SqlCommand command = new SqlCommand(instrucao, controllerConfiguracaoSQL.Conectar());
            command.Parameters.AddWithValue("@Codigo", modelFinanceiro.Codigo);
            command.Parameters.AddWithValue("@statusPagamento", modelFinanceiro.statusPagamento);
            command.Parameters.AddWithValue("@statusVenda", modelFinanceiro.statusVenda);

            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
}
