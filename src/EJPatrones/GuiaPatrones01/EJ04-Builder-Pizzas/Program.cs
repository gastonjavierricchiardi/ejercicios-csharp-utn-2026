// EJ04-Builder
using System;
public class Program
{
    public static void Main()
    //static void Main(string[] args) // si tiene que recibir datos por consola
    {
        // Creamos el director
        PizzaDirector director = new PizzaDirector();

        // Construimos las pizzas
        Pizza muzzarella = director.BuildPizza(new MuzzarelaBuilder());
        Pizza napolitana = director.BuildPizza(new NapolitanaBuilder());

        // Mostramos los resultados

        muzzarella.Mostrar();
        napolitana.Mostrar();
    }
}