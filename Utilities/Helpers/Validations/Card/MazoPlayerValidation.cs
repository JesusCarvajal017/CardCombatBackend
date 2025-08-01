using Entity.Dtos.Card;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class MazoPlayerValidation : AbstractValidator<MazoPlayerDto>
    {
        public MazoPlayerValidation()
        {
            RuleFor(x => x.CardId)
           .NotEmpty().WithMessage("La carta es obligatoria");

          
     
        }
    }
}
