using MediatR;

namespace RestauranteAtual.API.Application.Cliente.Command
{
    public class DeleteClientCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
