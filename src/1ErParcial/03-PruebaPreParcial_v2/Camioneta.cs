public class Camioneta : Vehiculo
{
    private const double ADICIONAL_DIA = 5000;
    private const double COSTO_KM_EXCEDENTE = 500;

    private double limiteKilometrosIncluidos;

    public Camioneta(
        string patente,
        string marca,
        string modelo,
        double precioBasePorDia,
        double capacidadCarga,
        double limiteKilometrosIncluidos)
        : base(
            patente,
            marca,
            modelo,
            precioBasePorDia,
            capacidadCarga)
    {
        this.limiteKilometrosIncluidos = limiteKilometrosIncluidos;
    }

    public double GetLimiteKilometrosIncluidos()
    {
        return limiteKilometrosIncluidos;
    }

    public override double CalcularCosto(
        int dias,
        double kilometrosRecorridos)
    {
        double costo = dias * GetPrecioBasePorDia()
            + dias * ADICIONAL_DIA;

        if (kilometrosRecorridos > limiteKilometrosIncluidos)
        {
            double kilometrosExcedentes =
                kilometrosRecorridos - limiteKilometrosIncluidos;

            costo += kilometrosExcedentes * COSTO_KM_EXCEDENTE;
        }

        return costo;
    }
}