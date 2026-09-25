public class ItemVenta
{
    // 1. CAMPOS / ATRIBUTOS
    private Mueble mueble;
    private int cantidad;

    // 2. CONSTRUCTOR
    public ItemVenta(Mueble mueble, int cantidad)
    {
        this.mueble = mueble;
        this.cantidad = cantidad;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public double CalcularSubtotal()
    {
        mueble.VerificarStock(cantidad);
        return mueble.CalcularPrecio(cantidad);
    }
}