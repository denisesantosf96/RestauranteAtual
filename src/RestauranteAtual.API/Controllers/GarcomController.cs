using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestauranteAtual.API.Application.Garcom.Comand;
using RestauranteAtual.API.Application.Garcom.Query;

namespace RestauranteAtual.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GarcomController : Controller
    {
        private readonly IMediator _mediator;

        public GarcomController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllClient(CancellationToken cancellationToken)
        {
            var garcons = await _mediator.Send(new GetAllWaiterQuery(), cancellationToken)
                .ConfigureAwait(false);
            return garcons.Any() ? Ok(garcons) : NoContent();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> Create(CreateWaiterCommand createWaiterCommand, CancellationToken cancellationToken)
        {
            if (!createWaiterCommand.Validation.IsValid)
            {
                return BadRequest(createWaiterCommand.Validation.Errors);
            }

            var sucesso = await _mediator.Send(createWaiterCommand, cancellationToken)
                .ConfigureAwait(false);

            return Ok(sucesso);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Update(UpdateWaiterCommand updateWaiterCommand, CancellationToken cancellationToken)
        {
            var sucesso = await _mediator.Send(updateWaiterCommand, cancellationToken).ConfigureAwait(false);

            return Ok(sucesso);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(DeleteWaiterCommand deleteWaiterCommand, CancellationToken cancellationToken)
        {
            var sucesso = await _mediator.Send(deleteWaiterCommand, cancellationToken).ConfigureAwait(false);

            return Ok(sucesso);
        }
    }
}
