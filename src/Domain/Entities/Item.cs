namespace Domain.Entities;

public class Item : BaseEntity
{
    public int Id { get; }
    public string Title { get; protected set; } = String.Empty;
    public string Description { get; protected set; } = String.Empty;
    public DateTime? Due { get; protected set; }
    public bool Done { get; protected set; }

    protected Item() { }

    public Item(string title, string description, DateTime? due)
    {
        Title = title;
        Description = description;
        Due = due;
        CreatedAt = DateTime.Now;
        Active = true;
    }

    public bool IsValid()
    {
        if (Title == String.Empty)
        {
            AddNotification("Title cannot be empty");
        }

        if (Description == String.Empty)
        {
            AddNotification("Description cannot be empty");
        }

        return Notifications == null || Notifications.Count == 0;
    }

}