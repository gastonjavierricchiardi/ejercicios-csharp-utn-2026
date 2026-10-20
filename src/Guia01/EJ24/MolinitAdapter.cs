// EJ24
public class MolinitAdapter : IMolinete
{
    // 1. CAMPOS / ATRIBUTOS
    private Molinit molinit;

    // 2. CONSTRUCTOR
    public MolinitAdapter(Molinit molinit)
    {
        this.molinit = molinit;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public int ObtenerIngresos() { return molinit.ObtenerEntrada(); }
    public int ObtenerEgresos() { return molinit.ObtenerSalida(); }
}