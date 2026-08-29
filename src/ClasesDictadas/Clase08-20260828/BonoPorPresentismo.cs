public abstract class BonoPorPresentismo
{
    
    public abstract double DevolverBono(Empleado empleado);

}

public class BonoFijo : BonoPorPresentismo
{
    public override double DevolverBono(Empleado empleado)
    {
        return 500;
    }
}

public class BonoA : BonoPorPresentismo
{
    public override double DevolverBono(Empleado empleado)
    {
        int faltas = empleado.Ausentes;
        if( faltas ==  0) return 1000;
        else  
            if(faltas == 1)
                return 450;
            else
                return 0;
    }
}