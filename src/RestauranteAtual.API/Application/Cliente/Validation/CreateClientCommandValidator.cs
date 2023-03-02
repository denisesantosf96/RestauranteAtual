using FluentValidation;
using RestauranteAtual.API.Application.Cliente.Command;

namespace RestauranteAtual.API.Application.Cliente.Validation
{
    public class CreateClientCommandValidator : AbstractValidator<CreateClientCommand>
    {
        public CreateClientCommandValidator()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);

            RuleFor(x => x.CPF)
                .NotNull()
                .NotEmpty()
                .MaximumLength(14);

            RuleFor(x => x.RG)
                .NotNull()
                .NotEmpty()
                .MaximumLength(14);

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
        }
    }
}
