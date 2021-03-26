using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelTicket
    {
        public int Codigo { get; set; }
        public string GeradoPor { get; set; }
        public string Vendedor { get; set; }
        public string Data { get; set; }
        public string Valor { get; set; }
        public string Status { get; set; }
    }
}
