
using System.Collections.Generic;
using ProjetoModeloDDD.Aplication.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Aplication
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }


        public IEnumerable<Produto> BuscarProdutoPorNome(string nome) 
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
