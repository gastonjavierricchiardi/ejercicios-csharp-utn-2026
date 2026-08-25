// src\Herencia\Herencia02_sueldos\CalculadorSueldo.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
public class CalculadorSueldo
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public double CalcularBonoPresentismoA(Empleado empleado)
    {
        if (empleado.GetFaltas() == 0)
        {
            return 1000;
        }

        if (empleado.GetFaltas() == 1)
        {
            return 450;
        }
        return 0;
    }

    public double CalcularBonoPresentismoB() { return 500; } // Veremos si se agrega mas lógica

    public double CalcularBonoResultado(Empleado empleado, double objetivo)
    {
        if (objetivo == 100)
        {
            return empleado.CalcularSueldoNeto() * 0.10;
        }

        if (objetivo == 80)
        {
            return 800;
        }
        return 0;
    }

    public double CalcularSueldo(Empleado empleado, double objetivo)
    {
        double sueldoNeto = empleado.CalcularSueldoNeto();
        double bonoPresentismo = CalcularBonoPresentismoA(empleado) + CalcularBonoPresentismoB();
        double bonoResultado = CalcularBonoResultado(empleado, objetivo);

        return sueldoNeto + bonoPresentismo + bonoResultado;
    }
}