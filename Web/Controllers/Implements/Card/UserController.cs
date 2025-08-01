using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Model.Card;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class UserController
       : GenericController<
       User,
       UserQueryDto,
       UserDto>
    {
        public UserController(
            IQueryServices<User, UserQueryDto> q,
            ICommandService<User, UserDto> c)
          : base(q, c) { }
    }

}
