public class Fiaca : Empleado
{
    public override bool AceptaSubir(Micro micro)
    {
        if (micro.EstaLleno())
            return false;
            
        return micro.HayAsientosDisponibles();
    }
}