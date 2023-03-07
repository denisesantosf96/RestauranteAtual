using MediatR;
using RestauranteAtual.API.Application.Garcom.Query;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Garcom.Handler
{
    public class GetAllWaiterQueryHandler : IRequestHandler<GetAllWaiterQuery, IEnumerable<Domain.Garcom>>
    {
        private readonly IGenericRepository<Domain.Garcom> _garcomRepository;

        public GetAllWaiterQueryHandler(IGenericRepository<Domain.Garcom> garcomRepository)
        {
            _garcomRepository = garcomRepository;
        }

        public async Task<IEnumerable<Domain.Garcom>> Handle(GetAllWaiterQuery request, CancellationToken cancellationToken)
        {
            return await _garcomRepository.GetAllAsync(
                noTracking: true,
                cancellationToken: cancellationToken
                ).ConfigureAwait(false);
        }
    }
}
