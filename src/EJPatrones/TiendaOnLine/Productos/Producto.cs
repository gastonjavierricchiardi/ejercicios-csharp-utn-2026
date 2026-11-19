// EJ-TiendaOnLine (Abstract Factory)
public abstract class Producto
{
    // 1. CAMPOS / ATRIBUTOS
    private string nombre;
    private string codigo;
    private decimal precio;

    // 2. CONSTRUCTOR
    protected Producto(
        string nombre,
        string codigo,
        decimal precio
    )
    {
        this.nombre = nombre;
        this.codigo = codigo;
        this.precio = precio;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public decimal Precio
    {
        get { return precio; }
        //set { precio = value; }
    }
    public string Codigo
    {
        get { return codigo; }
        //set { codigo = value; }
    }
    public string Nombre
    {
        get { return nombre; }
        //set { nombre = value; }
    }

    // 4. MÉTODOS
    public decimal CalcularPrecio()
    {
        return precio;
    }
}
