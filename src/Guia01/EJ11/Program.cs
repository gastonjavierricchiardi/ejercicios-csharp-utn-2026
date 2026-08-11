/* /src/Guia01/EJ11/Program.cs
11. Continuando con el ejemplo anterior, realizar las siguientes modificaciones:
    - Modificar la clase `Guardia` para que el método público `ControlarDocumento()` devuelva el mensaje `"Adelante <nombre completo del visitante> con dni <dni>"` reemplazando respectivamente con el nombre completo del visitante y su dni.
    - Crear una instancia de cada una de las clases y asignarle valores.
    - Mostrar por pantalla los valores.
    - Analizar si es posible pasar un único parámetro al método `ControlarDocumento()` y estudiar las ventajas y desventajas que tendría asociado.
*/
public class Program
{
    public static void Main()
    {
        Persona persona1 = new Persona();
        persona1.SetNombre("Gastón");
        persona1.SetApellido("Ricchiardi");

        Visitante visitante1 = new Visitante();
        visitante1.SetNombre("Desirée");
        visitante1.SetApellido("Candelaria");
        visitante1.SetDni(12345678);

        Guardia guardia1 = new Guardia();
        guardia1.SetNombre("Carlos");
        guardia1.SetApellido("Gómez");

        Console.WriteLine(persona1.Presentarse());
        Console.WriteLine($"{visitante1.Presentarse()} - DNI: {visitante1.GetDni()}");
        Console.WriteLine(guardia1.Presentarse());

        Console.WriteLine();

        // del Ej10
        // Console.WriteLine(guardia1.ControlarDocumento(visitante1.GetDni()));
        Console.WriteLine(guardia1.ControlarDocumento(visitante1));
    }
}



/*
Console.WriteLine($"Persona: {persona1.GetNombre()} {persona1.GetApellido()}");
Console.WriteLine($"Visitante: {visitante1.GetNombre()} {visitante1.GetApellido()}");
Console.WriteLine($"Guardia: {guardia1.GetNombre()} {guardia1.GetApellido()}");
*/