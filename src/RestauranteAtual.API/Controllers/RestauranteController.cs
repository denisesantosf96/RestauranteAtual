using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestauranteAtual.API.Application.Restaurante.Command;
using RestauranteAtual.API.Application.Restaurante.Query;

namespace RestauranteAtual.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestauranteController : Controller
    {
        private readonly IMediator _mediator;

        public RestauranteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllRestaurant(CancellationToken cancellationToken)
        {
            var restaurantes = await _mediator.Send(new GetAllRestaurantQuery(), cancellationToken)
                .ConfigureAwait(false);
            return restaurantes.Any() ? Ok(restaurantes) : NoContent();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> Create(CreateRestaurantCommand createRestaurantCommand, CancellationToken cancellationToken)
        {
            if (!createRestaurantCommand.Validation.IsValid)
            {
                return BadRequest(createRestaurantCommand.Validation.Errors);
            }

            var sucesso = await _mediator.Send(createRestaurantCommand, cancellationToken)
                .ConfigureAwait(false);

            return Ok(sucesso);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Update(UpdateRestaurantCommand updateRestaurantCommand, CancellationToken cancellationToken)
        {
            var sucesso = await _mediator.Send(updateRestaurantCommand, cancellationToken).ConfigureAwait(false);

            return Ok(sucesso);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(DeleteRestaurantCommand deleteRestaurantCommand, CancellationToken cancellationToken)
        {
            var sucesso = await _mediator.Send(deleteRestaurantCommand, cancellationToken).ConfigureAwait(false);

            return Ok(sucesso);
        }
    }
}
