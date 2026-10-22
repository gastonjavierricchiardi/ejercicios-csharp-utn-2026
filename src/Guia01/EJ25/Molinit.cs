// EJ24 --> EJ25
public class Molinit
{
    // 1. CAMPOS / ATRIBUTOS
    private int ingresos;
    private int egresos;

    // 2. CONSTRUCTOR
    public Molinit(
        int ingresos,
        int egresos
    )
    {
        this.ingresos = ingresos;
        this.egresos = egresos;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public int ObtenerEntrada() { return ingresos; }
    public int ObtenerSalida() { return egresos; }
}