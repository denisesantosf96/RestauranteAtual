using MediatR;
using RestauranteAtual.API.Application.Garcom.Comand;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Garcom.Handler
{
    public class DeleteWaiterCommandHandler : IRequestHandler<DeleteWaiterCommand, bool>
    {
        private readonly IGenericRepository<Domain.Garcom> _garcomRepository;

        public DeleteWaiterCommandHandler(IGenericRepository<Domain.Garcom> garcomRepository)
        {
            _garcomRepository = garcomRepository;
        }

        public async Task<bool> Handle(DeleteWaiterCommand request, CancellationToken cancellationToken)
        {
            var garcom = await _garcomRepository.GetByKeysAsync(cancellationToken, request.Id).ConfigureAwait(false);

            _garcomRepository.Delete(garcom);
            return await _garcomRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
