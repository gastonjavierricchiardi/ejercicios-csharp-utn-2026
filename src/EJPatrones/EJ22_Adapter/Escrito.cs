// EJ22
using System;
public class Escrito
{
    // 1. CAMPOS / ATRIBUTOS
    private int legajo;
    private DateTime erogacion;
    private string cuerpo;
    private string autor;

    // 2. CONSTRUCTOR
    public Escrito(
        int legajo,
        DateTime erogacion,
        string cuerpo,
        string autor
    )
    {
        this.legajo = legajo;
        this.erogacion = erogacion;
        this.cuerpo = cuerpo;
        this.autor = autor;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Autor
    {
        get { return autor; }
        //set { autor = value; }
    }
    public string Cuerpo
    {
        get { return cuerpo; }
        //set { cuerpo = value; }
    }
    public DateTime Erogacion
    {
        get { return erogacion; }
        //set { erogacion = value; }
    }
    public int Legajo
    {
        get { return legajo; }
        //set { legajo = value; }
    }
    // 4. MÉTODOS
}
