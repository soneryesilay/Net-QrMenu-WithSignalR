using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenuWebUI.Dtos.TestimonialDtos
{
	public class ResultTestimonialDto
    {
        public int testimonialID { get; set; }
        public string testimonialName { get; set; }
        public string title { get; set; }
        public string comment { get; set; }
        public string imageUrl { get; set; }
        public bool status { get; set; }
    }
}
