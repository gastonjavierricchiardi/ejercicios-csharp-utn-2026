namespace MisClases;

public abstract class Envio
{
    private int numeroGuia;
    private string destino;
    private double kilometros;
    private double peso;
    private double tarifaPorKilometro;

    protected Envio(
        int numeroGuia,
        string destino,
        double kilometros,
        double peso,
        double tarifaPorKilometro)
    {
        this.numeroGuia = numeroGuia;
        this.destino = destino;
        this.kilometros = kilometros;
        this.peso = peso;
        this.tarifaPorKilometro = tarifaPorKilometro;
    }

    public int NumeroGuia
    {
        get { return numeroGuia; }
    }

    public string Destino { get { return destino; } }

    protected double Kilometros { get { return kilometros; } }

    protected double Peso { get { return peso; } }

    protected double TarifaPorKilometro { get { return tarifaPorKilometro; } }

    public abstract double CalcularCosto();
}