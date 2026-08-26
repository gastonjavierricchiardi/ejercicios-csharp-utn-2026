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
        IPhone iphoneCatalina = new IPhone();

        // Creamos las dos personas con sus respectivo celulares
        Persona juliana = new Persona("Juliana", motorolaJuliana);
        Persona catalina = new Persona("Catalina", iphoneCatalina);

        // Comprobar la batería incial
        Console.WriteLine($"BATERÍA MotorolaG5 de Juliana: {juliana.ObtenerTelefono().ObtenerBateria()}");
        Console.WriteLine($"BATERÍA Iphone de Catalina   : {catalina.ObtenerTelefono().ObtenerBateria()}");

        // Realizamos la primera llamada de Motorolag5 hacía Iphone
        Console.WriteLine();
        Console.WriteLine("Juliana llama a Catalina");

        juliana.ObtenerTelefono().Llamar(
            catalina.ObtenerTelefono(),
            10
        );

        // Comprobar la batería después de la llamada
        Console.WriteLine($"BATERÍA MotorolaG5 de Juliana: {juliana.ObtenerTelefono().ObtenerBateria()}");
        Console.WriteLine($"BATERÍA Iphone de Catalina   : {catalina.ObtenerTelefono().ObtenerBateria()}");

        Console.WriteLine();
        Console.WriteLine("Catalina llama a Juliana");
        catalina.ObtenerTelefono().Llamar(
            juliana.ObtenerTelefono(),
            10
        );

        // Comprobamos la batería después de la llamada.
        Console.WriteLine($"BATERÍA MotorolaG5 de Juliana: {juliana.ObtenerTelefono().ObtenerBateria()}");
        Console.WriteLine($"BATERÍA Iphone de Catalina {catalina.ObtenerTelefono().ObtenerBateria()}");

        // Saber si un celu, esta apagado.
        Console.WriteLine();
        Console.WriteLine("ESTADO CELULARES");
        Console.WriteLine($"¿Motorola de Juliana apagado? {juliana.ObtenerTelefono().EstaApagado()}");
        Console.WriteLine($"¿Iphone de Catalina apagado? {catalina.ObtenerTelefono().EstaApagado()}");

        // Saber el estado de celulares según PERSONA
        Console.WriteLine();
        Console.WriteLine("ESTADO DE CELULARES SEGÚN LA PERSONA");
        Console.WriteLine($"¿Juliana tiene el celular apagado? {juliana.TieneCelularApagado()}");
        Console.WriteLine($"¿Catalina tiene el celular apagado? {catalina.TieneCelularApagado()}");

        // Agotamos la bateria de un celular.
        Console.WriteLine();
        Console.WriteLine("AGOTAMOS LA BATERÍA DEL IPHONE");
        catalina.ObtenerTelefono().Llamar(
            juliana.ObtenerTelefono(),
            50
        );
        Console.WriteLine($"BATERÍA del IPHONE de Catalina {catalina.ObtenerTelefono().ObtenerBateria()}");
        Console.WriteLine($"¿IPHONE apagado? {catalina.ObtenerTelefono().EstaApagado()}");
        Console.WriteLine($"¿Catalina tiene el celular apagado? {catalina.TieneCelularApagado()}");

        //Recargamos el celu
        Console.WriteLine();
        Console.WriteLine("RECARGAMOS IPHONE");
        catalina.ObtenerTelefono().Recargar();
        Console.WriteLine($"BATERÍA del IPHONE de Catalina {catalina.ObtenerTelefono().ObtenerBateria()}");
        Console.WriteLine($"¿IPHONE apagado? {catalina.ObtenerTelefono().EstaApagado()}");
        Console.WriteLine($"¿Catalina tiene el celular apagado {catalina.TieneCelularApagado()}");
    }
}

// --- //

/*md
Nuestro método es:
```
public abstract void Llamar(Telefono telefono, double duracion);
```
pero actualmente ni Motorola ni iPhone utilizan:

`telefono`

El parámetro nos sirve conceptualmente para expresar:

un `teléfono` llama a otro `teléfono`

pero en la implementación actual el receptor no interviene en ninguna regla.

OBSERVACIÓN: teléfono representa el destinatario de la llamada, aunque actualmente no participa del cálculo.
*/