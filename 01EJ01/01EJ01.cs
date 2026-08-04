using System;

public class Persona
{
    public string _nombre;
    public string _apellido;

    public Persona(string _nombre, string _apellido)
    {
        this._nombre = _nombre;
        this._apellido = _apellido;
    }

    public string GetNombre()
    {
        return this._nombre;
    }

    public void SetNombre(string nombre)
    {
        this._nombre = nombre;
    }

    public string GetApellido()
    {
        return this._apellido;
    }

    public void SetApellido(string apellido)
    {
        this._apellido = apellido;
    }
}

public class Program
{
    public static void Main()
    {
        Persona myVariable = new Persona("Gastón", "Javier");

        Console.WriteLine($"Nombre: {myVariable._nombre}");
        Console.WriteLine($"Apellido: {myVariable._apellido}");
    }
}