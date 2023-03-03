using MediatR;

namespace RestauranteAtual.API.Application.Produto.Command
{
    public class UpdateProductCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
