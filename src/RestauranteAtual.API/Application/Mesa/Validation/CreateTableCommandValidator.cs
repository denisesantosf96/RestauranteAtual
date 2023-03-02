using FluentValidation;
using RestauranteAtual.API.Application.Mesa.Command;

namespace RestauranteAtual.API.Application.Mesa.Validation
{
    public class CreateTableCommandValidator : AbstractValidator<CreateTableCommand>
    {
        public CreateTableCommandValidator()
        {
            RuleFor(x => x.IdRestaurante)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Localizacao)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100);
        }
    }
}
