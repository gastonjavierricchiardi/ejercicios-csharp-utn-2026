// EJ-TiendaOnLine (Abstract Factory)
public abstract class Webcam : Producto
{
    // 1. CAMPOS / ATRIBUTOS
    private string resolucion;
    // 2. CONSTRUCTOR
    protected Webcam(
        string nombre,
        string codigo,
        decimal precio,
        string resolucion // Agregamos los atributos locales
        ) : base(nombre, codigo, precio)
    {
        this.resolucion = resolucion;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
}