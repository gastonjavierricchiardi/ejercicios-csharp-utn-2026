// CentroMedico
using System;

public class Program
{
    public static void Main()
    {
        Hospital hospital1 = new Hospital(
            "Dr. Bernardo Houssay", "Direccion 1", 30, 10m, 5);

        Hospital hospital2 = new Hospital(
            "J. Ubaldo Carrea", "Direccion 2", 20, 20m, 3);

        UnidadAtencionPrimaria uap = new UnidadAtencionPrimaria(
            "UAP Centro", "Direccion 3", 10, 30m);

        UnidadAdministrativa ua = new UnidadAdministrativa(
            "Vicente Lopez Centro", "Direccion 4");

        ua.Agregar(hospital1);
        ua.Agregar(hospital2);
        ua.Agregar(uap);

        Console.WriteLine("=== ESTADO INICIAL ===");
        Console.WriteLine($"Nombre: {ua.Nombre}");
        Console.WriteLine($"Direccion: {ua.ObtenerDireccion()}");
        Console.WriteLine($"Ambulancias: {ua.ObtenerCantidadAmbulancias()}");
        Console.WriteLine($"Personal: {ua.ObtenerPersonal()}");
        Console.WriteLine($"Tiempo medio: {ua.ObtenerTiempoMedio()}");

        // Modificamos los recursos de un hospital.
        hospital1.ModificarAmbulancias(7);
        hospital1.ModificarTiempoMedio(25m);

        Console.WriteLine("\n=== DESPUES DE MODIFICAR ===");
        Console.WriteLine($"Ambulancias: {ua.ObtenerCantidadAmbulancias()}");
        Console.WriteLine($"Personal: {ua.ObtenerPersonal()}");
        Console.WriteLine($"Tiempo medio: {ua.ObtenerTiempoMedio()}");

        // Eliminamos un hospital de la UA.
        ua.Eliminar(hospital2);

        Console.WriteLine("\n=== DESPUES DE ELIMINAR ===");
        Console.WriteLine($"Ambulancias: {ua.ObtenerCantidadAmbulancias()}");
        Console.WriteLine($"Personal: {ua.ObtenerPersonal()}");
        Console.WriteLine($"Tiempo medio: {ua.ObtenerTiempoMedio()}");

        // Bloque Vacio
        ua.Eliminar(hospital1);
        ua.Eliminar(uap);

        Console.WriteLine("\n=== UNIDAD ADMINISTRATIVA VACIA ===");
        Console.WriteLine($"Ambulancias: {ua.ObtenerCantidadAmbulancias()}");
        Console.WriteLine($"Personal: {ua.ObtenerPersonal()}");
        Console.WriteLine($"Tiempo medio: {ua.ObtenerTiempoMedio()}");
    }
}