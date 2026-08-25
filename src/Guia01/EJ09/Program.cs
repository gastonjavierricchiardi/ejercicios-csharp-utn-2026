/* /src/Guia01/EJ09/Program.cs
Gastón Ricchiardi (gastonj@hotmail.com)
9. Crear una clase `Persona` que tenga los atributos privados **nombre** y **apellido**, con sus setters y getters.
- Crear una clase llamada `Visitante` que extienda de **Persona**
- Crear una clase `Guardia` que extienda de **persona**
- Crear una instancia de cada una de las clases y asignarle valores.
- Mostrar por pantalla los valores; estudiar las ventajas del uso de la **herencia**

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

        Guardia guardia1 = new Guardia();
        guardia1.SetNombre("Carlos");
        guardia1.SetApellido("Gómez");

        Console.WriteLine($"Persona: {persona1.GetNombre()} {persona1.GetApellido()}");
        Console.WriteLine($"Visitante: {visitante1.GetNombre()} {visitante1.GetApellido()}");
        Console.WriteLine($"Guardia: {guardia1.GetNombre()} {guardia1.GetApellido()}");
        // Crear objetos y probar el ejercicio
    }
}