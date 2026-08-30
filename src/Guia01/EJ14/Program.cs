/* /src/Guia01/EJ14/Program.cs
Gastón Ricchiardi (gastonj@hotmail.com)
14. Una empresa de seguridad que se dedica a la vigilancia mediante el empleo de drones, ha desarrollado un sistema de montaje que permitirá que 
los drones puedan cargar, además de la cámara de vigilancia, una herramienta accionable a distancia.
Actualmente el sistema de anclaje admite:
- **Sensor infrarrojo:** pesa 250 gramos
- **Taser:** pesa 300 gramos
- **Brazo robótico:** pesa 500 gramos

El dron puede soportar hasta 200 gramos sin sufrir penalizaciones de velocidad (5 m/s) ni altura (100 m); luego, por cada 50 gramos extras, 
el dron reduce su velocidad en 2% y la altura en 5%.

Analizar, diseñar, diagramar las relaciones e implementar el código.
Crear instancias de cada una de las clases y asignarle al dron las distintas herramientas, procurando mostrar por pantalla los siguientes datos
entre las distintas asignaciones: velocidad, altura y tipo de herramienta que lleva.
*/

public class Program
{
    public static void Main()
    {
        // Creamos las herramientas
        Herramienta sensor = new SensorInfrarrojo();
        Herramienta taser = new Taser();
        Herramienta brazo = new BrazoRobotico();

        // Mostramos la referencia base del Dron sin carga
        Console.WriteLine("VALORES BASE DEL DRON - SIN CARGA");
        Console.WriteLine("Velocidad: 5 m/s, altura: 100 m");

        // Agregamos Sensor infrarrojo
        Console.WriteLine();
        Console.WriteLine($"+ Agregamos: {sensor.GetTipoHerramienta()}");

        Dron dron = new Dron(sensor);

        Console.WriteLine(dron.GetInfo());

        // Cambiamos Sensor por Taser
        Console.WriteLine();
        Console.WriteLine($"- Quitamos: {sensor.GetTipoHerramienta()}");
        Console.WriteLine($"+ Agregamos: {taser.GetTipoHerramienta()}");

        dron.Herramienta = taser;

        Console.WriteLine(dron.GetInfo());

        // Cambiamos Taser por Brazo robótico
        Console.WriteLine();
        Console.WriteLine($"- Quitamos: {taser.GetTipoHerramienta()}");
        Console.WriteLine($"+ Agregamos: {brazo.GetTipoHerramienta()}");

        dron.Herramienta = brazo;

        Console.WriteLine(dron.GetInfo());
    }
}