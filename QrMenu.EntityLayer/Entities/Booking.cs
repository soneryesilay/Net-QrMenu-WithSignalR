namespace QrMenu.EntityLayer.Entities
{
    public class Booking
    {
        public int bookingID { get; set; }
        public string customerName { get; set; }
		public string Description { get; set; }
		public string phoneNumber { get; set; }
        public string mailAdress { get; set; }
        public int personCount { get; set; }
        public DateTime date { get; set; }
        
    }
}
