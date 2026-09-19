public abstract class Navio
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    private string _flotabilidad;
    public string Flotabilidad
    {
        get { return _flotabilidad; }
        set { _flotabilidad = value; }
    }

    private string _estabilidad;
    public string Estabilidad
    {
        get { return _estabilidad; }
        set { _estabilidad = value; }
    }

    public abstract string GetInformacion();
    
    
    
}