// EJ02-Decorator

public class Program
{
    public static void Main() // static void Main(string[] args) { }
    {
        ICoffee coffee = new Coffee();

        coffee = new MilkDecorator(coffee);

        coffee = new ChocolateDecorator(coffee);

        System.Console.WriteLine($"{coffee.GetDescription()}: $ {coffee.GetPrice()}");
    }
}