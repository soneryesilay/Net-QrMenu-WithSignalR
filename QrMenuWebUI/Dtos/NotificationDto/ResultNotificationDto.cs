namespace QrMenuWebUI.Dtos.NotificationDto;
public class ResultNotificationDto
{
    public int notificationID { get; set; }
    public string type { get; set; }
    public string Icon { get; set; }
    public string description { get; set; }
    public DateTime date { get; set; }
    public bool status { get; set; }
}