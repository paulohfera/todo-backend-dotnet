namespace Domain.Entities;

public class BaseEntity
{
    public DateTime CreatedAt { get; protected set; }
    public DateTime UpdatedAt { get; protected set; }
    public bool Active { get; protected set; }
    public List<string>? Notifications { get; private set; }

    public void AddNotification(string notification)
    {
        Notifications ??= new List<string>();
        Notifications.Add(notification);
    }
}