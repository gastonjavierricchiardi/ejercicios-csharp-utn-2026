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