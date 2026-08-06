public class Vehiculo
{
    public string marca;
    public string modelo;
    private string _patente;

    public Vehiculo(string marca, string modelo, string patente)
    {
        this.marca = marca;
        this.modelo = modelo;
        this._patente = patente;
    }

    public string GetPatente()
    {
        return this._patente;
    }
}

public class Program
{
    public static void Main()
    {
        Vehiculo v1 = new Vehiculo("Chevrolet", "Spin", "AD921HB");

        Console.WriteLine($"Marca: {v1.marca}");
        Console.WriteLine($"Modelo: {v1.modelo}");
        Console.WriteLine($"Patente: {v1.GetPatente()}");

        Console.WriteLine("--------------------");

        Vehiculo v2 = new Vehiculo("Ford", "K", "FMM164");

        Console.WriteLine($"Marca: {v2.marca}");
        Console.WriteLine($"Modelo: {v2.modelo}");
        Console.WriteLine($"Patente: {v2.GetPatente()}");
    }
}