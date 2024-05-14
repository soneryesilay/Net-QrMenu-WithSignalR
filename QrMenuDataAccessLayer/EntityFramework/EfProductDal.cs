using Microsoft.EntityFrameworkCore;
using QrMenu.DataAccessLayer.Abstract;
using QrMenu.DataAccessLayer.Repositories;
using QrMenu.EntityLayer.Entities;
using QrMenuDataAccessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(QrMenuContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new QrMenuContext();
            var values=context.Products.Include(x=>x.Category).ToList();
            return values;
        }

		public int ProductCount()
		{
			using var context = new QrMenuContext();
            return context.Products.Count();
		}

		public int ProductCountByCategoryNameIkram()
		{
			using var context = new QrMenuContext();
			return context.Products.Include(x=>x.Category).Where(x=>x.Category.categoryName== "İkramlar").Count();	
		}

		public int ProductCountByCategoryNameTatli()
		{
			using var context = new QrMenuContext();
			return context.Products.Include(x=>x.Category).Where(x=>x.Category.categoryName== "Tatlılar").Count();
		}

		public string ProductNameByMaxPrice()
		{
			using var context = new QrMenuContext();
			return context.Products.OrderByDescending(x=>x.price).FirstOrDefault().productName;
		}

		public string ProductNameByMinPrice()
		{
			using var context = new QrMenuContext();
			// Fiyatı sıfır olmayan ve productName'inin en küçük olanını alın
			var product = context.Products.Where(x => x.price > 0).OrderBy(x => x.price).FirstOrDefault();
			return product?.productName; // Eğer product null ise null hatası almamak için ?. operatörü ile kontrol edin
		}


		public decimal ProductPriceAvg()
		{
			using var context = new QrMenuContext();
			return context.Products.Average(x=>x.price);	

		}

		public decimal ProductPriceByAvgKebab()
		{
			using var context = new QrMenuContext();
			return context.Products.Include(x=>x.Category).Where(x=>x.Category.categoryName== "Kebaplar").Average(x=>x.price);
		}
	}
}
