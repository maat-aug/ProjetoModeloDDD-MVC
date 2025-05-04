using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia.Communication.Request.Cliente
{
    public class RequestCreatedClienteJson
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}
