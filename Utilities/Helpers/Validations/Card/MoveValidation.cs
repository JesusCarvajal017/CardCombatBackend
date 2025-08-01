using Entity.Dtos.Card;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class MoveValidation : AbstractValidator<MoveDto>
    {
        public MoveValidation()
        {
            RuleFor(x => x.CardId)
           .NotEmpty().WithMessage("El id de la carta es obligatoria");

        }
    }
}
