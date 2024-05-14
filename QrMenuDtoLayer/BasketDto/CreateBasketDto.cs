using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.DtoLayer.BasketDto
{
    public class CreateBasketDto
    {
        public string price { get; set; }
        public decimal count { get; set; }
        public decimal totalPrice { get; set; }
        public int productID { get; set; }
        public int MenuTableID { get; set; }
    }
}
