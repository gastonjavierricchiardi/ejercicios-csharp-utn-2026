using System;
using System.Collections.Generic;

public class Habitacion
{
    // 1. CAMPOS / ATRIBUTOS
    private string id;
    private List<Pared> paredes;
    private Habitacion? anterior;
    private Habitacion? siguiente;

    // 2. CONSTRUCTOR
    public Habitacion(string id, List<Pared> paredes)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException(
                "La habitacion debe tener un identificador.");
        }

        if (paredes == null || paredes.Count != 4)
        {
            throw new ArgumentException(
                "La habitacion debe tener exactamente cuatro paredes.");
        }

        bool tienePuerta = false;
        int cantidadParedesAgua = 0;

        foreach (Pared pared in paredes)
        {
            if (pared == null)
            {
                throw new ArgumentException(
                    "Una pared no puede ser nula.");
            }

            if (pared is ParedAgua)
            {
                cantidadParedesAgua++;
            }

            if (pared is ParedSolida paredSolida &&
                paredSolida.TienePuerta)
            {
                tienePuerta = true;
            }
        }

        if (!tienePuerta && cantidadParedesAgua != 4)
        {
            throw new ArgumentException(
                "La habitacion necesita una puerta, " +
                "excepto cuando todas sus paredes son de agua.");
        }

        this.id = id;
        this.paredes = new List<Pared>(paredes);
        anterior = null;
        siguiente = null;
    }

    // 3. PROPIEDADES
    public string Id
    {
        get { return id; }
    }

    public Habitacion? Anterior
    {
        get { return anterior; }
    }

    public Habitacion? Siguiente
    {
        get { return siguiente; }
    }

    // 4. MÉTODOS
    public List<Pared> ObtenerParedes()
    {
        return new List<Pared>(paredes);
    }

    public bool PuedeAtravesarse()
    {
        foreach (Pared pared in paredes)
        {
            if (pared.EsAtravesable())
            {
                return true;
            }
        }

        return false;
    }

    internal void EnlazarSiguiente(Habitacion habitacion)
    {
        siguiente = habitacion;
        habitacion.anterior = this;
    }
}