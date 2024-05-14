using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.EntityLayer.Entities
{
    public class Basket
    {
        public int basketID { get; set; }
        public decimal price { get; set; }
        public decimal count { get; set; }
        public decimal totalPrice { get; set; }
        public int productID { get; set; }
        public Product Product { get; set; }
        public int MenuTableID { get; set; }
        public MenuTable MenuTable { get; set; }
    }
}
