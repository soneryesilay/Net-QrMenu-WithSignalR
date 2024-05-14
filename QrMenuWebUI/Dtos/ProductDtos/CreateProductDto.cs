namespace QrMenuWebUI.Dtos.ProductDtos
{
	public class CreateProductDto
	{
		public string productName { get; set; }
		public string description { get; set; }
		public decimal price { get; set; }
		public string imageUrl { get; set; }
		public bool productStatus { get; set; }
		public int categoryID { get; set; }
	}
}
