// src/Guia01/EJ15/Acorazado.cs

public class Acorazado : Navio
{
    // 1. CAMPOS / ATRIBUTOS
    private string solidez = "";
    private string potenciaFuego = "";
    private string maniobrabilidad = "";
    private double velocidadCrucero;
    // 2. CONSTRUCTOR
    public Acorazado(
        string nombre,
        string flotabilidad,
        string estabilidad,
        string solidez,
        string potenciaFuego,
    string maniobrabilidad,
        double velocidadCrucero
    ) : base(nombre, flotabilidad, estabilidad)
    {
        this.solidez = solidez;
        this.potenciaFuego = potenciaFuego;
        this.maniobrabilidad = maniobrabilidad;
        this.velocidadCrucero = velocidadCrucero;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Solidez { get => solidez; }
    public string PotenciaFuego { get => potenciaFuego; }
    public string Maniobrabilidad { get => maniobrabilidad; }
    public double VelocidadCrucero { get => velocidadCrucero; }


    // 4. MÉTODOS
    // Comportamiento del objeto.
}
