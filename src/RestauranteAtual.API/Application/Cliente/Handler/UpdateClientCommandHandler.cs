using MediatR;
using RestauranteAtual.API.Application.Cliente.Command;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Cliente.Handler
{
    public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, bool>
    {
        private readonly IGenericRepository<Domain.Cliente> _clienteRepository;

        public UpdateClientCommandHandler(IGenericRepository<Domain.Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<bool> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var cliente = await _clienteRepository.GetByKeysAsync(cancellationToken, request.Id).ConfigureAwait(false);

            cliente.Nome = request.Nome;
            cliente.CPF = request.CPF;
            cliente.RG = request.RG;
            cliente.Telefone = request.Telefone;
            cliente.Endereco = request.Endereco;
            cliente.Numero = request.Numero;
            cliente.Bairro = request.Bairro;
            cliente.Cidade = request.Cidade;
            cliente.Estado = request.Estado;
            cliente.Pais = request.Pais;
            cliente.CEP = request.CEP;
            cliente.Genero = request.Genero;
            cliente.DataNascimento = request.DataNascimento;

            _clienteRepository.Update(cliente);
            return await _clienteRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
