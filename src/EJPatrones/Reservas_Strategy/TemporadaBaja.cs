public class TemporadaBaja : ITemporada
{
    public string Nombre
    {
        get { return "Baja"; }
    }

    public double CalcularPrecio(
        Habitacion habitacion,
        RegimenAlimenticio regimen,
        int dias)
    {
        double precio = habitacion.PrecioDiario;

        double incremento =
            precio * regimen.PorcentajeIncremento;

        return (precio + incremento / 2) * dias * 1.10;
    }
}