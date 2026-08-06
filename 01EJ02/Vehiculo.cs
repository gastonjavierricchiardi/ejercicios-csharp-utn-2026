// Vehiculo.cs
using System;

public class Vehiculo
{
    // Atributos
    public string marca;
    public string modelo;
    private string _patente;
    // Constructor
    public Vehiculo(string marca, string modelo, string patente)
    {
        this.marca = marca;
        this.modelo = modelo;
        this._patente = patente;
    }
    // Propiedades (get y set)
    public string GetMarca()
    {
        return this.marca;
    }
    public void SetMarca(string marca)
    {
        this.marca = marca;
    }
    public string GetModelo()
    {
        return this.modelo;
    }
    public void SetModelo(string modelo)
    {
        this.modelo = modelo;
    }
    // Patente no tiene setters porque no queremos modificarlo desde afuera
    public string GetPatente()
    {
        return this._patente;
    }
}