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
	public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
	{
		public EfDiscountDal(QrMenuContext context) : base(context)
		{
		}

		public void ChangeStatusToFalse(int id)
		{
			using var context = new QrMenuContext();
			var value = context.Discounts.Find(id);
			value.Status = false;
			context.SaveChanges();
		}

		public void ChangeStatusToTrue(int id)
		{
			using var context = new QrMenuContext();
			var value = context.Discounts.Find(id);
			value.Status = true;
			context.SaveChanges();
		}


		public List<Discount> GetListByStatusTrue()
		{
			using var context = new QrMenuContext();
			var value = context.Discounts.Where(x => x.Status == true).ToList();
			return value;
		}
	}
}
