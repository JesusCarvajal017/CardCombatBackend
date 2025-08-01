using AutoMapper;
using Entity.Dtos.Card;
using Entity.Model.Card;

namespace Utilities.MappersApp.Card
{
    public class MazoPlayerMap : Profile
    {
        public MazoPlayerMap()
        {
            CreateMap<MazoPlayer, MazoPlayerDto>().ReverseMap();

            CreateMap<MazoPlayer, MazoPlayerQueryDto>()
                .ForMember(dest => dest.PlayerName, opt => opt.MapFrom(src => src.Player.Name))
                .ForMember(dest => dest.CardName, opt => opt.MapFrom(src => src.Card.Name));
                
                //.ReverseMap();
        }
    }
}