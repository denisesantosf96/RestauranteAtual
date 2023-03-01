using MediatR;
using RestauranteAtual.API.Application.Mesa.Command;
using RestauranteAtual.Domain;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Mesa.Handler
{
    public class CreateTableCommandHandler : IRequestHandler<CreateTableCommand, bool>
    {
        private readonly IGenericRepository<Domain.Mesa> _mesaRepository;
        private readonly IGenericRepository<Domain.Restaurante> _restauranteRepository;

        public CreateTableCommandHandler(IGenericRepository<Domain.Mesa> mesaRepository,
            IGenericRepository<Domain.Restaurante> restauranteRepository)
        {
            _mesaRepository = mesaRepository;
            _restauranteRepository = restauranteRepository;
        }

        public async Task<bool> Handle(CreateTableCommand request, CancellationToken cancellationToken)
        {
            if (!request.Validation.IsValid)
            {
                return false;
            }

            var mesa = new Domain.Mesa
            {
                IdRestaurante = request.IdRestaurante,
                Localizacao = request.Localizacao,
                NumeroDaMesa = request.NumeroDaMesa
            };

            await _mesaRepository.AddAsync(mesa, cancellationToken).ConfigureAwait(false);
            return await _mesaRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
