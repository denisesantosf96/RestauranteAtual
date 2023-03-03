using MediatR;
using RestauranteAtual.API.Application.Produto.Command;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Produto.Handler
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IGenericRepository<Domain.Produto> _produtoRepository;

        public DeleteProductCommandHandler(IGenericRepository<Domain.Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.GetByKeysAsync(cancellationToken, request.Id).ConfigureAwait(false);

            _produtoRepository.Delete(produto);
            return await _produtoRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
