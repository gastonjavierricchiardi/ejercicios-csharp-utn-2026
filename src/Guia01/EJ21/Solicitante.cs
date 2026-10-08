// EJ21
public class Solicitante
{
    // 1. CAMPOS / ATRIBUTOS
    private string dni;
    private double sueldoBruto;
    private int antiguedadEmpleoActual;

    // 2. Constructor
    public Solicitante(
        string dni,
        double sueldoBruto,
        int antiguedadEmpleoActual
    )
    {
        this.dni = dni;
        this.sueldoBruto = sueldoBruto;
        this.antiguedadEmpleoActual = antiguedadEmpleoActual;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS / generados con propfull
    public int AntiguedadEmpleoActual
    {
        get => antiguedadEmpleoActual;
        // set => antiguedadEmpleoActual = value;
    }
    public double SueldoBruto
    {
        get => sueldoBruto;
        // set => sueldoBruto = value;
    }
    public string Dni
    {
        get { return dni; }
        // set { dni = value; }
    }
    // 4. MÉTODOS
}