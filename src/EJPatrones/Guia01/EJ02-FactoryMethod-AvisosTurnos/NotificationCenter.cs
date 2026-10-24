public abstract class NotificationCenter
{
    public abstract INotification CreateNotification();

    public void Notify(string message)
    {
        CreateNotification().Send(message);
    }
}