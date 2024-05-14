using AutoMapper;
using QrMenu.EntityLayer.Entities;
using QrMenu.DtoLayer.SliderDto;

namespace QrMenuAPI.Mapping
{
	public class SliderMapping:Profile
	{
        public SliderMapping()
        {
			CreateMap<Slider, ResultSliderDto>().ReverseMap();
		}
    }
}
