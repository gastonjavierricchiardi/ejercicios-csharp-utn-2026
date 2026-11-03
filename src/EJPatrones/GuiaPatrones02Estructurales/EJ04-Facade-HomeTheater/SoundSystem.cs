// EJ04-FACADE
using System;
public class SoundSystem
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public void TurnOn()
    {
        System.Console.Write("Sonido encendido");
    }

    public void TurnOff()
    {
        System.Console.WriteLine("Sonido apagado");
    }

    public void SetVolume(int volume)
    {
        System.Console.WriteLine($", Volumen {volume}");
    }
}