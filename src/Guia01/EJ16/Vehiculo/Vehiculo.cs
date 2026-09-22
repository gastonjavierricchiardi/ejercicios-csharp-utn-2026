using System.Collections.Generic;

public abstract class Vehiculo
{
    // 1. CAMPOS / ATRIBUTOS
    private List<Elemento> carga;

    // 2. CONSTRUCTOR
    protected Vehiculo()
    {
        carga = new List<Elemento>();
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public abstract void Cargar(Elemento elemento);

    public List<Elemento> ListarItems()
    {
        List<Elemento> items = new List<Elemento>();

        foreach (Elemento elemento in carga)
        {
            items.Add(elemento);
        }

        return items;
    }

    protected bool TieneCapacidad(int capacidadMaxima)
    {
        int cantidad = 0;

        foreach (Elemento elemento in carga)
        {
            cantidad++;
        }

        return cantidad < capacidadMaxima;
    }

    protected void AgregarElemento(Elemento elemento)
    {
        carga.Add(elemento);
    }
}