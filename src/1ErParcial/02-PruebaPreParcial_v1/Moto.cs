public class Moto : Vehiculo
{
    public Moto(
        string patente,
        string marca,
        string modelo,
        double precioBasePorDia)
        : base(patente, marca, modelo, precioBasePorDia)
    { }

    public override double CalcularCosto(int dias, double kilometrosRecorridos)
    {
        return dias * PrecioBasePorDia + 1000 * dias;
    }
}