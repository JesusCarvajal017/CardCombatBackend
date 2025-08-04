using AutoMapper;
using Entity.Dtos.Card;
using Entity.Dtos.Card.move;
using Entity.Model.Card;

namespace Utilities.MappersApp.Card
{
    public class MoveMap : Profile
    {
        public MoveMap()
        {
            CreateMap<Move, MoveDto>().ReverseMap();

            CreateMap<Move, MoverRoundDto>()
                .ForMember(dest => dest.PlayerId, opt => opt.MapFrom(src => src.Player.Id))
                .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.Card.Id))
                .ForMember(dest => dest.CardName, opt => opt.MapFrom(src => src.Card.Name))
                .ForMember(dest => dest.Legenday, opt => opt.MapFrom(src => src.Card.Legenday))
                .ForMember(dest => dest.Speed, opt => opt.MapFrom(src => src.Card.Speed))
                .ForMember(dest => dest.Endurace, opt => opt.MapFrom(src => src.Card.Endurace))
                .ForMember(dest => dest.SpecialPower, opt => opt.MapFrom(src => src.Card.SpecialPower))
                .ForMember(dest => dest.Technique, opt => opt.MapFrom(src => src.Card.Technique))
                .ForMember(dest => dest.Brutality, opt => opt.MapFrom(src => src.Card.Brutality));
        }
    }
}