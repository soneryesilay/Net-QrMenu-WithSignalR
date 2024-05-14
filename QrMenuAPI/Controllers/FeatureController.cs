using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QrMenu.BusinessLayer.Abstract;
using QrMenu.DtoLayer.BookingDto;
using QrMenu.DtoLayer.DiscountDto;
using QrMenu.DtoLayer.FeatureDto;
using QrMenu.EntityLayer.Entities;

namespace QrMenuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            _featureService.TAdd( new Feature()
            {
                description1=createFeatureDto.description1,
                description2=createFeatureDto.description2,
                description3 = createFeatureDto.description3,
                title1 = createFeatureDto.title1,
                title2 = createFeatureDto.title2,
                title3 = createFeatureDto.title3,
              
            });

            return Ok("Feature Added!");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok("Feature deleted!");

        }

		[HttpGet("{id}")]
		public IActionResult GetFeature(int id)
		{
			var value = _featureService.TGetByID(id);
			return Ok(value);
		}

		[HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            _featureService.TUpdate(new Feature()
            {
                description1 = updateFeatureDto.description1,
                description2 = updateFeatureDto.description2,
                description3 = updateFeatureDto.description3,
                title1 = updateFeatureDto.title1,
                title2 = updateFeatureDto.title2,
                title3 = updateFeatureDto.title3,
				featureID = updateFeatureDto.featureID,


			});
            return Ok("Feature updated!");
        }

    }
}
