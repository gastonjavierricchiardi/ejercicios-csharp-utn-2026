// src\Herencia\Herencia02_sueldos\Administativo.cs

public class Administrativo : Empleado
{
    // 1. CAMPOS / ATRIBUTOS

    // 2. CONSTRUCTOR
    public Administrativo(int IdEmpleado, int faltas)
        : base(IdEmpleado, faltas) { }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override double CalcularSueldoNeto()
    {
        return 40000;
    }
}