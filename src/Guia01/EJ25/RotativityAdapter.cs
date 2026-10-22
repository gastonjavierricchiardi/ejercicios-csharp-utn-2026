// Exclusivo del EJ25
public class RotativityAdapter : IMolinete
{
    // 1. CAMPOS / ATRIBUTOS
    private Rotativity rotativity;

    // 2. CONSTRUCTOR
    public RotativityAdapter(Rotativity rotativity) { this.rotativity = rotativity; }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public int ObtenerIngresos() { return rotativity.GetUsage()[0]; }
    public int ObtenerEgresos() { return rotativity.GetUsage()[1]; }
}