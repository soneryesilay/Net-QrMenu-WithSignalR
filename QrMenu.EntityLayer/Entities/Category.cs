namespace QrMenu.EntityLayer.Entities
{
    public class Category
    {
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public bool categoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}
