// Exclusivo del EJ25
public class Rotativity
{
    // 1. CAMPOS / ATRIBUTOS
    private int ingresos;
    private int egresos;

    // 2. CONSTRUCTOR
    public Rotativity(
        int ingresos,
        int egresos
    )
    {
        this.ingresos = ingresos;
        this.egresos = egresos;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public int[] GetUsage()
    {
        return new int[] { ingresos, egresos };
    }
}