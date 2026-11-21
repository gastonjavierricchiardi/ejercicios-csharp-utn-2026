// EJ-TiendaOnLine (Abstract Factory)
public abstract class Kit : Producto
{
    // 1. CAMPOS / ATRIBUTOS
    private bool bluetooht;

    // 2. CONSTRUCTOR
    protected Kit(
        string nombre,
        string codigo,
        decimal precio,
        bool bluetooht
        ) : base(nombre, codigo, precio)
    {
        this.bluetooht = bluetooht;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
}