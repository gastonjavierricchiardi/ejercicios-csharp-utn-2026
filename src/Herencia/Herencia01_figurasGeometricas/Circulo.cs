// src/Herencia/Herencia01_figurasGeometricas/Circulo.cs
public class Circulo : FiguraGeometrica
{
    // PROPIEDADES
    public double Radio { get; set; }

    // 2. CONSTRUCTOR
    public Circulo(string nombre, string color, double radio) : base(nombre, color)
    {
        this.Radio = radio;
    }
    // 4. MÉTODOS (Comportamiento)
    public override double CalcularArea()
    {
        // manejo de errores automatico throw new NotImplementedException();
        // return Math.PI * radio * radio;
        return 3.1416 * Radio * Radio;
    }

    public override double CalcularPerimetro()
    {
        // throw new NotImplementedException();
        return 2 * 3.1416 * Radio;
    }
}
