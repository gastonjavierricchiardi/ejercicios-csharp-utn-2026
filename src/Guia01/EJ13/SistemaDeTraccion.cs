// /src/Guia01/EJ13/SistemaDeTraccion.cs
// Gastón Ricchiardi(Gastonj@hotmail.com)

public abstract class SistemaDeTraccion
{
    // 1. ATRIBUTOS
    private string entorno = "";

    // 2. CONSTRUCTOR

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Entorno
    {
        get => entorno;
        set => entorno = value;
    }

    // 4. MÉTODOS (Comportamiento)
    public abstract double AvanceMaximo();

    public abstract double Desgaste();

    public abstract string GetInfoExtra();

    public abstract string GetTipoTraccion();
}