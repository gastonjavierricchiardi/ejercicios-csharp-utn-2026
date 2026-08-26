using System.Runtime.CompilerServices;

public abstract class Persona
{
    public Persona()
    {
        name = "Juan";
        LastName = "Perez";
    }

    public Persona(string nombre, string apellido)
    {
        name = nombre;
        LastName = apellido;
    }

    protected string name;
    public string LastName
    {
        get { return field.Trim().ToUpper(); }

        set { field = value.Trim(); }
    }

    public string GetName()
    {
        return this.name.Trim().ToUpper();
    }

    public void SetName(string name)
    {
        this.name = name.Trim();
    }

    public virtual string GetFullName()
    {
        return $"{this.name}, {this.LastName}";
    }

    public abstract string Saludar();
    public abstract double CalcularCosto();
}