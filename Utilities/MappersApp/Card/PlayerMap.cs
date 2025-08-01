using AutoMapper;
using Entity.Dtos.Card;
using Entity.Model.Card;

namespace Utilities.MappersApp.Card
{
    public class PlayerMap : Profile
    {
        public PlayerMap()
        {
            CreateMap<Player, PlayerDto>().ReverseMap();
        }
    }
}