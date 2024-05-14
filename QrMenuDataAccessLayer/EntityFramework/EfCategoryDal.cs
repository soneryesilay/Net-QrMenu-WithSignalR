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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(QrMenuContext context) : base(context)
        {
        }

		public int ActiveCategoryCount()
		{
			using var context= new QrMenuContext();
			return context.Categories.Where(x => x.categoryStatus == true).Count();

		}

		public int CategoryCount()
		{
			using var context = new QrMenuContext();
			return context.Categories.Count();
		}

		public int PassiveCategoryCount()
		{
			using var context=new QrMenuContext();
			return context.Categories.Where(x => x.categoryStatus == false).Count();
		}
	}
}
