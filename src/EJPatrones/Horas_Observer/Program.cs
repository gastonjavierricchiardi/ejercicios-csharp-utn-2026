using System;
public class Program
{
    public static void Main()
    {
        // 1. Crear reloj con hora local inicial.
        RelojAeropuerto reloj = new RelojAeropuerto(
            new DateTime(2022, 6, 2, 18, 24, 0));

        // 2. Crear destinos.
        Destino madrid = new Destino("Madrid", 5);
        Destino nuevaYork = new Destino("Nueva York", -1);
        Destino beijing = new Destino("Beijing", 11);

        // 3. Suscribir destinos al reloj.
        reloj.AgregarDestino(madrid);
        reloj.AgregarDestino(nuevaYork);
        reloj.AgregarDestino(beijing);

        // 4. Mostrar horarios iniciales.
        Console.WriteLine("=== HORARIOS INICIALES ===");

        Console.WriteLine(
            $"Hora local: {reloj.FechaHoraLocal:dd/MM/yy HH:mm}");

        Console.WriteLine(
            $"Madrid: {madrid.FechaHoraActual:dd/MM/yy HH:mm}");

        Console.WriteLine(
            $"Nueva York: {nuevaYork.FechaHoraActual:dd/MM/yy HH:mm}");

        Console.WriteLine(
            $"Beijing: {beijing.FechaHoraActual:dd/MM/yy HH:mm}");

        // 5. Cambiar la hora local.
        reloj.EstablecerFechaHoraLocal(
            new DateTime(2022, 6, 2, 20, 0, 0));

        Console.WriteLine();
        Console.WriteLine("=== CAMBIO DE HORA LOCAL ===");

        Console.WriteLine(
            $"Hora local: {reloj.FechaHoraLocal:dd/MM/yy HH:mm}");

        Console.WriteLine(
            $"Madrid: {madrid.FechaHoraActual:dd/MM/yy HH:mm}");

        Console.WriteLine(
            $"Nueva York: {nuevaYork.FechaHoraActual:dd/MM/yy HH:mm}");

        Console.WriteLine(
            $"Beijing: {beijing.FechaHoraActual:dd/MM/yy HH:mm}");

        // 6. Eliminar un destino.
        reloj.EliminarDestino(nuevaYork);

        // 7. Cambiar nuevamente la hora local.
        reloj.EstablecerFechaHoraLocal(
            new DateTime(2022, 6, 3, 8, 15, 0));

        // 8. Agregar un nuevo destino.
        Destino tokio = new Destino("Tokio", 12);
        reloj.AgregarDestino(tokio);

        Console.WriteLine();
        Console.WriteLine("=== ALTA Y BAJA DE DESTINOS ===");

        Console.WriteLine(
            $"Hora local: {reloj.FechaHoraLocal:dd/MM/yy HH:mm}");

        Console.WriteLine(
            $"Madrid: {madrid.FechaHoraActual:dd/MM/yy HH:mm}");

        Console.WriteLine(
            $"Beijing: {beijing.FechaHoraActual:dd/MM/yy HH:mm}");

        Console.WriteLine(
            $"Tokio: {tokio.FechaHoraActual:dd/MM/yy HH:mm}");

        Console.WriteLine(
            $"Nueva York (eliminada): {nuevaYork.FechaHoraActual:dd/MM/yy HH:mm}");
    }
}