public class Televisor : Elemento
{
    // 1. CAMPOS / ATRIBUTOS
    private int voltaje;
    private TipoPantalla tipoPantalla;
    private bool esInteligente;


    // 2. CONSTRUCTOR
    public Televisor(
        string descripcion,
        double alto,
        double ancho,
        double profundidad,
        int numeroIdentificador,
        int voltaje,
        TipoPantalla tipoPantalla,
        bool esInteligente)
        : base(
            descripcion,
            alto,
            ancho,
            profundidad,
            numeroIdentificador)
    {
        this.voltaje = voltaje;
        this.tipoPantalla = tipoPantalla;
        this.esInteligente = esInteligente;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS
    public int Voltaje
    {
        get { return voltaje; }
    }

    public TipoPantalla TipoPantalla
    {
        get { return tipoPantalla; }
    }

    public bool EsInteligente
    {
        get { return esInteligente; }
    }

    // 4. MÉTODOS
}