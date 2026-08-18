// src\Herencia\Herencia02_sueldos\Gerente.cs

public class Gerente : Empleado
{
    // 1. CAMPOS / ATRIBUTOS

    // 2. CONSTRUCTOR
    public Gerente(int idEmpleado, int faltas)
                : base(idEmpleado, faltas) { }
    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override double CalcularSueldoNeto()
    {
        return 100000;
    }
}