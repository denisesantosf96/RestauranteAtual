using MediatR;

namespace RestauranteAtual.API.Application.Garcom.Comand
{
    public class UpdateWaiterCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime? DataAdmissao { get; set; }
    }
}
