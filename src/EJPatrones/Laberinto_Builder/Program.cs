using System;

public class Program
{
    public static void Main()
    {
        ConstructorLaberinto constructor =
            new ConstructorLaberinto();

        // Nivel 3 configurable: 18 habitaciones.
        constructor.ConfigurarMinimoHabitaciones(3, 18);

        // VERSION 1: Laberinto clasico.
        constructor.Iniciar(1, Dificultad.Facil);
        constructor.ConstruirClasico(MaterialPared.Arbustos);

        Laberinto clasico = constructor.ObtenerLaberinto();

        ProbarLaberinto("CLASICO - ARBUSTOS", clasico);

        // VERSION 2: Una pared de cada material.
        constructor.Iniciar(2, Dificultad.Intermedio);
        constructor.ConstruirModernoUnaDeCada();

        Laberinto modernoA = constructor.ObtenerLaberinto();

        ProbarLaberinto("MODERNO - UNA DE CADA", modernoA);

        // VERSION 2: Dos paredes de cada material elegido.
        constructor.Iniciar(3, Dificultad.Dificil);
        constructor.ConstruirModernoDosDeCada(
            MaterialPared.Piedra,
            MaterialPared.Agua);

        Laberinto modernoB = constructor.ObtenerLaberinto();

        ProbarLaberinto("MODERNO - DOS DE CADA", modernoB);

        // VERSION 2: Habitaciones con cuatro paredes de agua.
        constructor.Iniciar(1, Dificultad.Facil);
        constructor.ConstruirSoloAgua();

        Laberinto acuatico = constructor.ObtenerLaberinto();

        ProbarLaberinto("LABERINTO DE AGUA", acuatico);
    }

    private static void ProbarLaberinto(
        string titulo, Laberinto laberinto)
    {
        Console.WriteLine();
        Console.WriteLine($"=== {titulo} ===");

        Console.WriteLine($"Nivel: {laberinto.Nivel}");
        Console.WriteLine($"Dificultad: {laberinto.Dificultad}");
        Console.WriteLine(
            $"Habitaciones: {laberinto.CantidadHabitaciones}");

        Habitacion? primera =
            laberinto.ObtenerPrimeraHabitacion();

        if (primera != null)
        {
            Console.WriteLine("Paredes de la primera habitacion:");

            foreach (Pared pared in primera.ObtenerParedes())
            {
                if (pared is ParedSolida solida)
                {
                    Console.WriteLine(
                        $"- {solida.Material}, " +
                        $"puerta: {solida.TienePuerta}, " +
                        $"atravesable: {solida.EsAtravesable()}");
                }
                else
                {
                    Console.WriteLine(
                        $"- Agua, atravesable: {pared.EsAtravesable()}");
                }
            }
        }

        Personaje personaje = new Personaje();
        personaje.Recorrer(laberinto);

        Console.WriteLine(
            $"Habitaciones recorridas: " +
            $"{personaje.CantidadHabitacionesRecorridas()}");

        Console.WriteLine(
            $"Habitacion actual: " +
            $"{personaje.ObtenerHabitacionActual()?.Id}");

        Console.WriteLine(
            $"Logro salir: {personaje.LogroSalir()}");
    }
}