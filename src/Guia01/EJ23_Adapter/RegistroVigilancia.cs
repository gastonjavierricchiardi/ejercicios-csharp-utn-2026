// EJ23
using System;
public class RegistroVigilancia
{
    // 1. CAMPOS / ATRIBUTOS
    private int idDispositivo;
    private string tipo;
    private string tamanio;
    private string observaciones;
    // 2. CONSTRUCTOR
    public RegistroVigilancia(
        int id,
        string tipo,
        string tamanio,
        string observaciones
    )
    {
        this.idDispositivo = id;
        this.tipo = tipo;
        this.tamanio = tamanio;
        this.observaciones = observaciones;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public int IdDispositivo
    {
        get { return idDispositivo; }
        //        set { idDispositivo = value; }
    }

    public string Tipo
    {
        get { return tipo; }
        //        set { tipo = value; }
    }
    public string Tamanio
    {
        get { return tamanio; }
        //        set { tamanio = value; }
    }
    public string Observaciones
    {
        get { return observaciones; }
        //        set { observaciones = value; }
    }
    // 4. MÉTODOS
}