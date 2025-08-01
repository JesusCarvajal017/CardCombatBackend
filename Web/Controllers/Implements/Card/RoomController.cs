using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Model.Card;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class RoomController
       : GenericController<
       Room,
       RoomDto,
       RoomDto>
    {
        public RoomController(
            IQueryServices<Room, RoomDto> q,
            ICommandService<Room, RoomDto> c)
          : base(q, c) { }
    }

}
