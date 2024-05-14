using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.DtoLayer.ContactDto
{
    public class CreateContactDto
    {

        public string location { get; set; }
        public string phoneNumber { get; set; }
        public string mailAdress { get; set; }
        public string footerDescription { get; set; }
    }
}
