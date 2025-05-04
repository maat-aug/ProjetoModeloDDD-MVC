using Barbearia.Domain.Entities;
using Barbearia.Domain.Interfaces.Repositories;
using Barbearia.Infra.Data.Context;
using Barbearia.Infra.Data.Repositories._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia.Infra.Data.Repositories
{
    public class BarbeiroRepository : RepositoryBase<Barbeiro>, IBarbeiroRepository
    {
        public BarbeiroRepository(BarbeariaContext context) 
            : base(context)
        {
        }
    }
}
