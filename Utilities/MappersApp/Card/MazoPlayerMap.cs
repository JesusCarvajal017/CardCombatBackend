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
                .ForMember(dest => dest.CardName, opt => opt.MapFrom(src => src.Card.Name))
                .ForMember(dest => dest.Img, opt => opt.MapFrom(src => src.Card.Img))
                .ForMember(dest => dest.Legenday, opt => opt.MapFrom(src => src.Card.Legenday))
                .ForMember(dest => dest.Speed, opt => opt.MapFrom(src => src.Card.Speed))
                .ForMember(dest => dest.Endurace, opt => opt.MapFrom(src => src.Card.Endurace))
                .ForMember(dest => dest.SpecialPower, opt => opt.MapFrom(src => src.Card.SpecialPower))
                .ForMember(dest => dest.Technique, opt => opt.MapFrom(src => src.Card.Technique))
                .ForMember(dest => dest.Brutality, opt => opt.MapFrom(src => src.Card.Brutality));

         }
    }
}