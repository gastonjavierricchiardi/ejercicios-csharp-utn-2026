// EJ19
using System.Collections.Generic;
public class ListaPrecio
{
    // 1. CAMPOS / ATRIBUTOS
    private string nombre;
    /*por ahora lo representamos con string
    revisar DateTime que lo vimos en la tutoría con el profe Andrés*/
    private string fechaTopeVigencia;
    private TipoListaPrecio tipo;
    private List<DetalleListaPrecio> detalles;
    // 2. CONSTRUCTOR
    public ListaPrecio(
        string nombre,
        string fechaTopeVigencia,
        TipoListaPrecio tipo
    )
    {
        this.nombre = nombre;
        this.fechaTopeVigencia = fechaTopeVigencia;
        this.tipo = tipo;

        detalles = new List<DetalleListaPrecio>();
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Nombre { get { return nombre; } }
    public string FechaTopeVigencia { get { return fechaTopeVigencia; } }
    public TipoListaPrecio Tipo { get { return tipo; } }

    public List<DetalleListaPrecio> Detalles { get { return detalles; } }

    // 4. MÉTODOS
    public void AgregarArticulo(
        Articulo articulo,
        double precioVenta
    )
    {
        DetalleListaPrecio detalle = new DetalleListaPrecio(
            articulo,
            precioVenta
        );

        detalles.Add(detalle);
    }
}