public interface ITemporada
{
    string Nombre { get; }

    double CalcularPrecio(
        Habitacion habitacion,
        RegimenAlimenticio regimen,
        int dias);
}