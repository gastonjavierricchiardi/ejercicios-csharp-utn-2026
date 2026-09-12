public class Apurado : Empleado
{
    public override bool AceptaSubir(Micro micro)
    {
        if (micro.EstaLleno())
            return false;
        else
            return true;
    }
}