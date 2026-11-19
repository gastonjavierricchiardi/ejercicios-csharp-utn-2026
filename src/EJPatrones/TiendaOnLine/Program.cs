// EJ-TiendaOnLine (Abstract Factory)
using System;
public class Program
{
    public static void Main()
    //static void Main(string[] args) // si tiene que recibir datos por consola
    {
        Combo comboGold = new Combo(new FabricaGold());
        Combo comboPlatinum = new Combo(new FabricaPlatinum());
        Combo comboStarter = new Combo(new FabricaStarter());

        Console.WriteLine("=== COMBO GOLD ===");
        Console.WriteLine(comboGold.ListarProductos());
        Console.WriteLine($"Precio total: ${comboGold.CalcularPrecioTotal()}");

        Console.WriteLine("\n=== COMBO PLATINUM ===");
        Console.WriteLine(comboPlatinum.ListarProductos());
        Console.WriteLine($"Precio total: ${comboPlatinum.CalcularPrecioTotal()}");

        Console.WriteLine("\n=== COMBO STARTER ===");
        Console.WriteLine(comboStarter.ListarProductos());
        Console.WriteLine($"Precio total: ${comboStarter.CalcularPrecioTotal()}");
    }
}