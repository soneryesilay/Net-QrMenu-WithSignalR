using AutoMapper;
using QrMenu.DtoLayer.FeatureDto;
using QrMenu.EntityLayer.Entities;

namespace QrMenuAPI.Mapping
{
    public class FeatureMapper : Profile
    {
        public FeatureMapper()
        {
            CreateMap<Feature,CreateFeatureDto>().ReverseMap();
            CreateMap<Feature,UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature,ResultFeatureDto>().ReverseMap();
            CreateMap<Feature,GetFeatureDto>().ReverseMap();
        }
    }
}
