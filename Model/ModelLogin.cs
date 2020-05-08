using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelLogin
    {
        public string Codigo { get; set; }
        public string ID { get; set; }
        public string Senha { get; set; }
        public string Nivel { get; set; }
        public bool Consultar { get; set; }
    }
}
