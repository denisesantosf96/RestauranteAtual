using FluentValidation;
using RestauranteAtual.API.Application.Restaurante.Command;

namespace RestauranteAtual.API.Application.Restaurante.Validation
{
    public class CreateRestaurantCommandValidator : AbstractValidator<CreateRestaurantCommand>
    {
        public CreateRestaurantCommandValidator()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);

            RuleFor(x => x.CNPJ)
                .NotNull()
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.Telefone)
                .NotNull()
                .NotEmpty()
                .MaximumLength(14);

            RuleFor(x => x.Endereco)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);

            RuleFor(x => x.Bairro)
                .NotNull()
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(x => x.Cidade)
                .NotNull()
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(x => x.Estado)
                .NotNull()
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.Pais)
                .NotNull()
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(x => x.CEP)
                .NotNull()
                .NotEmpty()
                .MaximumLength(9);

            RuleFor(x => x.HorarioFuncionamento)
                .NotNull()
                .NotEmpty()
                .MaximumLength(60);

            RuleFor(x => x.QuantidadeMaxima)
                .NotNull()
                .NotEmpty()
                .MaximumLength(80);
        }
    }
}
