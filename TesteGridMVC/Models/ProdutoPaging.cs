using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace TesteGridMVC.Models
{
    public class ProdutoPaging
    {
        public int? pageSize { set; get; }
        public StaticPagedList<Produto> Produtos { set; get; }
    }
}
