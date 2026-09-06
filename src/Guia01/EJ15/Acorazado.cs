// src/Guia01/EJ15/Acorazado.cs

public class Acorazado : Navio
{
    // 1. CAMPOS / ATRIBUTOS
    private string solidez = "";
    private string blindaje = "";
    private string potenciaFuego = "";
    private double velocidadCrucero;

    // 2. CONSTRUCTOR
    public Acorazado(
        string nombre,
        string flotabilidad,
        string estabilidad,
        string solidez,
        string blindaje,
        string potenciaFuego,
        double velocidadCrucero
    ) : base(nombre, flotabilidad, estabilidad)
    {
        this.solidez = solidez;
        this.blindaje = blindaje;
        this.potenciaFuego = potenciaFuego;
        this.velocidadCrucero = velocidadCrucero;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Solidez { get => solidez; }

    public string Blindaje { get => blindaje; }

    public string PotenciaFuego { get => potenciaFuego; }

    public double VelocidadCrucero { get => velocidadCrucero; }

    // 4. MÉTODOS
}