using AutoMapper;
using Entity.Dtos.Card;
using Entity.Model.Card;

namespace Utilities.MappersApp.Card
{
    public class RoomMap : Profile
    {
        public RoomMap()
        {
            CreateMap<Room, RoomDto>().ReverseMap();
        }
    }
}