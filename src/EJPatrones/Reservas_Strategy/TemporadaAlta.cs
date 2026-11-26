public class TemporadaAlta : ITemporada
{
    public string Nombre
    {
        get { return "Alta"; }
    }

    public double CalcularPrecio(
        Habitacion habitacion,
        RegimenAlimenticio regimen,
        int dias)
    {
        double precio = habitacion.PrecioDiario;

        double incremento =
            precio * regimen.PorcentajeIncremento;

        return (precio + incremento) * dias * 1.20;
    }
}