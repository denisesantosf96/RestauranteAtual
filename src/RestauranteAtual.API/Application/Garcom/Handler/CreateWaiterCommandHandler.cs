using MediatR;
using RestauranteAtual.API.Application.Garcom.Comand;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Garcom.Handler
{
    public class CreateWaiterCommandHandler : IRequestHandler<CreateWaiterCommand, bool>
    {
        private readonly IGenericRepository<Domain.Garcom> _garcomRepository;

        public CreateWaiterCommandHandler(IGenericRepository<Domain.Garcom> garcomRepository)
        {
            _garcomRepository = garcomRepository;
        }

        public async Task<bool> Handle(CreateWaiterCommand request, CancellationToken cancellationToken)
        {
            if (!request.Validation.IsValid)
            {
                return false;
            }

            var garcom = new Domain.Garcom
            {
                Nome = request.Nome,
                Idade = request.Idade,
                DataAdmissao = request.DataAdmissao
            };

            await _garcomRepository.AddAsync(garcom, cancellationToken)
                .ConfigureAwait(false);

            return await _garcomRepository.CommitAsync(cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
