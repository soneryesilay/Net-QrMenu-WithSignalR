using QrMenu.EntityLayer.Entities;
using QrMenuDataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.DataAccessLayer.Abstract
{
    public interface IMoneyCaseDal  : IGenericDal<MoneyCase>
    {
        decimal TotalMoneyCaseAmout();

    }
}
