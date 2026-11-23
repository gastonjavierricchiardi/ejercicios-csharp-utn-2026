public class CoordenadaGeografica
{
    // 1. CAMPOS / ATRIBUTOS
    private double latitud;
    private double longitud;

    // 2. CONSTRUCTOR
    public CoordenadaGeografica(
        double latitud,
        double longitud)
    {
        this.latitud = latitud;
        this.longitud = longitud;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public double Latitud
    {
        get { return latitud; }
    }

    public double Longitud
    {
        get { return longitud; }
    }

    // 4. MÉTODOS
}