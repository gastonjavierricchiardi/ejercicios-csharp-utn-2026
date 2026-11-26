using System;
using System.Collections.Generic;

public class Habitacion
{
    private int numero;
    private CategoriaHabitacion categoria;
    private int capacidadMaxima;
    private double precioDiario;
    private EstadoHabitacion estado;
    private List<RegimenAlimenticio> regimenesDisponibles;

    public Habitacion(
        int numero,
        CategoriaHabitacion categoria,
        int capacidadMaxima,
        List<RegimenAlimenticio> regimenesDisponibles)
    {
        if (numero <= 0 || capacidadMaxima <= 0)
        {
            throw new ArgumentException(
                "El numero y la capacidad deben ser positivos.");
        }

        if (regimenesDisponibles == null ||
            regimenesDisponibles.Count == 0)
        {
            throw new ArgumentException(
                "La habitacion debe admitir al menos un regimen.");
        }

        this.numero = numero;
        this.categoria = categoria;
        this.capacidadMaxima = capacidadMaxima;

        this.regimenesDisponibles =
            new List<RegimenAlimenticio>(regimenesDisponibles);

        switch (categoria)
        {
            case CategoriaHabitacion.Simple:
                precioDiario = 100;
                break;

            case CategoriaHabitacion.Doble:
                precioDiario = 250;
                break;

            case CategoriaHabitacion.Suite:
                precioDiario = 500;
                break;

            default:
                throw new ArgumentException(
                    "Categoria de habitacion invalida.");
        }

        estado = EstadoHabitacion.Disponible;
    }

    public int Numero
    {
        get { return numero; }
    }

    public CategoriaHabitacion Categoria
    {
        get { return categoria; }
    }

    public int CapacidadMaxima
    {
        get { return capacidadMaxima; }
    }

    public double PrecioDiario
    {
        get { return precioDiario; }
    }

    public EstadoHabitacion Estado
    {
        get { return estado; }
    }

    public List<RegimenAlimenticio> ObtenerRegimenesDisponibles()
    {
        return new List<RegimenAlimenticio>(
            regimenesDisponibles);
    }

    public bool AdmiteRegimen(RegimenAlimenticio regimen)
    {
        return regimenesDisponibles.Contains(regimen);
    }

    internal void Reservar()
    {
        if (estado == EstadoHabitacion.Reservada)
        {
            throw new HabitacionReservadaException(
                $"La habitacion {numero} ya esta reservada.");
        }

        estado = EstadoHabitacion.Reservada;
    }

    internal void Liberar()
    {
        estado = EstadoHabitacion.Disponible;
    }
}