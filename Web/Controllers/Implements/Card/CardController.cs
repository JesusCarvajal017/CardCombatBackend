using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Model.Card;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class CardController
       : GenericController<
       Cards,
       CardDto,
       CardDto>
    {
        public CardController(
            IQueryServices<Cards, CardDto> q,
            ICommandService<Cards, CardDto> c)
          : base(q, c) { }
    }

}
