using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestauranteAtual.API.Application.Produto.Command;
using RestauranteAtual.API.Application.Produto.Query;

namespace RestauranteAtual.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IMediator _mediator;

        public ProdutoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllClient(CancellationToken cancellationToken)
        {
            var produtos = await _mediator.Send(new GetAllProductQuery(), cancellationToken)
                .ConfigureAwait(false);
            return produtos.Any() ? Ok(produtos) : NoContent();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> Create(CreateProductCommand createProductCommand, CancellationToken cancellationToken)
        {
            if (!createProductCommand.Validation.IsValid)
            {
                return BadRequest(createProductCommand.Validation.Errors);
            }

            var sucesso = await _mediator.Send(createProductCommand, cancellationToken)
                .ConfigureAwait(false);

            return Ok(sucesso);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Update(UpdateProductCommand updateProductCommand, CancellationToken cancellationToken)
        {
            var sucesso = await _mediator.Send(updateProductCommand, cancellationToken).ConfigureAwait(false);

            return Ok(sucesso);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(DeleteProductCommand deleteProductCommand, CancellationToken cancellationToken)
        {
            var sucesso = await _mediator.Send(deleteProductCommand, cancellationToken).ConfigureAwait(false);

            return Ok(sucesso);
        }
    }
}
