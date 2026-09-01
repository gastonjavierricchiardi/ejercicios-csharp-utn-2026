public abstract class Persona
{

    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    private string apellido;
    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }

    private string documento;
    public string Documento
    {
        get { return documento; }
        set { documento = value; }
    }

    private DateTime fechaNacimiento;
    public DateTime FechaNacimiento
    {
        get { return fechaNacimiento; }
        set { fechaNacimiento = value; }
    }

    public int Edad => (DateTime.Now.Year - fechaNacimiento.Year);

    public abstract string Saludar(Persona receptorSaludo);
    public Persona(string nombre, string apellido)
    {
        this.Apellido = apellido;
        this.Nombre = nombre;
    }

    public abstract string Presentarse();
}