public class Claustrofobico : Empleado
{
    public static int VolumenTolerado = 120;
    
    public override bool AceptaSubir(Micro micro)
    {
        if (micro.EstaLleno())
            return false;
        
        if (micro.Volumen <= Claustrofobico.VolumenTolerado)
            return true;
        else
            return false;
    }
}