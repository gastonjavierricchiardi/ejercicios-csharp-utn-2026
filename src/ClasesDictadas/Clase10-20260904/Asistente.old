public abstract class Asistente
{
    private int dni;
    public int DNI
    {
        get { return dni; }
        set { dni = value; }
    }

    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }


    public override bool Equals(object? obj)
    {
        return  ((Asistente)obj).DNI == this.DNI;
    }

    public override int GetHashCode()
    {
        return this.DNI;
    }


    public Asistente(int documento, string nombre)
    {
        this.Nombre = nombre;
        this.DNI = documento;
    }


    public abstract string InformarBeneficio();


    
    
}