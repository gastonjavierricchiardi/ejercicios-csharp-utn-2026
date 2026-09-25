public class Moto : Vehiculo
{
    private const double ADICIONAL_DIA = 1000;

    public Moto(
        string patente,
        string marca,
        string modelo,
        double precioBasePorDia,
        double capacidadCarga)
        : base(
            patente,
            marca,
            modelo,
            precioBasePorDia,
            capacidadCarga)
    {
    }

    public override double CalcularCosto(
        int dias,
        double kilometrosRecorridos)
    {
        return dias * GetPrecioBasePorDia()
            + dias * ADICIONAL_DIA;
    }
}