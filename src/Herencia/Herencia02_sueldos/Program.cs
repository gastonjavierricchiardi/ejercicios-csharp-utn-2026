/* src\Herencia\Herencia02_sueldos\Program.cs
Gastón Ricchiardi (gastonj@hotmail.com)
Una empresa desea crear un programa para calcular el sueldo de sus empleados. La fórmula para calcular el sueldo de un empleado es la siguiente:

`Sueldo = neto + bonopresentismo + bonoresultado`

Los empleados pueden categorizarse en:

- Gerente. Sueldo neto 100000
- Administrativo. Sueldo neto 40000
- Operador. Sueldo neto 10500
- Cadete. Sueldo neto 1000

Existen 2 bonos por presentismo.

El bono A asigna:

- $1000 si el empleado no faltó nunca.
- $450 si el empleado faltó 1 única vez
- $0 en cualquier otro caso.

El bono B siempre suma $500 (cero pesos).

El bono por resultados ofrece 3 posibilidades:

- 10% sobre el sueldo neto en caso de objetivo cumplido
- $800 fijos en caso de cumplir el 80& del objetivo
- $0 (cero pesos) en cualquier otro caso.

Desarrolle una aplicación que permita calcular el sueldo de un empleado. Pruebe distintos escenarios.

*/

public class Program
{
    static void Main(string[] args)
    {
        Gerente gerente1 = new Gerente(1, 0); // id: 1 - Faltas: 0

        Console.WriteLine($"ID: {gerente1.GetIdEmpleado()}");
        Console.WriteLine($"Faltas: {gerente1.GetFaltas()}");
        Console.WriteLine($"Sueldo neto: {gerente1.CalcularSueldoNeto()}");

        Administrativo administrativo1 = new Administrativo(2, 1);

        Console.WriteLine($"ID: {administrativo1.GetIdEmpleado()}");
        Console.WriteLine($"Faltas: {administrativo1.GetFaltas()}");
        Console.WriteLine($"Sueldo neto: {administrativo1.CalcularSueldoNeto()}");

        Operador operador1 = new Operador(3, 2);

        Console.WriteLine($"ID: {operador1.GetIdEmpleado()}");
        Console.WriteLine($"Faltas: {operador1.GetFaltas()}");
        Console.WriteLine($"Sueldo neto: {operador1.CalcularSueldoNeto()}");

        Cadete cadete1 = new Cadete(4, 0);

        Console.WriteLine($"ID: {cadete1.GetIdEmpleado()}");
        Console.WriteLine($"Faltas: {cadete1.GetFaltas()}");
        Console.WriteLine($"Sueldo neto: {cadete1.CalcularSueldoNeto()}");

        // ---
        CalculadorSueldo calculador = new CalculadorSueldo();
        Console.WriteLine();

        Console.WriteLine("BONO PRESENTISMO A");
        Console.WriteLine($"Gerente: {calculador.CalcularBonoPresentismoA(gerente1)}");
        Console.WriteLine($"Administrativo: {calculador.CalcularBonoPresentismoA(administrativo1)}");
        Console.WriteLine($"Operador: {calculador.CalcularBonoPresentismoA(operador1)}");
        Console.WriteLine($"Cadete: {calculador.CalcularBonoPresentismoA(cadete1)}");

        Console.WriteLine();
        Console.WriteLine("BONO PRESENTISMO B");
        Console.WriteLine($"Bono presentismo B: {calculador.CalcularBonoPresentismoB()}");

        Console.WriteLine();
        Console.WriteLine("BONO RESULTADO");
        Console.WriteLine($"Gerente objetivo 100%: {calculador.CalcularBonoResultado(gerente1, 100)}");
        Console.WriteLine($"Administrativo objetivo 80%: {calculador.CalcularBonoResultado(administrativo1, 80)}");
        Console.WriteLine($"Operador objetivo 50%: {calculador.CalcularBonoResultado(operador1, 50)}");
        Console.WriteLine($"Cadete objetivo 100%: {calculador.CalcularBonoResultado(cadete1, 100)}");

        Console.WriteLine();
        Console.WriteLine("SUELDO FINAL:");

        Console.WriteLine($"Gerente: {calculador.CalcularSueldo(gerente1, 100)}");
        Console.WriteLine($"Administrativo: {calculador.CalcularSueldo(administrativo1, 80)}");
        Console.WriteLine($"Operador: {calculador.CalcularSueldo(operador1, 50)}");
        Console.WriteLine($"Cadete: {calculador.CalcularSueldo(cadete1, 100)}");
    }
}