/* // Guia01\EJ04\Program.cs
4. Crear una clase `Cine` que tenga los atributos privados `película` y `horario`:
    - Crear métodos públicos para la asignación y recuperación de valores.
    - Crear un método público `ObtenerCartelera()` que devuelva el nombre de la película y el horario.
    - Crear una instancia y asignarle valores.
    - Mostrar por pantalla los valores.

*/
public class Program
{
    public static void Main()
    {
        // Crear objetos y probar el ejercicio
        Cine cine1 = new Cine();

        cine1.SetPelicula("Volver al Futuro");
        cine1.SetHorario("22:30");

        Console.WriteLine(cine1.GetPelicula());
        Console.WriteLine(cine1.GetHorario());
    }
}