public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Enviando mensaje por Email: {message}");
    }
}