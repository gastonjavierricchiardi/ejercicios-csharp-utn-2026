// EJ26

public abstract class UnidadCorreo
{
    // 1. CAMPOS / ATRIBUTOS
    private int id;
    private string nombre;

    // 2. CONSTRUCTOR
    protected UnidadCorreo(
        int id,
        string nombre
    )
    {
        this.id = id;
        this.nombre = nombre;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Nombre
    {
        get { return nombre; }
        //set { nombre = value; }
    }
    public int Id
    {
        get { return id; }
        //set { id = value; }
    }
    // 4. MÉTODOS
}


