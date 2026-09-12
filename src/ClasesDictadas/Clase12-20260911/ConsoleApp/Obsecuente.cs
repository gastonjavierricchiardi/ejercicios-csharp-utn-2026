public class Obsecuente : Empleado
{
    public override bool AceptaSubir(Micro micro)
    {
        if (micro.EstaLleno())
            return false;
        else
            return this.SuJefe.AceptaSubir(micro); //Hago lo mismo que mi jefe...
    }
}