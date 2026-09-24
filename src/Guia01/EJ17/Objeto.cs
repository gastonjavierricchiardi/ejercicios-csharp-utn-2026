using System.Collections.Generic;
public class Objeto
{
    // 1. CAMPOS / ATRIBUTOS
    private Material material;
    private double volumen;
    private List<Objeto> contenido;

    // 2. CONSTRUCTOR
    public Objeto(
    Material material,
    double volumen)
    {
        this.material = material;
        this.volumen = volumen;
        contenido = new List<Objeto>();
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public Material Material { get { return material; } }
    public double Volumen { get { return volumen; } }

    // 4. MÉTODOS
    public void AgregarContenido(Objeto objeto)
    {
        contenido.Add(objeto);
    }
    public bool TieneContenido()
    {
        // return contenido.Count > 0;
        // para refactorizar con un foreac, ni siquiera necesitamos contador...
        // Si tiene 1 solo elemento sabemos que teiene contenido.
        foreach (Objeto objeto in contenido)
        {
            return true;
        }
        return false;
    }
    public IEnumerable<Objeto> ObtenerContenido()
    {
        return contenido;
    }
}