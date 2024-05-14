using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QrMenu.BusinessLayer.Abstract;
using QrMenu.DtoLayer.SocialMediaDto;
using QrMenu.DtoLayer.TestimonialDto;
using QrMenu.EntityLayer.Entities;

namespace QrMenuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Testimonial()
        {
            var values = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
               title = createTestimonialDto.title,
               comment = createTestimonialDto.comment,
               imageUrl=createTestimonialDto.imageUrl,
               status=createTestimonialDto.status,
               testimonialName = createTestimonialDto.testimonialName
               
            });
            return Ok("Testimonial Added!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Testimonial deleted!");
        }

		[HttpGet("{id}")]
		public IActionResult GetTestimonial(int id)
		{
			var value = _testimonialService.TGetByID(id);
			return Ok(value);
		}

		[HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {

                testimonialID = updateTestimonialDto.testimonialID,
                title=updateTestimonialDto.title,   
                comment = updateTestimonialDto.comment,
                imageUrl = updateTestimonialDto.imageUrl,
                status = updateTestimonialDto.status,
                testimonialName = updateTestimonialDto.testimonialName

            });
            return Ok("SocialMedia updated!");
        }

     
    }
}
