public class Heladera : Elemento
{
    // 1. CAMPOS / ATRIBUTOS
    private int voltaje;
    private bool poseeFreezer;


    // 2. CONSTRUCTOR
    public Heladera(
        string descripcion,
        double alto,
        double ancho,
        double profundidad,
        int numeroIdentificador,
        int voltaje,
        bool poseeFreezer)
        : base(
            descripcion,
            alto,
            ancho,
            profundidad,
            numeroIdentificador)
    {
        this.voltaje = voltaje;
        this.poseeFreezer = poseeFreezer;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS
    public int Voltaje
    {
        get { return voltaje; }
    }

    public bool PoseeFreezer
    {
        get { return poseeFreezer; }
    }

    // 4. MÉTODOS
}