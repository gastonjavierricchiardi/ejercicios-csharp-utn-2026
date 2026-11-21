// EJ-TiendaOnLine (Abstract Factory)
public abstract class Headset : Producto
{
    // 1. CAMPOS / ATRIBUTOS
    private bool bluetooth;
    private bool noiceCancelling;

    // 2. CONSTRUCTOR
    protected Headset(
        string nombre,
        string codigo,
        decimal precio,
        bool bluetooth,// los dos concretos
        bool noiceCancelling
        ) : base(nombre, codigo, precio)
    {
        this.bluetooth = bluetooth;
        this.noiceCancelling = noiceCancelling;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
}