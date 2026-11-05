// EJ02-Observer
using System;
public class Program
{
    public static void Main() //static void Main(string[] args){}
    {
        // Creamos en canal de novedades
        NewsChannel channel = new NewsChannel();

        // Creamos los subscriptores
        EmailSubscriber ana = new EmailSubscriber("Ana");
        AppSubscriber luis = new AppSubscriber("Luis");

        // Suscribimos a los alumnos
        channel.Subscribe(ana);
        channel.Subscribe(luis);

        // Primer novedad
        channel.PublishNews("Se suspenden las clases del martes 10/11/2026.");

        // Luis se da de baja
        channel.Unsubscribe(luis);

        // Segunda novedad
        channel.PublishNews("El parcial del martes 10/11/2026, se pasa al viernes 13/11/2026.");
    }
}