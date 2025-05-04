using Barbearia.Domain.Communication;
using Barbearia.Domain.Entities._Base;

namespace Barbearia.Domain.Entities
{
    public class Cliente : EntityBase
    {
        // Nome, Id, Idade, Criado Em está na EntityBase
        public string Email { get; set; } = string.Empty;

                public static implicit operator Cliente(RequestClienteJson request)
        {
            return new Cliente
            {
                Nome = request.Nome,
                Idade = request.Idade,
                Email = request.Email,
                

            };
        }

        public static implicit operator ReponseCreatedClienteJson(Cliente cliente)
        {
            return new ReponseCreatedClienteJson
            {
                Id = cliente.Id,
                Nome = cliente.Nome
            };
        }

    }
}