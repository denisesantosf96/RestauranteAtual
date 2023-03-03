using MediatR;
using RestauranteAtual.API.Application.Produto.Query;
using RestauranteAtual.Infrastructure.Data.Contract;

namespace RestauranteAtual.API.Application.Produto.Handler
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, IEnumerable<Domain.Produto>>
    {
        private readonly IGenericRepository<Domain.Produto> _produtoRepository;

        public GetAllProductQueryHandler(IGenericRepository<Domain.Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IEnumerable<Domain.Produto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _produtoRepository.GetAllAsync(
                noTracking: true,
                cancellationToken: cancellationToken
                ).ConfigureAwait(false);
        }
    }
}
