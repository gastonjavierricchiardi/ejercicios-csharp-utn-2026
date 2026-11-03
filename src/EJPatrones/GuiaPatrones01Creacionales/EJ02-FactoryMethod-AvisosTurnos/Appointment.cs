public class Appointment
{
    public void Confirm(NotificationCenter notificationCenter)
    {
        notificationCenter.Notify(GetConfirmationMessage());
    }

     public void Confirm(INotification notification)
    {
        notification.Send(GetConfirmationMessage());
    }

    private string GetConfirmationMessage()
    {
        return "Turno confirmado!";
    }
}