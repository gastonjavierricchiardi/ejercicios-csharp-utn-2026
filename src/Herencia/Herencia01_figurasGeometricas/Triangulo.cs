// src/Herencia/Herencia01_figurasGeometricas/Triangulo.cs
// Gastón Ricchiardi (gastonj@hotmail.com)

public class Triangulo : FiguraGeometrica
{
    // PROPIEDADES / ATRIBUTOS
    public double Base { get; set; }
    public double Altura { get; set; }
    public double LadoA { get; set; }
    public double LadoB { get; set; }
    public double LadoC { get; set; }

    // CONSTRUCTOR
    public Triangulo(
        string nombre,
        string color,
        double baseTriangulo,
        double altura,
        double ladoA,
        double ladoB,
        double ladoC
    ) : base(nombre, color)
    {
        Base = baseTriangulo;
        Altura = altura;
        LadoA = ladoA;
        LadoB = ladoB;
        LadoC = ladoC;
    }
    // 4. MÉTODOS (Comportamiento)
    public override double CalcularArea()
    {
        // throw new NotImplementedException();
        return Base * Altura / 2;
    }

    public override double CalcularPerimetro()
    {
        // throw new NotImplementedException();
        return LadoA + LadoB + LadoC;
    }




    // 3. PROPIEDADES / GETTERS Y SETTERS
}