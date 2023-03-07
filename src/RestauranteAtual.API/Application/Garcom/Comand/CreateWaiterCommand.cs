using MediatR;
using RestauranteAtual.API.Application.Cliente.Validation;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using Newtonsoft.Json;
using FluentValidation.Results;
using RestauranteAtual.API.Application.Garcom.Validation;

namespace RestauranteAtual.API.Application.Garcom.Comand
{
    public class CreateWaiterCommand : IRequest<bool>
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime? DataAdmissao { get; set; }

        [JsonIgnore]
        public ValidationResult Validation { get; }

        public CreateWaiterCommand(string nome, int idade, DateTime dataAdmissao)
        {
            Nome = nome;
            Idade = idade;
            DataAdmissao = dataAdmissao;

            var validator = new CreateWaiterCommandValidator();
            Validation = validator.Validate(this);
        }
    }
}
