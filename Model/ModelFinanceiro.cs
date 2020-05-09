using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelFinanceiro
    {
        public string Codigo { get; set; }
        public string nomeCliente { get; set; }
        public string dataVenda { get; set; }
        public string valorVenda { get; set; }
        public string opcaoPagamento { get; set; }
        public string statusPagamento { get; set; }
        public string statusVenda { get; set; }
    }
}
