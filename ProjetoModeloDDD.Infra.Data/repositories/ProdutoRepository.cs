

using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Infra.Data.repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {

        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
