// /src/Herencia/Herencia03_celulares/Persona.cs
public class Persona
{
    // 1. CAMPOS / ATRIBUTOS
    private string userName;
    private Telefono telefono;

    // 2. CONSTRUCTOR
    public Persona(string userName, Telefono telefono)
    {
        this.userName = userName;
        this.telefono = telefono;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public Telefono ObtenerTelefono()
    {
        return telefono;
    }

    // 4. MÉTODOS
    public bool TieneCelularApagado()
    {
        return telefono.EstaApagado();
    }
}