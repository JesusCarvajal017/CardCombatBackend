using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Model.Card;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class RoundController
       : GenericController<
       Round,
       RoundDto,
       RoundDto>
    {
        public RoundController(
            IQueryServices<Round, RoundDto> q,
            ICommandService<Round, RoundDto> c)
          : base(q, c) { }
    }

}
