// EJ-TiendaOnLine (Abstract Factory)
using System.Collections.Generic;
public interface IFabricaCombo
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    string ObtenerVersion();
    List<Producto> ObtenerProductos();
}