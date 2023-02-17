using MediatR;

namespace RestauranteAtual.API.Application.Restaurante.Query
{
    public class GetAllRestaurantQuery : IRequest<IEnumerable<Domain.Restaurante>>
    {
    }
}
