namespace MisClases;

public class CargaPesada : Envio, IAsegurable
{
    // 1. CAMPOS / ATRIBUTOS

    private static readonly double COSTO_POR_KILO = 200;
    private static readonly double RECARGO_EXCESO = 20000;

    private double pesoMaximoAdmitido;
    private double valorDeclarado;
    private string descripcionCobertura;
    private bool seguroContratado;

    // 2. CONSTRUCTOR
    public CargaPesada(
    int numeroGuia,
    string destino,
    double kilometros,
    double peso,
    double tarifaPorKilometro,
    double pesoMaximoAdmitido)
    : base(
        numeroGuia,
        destino,
        kilometros,
        peso,
        tarifaPorKilometro)
    {
        this.pesoMaximoAdmitido = pesoMaximoAdmitido;

        valorDeclarado = 0;
        descripcionCobertura = "";
        seguroContratado = false;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public override double CalcularCosto()
    {
        double costoDistancia = Kilometros * TarifaPorKilometro;
        double costoPeso = Peso * COSTO_POR_KILO;
        double costoTotal = costoDistancia + costoPeso;

        if (Peso > pesoMaximoAdmitido)
        {
            costoTotal += RECARGO_EXCESO;
        }

        return costoTotal;
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