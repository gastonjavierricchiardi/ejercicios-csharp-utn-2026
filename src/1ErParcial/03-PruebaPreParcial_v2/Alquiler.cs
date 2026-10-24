public class Alquiler
{
    private Vehiculo vehiculo;
    private int dias;
    private double kilometrosRecorridos;

    public Alquiler(
        Vehiculo vehiculo,
        int dias,
        double kilometrosRecorridos)
    {
        this.vehiculo = vehiculo;
        this.dias = dias;
        this.kilometrosRecorridos = kilometrosRecorridos;
    }

    public Vehiculo GetVehiculo()
    {
        return vehiculo;
    }

    public int GetDias()
    {
        return dias;
    }

    public double GetKilometrosRecorridos()
    {
        return kilometrosRecorridos;
    }

    public double CalcularCosto()
    {
        return vehiculo.CalcularCosto(
            dias,
            kilometrosRecorridos);
    }
}