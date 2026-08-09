/** Guia01\EJ03\Program.cs/
3. Crear una clase `Articulo` que tenga los atributos **privados:** `marca` y `modelo`.
    - Crear métodos públicos para la asignación de valores.
    - Crear una instancia y asignarle valores.
    - Notar que no es posible mostrar los valores por pantalla y analizar el motivo por lo que esto ocurre.
*/
public class Program
{
    public static void Main()
    {
        // Creamos el objeto
        Articulo art1 = new Articulo();

        // Asignamos los valores al objeto.
        art1.SetMarca("Chrevrolet");
        art1.SetModelo("Spin");

        // Mostramos los valores en pantalla
        Console.Write(art1._marca);
        Console.WriteLine(); // Salto de línea
        Console.Write(art1._modelo);

        // o bien podemos hace el salto de línea como en TS con "\n"
    }
}