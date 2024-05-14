using AutoMapper;
using QrMenu.DtoLayer.ProductDto;
using QrMenu.EntityLayer.Entities;

namespace QrMenuAPI.Mapping
{
    public class ProductMapper :Profile
    {
        public ProductMapper()
        {
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,GetProductDto>().ReverseMap();
            CreateMap<Product,ResultProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
            CreateMap<Product,ResultProductWithCategory>().ReverseMap();
        }
    }
}
