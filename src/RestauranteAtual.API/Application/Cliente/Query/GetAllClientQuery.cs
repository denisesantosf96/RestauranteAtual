using MediatR;

namespace RestauranteAtual.API.Application.Cliente.Query
{
    public class GetAllClientQuery : IRequest<IEnumerable<Domain.Cliente>>
    {
    }
}