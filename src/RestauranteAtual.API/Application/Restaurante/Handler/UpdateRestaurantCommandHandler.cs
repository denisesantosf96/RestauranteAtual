using MediatR;
using RestauranteAtual.API.Application.Restaurante.Command;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Restaurante.Handler
{
    public class UpdateRestaurantCommandHandler : IRequestHandler<UpdateRestaurantCommand, bool>
    {
        private readonly IGenericRepository<Domain.Restaurante> _restauranteRepository;

        public UpdateRestaurantCommandHandler(IGenericRepository<Domain.Restaurante> restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        public async Task<bool> Handle(UpdateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var restaurante = await _restauranteRepository.GetByKeysAsync(cancellationToken, request.Id).ConfigureAwait(false);

            restaurante.Nome = request.Nome;
            restaurante.CNPJ = request.CNPJ;
            restaurante.Telefone = request.Telefone;
            restaurante.HorarioFuncionamento = request.HorarioFuncionamento;
            restaurante.QuantidadeMaxima = request.QuantidadeMaxima;
            restaurante.Endereco = request.Endereco;
            restaurante.Numero = request.Numero;
            restaurante.Bairro = request.Bairro;
            restaurante.Cidade = request.Cidade;
            restaurante.Estado = request.Estado;
            restaurante.Pais = request.Pais;
            restaurante.CEP = request.CEP;
            restaurante.QuantidadeMesa = request.QuantidadeMesa;

            _restauranteRepository.Update(restaurante);
            return await _restauranteRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
