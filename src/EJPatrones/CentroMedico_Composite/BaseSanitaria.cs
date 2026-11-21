// CentroMedico

public abstract class BaseSanitaria
{
    // 1. CAMPOS / ATRIBUTOS
    private string nombre;
    private string direccion;

    // 2. CONSTRUCTOR
    protected BaseSanitaria(
        string nombre,
        string direccion
    )
    {
        this.nombre = nombre;
        this.direccion = direccion;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Nombre
    {
        get { return nombre; }
    }

    // 4. MÉTODOS
    public string ObtenerDireccion()
    {
        return direccion;
    }

    public abstract int ObtenerCantidadAmbulancias();
    public abstract int ObtenerPersonal();
    public abstract decimal ObtenerTiempoMedio();
}