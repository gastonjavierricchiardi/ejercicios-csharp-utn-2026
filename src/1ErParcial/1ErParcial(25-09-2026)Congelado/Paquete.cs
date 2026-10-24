namespace MisClases;

public class Paquete : Envio, IAsegurable
{
    private static readonly double COSTO_POR_KILO = 300;

    private double valorDeclarado;
    private string descripcionCobertura;
    private bool seguroContratado;

    public Paquete(
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
        valorDeclarado = 0;
        descripcionCobertura = "";
        seguroContratado = false;
    }

    public override double CalcularCosto()
    {
        double costoDistancia = Kilometros * TarifaPorKilometro;
        double costoPeso = Peso * COSTO_POR_KILO;

        return costoDistancia + costoPeso;
    }

    public double ObtenerValorDeclarado()
    {
        return valorDeclarado;
    }

    public string ObtenerDescripcionCobertura()
    {
        return descripcionCobertura;
    }

    public bool TieneSeguroContratado()
    {
        return seguroContratado;
    }

    public void ContratarSeguro(
        double valorDeclarado,
        string descripcionCobertura)
    {
        this.valorDeclarado = valorDeclarado;
        this.descripcionCobertura = descripcionCobertura;
        seguroContratado = true;
    }
}