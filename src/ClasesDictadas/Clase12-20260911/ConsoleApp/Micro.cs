public class Micro
{
    private int cantidadAsientos;
    public int CantidadAsientos
    {
        get { return cantidadAsientos; }
        set { cantidadAsientos = value; }
    }

    private int _cantidadParados;
    public int CantidadParados
    {
        get { return _cantidadParados; }
        set { _cantidadParados = value; }
    }

    private int _volumen;
    public int Volumen
    {
        get { return _volumen; }
        set { _volumen = value; }
    }

    private Empleado _primerEmpleadoEnSubir;
    public Empleado PrimerEmpleadoEnSubir
    {
        get { return _primerEmpleadoEnSubir; }
        set { _primerEmpleadoEnSubir = value; }
    }
    

    private List<Empleado> _parados;
    public List<Empleado> Parados
    {
        get { return _parados; }
        set { _parados = value; }
    }

    private List<Empleado> _sentados;
    public List<Empleado> Sentados
    {
        get { return _sentados; }
        set { _sentados = value; }
    }

    public int CantidadEspaciosDisponibles()
    {
        return 10;
    }


    //Después agregaremos lógica...
    public bool EstaLleno()
    {
        return false;
    }

    public bool HayAsientosDisponibles()
    {
        int cantidadDeAsientosOcupados = 0;

        foreach (Empleado unSentado in Sentados)
        {
            cantidadDeAsientosOcupados ++;            
        }

        if (cantidadDeAsientosOcupados < this.CantidadAsientos)
            return true;
        else 
            return false;
    }
    
    public bool Subir(Empleado empleado)
    {
        if (empleado.AceptaSubir(this))
        {
            Sentados.Add(empleado);
            return true;
        } 
        else
            return false;
    }
    
    
    
    
}