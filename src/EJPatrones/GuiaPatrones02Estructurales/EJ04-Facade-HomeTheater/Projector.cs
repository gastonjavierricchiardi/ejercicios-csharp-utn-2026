// EJ04-FACADE
using System;
public class Projector
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public void TurnOn()
    {
        System.Console.Write("Proyector encendido");
    }

    public void TurnOff()
    {
        System.Console.WriteLine("Proyector apagado");
    }

    public void SetInput(string input)
    {
        System.Console.WriteLine($" en {input}");
    }
}