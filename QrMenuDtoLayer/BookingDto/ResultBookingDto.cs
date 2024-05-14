using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.DtoLayer.BookingDto
{
    public class ResultBookingDto
    {
        public int bookingID { get; set; }
        public string customerName { get; set; }
        public string phoneNumber { get; set; }
        public string mailAdress { get; set; }
        public int personCount { get; set; }
        public DateTime date { get; set; }

	}
}
