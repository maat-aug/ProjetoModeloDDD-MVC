using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia.Domain.Entities._Base
{
    public class EntityBase
    {
        public string Nome { get; set; } = string.Empty;
        public long Id { get; set; }
        public int Idade { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
}
