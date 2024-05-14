using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.DtoLayer.CategoryDto
{
    public class GetCategoryDto
    {
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public bool categoryStatus { get; set; }
    }
}
