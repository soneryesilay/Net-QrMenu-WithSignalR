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
	public class EfOrderDal : GenericRepository<Order>, IOrderDal
	{
		public EfOrderDal(QrMenuContext context) : base(context)
		{

		}

		public int ActiveOrderCount()
		{
			using var context = new QrMenuContext();
			//aktif sipariş sayısı
			return context.Orders.Where(x => x.description == "Müşteri Masada").Count();
		}

		public decimal LastOrderPrice()
		{
			using var context = new QrMenuContext();
			return context.Orders.OrderByDescending(x => x.orderID).Take(1).Select(y=>y.totalPrice).FirstOrDefault();
		}

        public decimal TodayTotalPrice()
        {
			using var context = new QrMenuContext();
			//bu günkü toplam ciro
			return context.Orders.Where(o => o.OrderDate.Date == DateTime.Today).Sum(x => x.totalPrice);
			throw new NotImplementedException();
        }

        public int TotalOrderCount()
		{
			using var context= new QrMenuContext();
			return context.Orders.Count();

		}

	




	}

}
