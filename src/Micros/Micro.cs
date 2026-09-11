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
        return pasajeros.Count < capacidadSentados;
    }

    public bool HayLugar()
    {
        return pasajeros.Count < CalcularCapacidadTotal();
    }

    public int LugaresLibres()
    {
        return CalcularCapacidadTotal() - pasajeros.Count;
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
        if (pasajeros.Count == 0)
        {
            throw new Exception("El micro está vaciío.");
        }
        if (pasajeros.Contains(persona))
        {
            pasajeros.Remove(persona);
        }
        else
        {
            throw new Exception("La persona no se encuentra en el micro.");
        }
    }

    public Persona? PrimerPasajero() { throw new NotImplementedException(); }
}