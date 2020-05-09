using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelFinanceiro
    {
        //Pedido
        public string Codigo { get; set; }
        public string nomeCliente { get; set; }
        public string dataVenda { get; set; }
        public string valorVenda { get; set; }
        public string opcaoPagamento { get; set; }
        public string statusPagamento { get; set; }
        public string statusVenda { get; set; }

        //Pedido Itens
        public string codigo { get; set; }
        public string CodigoPedido { get; set; }
        public string CodigoBarras { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public string Fabricante { get; set; }
        public string ValorProduto { get; set; }
        public string Plataforma { get; set; }
        public string Garantia { get; set; }
    }
}
