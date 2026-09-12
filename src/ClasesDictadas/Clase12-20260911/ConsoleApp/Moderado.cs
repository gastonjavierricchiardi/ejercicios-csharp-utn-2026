public class Moderado : Empleado
{

    private int toleranciaEspacioDisponible;
    public int ToleranciaEspacioDisponible
    {
        get { return toleranciaEspacioDisponible; }
        set { toleranciaEspacioDisponible = value; }
    }
    

    public Moderado(int tolerancia)
    {
        this.toleranciaEspacioDisponible = tolerancia;
    }
    public override bool AceptaSubir(Micro micro)
    {
        if (micro.EstaLleno())
            return false;
        else
        {
            if (micro.CantidadEspaciosDisponibles() < this.ToleranciaEspacioDisponible)
                return false;
            else
                return true;
        }
    }
}