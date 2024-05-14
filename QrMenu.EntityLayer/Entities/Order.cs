using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.EntityLayer.Entities
{
	public class Order
	{
		public int orderID { get; set; }
		public int tableID { get; set; }
		public MenuTable MenuTable { get; set; }
		public string description { get; set; }
		[Column(TypeName = "Date")]
		public DateTime OrderDate { get; set; }
		
		public decimal totalPrice { get; set; }
		
		public List<OrderDetail> orderDetails { get; set; }
	}
}
