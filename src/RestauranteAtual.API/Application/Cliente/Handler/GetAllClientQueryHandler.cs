using MediatR;
using RestauranteAtual.API.Application.Cliente.Query;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Cliente.Handler
{
    public class GetAllClientQueryHandler : IRequestHandler<GetAllClientQuery, IEnumerable<Domain.Cliente>>
    {
        private readonly IGenericRepository<Domain.Cliente> _clienteRepository;

        public GetAllClientQueryHandler(IGenericRepository<Domain.Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Domain.Cliente>> Handle(GetAllClientQuery request, CancellationToken cancellationToken)
        {
            return await _clienteRepository.GetAllAsync(
                noTracking: true,
                cancellationToken: cancellationToken
                ).ConfigureAwait(false);
        }
    }
}
