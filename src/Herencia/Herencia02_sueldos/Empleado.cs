// src\Herencia\Herencia02_sueldos\Empleado.cs
// Gastón Ricchiardi (gastonj@hotmail.com)

public abstract class Empleado
{
    // 1. CAMPOS / ATRIBUTOS
    // Estado interno del objeto.
    private int idEmpleado;
    private int faltas;
    // 2. CONSTRUCTOR
    public Empleado(int idEmpleado, int faltas)
    {
        this.idEmpleado = idEmpleado;
        this.faltas = faltas;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public int GetIdEmpleado()
    {
        return idEmpleado;
    }
    public int GetFaltas()
    {
        return faltas;
    }
    /* ALTERNATIVA CON PROPERTIES AUTOMÁTICAS:

    public int IdEmpleado { get; }
    public int Faltas { get; }

    Si quisiéramos permitir también modificación desde afuera:
    public int Faltas { get; set; }
    */

    // 4. MÉTODOS
    public abstract double CalcularSueldoNeto();
}