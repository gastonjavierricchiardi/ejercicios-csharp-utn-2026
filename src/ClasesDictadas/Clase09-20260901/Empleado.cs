public class Empleado : Persona, ICosteable
{
    public static readonly double CargasSociales = 1.4;

    public Empleado()
    {
    }

     public Empleado(string nombre, string apellido) : base(nombre, apellido)
    {
        
    }
    public Empleado(string nombre, string apellido, int legajo, int antiguedad) : base (nombre, apellido)
    {
        Legajo = legajo;
        Antiguedad = antiguedad;
    }

    public double SueldoBruto {get; set;}
    public int Legajo { get; set; }
    public int Antiguedad { get; set; }

    public DatosContacto Contacto { get; set; }

    public double CalcularBonoAntiguedad()
    {
        return Antiguedad * 1.25;
    }

    public override string Saludar()
    {
        return $"{GetFullName()} mi legajo: {Legajo}, llamame al {(Contacto != null ? Contacto.Telefono : "No tengo fono")}";
    }

    public double CalcularCosto()
    {
        return SueldoBruto * CargasSociales;
    }

    public override bool Equals(object obj)
    {
        return obj is Empleado && ((Empleado) obj).Legajo == this.Legajo;
    }

    public override int GetHashCode()
    {
        return this.Legajo;
    }
}