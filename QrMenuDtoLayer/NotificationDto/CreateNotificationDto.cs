namespace QrMenu.DtoLayer.NotificationDto;

public class CreateNotificationDto
{
    public string type { get; set; }
    public string Icon { get; set; }
    public string description { get; set; }
    public DateTime date { get; set; }
    public bool status { get; set; }
}