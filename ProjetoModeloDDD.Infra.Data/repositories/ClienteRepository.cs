

using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Infra.Data.repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {

    }
}
