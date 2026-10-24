public class EmailCreator : NotificationCenter
{
    public override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}