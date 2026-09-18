// TrenesyDepositos\VagonCarga.cs

public class VagonCarga : Vagon
{
    // 1. CAMPOS / ATRIBUTOS
    private double cargaMaxima;

    // 2. CONSTRUCTOR
    public VagonCarga(double cargaMaxima)
    {
        this.cargaMaxima = cargaMaxima;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS

    public override double PesoMaximo()
    {
        return cargaMaxima + 160;
    }
}