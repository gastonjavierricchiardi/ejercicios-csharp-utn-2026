/*
Clase 04 - 14/8/2026.
Profesor Andrés:
Hola a todos,

Les dejo un breve resumen de lo que trabajamos en la clase de hoy.

📐 DIAGRAMA DE CLASES
Trabajamos sobre la representación de clases mediante diagramas de clases, analizando cómo representar atributos, métodos y las relaciones entre las diferentes clases.

También comenzamos a trabajar con el concepto de herencia, identificando qué características son comunes a una clase padre y cuáles son específicas de sus clases hijas.

El diagrama de clases que realizamos durante la clase nos sirvió como una primera aproximación al diseño de la solución.

Cuando pasamos del diagrama a la implementación, nos dimos cuenta de que necesitábamos revisar algunas de las decisiones que habíamos tomado inicialmente. Por ejemplo, en el caso del Triángulo, inicialmente habíamos considerado la base y la altura, pero al momento de calcular el perímetro vimos que necesitábamos conocer también los otros dos lados del triángulo, ya que la base representa solamente uno de sus lados.

Esto es algo importante para tener en cuenta: el diseño y la implementación están relacionados y el diseño puede necesitar ser revisado a medida que comprendemos mejor el problema que estamos resolviendo.

Les adjunto la solución que desarrollamos en conjunto durante la clase para resolver el primer ejercicio utilizando herencia.

---> DIAGRAMA

Ejercicio – Figuras geométricas
Desarrollar una aplicación que permita conocer el área y el perímetro de un triángulo, de un cuadrado y de un círculo. Cada figura posee un nombre y un color. La aplicación debe permitir obtener para cada una de las figuras su nombre, color, perímetro y área.

Para probar esta aplicación, cree por lo menos 1 figura de cada tipo y muestre el resultado de invocar a sus métodos.

Implemente la misma solución utilizando polimorfismo.

A partir de este ejercicio trabajamos con una clase Figura que contiene características y comportamientos comunes, y luego creamos las clases Cuadrado, Triángulo y Círculo, que heredan de ella.

También vimos cómo sobrescribir métodos. Para poder hacerlo, en la clase padre debemos indicar que el método puede ser sobrescrito utilizando virtual:

public virtual double GetArea()
{
    return 1;
}
Luego, en las clases hijas, podemos redefinir ese comportamiento utilizando override:

public override double GetArea()
{
    return lado * lado;
}
Lo mismo hicimos con el método GetPerimetro().

¿Vimos polimorfismo?
Sí, ya tuvimos un primer acercamiento al polimorfismo, particularmente al utilizar métodos virtual y override.

Sin embargo, todavía no lo desarrollamos en profundidad. Vamos a trabajar el concepto de polimorfismo con mayor detalle en las próximas clases, viendo cómo podemos trabajar con una referencia del tipo de la clase padre y, en tiempo de ejecución, ejecutar el comportamiento correspondiente a la clase hija.

Por ahora, lo importante es que comprendan la relación entre:

Herencia → clase padre y clases hijas → virtual (en clase padre) → override (en la clase hija que cambiamos el comportamiento)

y que puedan identificar qué características y comportamientos son comunes y cuáles corresponden específicamente a cada tipo de figura.

La solución que desarrollamos durante la clase queda como material de referencia para que puedan revisarla y volver a probarla en sus propios proyectos.

Saludos, buen fin de semana,

Andrés

*/


Figura unaFigura = new Figura();
unaFigura.Color = "Rojo";
unaFigura.Nombre = "Figura";

Console.WriteLine(unaFigura.GetInfo());

Cuadrado cuadrado = new Cuadrado(5);
cuadrado.Color = "Azul";

Console.WriteLine(cuadrado.GetInfo());

Triangulo unTriangulo = new Triangulo(3, 8, 10, 5);
unTriangulo.Color = "Verde";

Console.WriteLine(unTriangulo.GetInfo());

Circulo objCirculo = new Circulo(10);
objCirculo.Color = "violeta";
Console.WriteLine(objCirculo.GetInfo());

public class Figura
{
    private string nombre = "";
    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    private string color = "";
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public virtual double GetArea()
    {
        return (double)1;
    }

    public virtual double GetPerimetro()
    {
        return (double)1;
    }

    // public Figura(string color, string nombre)
    // {
    //     this.color = color;
    //     this.nombre = nombre;
    // }

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
        return this.Radio * this.Radio * 3.1416;
    }

    public override double GetPerimetro()
    {
        // return this.Radio * 3.14;
        return 2 * this.Radio * 3.1416;
    }

    public Circulo(double radio)
    {
        this.Radio = radio;
        this.Nombre = "Círculo";
    }
}