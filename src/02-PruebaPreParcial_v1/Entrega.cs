public class Entrega
{
    public IEntregable Vehiculo { get; set; }
    public double PesoCarga { get; set; }

    public Entrega(IEntregable vehiculo, double pesoCarga)
    {
        Vehiculo = vehiculo;
        PesoCarga = pesoCarga;
    }
}