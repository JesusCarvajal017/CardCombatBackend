using Entity.Dtos.Card;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class RoundValidation : AbstractValidator<RoundDto>
    {
        public RoundValidation()
        {
            RuleFor(x => x.Number)
           .NotEmpty().WithMessage("El numero de orden es obligatorio");

        }
    }
}
