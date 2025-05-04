using Barbearia.Domain.Entities;
using Barbearia.Domain.Interfaces.Repositories;
using Barbearia.Infra.Data.Context;
using Barbearia.Infra.Data.Repositories._Base;

namespace Barbearia.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(BarbeariaContext context) 
            : base(context)
        {
        }
    }
}
