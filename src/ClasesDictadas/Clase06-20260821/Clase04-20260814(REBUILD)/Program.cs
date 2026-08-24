// Rebuil de clase 04 dictada en clase 06 (Andrés)


Cuadrado cuadrado = new Cuadrado(5);
cuadrado.Color = "Azul";

Console.WriteLine(cuadrado.GetInfo());

Triangulo unTriangulo = new Triangulo(3, 8, 10, 5);
unTriangulo.Color = "Verde";

Console.WriteLine(unTriangulo.GetInfo());

Circulo objCirculo = new Circulo(10);
objCirculo.Color = "violeta";
Console.WriteLine(objCirculo.GetInfo());

public abstract class Figura
{
    private string nombre;
    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    private string color;
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public abstract double GetArea();


    public abstract double GetPerimetro();


    public string GetInfo()
    {
        return string.Format("Soy la figura {0}, con color {1} y mi perimetro es {2} con un área de {3}", nombre, color, this.GetPerimetro(), this.GetArea());
    }
}

public class Cuadrado : Figura
{
    private double lado;
    public double Lado
    {
        get { return lado; }
        set { lado = value; }
    }

    public Cuadrado(double lado)
    {
        this.lado = lado;
        this.Nombre = "Cuadrado";
    }

    public override double GetArea()
    {
        return lado * lado;
    }

    public override double GetPerimetro()
    {
        return 4 * lado;
    }

}

public class Triangulo : Figura
{
    private double _base;
    public double Base
    {
        get { return _base; }
        set { _base = value; }
    }

    private double altura;
    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    private double lado2;
    public double Lado2
    {
        get { return lado2; }
        set { lado2 = value; }
    }

    private double lado3;
    public double Lado3
    {
        get { return lado3; }
        set { lado3 = value; }
    }



    public Triangulo(double unaBase, double unaAltura, double lado2, double lado3)
    {
        this.Altura = unaAltura;
        this.Base = unaBase;
        this.Nombre = "Triangulo";
        this.Lado2 = lado2;
        this.Lado3 = lado3;
    }

    public override double GetArea()
    {
        return this.Altura * this.Base / 2;
    }

    public override double GetPerimetro()
    {
        //base.GetPerimetro();
        Console.WriteLine("Base: " + this.Base + " Lado2: " + this.Lado2 + " Lado3: " + this.Lado3);
        return this.Base + this.Lado2 + this.Lado3;
    }

}

public class Circulo : Figura
{
    private double radio;
    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }

    public override double GetArea()
    {
        return this.Radio * this.Radio * 3.14;
    }

    public override double GetPerimetro()
    {
        return this.Radio * 3.14;
    }

    public Circulo(double radio)
    {
        this.Radio = radio;
        this.Nombre = "Círculo";
    }

}