using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelFechamento
    {
        public string Vendedor { get; set; }
        public string Data { get; set; }
        public string ValorTotalVendido { get; set; }
        public string ValorTotalRecebido { get; set; }
        public string PedidosFinalizados { get; set; }
        public string ItensRecebidos { get; set; }
        public string Dinheiro { get; set; }
        public string Cartao { get; set; }
        public string Conveniado { get; set; }
        public string ValorSaida { get; set; }
        public string Cheque { get; set; }
        public string ValorCaixa { get; set; }
    }
}
