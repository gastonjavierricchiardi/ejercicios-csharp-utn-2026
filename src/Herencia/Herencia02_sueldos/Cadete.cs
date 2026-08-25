// src\Herencia\Herencia02_sueldos\Cadete.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
public class Cadete : Empleado
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public Cadete(int idEmpleado, int faltas)
        : base(idEmpleado, faltas) { }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override double CalcularSueldoNeto()
    {
        return 1000;
    }
}