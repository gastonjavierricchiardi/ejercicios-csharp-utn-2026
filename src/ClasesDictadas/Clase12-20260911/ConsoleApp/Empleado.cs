public abstract class Empleado
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private bool _esJefe;
    public bool EsJefe
    {
        get { return _esJefe; }
        set { _esJefe = value; }
    }

    private Empleado _suJefe;
    public Empleado SuJefe
    {
        get { return _suJefe; }
        set { _suJefe = value; }
    }


    public abstract bool AceptaSubir(Micro micro);
    
    
}