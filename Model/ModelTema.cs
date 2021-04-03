using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelTema
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string EnderecoImagemFundo { get; set; }
        public string ImagemEndereco { get; set; }
        public string R { get; set; }
        public string G { get; set; }
        public string B { get; set; }
        public bool status { get; set; }
        public bool Consultar { get; set; }
    }
}
