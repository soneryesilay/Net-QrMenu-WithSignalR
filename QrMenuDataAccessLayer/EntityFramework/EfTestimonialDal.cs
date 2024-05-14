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
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        public EfTestimonialDal(QrMenuContext context) : base(context)
        {
        }
    }
}
