// EJ-TiendaOnLine (Abstract Factory)
using System.Collections.Generic;

public class Combo
{
    // 1. CAMPOS / ATRIBUTOS
    private List<Producto> productos;
    private string version;
    // 2. CONSTRUCTOR
    public Combo(IFabricaCombo fabrica)
    {
        productos = new List<Producto>();
        version = fabrica.ObtenerVersion();

        ObtenerProductos(fabrica);
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS

    private void ObtenerProductos(IFabricaCombo fabrica)
    {
        foreach (Producto producto in fabrica.ObtenerProductos())
        {
            productos.Add(producto);
        }
    }
    public decimal CalcularPrecioTotal()
    {
        decimal total = 0;

        foreach (Producto producto in productos)
        {
            total += producto.CalcularPrecio();
        }
        return total;
    }

    public string ListarProductos()
    {
        string listado = "";

        foreach (Producto producto in productos)
        {
            listado += producto.Nombre + "\n";
        }
        return listado;
    }
}
