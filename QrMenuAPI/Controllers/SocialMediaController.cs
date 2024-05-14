using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QrMenu.BusinessLayer.Abstract;
using QrMenu.DtoLayer.ProductDto;
using QrMenu.DtoLayer.SocialMediaDto;
using QrMenu.EntityLayer.Entities;

namespace QrMenuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var values = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
                    icon= createSocialMediaDto.icon,
                    title=createSocialMediaDto.title,
                    url=createSocialMediaDto.url,

            });
            return Ok("SocialMedia Added!");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("SocialMedia deleted!");

        }

        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            
            var socialMedia = _socialMediaService.TGetByID(updateSocialMediaDto.socialMediaID);
            if (socialMedia == null)
            {
               
                return NotFound("SocialMedia not found!");
            }

           
            socialMedia.icon = updateSocialMediaDto.icon;
            socialMedia.title = updateSocialMediaDto.title;
            socialMedia.url = updateSocialMediaDto.url;

           
            _socialMediaService.TUpdate(socialMedia);

            return Ok("SocialMedia updated!");
        }


        [HttpGet("{id}")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            return Ok(value);
        }
    }
}
