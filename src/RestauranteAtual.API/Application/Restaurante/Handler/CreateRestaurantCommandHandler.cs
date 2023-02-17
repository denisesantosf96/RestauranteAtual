using MediatR;
using RestauranteAtual.API.Application.Restaurante.Command;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Restaurante.Handler
{
    public class CreateRestaurantCommandHandler : IRequestHandler<CreateRestaurantCommand, bool>
    {
        private readonly IGenericRepository<Domain.Restaurante> _restauranteRepository;

        public CreateRestaurantCommandHandler(IGenericRepository<Domain.Restaurante> restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        public async Task<bool> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
        {
            if (!request.Validation.IsValid)
            {
                return false;
            }

            var restaurante = new Domain.Restaurante
            {
                Nome = request.Nome,
                CNPJ = request.CNPJ,
                Telefone = request.Telefone,
                HorarioFuncionamento = request.HorarioFuncionamento,
                QuantidadeMaxima = request.QuantidadeMaxima,
                Endereco = request.Endereco,
                Numero = request.Numero,
                Bairro = request.Bairro,
                Cidade = request.Cidade,
                Estado = request.Estado,
                Pais = request.Pais,
                CEP = request.CEP,
                QuantidadeMesa = request.QuantidadeMesa
            };

            await _restauranteRepository.AddAsync(restaurante, cancellationToken)
                .ConfigureAwait(false);

            return await _restauranteRepository.CommitAsync(cancellationToken)
                .ConfigureAwait(false);

        }
    }
}
