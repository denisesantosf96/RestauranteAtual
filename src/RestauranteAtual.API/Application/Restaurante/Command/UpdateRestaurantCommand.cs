using MediatR;

namespace RestauranteAtual.API.Application.Restaurante.Command
{
    public class UpdateRestaurantCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Pais { get; set; }

        public string CEP { get; set; }

        public string HorarioFuncionamento { get; set; }

        public string QuantidadeMaxima { get; set; }

        public int QuantidadeMesa { get; set; }
    }
}
