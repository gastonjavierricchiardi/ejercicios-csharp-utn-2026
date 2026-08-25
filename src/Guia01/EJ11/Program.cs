/* /src/Guia01/EJ11/Program.cs
Gastón Ricchiardi (gaston@hotmail.com)
11. Continuando con el ejemplo anterior, realizar las siguientes modificaciones:
    - Agregar en `Visitante` el atributo privado `dni` (numérico) con sus setters y getters correspondientes.
    - Agregar en `Guardia` el método público `ControlarDocumento()` que reciba como parámetro el `dni` de la persona y devuelva el mensaje `"Adelante persona con dni <dni>"` donde `<dni>` es el valor recibido por parámetro.
    - Crear una instancia de cada una de las clases y asignarle valores.
    - Mostrar por pantalla los valores.

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