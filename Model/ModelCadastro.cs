using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelCadastro
    {
        public string Codigo { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string dtCadastro { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool consulta { get; set; }
    }
}
