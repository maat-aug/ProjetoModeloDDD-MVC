using Barbearia.Domain.Communication;
using Barbearia.Domain.Entities;
using Barbearia.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Barbearia.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ReponseCreatedClienteJson), StatusCodes.Status201Created)]
        public IActionResult Create(
            [FromBody] RequestClienteJson request,
            [FromServices] IClienteService service)
        {
            var cliente = service.Add(request);
            ReponseCreatedClienteJson response = cliente;
            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ReponseCreatedClienteJson), StatusCodes.Status200OK)]
        public IActionResult GetAll(
        [FromServices] IClienteService service)
        {
            var response = service.GetAll();
            return Ok(response);
        }

        [HttpGet]
        [Route("{searchId}/GetById")]
        [ProducesResponseType(typeof(ReponseCreatedClienteJson), StatusCodes.Status200OK)]
        public IActionResult GetById(
        [FromRoute] long searchId,
        [FromServices] IClienteService service)
        {
            var response = service.GetById(searchId);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpDelete]
        [Route("{searchId}/Delete")]
        public IActionResult Delete(
        [FromRoute] long searchId,
        [FromServices] IClienteService service)
        {
            var sistemaGrupo = service.GetById(searchId);
            if (sistemaGrupo == null)
            {
                return NotFound();
            }

            service.Delete(sistemaGrupo);
            return NoContent();
        }
        [HttpPut]
        [Route("{searchId}/Update")]
        [ProducesResponseType(typeof(ReponseCreatedClienteJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Update(
    [FromRoute] long searchId,
    [FromBody] RequestClienteJson request,
    [FromServices] IClienteService service)
        {
            var existingCliente = service.GetById(searchId);
            if (existingCliente == null)
                return NotFound();

            Cliente updated = request;
            updated.Id = existingCliente.Id;

            var result = service.Update(updated, existingCliente);
            ReponseCreatedClienteJson response = result;
            return Ok(response);
        }




    }
}
