using MediatR;

namespace RestauranteAtual.API.Application.Mesa.Command
{
    public class DeleteTableCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
