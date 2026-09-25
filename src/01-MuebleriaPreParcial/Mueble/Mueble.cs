public class Mueble
{
    // 1. CAMPOS / ATRIBUTOS
    private string nombre;
    private double precioUnitario;
    private int stock;

    // 2. CONSTRUCTOR
    public Mueble(string nombre, double precioUnitario, int stock)
    {
        this.nombre = nombre;
        this.precioUnitario = precioUnitario;
        this.stock = stock;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public void VerificarStock(int cantidad)
    {
        if (cantidad > stock)
        {
            throw new StockInsuficienteException($"Stock insuficiente para {nombre}. Stock disponible: {stock}, cantidad solicitada: {cantidad}.");
        }
    }
    public virtual double CalcularPrecio(int cantidad)
    {
        return precioUnitario * cantidad;
    }
}