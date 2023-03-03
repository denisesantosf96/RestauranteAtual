using MediatR;
using RestauranteAtual.API.Application.Cliente.Validation;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using Newtonsoft.Json;
using FluentValidation.Results;
using RestauranteAtual.API.Application.Produto.Validation;

namespace RestauranteAtual.API.Application.Produto.Command
{
    public class CreateProductCommand : IRequest<bool>
    {
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }

        [JsonIgnore]
        public ValidationResult Validation { get; }

        public CreateProductCommand(string nome, decimal valorUnitario)
        {
            Nome = nome;
            ValorUnitario = valorUnitario;

            var validator = new CreateProductCommandValidator();
            Validation = validator.Validate(this);
        }
    }
}
