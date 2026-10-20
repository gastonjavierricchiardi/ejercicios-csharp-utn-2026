// EJ24
public class GiraMaxAdapter : IMolinete
{
    // 1. CAMPOS / ATRIBUTOS
    private GiraMax giraMax;

    // 2. CONSTRUCTOR
    public GiraMaxAdapter(GiraMax giraMax)
    {
        this.giraMax = giraMax;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public int ObtenerIngresos() { return giraMax.GetInboundAccess(); }
    public int ObtenerEgresos() { return giraMax.GetOutboundAccess(); }
}



