using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelEmpresa
    {
        public int Codigo { get; set; }
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }
        public string DataCadastro { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public bool Consultar { get; set; }
        public bool Cadasrar { get; set; }
        public bool Editar { get; set; }
    }
}
