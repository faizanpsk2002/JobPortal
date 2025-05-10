using Job.Models;

public class NotificationService : INotificationService
{
    // For demo purpose, you can replace with DB or persistent storage
    private static List<NotificationModel> _notifications = new()
    {
        new NotificationModel { Id = 1, Title = "Welcome", Message = "Thanks for joining!", IsRead = false },
        new NotificationModel { Id = 2, Title = "Update", Message = "New jobs posted today.", IsRead = false },
    };

    public Task<List<NotificationModel>> GetNotificationsAsync()
    {
        return Task.FromResult(_notifications.OrderByDescending(n => n.CreatedAt).ToList());
    }

    public Task MarkAsReadAsync(int id)
    {
        var notification = _notifications.FirstOrDefault(n => n.Id == id);
        if (notification != null)
        {
            notification.IsRead = true;
        }
        return Task.CompletedTask;
    }
}
