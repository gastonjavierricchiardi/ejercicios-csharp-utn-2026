public class Persona
{
    
    private int dni;
    public int Dni
    {
        get { return dni; }
        set { dni = value; }
    }

    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private string _apellido;
    public string Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }

    public string Saludar()
    {
        return $"Soy {this.Apellido}, {this.Nombre}";
    }

    public Persona(int dni, string nombre, string apellido)
    {

        if (dni == 0)
            throw new ExcepcionPersona("El DNI no puede ser cero");
        if (string.IsNullOrEmpty(nombre))
            throw new ExcepcionPersona("El nombre no puede ser nulo o vacio");

        if (string.IsNullOrEmpty(apellido))
            throw new ExcepcionPersona("El nombre no puede ser nulo o vacio");

        this.Dni = dni;
        this.Apellido = apellido;
        this.Nombre = nombre;
    }
}