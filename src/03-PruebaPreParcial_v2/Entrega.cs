public class Entrega
{
    private Vehiculo vehiculo;
    private double pesoCarga;

    public Entrega(
        Vehiculo vehiculo,
        double pesoCarga)
    {
        this.vehiculo = vehiculo;
        this.pesoCarga = pesoCarga;
    }

    public Vehiculo GetVehiculo()
    {
        return vehiculo;
    }

    public double GetPesoCarga()
    {
        return pesoCarga;
    }
}