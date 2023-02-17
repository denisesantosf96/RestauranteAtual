using MediatR;

namespace RestauranteAtual.API.Application.Restaurante.Command
{
    public class DeleteRestaurantCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
