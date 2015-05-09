

using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Infra.Data.repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {

    }
}
