using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestauranteAtual.API.Application.Cliente.Command;
using RestauranteAtual.API.Application.Cliente.Query;

namespace RestauranteAtual.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IMediator _mediator;

        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllClient(CancellationToken cancellationToken)
        {
            var clientes = await _mediator.Send(new GetAllClientQuery(), cancellationToken)
                .ConfigureAwait(false);
            return clientes.Any() ? Ok(clientes) : NoContent();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> Create(CreateClientCommand createClientCommand, CancellationToken cancellationToken)
        {
            if (!createClientCommand.Validation.IsValid)
            {
                return BadRequest(createClientCommand.Validation.Errors);
            }

            var sucesso = await _mediator.Send(createClientCommand, cancellationToken)
                .ConfigureAwait(false);

            return Ok(sucesso);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Update(UpdateClientCommand updateClientCommand, CancellationToken cancellationToken)
        {
            var sucesso = await _mediator.Send(updateClientCommand, cancellationToken).ConfigureAwait(false);

            return Ok(sucesso);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(DeleteClientCommand deleteClientCommand, CancellationToken cancellationToken)
        {
            var sucesso = await _mediator.Send(deleteClientCommand, cancellationToken).ConfigureAwait(false);

            return Ok(sucesso);
        }

    }
}
