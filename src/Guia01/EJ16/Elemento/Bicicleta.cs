public class Bicicleta : Elemento
{
    // 1. CAMPOS / ATRIBUTOS
    private int rodado;
    private bool esElectrica;
    private int cantidadCambios;


    // 2. CONSTRUCTOR
    public Bicicleta(
        string descripcion,
        double alto,
        double ancho,
        double profundidad,
        int numeroIdentificador,
        int rodado,
        bool esElectrica,
        int cantidadCambios)
        : base(
            descripcion,
            alto,
            ancho,
            profundidad,
            numeroIdentificador)
    {
        this.rodado = rodado;
        this.esElectrica = esElectrica;
        this.cantidadCambios = cantidadCambios;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS
    public int Rodado
    {
        get { return rodado; }
    }

    public bool EsElectrica
    {
        get { return esElectrica; }
    }

    public int CantidadCambios
    {
        get { return cantidadCambios; }
    }

    // 4. MÉTODOS
}