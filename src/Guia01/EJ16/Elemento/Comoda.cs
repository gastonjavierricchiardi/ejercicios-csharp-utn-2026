public class Comoda : Elemento
{
    // 1. CAMPOS / ATRIBUTOS
    private double superficie;
    private int cantidadCajones;


    // 2. CONSTRUCTOR
    public Comoda(
        string descripcion,
        double alto,
        double ancho,
        double profundidad,
        int numeroIdentificador,
        double superficie,
        int cantidadCajones)
        : base(
            descripcion,
            alto,
            ancho,
            profundidad,
            numeroIdentificador)
    {
        this.superficie = superficie;
        this.cantidadCajones = cantidadCajones;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS
    public double Superficie
    {
        get { return superficie; }
    }

    public int CantidadCajones
    {
        get { return cantidadCajones; }
    }

    // 4. MÉTODOS
}