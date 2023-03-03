using MediatR;

namespace RestauranteAtual.API.Application.Produto.Command
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
