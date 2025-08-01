using AutoMapper;
using Entity.Dtos.Card;
using Entity.Model.Card;

namespace Utilities.MappersApp.Card
{
    public class MoveMap : Profile
    {
        public MoveMap()
        {
            CreateMap<Move, MoveDto>().ReverseMap();
        }
    }
}