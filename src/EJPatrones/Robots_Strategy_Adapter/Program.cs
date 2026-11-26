using System;

public class Program
{
    public static void Main()
    {
        // Parte 1: tracciones y armamentos intercambiables.
        RuedaCaucho rueda = new RuedaCaucho();
        Oruga orugaOriginal = new Oruga(new SensorMekeM0(26));

        Robot robot1 = new Robot("KT-2020-P-01", 100, new Granadas(), rueda);
        Robot robot2 = new Robot("KT-2020-P-02", 100, new RayoLaser(), orugaOriginal);

        Console.WriteLine("=== COMBATE POR RESISTENCIA ===");
        Console.WriteLine($"{robot1.NumeroSerie}: {robot1.PotenciaTraccionDisponibleHp} hp, " +
                          $"autonomia {rueda.AutonomiaKm} km");
        Console.WriteLine($"{robot2.NumeroSerie}: {robot2.PotenciaTraccionDisponibleHp} hp, " +
                          $"autonomia {orugaOriginal.AutonomiaKm} km");
        MostrarResultado(robot1, robot2);

        // Parte 2: se adapta el sensor, sin cambiar Robot ni Oruga.
        SensorDigitalFahrenheit digital = new SensorDigitalFahrenheit(86);
        ISensorTemperatura adaptador = new AdaptadorSensorDigital(digital);
        Oruga orugaDigital = new Oruga(adaptador);

        Console.WriteLine();
        Console.WriteLine("=== SENSORES DE TEMPERATURA ===");
        Console.WriteLine($"Meke-M0: {orugaOriginal.ObtenerTemperaturaCelsius():F1} C");
        Console.WriteLine($"Digital: {digital.ObtenerTemperaturaFahrenheit():F1} F " +
                          $"= {orugaDigital.ObtenerTemperaturaCelsius():F1} C");

        // Segundo combate: los robots no pierden toda la resistencia
        // antes de que la traccion del primero se deteriore al 100%.
        Robot robot3 = new Robot("KT-2020-P-03", 500, new Espada(), new RuedaCaucho());
        Robot robot4 = new Robot("KT-2020-P-04", 500, new Espada(), orugaDigital);

        Console.WriteLine();
        Console.WriteLine("=== COMBATE POR DESGASTE DE TRACCION ===");
        MostrarResultado(robot3, robot4);
    }

    private static void MostrarResultado(Robot primero, Robot segundo)
    {
        Combate combate = new Combate(primero, segundo);
        Robot? ganador = combate.Simular();

        Console.WriteLine($"{primero.NumeroSerie}: resistencia {primero.Resistencia}, " +
                          $"desgaste {primero.Traccion.DeterioroPorcentaje}%");
        Console.WriteLine($"{segundo.NumeroSerie}: resistencia {segundo.Resistencia}, " +
                          $"desgaste {segundo.Traccion.DeterioroPorcentaje}%");
        Console.WriteLine($"Ganador: {ganador?.NumeroSerie ?? "Sin ganador"}");
    }
}
