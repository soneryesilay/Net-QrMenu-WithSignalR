using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QrMenu.BusinessLayer.Abstract;
using QrMenu.DtoLayer.AboutDto;
using QrMenu.DtoLayer.CategoryDto;
using QrMenu.EntityLayer.Entities;

namespace QrMenuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _mapper.Map<List<ResultAboutDto>>(_aboutService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
         
            _aboutService.TAdd(new About()
            {
                imageUrl = createAboutDto.imageUrl,
                title = createAboutDto.title,
                description = createAboutDto.description,

            });

            return Ok("About part successfully added!");
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok("About part successfully deleted!");
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            _aboutService.TUpdate(new About()
            {
                imageUrl = updateAboutDto.imageUrl,
                title = updateAboutDto.title,
                description = updateAboutDto.description,
            });
            return Ok("About part successfully updated!");
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value= _aboutService.TGetByID(id);
            return Ok(value);
        }
    }
}
