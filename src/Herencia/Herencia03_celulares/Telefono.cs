// /src/Herencia/Herencia03_celulares/Telefono.cs

public abstract class Telefono
{
    // 1. CAMPOS / ATRIBUTOS
    private static double bateriaMaxima = 5;
    private double bateria;

    // 2. CONSTRUCTOR
    public Telefono()
    {
        bateria = bateriaMaxima;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public double ObtenerBateria() { return bateria; }

    // 4. MÉTODOS
    public bool EstaApagado() { return bateria == 0; }

    public void Recargar() { bateria = bateriaMaxima; }

    protected void DescontarBateria(double cantidad)
    {
        bateria = bateria - cantidad;
        if (bateria < 0)
        {
            bateria = 0;
        }
    }

    public abstract void Llamar(Telefono telefono, double duracion);
}