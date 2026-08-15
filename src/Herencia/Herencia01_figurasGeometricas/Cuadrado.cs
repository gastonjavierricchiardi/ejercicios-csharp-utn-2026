// src/Herencia/Herencia01_figurasGeometricas/Cuadrado.cs

public class Cuadrado : FiguraGeometrica
{
    // PROPIEDADES
    public double Lado { get; set; }
    // CONSTRUCTOR
    public Cuadrado(string nombre, string color, double lado) : base(nombre, color)
    {
        this.Lado = lado;
    }

    // MÉTODOS
    // para sobre escribir dice el apunte override
    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}