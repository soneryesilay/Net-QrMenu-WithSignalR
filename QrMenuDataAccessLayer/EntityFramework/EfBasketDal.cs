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
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(QrMenuContext context) : base(context)
        {
        }

        public List<Basket> GetBasketByMenuTableNumber(int id)
        {
             using var context = new QrMenuContext();
             var values = context.Baskets
            .Where(x => x.MenuTableID == id)
            .Include(y => y.Product)
            .Include(z => z.MenuTable)
            .ToList();

            return values;
        }
    }
}
