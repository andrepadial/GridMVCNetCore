using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteGridMVC.Models;

namespace TesteGridMVC.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        List<Produto> ObterProdutos();

        int ObterQtdProdutos();

        List<Produto> ObterProdutosPaginado(int? page, int pageSize);
    }
}
