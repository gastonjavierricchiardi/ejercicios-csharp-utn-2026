//EJ26_Composite

using System;

public class Program
{
    public static void Main()
    {
        // Crear la sede central.
        Dependencia central = new Dependencia(1, "Sede Central");

        // Crear una dependencia subordinada.
        Dependencia dependenciaA = new Dependencia(2, "Dependencia A");

        central.AgregarDependencia(dependenciaA);

        // Crear las tres sucursales.
        Sucursal sucursal1 = new Sucursal(101, "Sucursal 1");
        Sucursal sucursal2 = new Sucursal(102, "Sucursal 2");
        Sucursal sucursal3 = new Sucursal(103, "Sucursal 3");
        // Cuarta sucursal: probar la prioridad 3.
        Sucursal sucursal4 = new Sucursal(104, "Sucursal 4");

        // Incorporarlas consecutivamente.
        central.IncorporarSucursal(sucursal1);
        central.IncorporarSucursal(sucursal2);
        central.IncorporarSucursal(sucursal3);

        central.IncorporarSucursal(sucursal4);

        // Otra dependencia que todavía no tiene sucursales.
        Dependencia dependenciaB = new Dependencia(3, "Dependencia B");

        central.AgregarDependencia(dependenciaB);

        Console.WriteLine("Dependencia B agregada a la central.");

        // Quinta sucursal: provocar la transformación.
        Sucursal sucursal5 = new Sucursal(105, "Sucursal 5");

        central.IncorporarSucursal(sucursal5);

        // Sexta sucursal: comprobar la búsqueda recursiva.
        Sucursal sucursal6 = new Sucursal(106, "Sucursal 6");

        central.IncorporarSucursal(sucursal6);

        Console.WriteLine("Prueba terminada.");
    }
}
