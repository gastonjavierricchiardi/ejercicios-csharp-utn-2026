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

        System.Console.WriteLine("=== COMBO GOLD ===");
        System.Console.WriteLine($"Precio total: ${comboGold.CalcularPrecioTotal()}");

        System.Console.WriteLine("=== COMBO PLATINUM ===");
        System.Console.WriteLine($"Precio total: ${comboPlatinum.CalcularPrecioTotal()}");

        System.Console.WriteLine("=== COMBO STARTER ===");
        System.Console.WriteLine($"Precio total: $ {comboStarter.CalcularPrecioTotal()}");
    }
}