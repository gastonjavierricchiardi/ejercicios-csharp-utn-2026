namespace MisClases;

public abstract class Envio
{
    // 1. CAMPOS / ATRIBUTOS
    private int numeroGuia;
    private string destino;
    private double kilometros;
    private double peso;
    private double tarifaPorKilometro;

    // 2. CONSTRUCTOR
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

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public int NumeroGuia { get { return numeroGuia; } }
    public string Destino { get { return destino; } }
    protected double Kilometros { get { return kilometros; } }
    protected double Peso { get { return peso; } }

    // 4. MÉTODOS
    protected double TarifaPorKilometro { get { return tarifaPorKilometro; } }
    public abstract double CalcularCosto(); // Abstracto
}