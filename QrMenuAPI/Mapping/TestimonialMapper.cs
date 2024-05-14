using AutoMapper;
using QrMenu.DtoLayer.TestimonialDto;
using QrMenu.EntityLayer.Entities;

namespace QrMenuAPI.Mapping
{
    public class TestimonialMapper:Profile
    {
        public TestimonialMapper()
        {
            CreateMap<Testimonial,CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial,UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial,GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonial,ResultTestimonialDto>().ReverseMap();
        }
    }
}
