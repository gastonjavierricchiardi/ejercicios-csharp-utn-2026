// Console.WriteLine("Hello, World!");
// Pregunra 2
/*
Player player = new Player();
player.update();

class GameObject
{
    public virtual void update()
    {
        Console.WriteLine("Actualizando GameObject...");
    }
}

class Player : GameObject
{
    public override void update()
    {
        base.update();
        Console.WriteLine("Actualizando jugador...");
    }
}
*/
/*
// Pregunta 3

Person employee = new Employee(); // Upcasting implicito
employee.SayHi(); // Llamada al método de la clase base
class Person
{
    public virtual void SayHi()
    {
        Console.WriteLine("Hola, soy una persona.");
    }
}

class Employee : Person
{
    public void SayBye()
    {
        Console.WriteLine("Adiós, soy un empleado.");
    }
}
*/

// Pregunta 7
/*
Employee employee = new Employee();
employee.SayHi(); // Llamada al método de la clase derivada

class Person
{
    public virtual void SayHi()
    {
        Console.WriteLine($"Hola, mi nombre es {this.GetFullName()}.");
    }

    protected virtual string GetFullName()
    {
        return "Nombre Completo (PERSONA)";
    }
}

class Employee : Person
{
    public double file = 123;

    public override void SayHi()
    {
        Console.WriteLine(
$"Hola, mi nombre es {this.GetFullName()} y mi número de legajo es {this.file}."
        );
    }
}
*/

// Pregunta 12
/*
DerivedClass d = new DerivedClass(100);
d.DisplayValue();

class BaseClass
{
    protected double value;
    public BaseClass(double value)
    {
        this.value = value;
    }
}

class DerivedClass : BaseClass
{
    public DerivedClass(double value) : base(value) { }
    public void DisplayValue()
    {
        Console.WriteLine($"El valor es: {this.value}");
    }
}
*/

// Pregunta 14
/*
Car myCar = new Car();
myCar.Honk(); // Llamada al método de la clase base
myCar.TurnEngineOn(); // Llamada al método de la clase derivada

abstract class Vehicle
{
    public abstract bool TurnEngineOn();
    public void Honk()
    {
        Console.WriteLine("¡TU-TUUUUUUUUUUUU");
    }
}

class Car : Vehicle
{
    public override bool TurnEngineOn()
    {
        Console.WriteLine("Encendiendo el motor del coche está encendido.");
        return true;
    }
}
*/
/*
public class Program
{
    static void Main()
    {
        C cInstance = new C();
        cInstance.Method(); // Llamada al método de la clase base
    }
}

class A
{
    public virtual void Method()
    {
        Console.WriteLine("Método de la clase A");
    }
}

class B : A
{
    public override void Method()
    {
        Console.WriteLine("Método de la clase B");
    }
}

class C : B
{
    public override void Method()
    {
        base.Method();
        Console.WriteLine("Método de la clase C");
    }
}
*/

/*

class Person
{
    protected virtual string GetFullName()
    {
        return "John Doe";
    }

    public virtual void SayHi()
    {
        Console.WriteLine($"Hola!");
    }
}

class Employee : Person
{
    public double GetFile()
    {
        return 12345;
    }

    public override void SayHi()
    {
        base.SayHi(); // Lalama al metodo de la clase base
        Console.WriteLine($"Mi legajo es {this.GetFile()}");
    }
}
*/

/*
Shape MyShape = new Shape();
abstract class Shape
{
    public abstract double CalculateArea();
    public virtual string GetShapeName()
    {
        return "Forma Genérica";
    }
}

class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * this.radius * this.radius;
    }
}
*/

Printer generalPrinter = new HigResolutionPrinter(); // Upcasting
generalPrinter.PrintDocument("reporte Anual");

generalPrinter.Calibrate();
// Error: No se puede acceder al método de la clase derivada a través de la referencia de la clase base

class Printer
{
    public virtual void PrintDocument(string doc)
    {
        Console.WriteLine($"Imprimiendo: {doc}");
    }
}

class HigResolutionPrinter : Printer
{
    public override void PrintDocument(string doc)
    {
        Console.WriteLine($"Imprimiendo en alta resolución: {doc}");
    }

    public void Calibrate()
    {
        Console.WriteLine("Calibrando...");
    }
}