/* /src/Guia01/EJ09/Program.cs
9. Continuando con el ejemplo anterior, realizar las siguientes modificaciones:
    - Agregar en `Persona` el método `Presentarse()` que devuelva nombre y apellido de la persona.
    - Crear una instancia de cada una de las clases y asignarle valores.
    - Mostrar por pantalla los valores.
    - Sobreescribir el método `Presentarse()` en la clase `Guardia` de modo tal que devuelva el siguiente mensaje `"Hola, mi nombre es <nombre y apellido> y soy el guardia."` donde `<nombre y apellido>` debe ser reemplazado por el nombre y apellido del guardia.
    - Mostrar por pantalla el resultado de invocar el método `Presentarse()` y advertir que la implementación en la clase `Guardia` tiene precedencia sobre la de su padre.
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