public class CoordenadaUTM
{
    // 1. CAMPOS / ATRIBUTOS
    private double este;
    private double norte;
    private int zona;
    private string hemisferio;

    // 2. CONSTRUCTOR
    public CoordenadaUTM(
        double este,
        double norte,
        int zona,
        string hemisferio)
    {
        this.este = este;
        this.norte = norte;
        this.zona = zona;
        this.hemisferio = hemisferio;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public double Este
    {
        get { return este; }
    }

    public double Norte
    {
        get { return norte; }
    }

    public int Zona
    {
        get { return zona; }
    }

    public string Hemisferio
    {
        get { return hemisferio; }
    }

    // 4. MÉTODOS
}