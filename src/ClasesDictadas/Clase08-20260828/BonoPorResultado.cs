public class BonoPorResultado
{
    public double DevolverBono(Empleado empleado)
    {
        float objetivoCumplido = empleado.PorcentajeDeObjetivoCumplido;
        if (objetivoCumplido == 100)
            return empleado.Categoria.DevolverNeto() * 0.1;
    
        if(objetivoCumplido >= 80)
            return 800;

        return 0;
    }
}