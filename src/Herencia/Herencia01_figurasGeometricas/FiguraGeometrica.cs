// Herencia/Herencia01_figurasGeometricas/FiguraGeometrica.cs

public abstract class FiguraGeometrica
{
    // ATRIBUTOS / PROPIEDADES / GETTERS Y SETTERS
    public string Nombre { get; set; }
    public string Color { get; set; }

    // 2. CONSTRUCTOR

    public FiguraGeometrica(string nombre, string color)
    {
        Nombre = nombre;
        Color = color;
    }


    // 4. MÉTODOS Abstractos
    // Solo se firman, cada Heredado lo implementa como quiere.
    public abstract double CalcularArea();

    public abstract double CalcularPerimetro();

    // 4. MÉTODOS (Comportamiento) Concreto

    public string ObtenerInformacion()
    {
        return $"Nombre: {Nombre} - Color: {Color} - " + $"Perímetro: {CalcularPerimetro()} - Área: {CalcularArea()}";
    }
}