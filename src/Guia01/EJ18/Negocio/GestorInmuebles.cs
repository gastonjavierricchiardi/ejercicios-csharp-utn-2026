using System.Collections.Generic;

public class GestorInmuebles
{
    // 1. CAMPOS / ATRIBUTOS

    private RepositorioInmueblesMemoria repositorio;


    // 2. CONSTRUCTOR

    public GestorInmuebles(RepositorioInmueblesMemoria repositorio)
    {
        this.repositorio = repositorio;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS


    // 4. MÉTODOS

    public bool DarDeAlta(Inmueble inmueble)
    {
        if (!inmueble.EstaCompleto())
        {
            return false;
        }

        repositorio.Guardar(inmueble);

        return true;
    }

    public List<Inmueble> ObtenerInmuebles()
    {
        return repositorio.ObtenerTodos();
    }
}