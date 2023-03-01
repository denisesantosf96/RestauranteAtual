using MediatR;
using RestauranteAtual.API.Application.Mesa.Query;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Mesa.Handler
{
    public class GetAllTableQueryHandler : IRequestHandler<GetAllTableQuery, IEnumerable<Domain.Mesa>>
    {
        private readonly IGenericRepository<Domain.Mesa> _mesaRepository;

        public GetAllTableQueryHandler(IGenericRepository<Domain.Mesa> mesaRepository)
        {
            _mesaRepository = mesaRepository;
        }

        public async Task<IEnumerable<Domain.Mesa>> Handle(GetAllTableQuery request, CancellationToken cancellationToken)
        {
            return await _mesaRepository.GetAllAsync(
                noTracking: true,
                includeProperties: "Restaurantes",
                cancellationToken: cancellationToken
                ).ConfigureAwait(false);
        }
    }
}
