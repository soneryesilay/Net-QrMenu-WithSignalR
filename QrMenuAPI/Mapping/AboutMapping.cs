using AutoMapper;
using QrMenu.DtoLayer.AboutDto;
using QrMenu.EntityLayer.Entities;

namespace QrMenuAPI.Mapping
{
    public class AboutMapping  : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About,CreateAboutDto>().ReverseMap(); 
            CreateMap<About,GetAboutDto>().ReverseMap();
            CreateMap<About,UpdateAboutDto>().ReverseMap();
        }
    }
}
