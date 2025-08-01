using Entity.Dtos.Card;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class RoomValidation : AbstractValidator<RoomDto>
    {
        public RoomValidation()
        {
            RuleFor(x => x.AmountPlayer)
           .NotEmpty().WithMessage("El numero de rondas es obligarorio");

          
     
        }
    }
}
