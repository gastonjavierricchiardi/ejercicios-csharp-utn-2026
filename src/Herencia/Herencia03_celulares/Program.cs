/* /src/Herencia/Herencia03_celulares/Program.cs
# Ejercicio - Celulares

Implementar un aplicación donde se represente a personas que hablan entre sí por celulares.

Juliana tiene un Motorola G5, y Catalina tiene un iPhone.

El Motorola G5 pierde 0,25 "puntos" de batería por cada llamada, y el iPhone pierde 0,1% de la duración de cada llamada en batería. Ambos celulares tienen 5 "puntos" de batería como máximo.

Implementar a Juliana, Catalina, el Motorola G5 de Juliana y el iPhone de Catalina y hacer una aplicación de consola en donde Juliana y Catalina se hagan llamadas telefónicas de distintas duraciones.

Se pide al finalizar cada llamada:

1. Conocer la cantidad de batería de cada celular.
2. Saber si un celular está apagado (si está sin batería).
3. Recargar un celular (que vuelva a tener su batería completa).
4. Saber si Juliana tiene el celular apagado; saber si Catalina tiene el celular apagado.
*/

public class Program
{
    static void Main(string[] args)
    {
        //Crear Celulares
        MotorolaG5 motorolaJuliana = new MotorolaG5();
        iPhone iphoneCatalina = new iPhone();

        // Creamos las dos personas con sus respectivo celulares
        Persona juliana = new Persona("Juliana", motorolaJuliana);
        Persona catalina = new Persona("Catalina", iphoneCatalina);

        // Comprobar la batería incial
        Console.WriteLine($"Batería MotorolaG5 de Juliana: {juliana.ObtenerTelefono().ObtenerBateria()}");
        Console.WriteLine($"Batería Iphone de Catalina   : {catalina.ObtenerTelefono().ObtenerBateria()}");

        // Realizamos la primera llamada de Motorolag5 hacía Iphone
        Console.WriteLine();
        Console.WriteLine("Juliana llama a Catalina");

        juliana.ObtenerTelefono().Llamar(
            catalina.ObtenerTelefono(),
            10
        );

        // Comprobar la batería después de la llamada
        Console.WriteLine($"Batería MotorolaG5 de Juliana: {juliana.ObtenerTelefono().ObtenerBateria()}");
        Console.WriteLine($"Batería Iphone de Catalina   : {catalina.ObtenerTelefono().ObtenerBateria()}");


    }
}