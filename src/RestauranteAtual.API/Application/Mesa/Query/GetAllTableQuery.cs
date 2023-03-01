using MediatR;

namespace RestauranteAtual.API.Application.Mesa.Query
{
    public class GetAllTableQuery : IRequest<IEnumerable<Domain.Mesa>>
    {
    }
}
