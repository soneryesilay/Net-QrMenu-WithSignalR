using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenuWebUI.Dtos.SocialMediaDtos
{
	public class UpdateSocialMediaDto
    {
        public int socialMediaID { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string icon { get; set; }
    }
}
