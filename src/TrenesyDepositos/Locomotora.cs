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

    // 4. MÉTODOS

    public double ArrastreUtil()
    {
        return pesoMaximoArrastre - peso;
    }
}