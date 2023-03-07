using FluentValidation;
using RestauranteAtual.API.Application.Garcom.Comand;

namespace RestauranteAtual.API.Application.Garcom.Validation
{
    public class CreateWaiterCommandValidator : AbstractValidator<CreateWaiterCommand>
    {
        public CreateWaiterCommandValidator()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);
        }
    }
}
