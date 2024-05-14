using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.EntityLayer.Entities
{
	public class OrderDetail
	{
		public int orderDetailID { get; set; }
		public int productID { get; set; }
		public Product Product { get; set; }
		public int count { get; set; }
		public decimal unitPrice { get; set; }
		public decimal totalPrice { get; set; }
		public int orderID { get; set; }
		public Order Order { get; set; }
	}
}
