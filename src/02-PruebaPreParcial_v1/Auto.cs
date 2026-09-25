public class Auto : Vehiculo, IEntregable
{
    public double CapacidadCarga { get { return 200; } }

    public Auto(
        string patente,
        string marca,
        string modelo,
        double precioBasePorDia)
        : base(patente, marca, modelo, precioBasePorDia)
    { }
    public override double CalcularCosto(int dias, double kilometrosRecorridos)
    {
        return dias * PrecioBasePorDia + 2000 * dias;
    }

    public string ObtenerDescripcion()
    {
        return $"{Marca} {Modelo} - Patente: {Patente}";
    }
}