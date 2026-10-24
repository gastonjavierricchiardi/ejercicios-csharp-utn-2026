public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Enviando mensaje por SMS: {message}");
    }
}