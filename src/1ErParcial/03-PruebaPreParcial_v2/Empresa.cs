using System.Collections.Generic;

public class Empresa
{
    private Dictionary<string, Vehiculo> vehiculos =
        new Dictionary<string, Vehiculo>();

    private List<Alquiler> alquileres =
        new List<Alquiler>();

    private List<Entrega> entregas =
        new List<Entrega>();

    public bool RegistrarVehiculo(Vehiculo vehiculo)
    {
        string patente = vehiculo.GetPatente();

        if (vehiculos.ContainsKey(patente))
        {
            return false;
        }

        vehiculos.Add(patente, vehiculo);

        return true;
    }

    public Vehiculo? BuscarVehiculo(string patente)
    {
        if (vehiculos.ContainsKey(patente))
        {
            return vehiculos[patente];
        }

        return null;
    }

    public List<Vehiculo> ObtenerVehiculos()
    {
        return new List<Vehiculo>(vehiculos.Values);
    }

    public Alquiler RegistrarAlquiler(
        Vehiculo vehiculo,
        int dias,
        double kilometrosRecorridos)
    {
        Alquiler alquiler = new Alquiler(
            vehiculo,
            dias,
            kilometrosRecorridos);

        alquileres.Add(alquiler);

        return alquiler;
    }

    public Entrega RegistrarEntrega(
        Vehiculo vehiculo,
        double pesoCarga)
    {
        if (pesoCarga > vehiculo.GetCapacidadCarga())
        {
            throw new CapacidadCargaExcedidaException(
                "La carga supera la capacidad del vehículo.");
        }

        Entrega entrega = new Entrega(
            vehiculo,
            pesoCarga);

        entregas.Add(entrega);

        return entrega;
    }
}