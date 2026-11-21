// Gimnasio_Strategy
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // 1. ACTIVIDADES
        Actividad musculacion = new Actividad(
            "Musculacion", "Sala de pesas", 20000m,
            "Carlos", "Lunes y miercoles");

        Actividad pileta = new Actividad(
            "Pileta", "Natacion", 15000m,
            "Laura", "Martes y jueves");

        Actividad spinning = new Actividad(
            "Spinning", "Bicicletas", 10000m,
            "Maria", "Viernes");

        // 2. PROMOCIONES
        Promocion promocion1 = new Promocion(
            "Promo Musculacion y Pileta",
            new List<Actividad> { musculacion, pileta },
            20m);

        Promocion promocion2 = new Promocion(
            "Promo Pileta y Spinning",
            new List<Actividad> { pileta, spinning },
            10m);

        // 3. GIMNASIO
        Gimnasio gimnasio = new Gimnasio();

        gimnasio.AgregarPromocion(promocion1);
        gimnasio.AgregarPromocion(promocion2);
        gimnasio.EstablecerPromocionVigente(promocion1);

        // 4. SOCIO POR ACTIVIDADES
        Socio socio1 = new Socio(
            "Juan", "Perez", "12345678",
            "Direccion 1", "11111111",
            "juan@email.com",
            new CuotaPorActividades());

        socio1.Inscribirse(musculacion);
        socio1.Inscribirse(pileta);

        Console.WriteLine("=== SOCIO POR ACTIVIDADES ===");
        Console.WriteLine($"Cuota con promocion: {gimnasio.CalcularCuota(socio1)}");

        // 5. CAMBIO DE PROMOCION
        gimnasio.EstablecerPromocionVigente(promocion2);

        Console.WriteLine("\n=== CAMBIO DE PROMOCION ===");
        Console.WriteLine($"Cuota: {gimnasio.CalcularCuota(socio1)}");

        // 6. SOCIO CON PASE LIBRE
        Socio socio2 = new Socio(
            "Ana", "Gomez", "87654321",
            "Direccion 2", "22222222",
            "ana@email.com",
            new CuotaPaseLibre(30000m));

        Console.WriteLine("\n=== SOCIO CON PASE LIBRE ===");
        Console.WriteLine($"Cuota: {gimnasio.CalcularCuota(socio2)}");

        // 7. ELIMINAR PROMOCION VIGENTE
        gimnasio.EliminarPromocion(promocion2);

        Console.WriteLine("\n=== SIN PROMOCION VIGENTE ===");
        Console.WriteLine($"Cuota socio1: {gimnasio.CalcularCuota(socio1)}");
        Console.WriteLine($"Cuota socio2: {gimnasio.CalcularCuota(socio2)}");
    }
}