// EJ22
using System;
public class Documento
{
    // 1. CAMPOS / ATRIBUTOS
    private int expediente;
    private DateTime lanzamiento;
    private string contenido;
    private string nombre;

    // 2. CONSTRUCTOR
    public Documento(
        int expediente,
        DateTime lanzamiento,
        string contenido,
        string nombre
    )
    {
        this.expediente = expediente;
        this.lanzamiento = lanzamiento;
        this.contenido = contenido;
        this.nombre = nombre;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Nombre
    {
        get { return nombre; }
        //set { nombre = value; }
    }
    public string Contenido
    {
        get { return contenido; }
        //set { contenido = value; }
    }
    public DateTime Lanzamiento
    {
        get { return lanzamiento; }
        //set { lanzamiento = value; }
    }
    public int Expediente
    {
        get { return expediente; }
        //set { expediente = value; }
    }


    // 4. MÉTODOS
}
