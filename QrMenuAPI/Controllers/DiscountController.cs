using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QrMenu.BusinessLayer.Abstract;
using QrMenu.DtoLayer.CategoryDto;
using QrMenu.DtoLayer.ContactDto;
using QrMenu.DtoLayer.DiscountDto;
using QrMenu.EntityLayer.Entities;

namespace QrMenuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList() 
        {
            
            var values = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
           _discountService.TAdd( new Discount()
            {
               title=createDiscountDto.title,
               amout=createDiscountDto.amout,
               description=createDiscountDto.description,
               imageUrl=createDiscountDto.imageUrl,
		   });

            return Ok("Discount Added!");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value=_discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("Discount deleted!");

        }

		[HttpGet("{id}")]
		public IActionResult GetDiscount(int id)
		{
			var value = _discountService.TGetByID(id);
			return Ok(value);
		}

		[HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                discountID = updateDiscountDto.discountID,
                title = updateDiscountDto.title,
                amout = updateDiscountDto.amout,
                description = updateDiscountDto.description,
                imageUrl = updateDiscountDto.imageUrl,

			});

            return Ok("Category updated!");
        }

		[HttpGet("ChangeStatusToTrue/{id}")]
		public IActionResult ChangeStatusToTrue(int id)
		{
			_discountService.TChangeStatusToTrue(id);
			return Ok("Ürün İndirimi Aktif Hale Getirildi");
		}

		[HttpGet("ChangeStatusToFalse/{id}")]
		public IActionResult ChangeStatusToFalse(int id)
		{
			_discountService.TChangeStatusToFalse(id);
			return Ok("Ürün İndirimi Pasif Hale Getirildi");
		}

		[HttpGet("GetListByStatusTrue")]
		public IActionResult GetListByStatusTrue()
		{
			return Ok(_discountService.TGetListByStatusTrue());
		}

	}
}
