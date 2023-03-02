using FluentValidation.Results;
using MediatR;
using Newtonsoft.Json;
using RestauranteAtual.API.Application.Cliente.Validation;

namespace RestauranteAtual.API.Application.Cliente.Command
{
    public class CreateClientCommand : IRequest<bool>
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public decimal Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string CEP { get; set; }
        public string Genero { get; set; }
        public DateTime? DataNascimento { get; set; }

        [JsonIgnore]
        public ValidationResult Validation { get; }

        public CreateClientCommand(string nome, string cpf, string rg, string telefone, string endereco, int numero, string bairro, string cidade,
            string estado, string pais, string cep, string genero, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cpf;
            RG = rg;
            Telefone = telefone;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            CEP = cep;
            Genero = genero;
            DataNascimento = dataNascimento;

            var validator = new CreateClientCommandValidator();
            Validation = validator.Validate(this);
        }
    }
}
