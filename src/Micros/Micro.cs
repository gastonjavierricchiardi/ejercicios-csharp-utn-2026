// /src/Micros/Micro.cs
using System;
using System.Collections.Generic;
public class Micro
{
    // 1. CAMPOS / ATRIBUTOS
    private int capacidadSentados;
    private int capacidadParados;
    private double volumenM3;
    private List<Persona> pasajeros;


    // 2. CONSTRUCTOR
    public Micro(
        int capacidadSentados,
        int capacidadParados,
        double volumenM3
    )
    {
        this.capacidadSentados = capacidadSentados;
        this.capacidadParados = capacidadParados;
        this.volumenM3 = volumenM3;
        this.pasajeros = new List<Persona>();
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public double GetVolumenM3()
    {
        return volumenM3;
    }

    // 4. MÉTODOS
    public int CalcularCapacidadTotal()
    {
        return capacidadSentados + capacidadParados;
    }
    public bool HayLugarSentado()
    {
        // Refactorizamos para no usar .Count
        // return pasajeros.Count < capacidadSentados;
        int cantidadPasajeros = 0;
        foreach (Persona pasajeros in pasajeros)
        {
            cantidadPasajeros++;
        }
        return cantidadPasajeros < capacidadSentados;
    }

    public bool HayLugar()
    {
        // Refactorizamos return pasajeros.Count < CalcularCapacidadTotal();
        int cantidadPasajeros = 0;
        foreach (Persona pasajeros in pasajeros)
        {
            cantidadPasajeros++;
        }
        return cantidadPasajeros < CalcularCapacidadTotal();
    }

    public int LugaresLibres()
    {
        // Refactorizamos
        int cantidadPasajeros = 0;

        foreach (Persona pasajero in pasajeros)
        {
            cantidadPasajeros++;
        }
        return CalcularCapacidadTotal() - cantidadPasajeros;
    }

    public bool PuedeSubir(Persona persona)
    {
        return HayLugar() && persona.AceptaSubir(this);
    }

    public void SubirPasajero(Persona persona)
    {
        if (PuedeSubir(persona))
        {
            pasajeros.Add(persona);
        }
        else
        {
            throw new Exception("La persona no puede subir al micro.");
        }
    }

    public void BajarPasajero(Persona persona)
    {
        bool hayPasajeros = false;
        bool personaEncontrada = false;
        foreach (Persona pasajero in pasajeros)
        {
            hayPasajeros = true;

            if (pasajero == persona)
            {
                personaEncontrada = true;
            }
        }

        if (!hayPasajeros)
        {
            throw new Exception("El micro está vaciío.");
        }

        if (personaEncontrada)
        {
            pasajeros.Remove(persona);
        }
        else
        {
            throw new Exception("La persona no se encuentra en el micro.");
        }
    }
    public Persona? PrimerPasajero()
    // Refactorizamos
    {
        foreach (Persona pasajero in pasajeros)
        {
            return pasajero;
        }
        return null;
    }
}