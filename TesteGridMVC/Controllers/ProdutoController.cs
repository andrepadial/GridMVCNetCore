using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteGridMVC.Models;
using TesteGridMVC.Repository.Interfaces;
using X.PagedList;


namespace TesteGridMVC.Controllers
{
    public class ProdutoController : Controller
    {

        IProdutoRepository repository;

        public ProdutoController(IProdutoRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult Produto(int? page = 1)
        {
            ProdutoPaging produto = new ProdutoPaging();

            if (page < 0)
                page = 1;

            var pageIndex = (page ?? 1) - 1;
            var pageSize = 10;

            var total = repository.ObterQtdProdutos();
            var produtos = repository.ObterProdutosPaginado(page, pageSize).ToList();
            var produtosPaginados = new StaticPagedList<Produto>(produtos, pageIndex + 1, pageSize, total);

            produto.pageSize = pageSize;
            produto.Produtos = produtosPaginados;

            return View(produto);

        }

        
    }
}