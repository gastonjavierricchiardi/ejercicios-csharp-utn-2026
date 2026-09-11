public class ExcepcionPersona : Exception
{
    private string _mensaje;
    public string Mensaje
    {
        get { return _mensaje; }
        set { _mensaje = value; }
    }

    public ExcepcionPersona(string mensaje)
    {
        this.Mensaje = mensaje;
    }
    
}