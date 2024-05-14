using QrMenu.BusinessLayer.Abstract;
using QrMenu.DataAccessLayer.Abstract;
using QrMenu.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.BusinessLayer.Concrate
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

		public void TAdd(Product entity)
        {
            _productDal.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product TGetByID(int id)
        {
           return _productDal.GetByID(id);
        }

        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();
        }

        public List<Product> TGetProductsWithCategories()
        {
            return _productDal.GetProductsWithCategories();
        }

		public int TProductCount()
		{
            return _productDal.ProductCount();
		}

		public int TProductCountByCategoryNameIkram()
		{
			return _productDal.ProductCountByCategoryNameIkram();
		}

		public int TProductCountByCategoryNameTatli()
		{
			return _productDal.ProductCountByCategoryNameTatli();
		}

		public string TProductNameByMaxPrice()
		{
           return _productDal.ProductNameByMaxPrice();
		}

		public string TProductNameByMinPrice()
		{
			return _productDal.ProductNameByMinPrice();

		}

		public decimal TProductPriceAvg()
		{
            return _productDal.ProductPriceAvg();
        }

		public decimal TProductPriceByAvgKebab()
		{
			return _productDal.ProductPriceByAvgKebab();
		}

		public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
