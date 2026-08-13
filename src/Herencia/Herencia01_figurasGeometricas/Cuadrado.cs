// src/Herencia/Herencia01_figurasGeometricas/Cuadrado.cs

public class Cuadrado : FiguraGeometrica
{
    // PROPIEDADES
    public double lado { get; set; }
    // CONSTRUCTOR
    public Cuadrado(string nombre, string color, double lado) : base(nombre, color)
    {
        this.lado = lado;
    }

    // MÉTODOS
    // para sobre escribir dice el apunte override
    public override double CalcularArea()
    {
        return lado * lado;
    }

    public override double CalcularPerimetro()
    {
        return 4 * lado;
    }



}