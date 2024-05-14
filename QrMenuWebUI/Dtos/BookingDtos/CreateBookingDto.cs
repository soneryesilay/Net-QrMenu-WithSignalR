namespace QrMenuWebUI.Dtos.BookingDtos
{
	public class CreateBookingDto
    {
        public string customerName { get; set; }
        public string phoneNumber { get; set; }
        public string mailAdress { get; set; }
        public int personCount { get; set; }
        public DateTime date { get; set; }
    }
}
