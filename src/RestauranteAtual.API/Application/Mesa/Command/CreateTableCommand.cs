using FluentValidation.Results;
using MediatR;
using Newtonsoft.Json;
using RestauranteAtual.API.Application.Mesa.Validation;

namespace RestauranteAtual.API.Application.Mesa.Command
{
    public class CreateTableCommand : IRequest<bool>
    {
        public int IdRestaurante { get; set; }
        public string Localizacao { get; set; }
        public int NumeroDaMesa { get; set; }

        [JsonIgnore]
        public ValidationResult Validation { get; }

        public CreateTableCommand(int idRestaurante, string localizacao, int numeroDaMesa)
        {
            IdRestaurante = idRestaurante;
            Localizacao = localizacao;
            NumeroDaMesa = numeroDaMesa;

            var validator = new CreateTableCommandValidator();
            Validation = validator.Validate(this);
        }
    }
}