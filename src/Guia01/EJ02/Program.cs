/* Guia01\EJ02\Program.cs 
2. Crear una clase `Vehiculo` que tenga los atributos:
públicos:
    +`marca`,
    +`modelo` 
y un atributo privado:
    + `patente`.
- Crear una instancia y asignarle valores;
notar que el atributo privado no está disponible para la asignación de valores.
- Mostrar por pantalla los valores asignados.
*/

public class Program
{
    public static void Main()
    {
        // Creamos el primer vehiculo
        Vehiculo v1 = new Vehiculo(
            "Chevrolet",
            "Spin",
            "ZZZ000ZZ"
        );

        Console.WriteLine($"Marca: {v1.marca}");
        Console.WriteLine($"Modelo: {v1.modelo}");
        Console.WriteLine($"Patente: {v1.GetPatente()}");
        // La patente es privada, por eso no se accede directamente.
        // Se consulta mediante el método público GetPatente().
        // Console.WriteLine(v1._patente); // Error: _patente es private

        // Creamos el segundo Vehiculo
        Vehiculo v2 = new Vehiculo(
            "Ford",
            "K",
            "ZZZ999"
        );
        Console.WriteLine($"Marca: {v2.marca}");
        Console.WriteLine($"Modelo: {v2.modelo}");
        Console.WriteLine($"Patente: {v2.GetPatente()}");
    }
}
