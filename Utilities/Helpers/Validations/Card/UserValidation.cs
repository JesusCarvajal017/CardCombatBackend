using Entity.Dtos.Card;
using FluentValidation;

namespace Utilities.Helpers.Validations.Card
{
    public class UserValidation : AbstractValidator<UserDto>
    {
        public UserValidation()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El numero de orden es obligatorio");

        }
    }
}
