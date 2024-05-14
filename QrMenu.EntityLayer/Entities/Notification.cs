using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.EntityLayer.Entities
{
	public class Notification
	{
        public int notificationID { get; set; }
        public string type { get; set; }
        public string Icon { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public bool status { get; set; }
    }
}
