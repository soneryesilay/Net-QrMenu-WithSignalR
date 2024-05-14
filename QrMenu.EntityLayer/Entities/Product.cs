namespace QrMenu.EntityLayer.Entities
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string imageUrl { get; set; }
        public bool productStatus { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
        public List<Basket> Baskets { get; set; }
    }
}
