using MediatR;
using RestauranteAtual.API.Application.Produto.Command;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Produto.Handler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IGenericRepository<Domain.Produto> _produtoRepository;

        public CreateProductCommandHandler(IGenericRepository<Domain.Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            if (!request.Validation.IsValid)
            {
                return false;
            }

            var produto = new Domain.Produto
            {
                Nome = request.Nome,
                ValorUnitario = request.ValorUnitario
            };

            await _produtoRepository.AddAsync(produto, cancellationToken)
                .ConfigureAwait(false);

            return await _produtoRepository.CommitAsync(cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
