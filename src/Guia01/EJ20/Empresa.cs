// EJ20, EJ19
using System.Collections.Generic;
public class Empresa
{
    // 1. CAMPOS / ATRIBUTOS
    private List<Articulo> articulos;
    private List<ListaPrecio> listasDePrecio;

    // 2. CONSTRUCTOR, no crea los articulos ni las listas: Recibe objetos ya construido
    public Empresa()
    {
        articulos = new List<Articulo>();
        listasDePrecio = new List<ListaPrecio>();
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public List<Articulo> Articulos { get { return articulos; } }
    public List<ListaPrecio> ListasDePrecio { get { return listasDePrecio; } }

    // 4. MÉTODOS
    public void DarDeAlta(Articulo articulo)
    {
        articulos.Add(articulo);
    }
    public void AgregarListaPrecio(ListaPrecio lista)
    {
        listasDePrecio.Add(lista);
    }
    public void AjustarPrecios()
    {
        foreach (Articulo articulo in articulos)
        {
            double precioMayor = 0;
            bool encontroPrecio = false;

            // PRIMER RECORRIDO:
            // buscar el precio más alto del artículo
            foreach (ListaPrecio lista in listasDePrecio)
            {
                foreach (DetalleListaPrecio detalle in lista.Detalles)
                {
                    if (detalle.Articulo == articulo)
                    {
                        if (encontroPrecio == false || detalle.PrecioVenta > precioMayor)
                        {
                            precioMayor = detalle.PrecioVenta;
                            encontroPrecio = true;
                        }
                    }
                }
            }

            // SEGUNDO RECORRIDO:
            // ajustar los precios que superen la diferencia permitida
            if (encontroPrecio)
            {
                double precioMinimoPermitido =
                    precioMayor / 1.30;

                foreach (ListaPrecio lista in listasDePrecio)
                {
                    foreach (DetalleListaPrecio detalle in lista.Detalles)
                    {
                        if (detalle.Articulo == articulo)
                        {
                            if (detalle.PrecioVenta < precioMinimoPermitido)
                            {
                                detalle.ActualizarPrecio(precioMinimoPermitido);
                            }
                        }
                    }
                }
            }
        }
    }
}