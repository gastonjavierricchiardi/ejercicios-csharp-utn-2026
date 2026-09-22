public abstract class Elemento
{
    // 1. CAMPOS / ATRIBUTOS
    private string descripcion;
    private double alto;
    private double ancho;
    private double profundidad;
    private int numeroIdentificador;


    // 2. CONSTRUCTOR
    protected Elemento(
        string descripcion,
        double alto,
        double ancho,
        double profundidad,
        int numeroIdentificador)
    {
        this.descripcion = descripcion;
        this.alto = alto;
        this.ancho = ancho;
        this.profundidad = profundidad;
        this.numeroIdentificador = numeroIdentificador;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Descripcion
    {
        get { return descripcion; }
    }

    public double Alto
    {
        get { return alto; }
    }

    public double Ancho
    {
        get { return ancho; }
    }

    public double Profundidad
    {
        get { return profundidad; }
    }

    public int NumeroIdentificador
    {
        get { return numeroIdentificador; }
    }

    // 4. MÉTODOS
}
