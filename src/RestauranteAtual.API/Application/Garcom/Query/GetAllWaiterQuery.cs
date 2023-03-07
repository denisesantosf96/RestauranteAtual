using MediatR;

namespace RestauranteAtual.API.Application.Garcom.Query
{
    public class GetAllWaiterQuery : IRequest<IEnumerable<Domain.Garcom>>
    {
    }
}
