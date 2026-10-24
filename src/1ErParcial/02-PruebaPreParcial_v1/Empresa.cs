using System;
using System.Collections.Generic;

public class Empresa
{
    private List<Vehiculo> vehiculos;
    private List<Alquiler> alquileres;
    private List<Entrega> entregas;

    public Empresa()
    {
        vehiculos = new List<Vehiculo>();
        alquileres = new List<Alquiler>();
        entregas = new List<Entrega>();
    }

    public void RegistrarVehiculo(Vehiculo vehiculo)
    {
        if (BuscarVehiculo(vehiculo.Patente) != null)
        {
            throw new Exception("Ya existe un vehículo con esa patente.");
        }

        vehiculos.Add(vehiculo);
    }

    public Vehiculo? BuscarVehiculo(string patente)
    {
        foreach (Vehiculo vehiculo in vehiculos)
        {
            if (vehiculo.Patente == patente)
            {
                return vehiculo;
            }
        }

        return null;
    }

    public Alquiler RegistrarAlquiler(
        Vehiculo vehiculo,
        int dias,
        double kilometrosRecorridos)
    {
        Alquiler alquiler =
            new Alquiler(vehiculo, dias, kilometrosRecorridos);

        alquileres.Add(alquiler);

        return alquiler;
    }

    public Entrega RegistrarEntrega(
        IEntregable vehiculo,
        double pesoCarga)
    {
        if (pesoCarga > vehiculo.CapacidadCarga)
        {
            throw new CapacidadCargaExcedidaException(
                "La carga supera la capacidad permitida del vehículo.");
        }

        Entrega entrega = new Entrega(vehiculo, pesoCarga);

        entregas.Add(entrega);

        return entrega;
    }

    public List<Vehiculo> ConsultarVehiculos()
    {
        return vehiculos;
    }
}