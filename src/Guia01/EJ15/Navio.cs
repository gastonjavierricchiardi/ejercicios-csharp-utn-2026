// src/Guia01/EJ15/Navio.cs



public abstract class Navio
{
    // 1. CAMPOS / ATRIBUTOS
    private string nombre = "";
    private string flotabilidad = "";
    private string estabilidad = "";

    // 2. CONSTRUCTOR
    protected Navio(
        string nombre,
        string flotabilidad,
        string estabilidad)
    {
        this.nombre = nombre;
        this.flotabilidad = flotabilidad;
        this.estabilidad = estabilidad;
    }

    public string Nombre { get => nombre; }
    public string Flotabilidad { get => flotabilidad; }
    public string Estabilidad { get => estabilidad; }


    // 3. PROPIEDADES / GETTERS Y SETTERS
    // Formas de exponer o modificar el estado.

    // 4. MÉTODOS
    // Comportamiento del objeto.
}