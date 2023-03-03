using FluentValidation;
using RestauranteAtual.API.Application.Produto.Command;

namespace RestauranteAtual.API.Application.Produto.Validation
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);

            RuleFor(x => x.ValorUnitario)
                .NotNull();
        }
    }
}
