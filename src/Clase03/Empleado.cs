public class Empleado : Persona
{
    // int legajo;
    public int Legajo { get; set; }
    public int Antiguedad { get; set; }

    public double CalcularBonoAntiguedad()
    {
        return Antiguedad * 1.25;
    }
}