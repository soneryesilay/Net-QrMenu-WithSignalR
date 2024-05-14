using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QrMenu.BusinessLayer.Abstract;
using QrMenu.DtoLayer.BookingDto;
using QrMenu.DtoLayer.DiscountDto;
using QrMenu.DtoLayer.ProductDto;
using QrMenu.EntityLayer.Entities;
using QrMenuDataAccessLayer.Concrate;

namespace QrMenuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory() 
        {
            var context = new QrMenuContext();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                categoryName = y.Category.categoryName,
                description = y.description,
                imageUrl = y.imageUrl,
                price = y.price,
                productID = y.productID,
                productName = y.productName,
                productStatus = y.productStatus
            });

            return Ok(values.ToList());
        }


        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(values);
        }

		[HttpGet("{id}")]
		public IActionResult GetProduct(int id)
		{
			var value = _productService.TGetByID(id);
			return Ok(value);
		}

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }

		[HttpGet("ProductCountByIkram")]
		public IActionResult ProductCountByIkram()
		{
			return Ok(_productService.TProductCountByCategoryNameIkram());
		}


		[HttpGet("ProductCountByTatli")]
		public IActionResult ProductCountByIkramTatli()
		{
			return Ok(_productService.TProductCountByCategoryNameTatli());
		}


		[HttpGet("ProductPriceAvg")]
		public IActionResult ProductPriceAvg()
		{
			return Ok(_productService.TProductPriceAvg());
		}


		[HttpGet("ProductPriceMax")]
		public IActionResult ProductPriceMax()
		{
			return Ok(_productService.TProductNameByMaxPrice());
		}


		[HttpGet("ProductPriceMin")]
		public IActionResult ProductPriceMin()
		{
			return Ok(_productService.TProductNameByMinPrice());
		}

		[HttpGet("ProductPriceByAvgKebab")]
		public IActionResult TProductPriceByAvgKebab()
		{
			return Ok(_productService.TProductPriceByAvgKebab());
		}


		[HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
           _productService.TAdd(new Product()
            {
               
               description = createProductDto.description,
               imageUrl = createProductDto.imageUrl,
               price = createProductDto.price,
               productName = createProductDto.productName,
               productStatus = createProductDto.productStatus,
			   CategoryID = createProductDto.categoryID,

		   });
            return Ok("Product Added!");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Product deleted!");

        }


        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                productID = updateProductDto.productID,
                description = updateProductDto.description,
                imageUrl = updateProductDto.imageUrl,
                price = updateProductDto.price,
                productName = updateProductDto.productName,
                productStatus = updateProductDto.productStatus,
                CategoryID = updateProductDto.categoryID,

            });
            return Ok("Product updated!");
        }

    
    }
}
