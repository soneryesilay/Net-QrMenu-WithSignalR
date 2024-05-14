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
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        public EfMoneyCaseDal(QrMenuContext context) : base(context)
        {
        }

        public decimal TotalMoneyCaseAmout()
        {
            using var context= new QrMenuContext();
            return context.MoneyCases.Select(x => x.totalAmout).FirstOrDefault();
        }
    }
}
