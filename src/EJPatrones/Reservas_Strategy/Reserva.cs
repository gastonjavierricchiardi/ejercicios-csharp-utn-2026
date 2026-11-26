using System;
using System.Collections.Generic;

public class Reserva
{
    private int numero;
    private DateTime fechaIngreso;
    private DateTime fechaEgreso;
    private string cliente;
    private List<DetalleReserva> detalles;
    private double precio;

    internal Reserva(
        int numero,
        DateTime fechaIngreso,
        DateTime fechaEgreso,
        string cliente,
        List<DetalleReserva> detalles,
        double precio)
    {
        this.numero = numero;
        this.fechaIngreso = fechaIngreso;
        this.fechaEgreso = fechaEgreso;
        this.cliente = cliente;
        this.detalles = new List<DetalleReserva>(detalles);
        this.precio = precio;
    }

    public int Numero
    {
        get { return numero; }
    }

    public DateTime FechaIngreso
    {
        get { return fechaIngreso; }
    }

    public DateTime FechaEgreso
    {
        get { return fechaEgreso; }
    }

    public string Cliente
    {
        get { return cliente; }
    }

    public double Precio
    {
        get { return precio; }
    }

    public List<DetalleReserva> ObtenerDetalles()
    {
        return new List<DetalleReserva>(detalles);
    }
}