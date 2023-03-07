using MediatR;

namespace RestauranteAtual.API.Application.Garcom.Comand
{
    public class DeleteWaiterCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
