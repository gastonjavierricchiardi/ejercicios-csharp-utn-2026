public class Empresa
{
    private string razonSocial;
    public string RazonSocial
    {
        get { return razonSocial; }
        set { razonSocial = value; }
    }
    private List<Empleado> empleados;
    public List<Empleado> Empleados
    {
        get { return empleados; }
        set { empleados = value; }
    }

    public Empresa(string razonSocial, List<Empleado> empleados)
    {
        this.RazonSocial = razonSocial;
        this.Empleados = empleados;
    }
    public double CalcularSueldo(Empleado empleado)
    {
        //sueldo = neto + bonopresentismo + bonoresultado
        double sueldo = 0;
        sueldo = empleado.Categoria.DevolverNeto() + empleado.BonoPorResultado.DevolverBono(empleado) + empleado.BonoPorPresentismo.DevolverBono(empleado);

        return sueldo;
    }

    public void ImprimirRecibos()
    {
        foreach (Empleado unEmpleado in this.Empleados)
        {
            Console.WriteLine($"El sueldo de {unEmpleado.Apellido}, cuya categoria es {unEmpleado.Categoria.ToString()}, es de $ {this.CalcularSueldo(unEmpleado)}");
        }
    }
    
    
}