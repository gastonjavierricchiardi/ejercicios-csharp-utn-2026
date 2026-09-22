public class Lavarropas : Elemento
{
    // 1. CAMPOS / ATRIBUTOS
    private int voltaje;
    private double carga;
    private int revolucionesCentrifugado;


    // 2. CONSTRUCTOR
    public Lavarropas(
        string descripcion,
        double alto,
        double ancho,
        double profundidad,
        int numeroIdentificador,
        int voltaje,
        double carga,
        int revolucionesCentrifugado)
        : base(
            descripcion,
            alto,
            ancho,
            profundidad,
            numeroIdentificador)
    {
        this.voltaje = voltaje;
        this.carga = carga;
        this.revolucionesCentrifugado = revolucionesCentrifugado;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS
    public int Voltaje
    {
        get { return voltaje; }
    }

    public double Carga
    {
        get { return carga; }
    }

    public int RevolucionesCentrifugado
    {
        get { return revolucionesCentrifugado; }
    }

    // 4. MÉTODOS
}