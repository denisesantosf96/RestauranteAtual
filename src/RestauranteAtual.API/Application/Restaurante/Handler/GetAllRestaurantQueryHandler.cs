using MediatR;
using RestauranteAtual.API.Application.Restaurante.Query;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Restaurante.Handler
{
    public class GetAllRestaurantQueryHandler : IRequestHandler<GetAllRestaurantQuery, IEnumerable<Domain.Restaurante>>
    {
        private readonly IGenericRepository<Domain.Restaurante> _restauranteRepository;

        public GetAllRestaurantQueryHandler(IGenericRepository<Domain.Restaurante> restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }
        public async Task<IEnumerable<Domain.Restaurante>> Handle(GetAllRestaurantQuery request, CancellationToken cancellationToken)
        {
            return await _restauranteRepository.GetAllAsync(
                noTracking: true,
                cancellationToken: cancellationToken
                ).ConfigureAwait(false);
        }
    }
}
