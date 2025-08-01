using Entity.Dtos.Card;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class PlayerValidation : AbstractValidator<PlayerDto>
    {
        public PlayerValidation()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre del jugador es obligatorio");

          
     
        }
    }
}
