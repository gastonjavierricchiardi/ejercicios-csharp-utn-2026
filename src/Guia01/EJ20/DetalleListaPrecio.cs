// EJ19
public class DetalleListaPrecio
{
    // 1. CAMPOS / ATRIBUTOS
    private Articulo articulo;
    private double precioVenta;

    // 2. CONSTRUCTOR
    public DetalleListaPrecio(
        Articulo articulo,
        double precioVenta
    )
    {
        this.articulo = articulo;
        this.precioVenta = precioVenta;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public Articulo Articulo { get { return articulo; } }
    public double PrecioVenta { get { return precioVenta; } }
    // 4. MÉTODOS
    // Para el EJ 20, necesitamos que el precio se pueda modificar lo dejamos encapsulado, pero agregamos un método
    public void ActualizarPrecio(double nuevoPrecio)
    {
        precioVenta = nuevoPrecio;
    }
}