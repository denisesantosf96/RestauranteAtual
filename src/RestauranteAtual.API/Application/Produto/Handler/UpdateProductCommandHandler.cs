using MediatR;
using RestauranteAtual.API.Application.Produto.Command;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Produto.Handler
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IGenericRepository<Domain.Produto> _produtoRepository;

        public UpdateProductCommandHandler(IGenericRepository<Domain.Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.GetByKeysAsync(cancellationToken, request.Id).ConfigureAwait(false);

            produto.Nome = request.Nome;
            produto.ValorUnitario = request.ValorUnitario;

            _produtoRepository.Update(produto);
            return await _produtoRepository.CommitAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
