using MediatR;

namespace RestauranteAtual.API.Application.Produto.Query
{
    public class GetAllProductQuery : IRequest<IEnumerable<Domain.Produto>>
    {
    }
}
