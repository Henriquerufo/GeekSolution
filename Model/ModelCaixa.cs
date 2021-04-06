using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelCaixa
    {
        public int Codigo { get; set; }
        public int CodigoPedido { get; set; }
        public string CodigoBarras { get; set; }
        public string NomeCliente { get; set; }
        public string Vendedor { get; set; }
        public string RecebidoPor { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public string Fabricante { get; set; }
        public string ValorProduto { get; set; }
        public string Plataforma { get; set; }
        public string DataVenda { get; set; }
        public string DataRecebimento { get; set; }
        public string Garantia { get; set; }
        public string ValorVenda { get; set; }
        public string OpcaoPagamento { get; set; }
        public string Dinheiro { get; set; }
        public string Cartao { get; set; }
        public string Conveniado { get; set; }
        public string Ticket { get; set; }
        public decimal valorTicketPago { get; set; }
        public string CodigoTicket { get; set; }
        public string Cheque { get; set; }
        public string ChequeDias { get; set; }
        public string StatusPagamento { get; set; }
        public string StatusVenda { get; set; }

    }
}
