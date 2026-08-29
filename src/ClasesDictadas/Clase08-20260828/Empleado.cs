public class Empleado
{
    
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    
    private string apellido;
    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }
    

    private int ausentes;
    public int Ausentes
    {
        get { return ausentes; }
        set { ausentes = value; }
    }
    private float porcentajeObjetivoCumplido;
    public float PorcentajeDeObjetivoCumplido
    {
        get { return porcentajeObjetivoCumplido; }
        set { porcentajeObjetivoCumplido = value; }
    }

    private BonoPorResultado bonoPorResultado;
    public BonoPorResultado BonoPorResultado
    {
        get { return bonoPorResultado; }
        set { bonoPorResultado = value; }
    }
    
    
    public Empleado(string nombre, string apellido, int ausentes, BonoPorPresentismo bonoPorPresentismo, BonoPorResultado bonoPorResultado, float porcentajeObjetivo, ICategoria categoria)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Ausentes = ausentes;
        this.Categoria = categoria;
        this.BonoPorPresentismo = bonoPorPresentismo;
        this.BonoPorResultado = bonoPorResultado;
    }

    private BonoPorPresentismo bonoPorPresentismo;
    public BonoPorPresentismo BonoPorPresentismo
    {
        get { return bonoPorPresentismo; }
        set { bonoPorPresentismo = value; }
    }
    

    private ICategoria categoria;
    public ICategoria Categoria
    {
        get { return categoria; }
        set { categoria = value; }
    }
    
}