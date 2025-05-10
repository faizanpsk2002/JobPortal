using Job.Models;

public interface INotificationService
{
    Task<List<NotificationModel>> GetNotificationsAsync();
    Task MarkAsReadAsync(int id);
}
