using System;
using System.Collections.Generic;

public class ModuloGPS
{
    // 1. CAMPOS / ATRIBUTOS
    private List<string> satelites;
    private CoordenadaGeografica posicionActual;

    // 2. CONSTRUCTOR
    public ModuloGPS(
        List<string> satelites,
        CoordenadaGeografica posicionActual)
    {
        this.satelites = satelites;
        this.posicionActual = posicionActual;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public List<string> ObtenerSatelites()
    {
        return satelites;
    }

    public CoordenadaGeografica ObtenerPosicionActual()
    {
        return posicionActual;
    }

    public void TransmitirPosicionActual()
    {
        Console.WriteLine("Transmitiendo posicion GPS a la central...");
        Console.WriteLine($"Latitud: {posicionActual.Latitud}");
        Console.WriteLine($"Longitud: {posicionActual.Longitud}");
    }
}