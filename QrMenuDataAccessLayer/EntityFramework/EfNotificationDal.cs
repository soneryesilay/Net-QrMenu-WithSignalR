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
	public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
	{
		public EfNotificationDal(QrMenuContext context) : base(context)
		{
		}

		public List<Notification> GetAllNotificationByFalse()
		{
			using var context = new QrMenuContext();
			return context.Notifications.Where(x => x.status == false).ToList();
		}

		public int NotificationCountByStatusFalse()
		{
			using var context = new QrMenuContext();
			return context.Notifications.Where(x => x.status == false).Count();
		}

		public void NotificationStatusChangeToTrue(int id)
		{
			using var context= new QrMenuContext();
			var notification = context.Notifications.Find(id);
			notification.status = true;
			context.SaveChanges();
		}

		public void NotificationStatusChangeToFalse(int id)
		{
			using var context= new QrMenuContext();
			var notification = context.Notifications.Find(id);
			notification.status = false;
			context.SaveChanges();
		}
	}
}
