public class SmsCreator : NotificationCenter
{
    public override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}