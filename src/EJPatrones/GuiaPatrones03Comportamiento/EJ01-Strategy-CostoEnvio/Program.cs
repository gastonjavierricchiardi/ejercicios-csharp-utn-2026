// EJ01-Strategy
using System;
public class Program
{
    public static void Main()
    //static void Main(string[] args) // si tiene que recibir datos por consola
    {
        Order order = new Order(3, new StorePickupShipping());

        // Envío estándar
        order.SetShippingStrategy(new StandardShipping());
        System.Console.WriteLine($"Estándar: ${order.CalculateShippingCost()}");

        // Envío express
        order.SetShippingStrategy(new ExpressShipping());
        System.Console.WriteLine($"Express: ${order.CalculateShippingCost()}");

        // Retiro en local
        order.SetShippingStrategy(new StorePickupShipping());
        System.Console.WriteLine($"Retiro en local: ${order.CalculateShippingCost()}");
    }
}