// TrenesyDepositos\Locomotora.cs

public class Locomotora
{
    // 1. CAMPOS / ATRIBUTOS
    private double peso;
    private double pesoMaximoArrastre;
    private double velocidadMaxima;

    // 2. CONSTRUCTOR
    public Locomotora(
        double peso,
        double pesoMaximoArrastre,
        double velocidadMaxima
    )
    {
        this.peso = peso;
        this.pesoMaximoArrastre = pesoMaximoArrastre;
        this.velocidadMaxima = velocidadMaxima;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // Necesitamos leer la velocidad maxima de la Locomotora desde formación para poder calcular, le ponemos la property
    public double VelocidadMaxima
    {
        get { return this.velocidadMaxima; }
    }

    // Necesito exponer el peso de la locomotora para saber si esCompleja
    public double Peso
    {
        get { return peso; }
    }

    // 4. MÉTODOS
    public double ArrastreUtil()
    {
        return pesoMaximoArrastre - peso;
    }

    public bool EsEficiente()
    {
        return ArrastreUtil() >= peso * 5;
    }
}