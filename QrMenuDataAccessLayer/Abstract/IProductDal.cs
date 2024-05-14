using QrMenu.EntityLayer.Entities;
using QrMenuDataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.DataAccessLayer.Abstract
{
    public interface IProductDal: IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories(); 
        int ProductCount();
        int ProductCountByCategoryNameIkram();
        int ProductCountByCategoryNameTatli();
       //diğer ürünler içinde eklenebilir 
        decimal ProductPriceAvg();
		string ProductNameByMaxPrice();
		string ProductNameByMinPrice();

        decimal ProductPriceByAvgKebab();
		//diğer ürünler içinde eklenebilir 

	}
}
