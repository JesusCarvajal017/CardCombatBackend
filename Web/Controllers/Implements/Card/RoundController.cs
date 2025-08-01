using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Model.Card;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class RoundController
       : GenericController<
       Move,
       MoveDto,
       MoveDto>
    {
        public RoundController(
            IQueryServices<Move, MoveDto> q,
            ICommandService<Move, MoveDto> c)
          : base(q, c) { }
    }

}
