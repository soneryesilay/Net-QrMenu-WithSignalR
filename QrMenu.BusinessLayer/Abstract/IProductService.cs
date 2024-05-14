﻿using QrMenu.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
        int TProductCount();
		int TProductCountByCategoryNameIkram();
		int TProductCountByCategoryNameTatli();
		decimal TProductPriceAvg();	
		string TProductNameByMaxPrice();	
		string TProductNameByMinPrice();
		decimal TProductPriceByAvgKebab();
	}
}
