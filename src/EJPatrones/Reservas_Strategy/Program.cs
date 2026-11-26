using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Hotel hotel = new Hotel("Grand Splendid");

        // 1. Crear regimenes alimenticios.
        RegimenAlimenticio sa =
            new RegimenAlimenticio("SA", 0);

        RegimenAlimenticio mp =
            new RegimenAlimenticio("MP", 0.25);

        RegimenAlimenticio pc =
            new RegimenAlimenticio("PC", 0.75);

        // 2. Crear habitaciones.
        Habitacion simple = new Habitacion(
            101,
            CategoriaHabitacion.Simple,
            1,
            new List<RegimenAlimenticio> { sa });

        Habitacion doble = new Habitacion(
            102,
            CategoriaHabitacion.Doble,
            2,
            new List<RegimenAlimenticio> { sa, mp });

        Habitacion suite = new Habitacion(
            201,
            CategoriaHabitacion.Suite,
            4,
            new List<RegimenAlimenticio> { sa, mp, pc });

        hotel.AgregarHabitacion(simple);
        hotel.AgregarHabitacion(doble);
        hotel.AgregarHabitacion(suite);

        Console.WriteLine($"=== {hotel.Nombre} ===");
        Console.WriteLine($"Temporada: {hotel.TemporadaActual}");

        // 3. Primera reserva: temporada alta, 2 dias.
        List<DetalleReserva> detalles1 =
            new List<DetalleReserva>
            {
                new DetalleReserva(simple, sa),
                new DetalleReserva(doble, mp)
            };

        Reserva reserva1 = hotel.CrearReserva(
            "Cliente A",
            new DateTime(2026, 11, 26),
            new DateTime(2026, 11, 28),
            detalles1);

        Console.WriteLine();
        Console.WriteLine("=== PRIMERA RESERVA ===");
        Console.WriteLine($"Numero: {reserva1.Numero}");
        Console.WriteLine($"Precio: ${reserva1.Precio:F2}");

        // 4. Intentar reservar una habitacion ocupada.
        Console.WriteLine();
        Console.WriteLine("=== HABITACION OCUPADA ===");

        try
        {
            hotel.CrearReserva(
                "Cliente B",
                new DateTime(2026, 12, 1),
                new DateTime(2026, 12, 3),
                new List<DetalleReserva>
                {
                    new DetalleReserva(doble, mp)
                });
        }
        catch (HabitacionReservadaException error)
        {
            Console.WriteLine(error.Message);
        }

        // 5. Cambiar a temporada baja.
        hotel.CambiarTemporada();

        Console.WriteLine();
        Console.WriteLine("=== CAMBIO DE TEMPORADA ===");
        Console.WriteLine($"Temporada: {hotel.TemporadaActual}");

        // 6. Segunda reserva: temporada baja, 3 dias.
        Reserva reserva2 = hotel.CrearReserva(
            "Cliente C",
            new DateTime(2026, 12, 5),
            new DateTime(2026, 12, 8),
            new List<DetalleReserva>
            {
                new DetalleReserva(suite, pc)
            });

        Console.WriteLine($"Numero: {reserva2.Numero}");
        Console.WriteLine($"Precio: ${reserva2.Precio:F2}");

        // 7. Eliminar la primera reserva.
        hotel.EliminarReserva(reserva1.Numero);

        Console.WriteLine();
        Console.WriteLine("=== ELIMINACION ===");
        Console.WriteLine(
            $"Habitacion 101: {simple.Estado}");
        Console.WriteLine(
            $"Habitacion 102: {doble.Estado}");
        Console.WriteLine(
            $"Habitacion 201: {suite.Estado}");

        // 8. Volver a temporada alta.
        hotel.CambiarTemporada();

        Console.WriteLine();
        Console.WriteLine(
            $"Temporada actual: {hotel.TemporadaActual}");

        // 9. Listar reservas existentes.
        Console.WriteLine();
        Console.WriteLine("=== RESERVAS VIGENTES ===");

        foreach (Reserva reserva in hotel.ListarReservas())
        {
            Console.WriteLine(
                $"Reserva {reserva.Numero} - " +
                $"{reserva.Cliente} - " +
                $"Precio: ${reserva.Precio:F2}");
        }
    }
}