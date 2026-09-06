// src/Guia01/EJ15/LanchaMedica.cs
public class LanchaMedica : Navio
{
    // 1. CAMPOS / ATRIBUTOS
    private string maniobrabilidad = "";
    private string tipoMotor = "";
    private int capacidadGrua;

    // 2. CONSTRUCTOR

    public LanchaMedica(
        string nombre,
        string flotabilidad,
        string estabilidad,
        string maniobrabilidad,
        string tipoMotor,
        int capacidadGrua
    ) : base(nombre, flotabilidad, estabilidad)
    {
        this.maniobrabilidad = maniobrabilidad;
        this.tipoMotor = tipoMotor;
        this.capacidadGrua = capacidadGrua;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Maniobrabilidad { get => maniobrabilidad; }
    public string TipoMotor { get => tipoMotor; }
    public int CapacidadGrua { get => capacidadGrua; }

    // 4. MÉTODOS
    // Comportamiento del objeto.
}