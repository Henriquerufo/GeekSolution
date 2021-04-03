using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelEntradaProduto
    {
        public int  Codigo { get; set; }
        public string CodigoBarras { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public string Fabricante { get; set; }
        public string Quantidade { get; set; }
        public string ValorProduto { get; set; }
        public string Plataforma { get; set; }
        public string Garantia { get; set; }
        public string NomeEmpresa { get; set; }
        public string Estoquista { get; set; }
        public string DataRecebido { get; set; }
        public string QuantidadeItens { get; set; }
        public int CodigoEntradaProduto { get; set; }
    }
}
