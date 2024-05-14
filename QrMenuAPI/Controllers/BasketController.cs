using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QrMenu.BusinessLayer.Abstract;
using QrMenu.DtoLayer.BasketDto;
using QrMenu.EntityLayer.Entities;
using QrMenuAPI.Models;
using QrMenuDataAccessLayer.Concrate;

namespace QrMenuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public IActionResult GetBasketByMenuTableID(int id)
        {
            var values = _basketService.TGetBasketByMenuTableNumber(id);
            return Ok(values);
        }

        [HttpGet("BasketListByMenuTableWithProductName")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            using var context = new QrMenuContext();
            var values = context.Baskets.Include(x => x.Product).Where(y => y.MenuTableID == id).Select(z => new ResultBasketListWithProduct
            {
                basketID = z.basketID,
                count = z.count,
                MenuTableID = z.MenuTableID,
                price = z.price,
                productID = z.productID,
                totalPrice = z.totalPrice,
                productName = z.Product.productName,
                tableName=z.MenuTable.tableName
            }).ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            //Bahçe 01 --> 45
            using var context = new QrMenuContext();
            _basketService.TAdd(new Basket()
            {
                productID = createBasketDto.productID,
                count = 1,
                MenuTableID = 4,
                price = context.Products.Where(x => x.productID == createBasketDto.productID).Select(y => y.price).FirstOrDefault(),
                totalPrice = 0
            });
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetByID(id);
            _basketService.TDelete(value);
            return Ok("Sepetteki Seçilen Ürün Silindi");
        }


    }
}


