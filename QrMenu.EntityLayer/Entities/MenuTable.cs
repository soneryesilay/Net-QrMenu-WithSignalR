using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.EntityLayer.Entities
{
    public class MenuTable
    {
        public int menuTableID { get; set; }
        public string tableName { get; set; }
        public bool tableStatus { get; set; }
        public List<Basket> Baskets { get; set; }
    }
}
