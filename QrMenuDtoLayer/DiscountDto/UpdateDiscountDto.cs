using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.DtoLayer.DiscountDto
{
    public class UpdateDiscountDto
    {
        public int discountID { get; set; }
        public string title { get; set; }
        public string amout { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
		public bool Status { get; set; }
	}
}
