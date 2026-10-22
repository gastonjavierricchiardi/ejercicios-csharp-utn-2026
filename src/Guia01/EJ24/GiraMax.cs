// EJ24
public class GiraMax
{
    // 1. CAMPOS / ATRIBUTOS
    private int ingresos;
    private int egresos;

    // 2. CONSTRUCTOR
    public GiraMax(int ingresos, int egresos)
    {
        this.ingresos = ingresos;
        this.egresos = egresos;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public int Ingresos
    {
        get { return ingresos; }
        //set { ingresos = value; }
    }
    public int Egresos
    {
        get { return egresos; }
        //set { egresos = value; }
    }
    // 4. MÉTODOS

    public int GetInboundAccess()
    {
        return ingresos;
    }

    public int GetOutboundAccess()
    {
        return egresos;
    }
}