// EJ19
public class Articulo
{
    // 1. CAMPOS / ATRIBUTOS
    private string nombre;
    private double costoProduccion;
    private string observacion;

    /* 2. CONSTRUCTOR
    Se puede reducir código encadenando constructores
    public Articulo(string nombre, double costoProduccion)
    : this(nombre, costoProduccion, "")
    {}
    public Articulo(
        string nombre,
        double costoProduccion,
        string observacion
    ){
        this.nombre = nombre;
        this.costoProduccion = costoProduccion;
        this.observacion = observacion;
    }*/
    public Articulo(
        string nombre,
        double costoProduccion
    )
    {
        this.nombre = nombre;
        this.costoProduccion = costoProduccion;
        this.observacion = "";
    }
    // Cómo las observaciones pueden ser opcionales, mantenemos los dos para que
    // pueda crearse
    public Articulo(
        string nombre,
        double costoProduccion,
        string observacion
    )
    {
        this.nombre = nombre;
        this.costoProduccion = costoProduccion;
        this.observacion = observacion;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // Solo necesitamos que se vean desde afuera
    public string Nombre { get { return nombre; } }
    public double CostoProduccion { get { return costoProduccion; } }
    public string Observacion { get { return observacion; } }
    // 4. MÉTODOS
}