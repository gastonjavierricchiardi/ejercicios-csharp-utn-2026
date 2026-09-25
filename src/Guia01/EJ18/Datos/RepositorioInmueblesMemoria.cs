using System.Collections.Generic;

public class RepositorioInmueblesMemoria
{
    // 1. CAMPOS / ATRIBUTOS

    private List<Inmueble> inmuebles;


    // 2. CONSTRUCTOR

    public RepositorioInmueblesMemoria()
    {
        inmuebles = new List<Inmueble>();
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS


    // 4. MÉTODOS

    public void Guardar(Inmueble inmueble)
    {
        inmuebles.Add(inmueble);
    }

    public List<Inmueble> ObtenerTodos()
    {
        return inmuebles;
    }
}