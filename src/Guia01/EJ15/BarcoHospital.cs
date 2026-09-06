// src/Guia01/EJ15/BarcoHospital.cs

public class BarcoHospital : Navio
{
    // 1. CAMPOS / ATRIBUTOS
    private int capacidadPacientes;

    // 2. CONSTRUCTOR
    public BarcoHospital(
        string nombre,
        string flotabilidad,
        string estabilidad,
        int capacidadPacientes
    ) : base(nombre, flotabilidad, estabilidad)
    {
        this.capacidadPacientes = capacidadPacientes;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public int CapacidadPacientes
    {
        get => capacidadPacientes;
    }
    // 4. MÉTODOS
}