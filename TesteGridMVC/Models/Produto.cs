using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteGridMVC.Models
{
    public class Produto
    {
        public Int64 Id { set; get; }
        public string Nome { set; get; }
        public string Descricao { set; get; }
        public DateTime DataInclusao { set; get; }
        public DateTime DataAlteracao { set; get; }
        public Double ValorCompra { set; get; }

    }
}
