using QrMenu.EntityLayer.Entities;

namespace QrMenuWebUI.Dtos.BasketDtos
{
    public class ResultBasketDto
    {
        public int basketID { get; set; }
        public decimal price { get; set; }
        public decimal count { get; set; }
        public decimal totalPrice { get; set; }
        public int productID { get; set; }
        public int MenuTableID { get; set; }
        public string productName { get; set; }
        public string tableName { get; set; }
    }
}
