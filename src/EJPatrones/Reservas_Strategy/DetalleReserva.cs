public class DetalleReserva
{
    private Habitacion habitacion;
    private RegimenAlimenticio regimen;

    public DetalleReserva(
        Habitacion habitacion,
        RegimenAlimenticio regimen)
    {
        this.habitacion = habitacion;
        this.regimen = regimen;
    }

    public Habitacion Habitacion
    {
        get { return habitacion; }
    }

    public RegimenAlimenticio Regimen
    {
        get { return regimen; }
    }

    public double CalcularSubtotal(
        ITemporada temporada,
        int dias)
    {
        return temporada.CalcularPrecio(
            habitacion, regimen, dias);
    }
}