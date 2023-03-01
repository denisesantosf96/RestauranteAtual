using MediatR;

namespace RestauranteAtual.API.Application.Mesa.Command
{
    public class UpdateTableCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int IdRestaurante { get; set; }
        public string Localizacao { get; set; }
        public int NumeroDaMesa { get; set; }
    }
}
