using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelCadastroProduto
    {
        public string Codigo { get; set; }
        public string CodigoBarras { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public string Fabricante { get; set; }
        public string Quantidade { get; set; }
        public string ValorProduto { get; set; }
        public string Plataforma { get; set; }
        public string Garantia { get; set; }
        public bool Consultar { get; set; }
        public string NomeEmpresa { get; set; }
    }
}
