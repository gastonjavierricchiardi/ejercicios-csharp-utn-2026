// src\Herencia\Herencia02_sueldos\Operador.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
public class Operador : Empleado
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public Operador(int idEmpleado, int faltas)
        : base(idEmpleado, faltas) { }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // Formas de exponer o modificar el estado.

    // 4. MÉTODOS
    public override double CalcularSueldoNeto()
    {
        return 10500;
    }
}