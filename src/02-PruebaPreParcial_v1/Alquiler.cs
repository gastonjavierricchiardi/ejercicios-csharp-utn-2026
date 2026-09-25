public class Alquiler
{
    public Vehiculo Vehiculo { get; set; }
    public int Dias { get; set; }
    public double KilometrosRecorridos { get; set; }

    public Alquiler(
        Vehiculo vehiculo,
        int dias,
        double kilometrosRecorridos)
    {
        Vehiculo = vehiculo;
        Dias = dias;
        KilometrosRecorridos = kilometrosRecorridos;
    }

    public double CalcularCostoTotal()
    {
        return Vehiculo.CalcularCosto(Dias, KilometrosRecorridos);
    }
}