// TrenesyDepositos\VagonPasajeros.cs

public class VagonPasajeros : Vagon
{
    // 1. CAMPOS / ATRIBUTOS
    private double largo;
    private double anchoUtil;

    // 2. CONSTRUCTOR
    public VagonPasajeros(
        double largo,
        double anchoUtil)
    {
        this.largo = largo;
        this.anchoUtil = anchoUtil;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public override double CantidadPasajeros()
    {
        if (anchoUtil <= 2.5)
        {
            return largo * 8;
        }

        return largo * 10;
    }

    public override double PesoMaximo()
    {
        return CantidadPasajeros() * 80;
    }
}