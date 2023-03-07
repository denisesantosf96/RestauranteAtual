using MediatR;
using RestauranteAtual.API.Application.Garcom.Comand;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Garcom.Handler
{
    public class UpdateWaiterCommandHandler : IRequestHandler<UpdateWaiterCommand, bool>
    {
        private readonly IGenericRepository<Domain.Garcom> _garcomRepository;

        public UpdateWaiterCommandHandler(IGenericRepository<Domain.Garcom> garcomRepository)
        {
            _garcomRepository = garcomRepository;
        }

        public async Task<bool> Handle(UpdateWaiterCommand request, CancellationToken cancellationToken)
        {
            var garcom = await _garcomRepository.GetByKeysAsync(cancellationToken, request.Id).ConfigureAwait(false);

            garcom.Nome = request.Nome;
            garcom.Idade = request.Idade;
            garcom.DataAdmissao = request.DataAdmissao;

            _garcomRepository.Update(garcom);
            return await _garcomRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
