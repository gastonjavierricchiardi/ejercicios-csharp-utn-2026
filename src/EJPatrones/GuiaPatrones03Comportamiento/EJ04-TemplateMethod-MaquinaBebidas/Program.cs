// EJ04-TemplatedMeto
using System;
public class Program
{
    public static void Main() // static void Main(string[] args) { }
    {
        // Preparar un té
        System.Console.WriteLine("Té");
        Te te = new Te();
        te.PrepararBebida();
        System.Console.WriteLine();

        // Preparar un café
        System.Console.WriteLine("Café");
        Cafe cafe = new Cafe();
        cafe.PrepararBebida();
    }
}