using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Model.Card;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class PlayerController
       : GenericController<
       Player,
       PlayerDto,
       PlayerDto>
    {
        public PlayerController(
            IQueryServices<Player, PlayerDto> q,
            ICommandService<Player, PlayerDto> c)
          : base(q, c) { }
    }

}
