using Entity.Dtos.Card;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class CardValidation : AbstractValidator<CardDto>
    {
        public CardValidation()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre es oblgatorio");

     
        }
    }
}
