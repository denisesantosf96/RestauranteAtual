using MediatR;
using RestauranteAtual.API.Application.Mesa.Command;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Mesa.Handler
{
    public class DeleteTableCommandHandler : IRequestHandler<DeleteTableCommand, bool>
    {
        private readonly IGenericRepository<Domain.Mesa> _mesaRepository;

        public DeleteTableCommandHandler(IGenericRepository<Domain.Mesa> mesaRepository)
        {
            _mesaRepository = mesaRepository;
        }

        public async Task<bool> Handle(DeleteTableCommand request, CancellationToken cancellationToken)
        {
            var mesa = await _mesaRepository.GetByKeysAsync(cancellationToken, request.Id).ConfigureAwait(false);

            _mesaRepository.Delete(mesa);
            return await _mesaRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
