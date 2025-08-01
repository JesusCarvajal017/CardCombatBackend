using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Model.Card;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class MazoPlayerController
       : GenericController<
       MazoPlayer,
       MazoPlayerQueryDto,
       MazoPlayerDto>
    {
        public MazoPlayerController(
            IQueryServices<MazoPlayer, MazoPlayerQueryDto> q,
            ICommandService<MazoPlayer, MazoPlayerDto> c)
          : base(q, c) { }
    }

}
