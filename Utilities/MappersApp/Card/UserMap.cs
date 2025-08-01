using AutoMapper;
using Entity.Dtos.Card;
using Entity.Model.Card;


namespace Utilities.MappersApp.Card
{
    public class UserMap : Profile
    {
        public UserMap()
        {
            CreateMap<User, UserQueryDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
      
                .ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}