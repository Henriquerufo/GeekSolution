using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelDevolucaoPedido
    {
        public string Codigo { get; set; }
        public string CodigoBarras { get; set; }
        public string CodigoPedido { get; set; }
        public string statusPegamento { get; set; }
        public string statusVenda { get; set; }
        public string Ticket { get; set; }
        public string DataTicket { get; set; }
    }
}
