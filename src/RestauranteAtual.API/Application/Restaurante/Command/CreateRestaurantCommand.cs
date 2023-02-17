using FluentValidation.Results;
using MediatR;
using Newtonsoft.Json;
using RestauranteAtual.API.Application.Restaurante.Validation;

namespace RestauranteAtual.API.Application.Restaurante.Command
{
    public class CreateRestaurantCommand : IRequest<bool>
    {
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

        [JsonIgnore]
        public ValidationResult Validation { get; }

        public CreateRestaurantCommand(string nome, string cnpj, string telefone, string endereco, int numero, string bairro,string cidade,
            string estado, string pais, string cep, string horarioFuncionamento, string quantidadeMaxima, int quantidadeMesa)
        {
            Nome = nome;
            CNPJ = cnpj;
            Telefone = telefone;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            CEP = cep;
            HorarioFuncionamento = horarioFuncionamento;
            QuantidadeMaxima = quantidadeMaxima;
            QuantidadeMesa = quantidadeMesa;

            var validator = new CreateRestaurantCommandValidator();
            Validation = validator.Validate(this);
        }
    }
}
