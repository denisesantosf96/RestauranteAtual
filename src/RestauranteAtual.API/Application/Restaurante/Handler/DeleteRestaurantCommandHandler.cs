using MediatR;
using RestauranteAtual.API.Application.Restaurante.Command;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Restaurante.Handler
{
    public class DeleteRestaurantCommandHandler : IRequestHandler<DeleteRestaurantCommand, bool>
    {
        private readonly IGenericRepository<Domain.Restaurante> _restauranteRepository;

        public DeleteRestaurantCommandHandler(IGenericRepository<Domain.Restaurante> restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }
        public async Task<bool> Handle(DeleteRestaurantCommand request, CancellationToken cancellationToken)
        {
            var restaurante = await _restauranteRepository.GetByKeysAsync(cancellationToken, request.Id).ConfigureAwait(false);

            _restauranteRepository.Delete(restaurante);
            return await _restauranteRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
