using MediatR;
using RestauranteAtual.API.Application.Cliente.Command;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Cliente.Handler
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, bool>
    {
        private readonly IGenericRepository<Domain.Cliente> _clienteRepository;

        public CreateClientCommandHandler(IGenericRepository<Domain.Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<bool> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            if (!request.Validation.IsValid)
            {
                return false;
            }

            var cliente = new Domain.Cliente
            {
                    Nome = request.Nome,
                    CPF = request.CPF,
                    RG = request.RG,
                    Telefone = request.Telefone,
                    Endereco = request.Endereco,
                    Numero = request.Numero,
                    Bairro = request.Bairro,
                    Cidade = request.Cidade,
                    Estado = request.Estado,
                    Pais = request.Pais,
                    CEP = request.CEP,
                    Genero = request.Genero,
                    DataNascimento = request.DataNascimento
            };

                await _clienteRepository.AddAsync(cliente, cancellationToken)
                    .ConfigureAwait(false);

                return await _clienteRepository.CommitAsync(cancellationToken)
                    .ConfigureAwait(false);             
        }
    }
}