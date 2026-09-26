namespace MisClases;

public class Documentacion : Envio
{
    private static readonly double ADICIONAL_FIJO = 1000;

    public Documentacion(
        int numeroGuia,
        string destino,
        double kilometros,
        double peso,
        double tarifaPorKilometro)
        : base(
            numeroGuia,
            destino,
            kilometros,
            peso,
            tarifaPorKilometro)
    {
    }

    public override double CalcularCosto()
    {
        double costoDistancia = Kilometros * TarifaPorKilometro;
        return costoDistancia + ADICIONAL_FIJO;
    }
}