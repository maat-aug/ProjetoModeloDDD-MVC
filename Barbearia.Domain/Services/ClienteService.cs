using Barbearia.Domain.Entities;
using Barbearia.Domain.Interfaces.Repositories._Base;
using Barbearia.Domain.Interfaces.Services;
using Barbearia.Domain.Services._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        public ClienteService(IRepositoryBase<Cliente> repository) 
            : base(repository)
        {
        }
    }
}
