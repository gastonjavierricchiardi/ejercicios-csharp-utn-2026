public class Camioneta : Vehiculo, IEntregable
{
    public double LimiteKilometrosIncluidos { get; set; }

    public double CapacidadCarga { get { return 1000; } }

    public Camioneta(
        string patente,
        string marca,
        string modelo,
        double precioBasePorDia,
        double limiteKilometrosIncluidos)
        : base(patente, marca, modelo, precioBasePorDia)
    {
        LimiteKilometrosIncluidos = limiteKilometrosIncluidos;
    }

    public override double CalcularCosto(int dias, double kilometrosRecorridos)
    {
        double costo = dias * PrecioBasePorDia + 5000 * dias;

        if (kilometrosRecorridos > LimiteKilometrosIncluidos)
        {
            double kilometrosExcedentes =
                kilometrosRecorridos - LimiteKilometrosIncluidos;

            costo += kilometrosExcedentes * 500;
        }

        return costo;
    }

    public string ObtenerDescripcion()
    {
        return $"{Marca} {Modelo} - Patente: {Patente}";
    }
}