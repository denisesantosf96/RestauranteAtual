using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestauranteAtual.API.Application.Mesa.Command;
using RestauranteAtual.API.Application.Mesa.Query;

namespace RestauranteAtual.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MesaController : Controller
    {
        private readonly IMediator _mediator;

        public MesaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllTable(CancellationToken cancellationToken)
        {
            var mesas = await _mediator.Send(new GetAllTableQuery(), cancellationToken)
                .ConfigureAwait(false);
            return mesas.Any() ? Ok(mesas) : NoContent();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> Create(CreateTableCommand createTableCommand, CancellationToken cancellationToken)
        {
            if (!createTableCommand.Validation.IsValid)
            {
                return BadRequest(createTableCommand.Validation.Errors);
            }

            var sucesso = await _mediator.Send(createTableCommand, cancellationToken)
                .ConfigureAwait(false);

            return Ok(sucesso);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Update(UpdateTableCommand updateTableCommand, CancellationToken cancellationToken)
        {
            var sucesso = await _mediator.Send(updateTableCommand, cancellationToken).ConfigureAwait(false);

            return Ok(sucesso);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(DeleteTableCommand deleteTableCommand, CancellationToken cancellationToken)
        {
            var sucesso = await _mediator.Send(deleteTableCommand, cancellationToken).ConfigureAwait(false);

            return Ok(sucesso);
        }
    }
}
