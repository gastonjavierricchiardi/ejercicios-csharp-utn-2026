namespace MisClases;

public class Documentacion : Envio
{
    // 1. CAMPOS / ATRIBUTOS
    private static readonly double ADICIONAL_FIJO = 1000;

    // 2. CONSTRUCTOR
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

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public override double CalcularCosto()
    {
        double costoDistancia = Kilometros * TarifaPorKilometro;
        return costoDistancia + ADICIONAL_FIJO;
    }
}