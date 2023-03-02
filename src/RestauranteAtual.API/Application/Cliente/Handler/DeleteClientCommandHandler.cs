using MediatR;
using RestauranteAtual.API.Application.Cliente.Command;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Cliente.Handler
{
    public class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand, bool>
    {
        private readonly IGenericRepository<Domain.Cliente> _clienteRepository;

        public DeleteClientCommandHandler(IGenericRepository<Domain.Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<bool> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            var cliente = await _clienteRepository.GetByKeysAsync(cancellationToken, request.Id).ConfigureAwait(false);

            _clienteRepository.Delete(cliente);
            return await _clienteRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
