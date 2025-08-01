using AutoMapper;
using Entity.Dtos.Card;
using Entity.Model.Card;

namespace Utilities.MappersApp.Card
{
    public class CardMap : Profile
    {
        public CardMap()
        {
            CreateMap<Cards, CardDto>().ReverseMap();
        }
    }
}