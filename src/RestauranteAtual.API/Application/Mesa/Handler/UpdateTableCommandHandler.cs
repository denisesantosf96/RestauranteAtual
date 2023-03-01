using MediatR;
using RestauranteAtual.API.Application.Mesa.Command;
using RestauranteAtual.Infrastructure.Data;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Mesa.Handler
{
    public class UpdateTableCommandHandler : IRequestHandler<UpdateTableCommand, bool>
    {
        private readonly IGenericRepository<Domain.Mesa> _genericRepository;
        //private readonly IGenericRepository<Domain.Restaurante> _restauranteRepository;

        public UpdateTableCommandHandler(IGenericRepository<Domain.Mesa> genericRepository,
            IGenericRepository<Domain.Restaurante> restauranteRepository)
        {
            _genericRepository = genericRepository;
           // _restauranteRepository = restauranteRepository;
        }

        public async Task<bool> Handle(UpdateTableCommand request, CancellationToken cancellationToken)
        {            
           // var restaurante = await _restauranteRepository.GetByKeysAsync(cancellationToken, request.IdRestaurante) 
              //  ?? throw new ArgumentException("IdRestaurante inválido!");

            var mesa = await _genericRepository.GetByKeysAsync(cancellationToken, request.Id).ConfigureAwait(false);

            mesa.IdRestaurante = request.IdRestaurante;
            mesa.Localizacao = request.Localizacao;
            mesa.NumeroDaMesa = request.NumeroDaMesa;
           
            _genericRepository.Update(mesa);
            return await _genericRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
