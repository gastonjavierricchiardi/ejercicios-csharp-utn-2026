// EJ19
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
}