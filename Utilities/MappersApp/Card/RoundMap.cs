using AutoMapper;
using Entity.Dtos.Card;
using Entity.Model.Card;

namespace Utilities.MappersApp.Card
{
    public class RoundMap : Profile
    {
        public RoundMap()
        {
            CreateMap<Round, RoundDto>().ReverseMap();
        }
    }
}