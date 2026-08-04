using System;

public class Persona
{
    public string nombre;
    public string apellido;

    public Persona(string nombre, string apellido)
    {
        this.nombre = nombre;
        this.apellido = apellido;
    }

    public string GetNombre()
    {
        return this.nombre;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public string GetApellido()
    {
        return this.apellido;
    }

    public void SetApellido(string apellido)
    {
        this.apellido = apellido;
    }
}

public class Program
{
    public static void Main()
    {
        Persona myVariable = new Persona("Gastón", "Javier");

        Console.WriteLine($"Nombre: {myVariable.nombre}");
        Console.WriteLine($"Apellido: {myVariable.apellido}");
    }
}