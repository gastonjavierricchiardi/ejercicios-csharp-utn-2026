// EJ20, EJ19
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

    // CONSTRUCTORES MODIFICADOS EJ20
    public Articulo(
        string nombre,
        double costoProduccion
    )
    {
        ValidarDatos(
        nombre,
        costoProduccion,
        ""
        );
        this.nombre = nombre;
        this.costoProduccion = costoProduccion;
        this.observacion = "";
    }

    // EJ 20 Segundo constructor
    public Articulo(
        string nombre,
        double costoProduccion,
        string observacion
    )
    {
        ValidarDatos(
            nombre,
            costoProduccion,
            observacion
        );
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
    private void ValidarDatos(
        string nombre,
        double costoProduccion,
        string observacion
    )
    {
        // Las validaciones del EJ20
        if (nombre.Length > 15)
        {
            throw new ExceptionArticulo("El nombre no puede superar los 15 caracteres");
        }
        if (costoProduccion <= 0)
        {
            throw new ExceptionArticulo("El costo de producción debe ser mayor a cero");
        }
        if (observacion.Length > 30)
        {
            throw new ExceptionArticulo("La observación no puede superar los 30 caracteres");
        }
    }
}