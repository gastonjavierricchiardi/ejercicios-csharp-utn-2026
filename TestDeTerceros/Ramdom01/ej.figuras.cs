
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
//instancio objeto
//tipo 'figuras' nombre fig1 = se construye como tipo real Circulo (parametros brindados. NOTAR, los STRING van ENTRE "")
Figuras fig1 = new Circulo ("Circulo", "Rojo", 3.6); 
//POLIMORFISMO ugcastig, fig1 la declaro como Figuras, pero su TIPO REAL es la clase CIRCULO:
//solo puede llamar a los metodos que figuras conoce, pero la implementacion concreta sera la de circulo

//funcion para mostrar info (de que objeto.info de que método)
//funcion para mostrar (fig1.metodo para objeter nombre)
Console.WriteLine (fig1.getName());
//funcion para mostrar el perimetro (texto adicional + fig1.metodo para perimetro)
Console.WriteLine ("El perimetro de "+ fig1.getName()+ "es:" + fig1.Perimetro()); /*fig1 es de tipo figuras, conoce el metodo perimetro
pero la implementacion concreta seran segun la clase circulo, porque la instancie con el constructor de circulo*/
//funcion para mostrar la devolución del area de fig1
Console.WriteLine ("Su area es: " + fig1.Area()); //figuras conoce el metodo de area, pero la implementacion sera segun circulo

//acá noto el polimorfismo, el tipo de fig2 es FIGURAS, pero cuando llamo al constructor indico q su tipo real es CUADRADO
//construi un objeto que es un cuadrado pero se comportara como de tipo figura (parametros que le doy, string entre "")
Figuras fig2 = new Cuadrado ("cuadrado", "azul", 7);
//metodo para mostrar de fig2 su nombre(getName) y su color (getColor), con texto adicional
Console.WriteLine ("su nombre es: "+ fig2.getName() + "y su color es: " + fig2.getColor());
//metodo para mostrar su perimetro y area
Console.WriteLine ("el area de: "+ fig2.getName()+ " es: "+ fig2.Area() + " y su perimetro es: " + fig2.Perimetro());

//NOTAR: AMBOS OBJ INSTANCIADOS SON 'DE TIPO' FIGURAS, PERO EN EL COSNTRUCTOR SE INDICA SU CLASE REAL.
//los dos podran comportarse como figuras, pero al momento de implementar metodos lo haran como su clase real lo indica.


//creo la clase ABSTRACTA "Figuras", sera abstracta ya que no existe una figura generica
//aca solo creo sus atributos y metodos basicos para todas, toda clase hija debera tener y hacer eso, pero con sus formas concretas
public abstract class Figuras
{   //atributos privados, nombre y color, de tipo string
    private string name;
    private string color;
    
    //metodo getter para obtener el nombre (ya que es privado, directamente no se puede pedir)
    //privacidad + tipo de dato + nombre metodo
    public string getName()
    {
        return name; //me retorna el nombre
    }

    //privacidad + tipo de dato + nombre de metodo
    public string getColor() //getter para obtener color
    {
        return color; //retorna color
    }
    
    //CONSTRUCTOR: aca doy forma a la manera en que se instanciara una FIGURA
    //privacidad + nombre (= al de la clase) + (parametros con los que se inicializa)
    public Figuras (string name, string color)
    {   //inicialización del objeto que se cree con este contructor
        this.name = name;   //al name de ESTE objeto asignale name
        this.color = color; //al color de ESTE objeto asignale color
    }
    
    //metodos abstractos, en toda clase hija debe existir estos comportamientos. Se declara la firma unicamenta
    // me dice ¿que se hace?, pero el cuerpo (¿como se hara?) es propio de cada hija

    //privacidad + condicion de abstracto + firma (tipo de dato + nombre)
    public abstract double Perimetro(); //toda clase hija debe poder calcular su perimetro

    //privacidad + condicion de abstracto + firma
    public abstract double Area(); //toda clase hija debe poder calcular su area 
}

//creo una clase publica llamada Circulo, que HEREDA ==> (:) lo desaclarado en clase Figuras
//notar: no es abtracta, pueden existir obj de esta clase.
public class Circulo : Figuras
{   private double radio; //atributo propio de circulos. 

    //constructor de Circulo. 
    public Circulo (string name, string color, double nuevoRadio) : base (name,color) 
    //'base' = para inicializar name y color llama al constructor del padre. Ahorra escribir codigo
    {   //radio no era un parametro ni un atributo existente en padre, debe inicializarce 
        this.radio = nuevoRadio; //para inicializar radio debe asignar al radio de ESTE obj, el valor de nuevoRadio
    }
    

    //metodo con 'override' implica que la clase hija hace implemencion concreta del metodo abstracto heredado del padre 
    public override double Perimetro() //¿que deberia poder hacer? calcular su perimetro
    {   //si o si debe ser concreta en ¿como se hara el perimetro?:
        return 2*Math.PI*radio;
    }
    
    //implementacion concreta del metodo obstracto Area del padre.
    public override double Area()
    {    //¿como obtendra el area?:
        return Math.PI * Math.Pow(radio,2); 
    }
}

public class Cuadrado : Figuras
{
    private double lado;
    public Cuadrado (string name, string color, double nuevoLado) : base(name, color)
    {
        this.lado = nuevoLado;
    }

    public override double Perimetro()
    {
        Console.WriteLine ("El perimetro del cuadrado es: ");
        return lado*4;
    }

    public override double Area()
    {
        Console.WriteLine ("El area del cuadrado es: ");
        return lado*lado ;
    }

}

//creo clase publica Triangulo que hereda lo que tiene Figuras
public class Triangulo : Figuras
{   //declaro atributos propios de Triangulo
    private double altura;
    private double BaseLado1;
    private double lado2;
    private double lado3; 

    //defino el constructor
     public Triangulo (string name, string color, double altura, double BaseLado1, double lado2, double lado3) : base(name, color)
     //:base me indica que name y color se inicializa segun el constructor del padre
    {   //indico como se inicializan los demas atributos
        this.altura = altura; //a la altura de ESTE obj se le asigna el valor altura
        this.BaseLado1 = BaseLado1; //lo mismo pero con baselado1
        this.lado2= lado2;
        this.lado3 = lado3;
    }
    
    //implemento los metodos abstractos heredados (override señala que es implementacion concreta)
    //si o si debe darle implementacion concreta ¿qué hace?, debe definir el cuerpo obligatoriamente
    public override double Perimetro()
    {   //cuerpo concreto de Perimetro para clase hija Triangulo
        // calcula y retorna el perimetro de un triangulo
        return BaseLado1+lado2+lado3;
    }

    public override double Area()
    {   //cuerpo concreto de Area para tringulo 
        //calculo y retorna el area del triangulo
        return (BaseLado1*altura)/2;
    }
  
  /*NOTAR: Figuras es clase padre. Circulo, cuadro y triangulo son clases hijas.
  la herencia me permitio que todas mis figuras tengan una informacion y comportamiento general de base (lo indicado en clase 
  todos los presentan), a la vez que permite flexibilidad al momento de declarar atributos propios y metodos, 
  ya que cada clase hija tiene requerimientos diferentes. La clase abstracta me otorga la flexibilidad de tener un esquema general 
  de lo que sabran y haran todas mis clases hijas, pero es un modelo, no existe un objeto que pertenezca a esa clase generica 
  (no existe una figura geometrica figura, si o si es triangulo, cuadrado, etc) a la vez que los metodos
  abstractos que contiene me garantiza QUE comportamientos deben existir, ¿como lo haran? sera tarea de cada clase hija
  declarar el cuerpo de los metodos, ya que cada subclase lo hara de forma distinta segun su naturaleza, el metodo abstracto señala QUE HARAN 
  pero no COMO, el QUE se les asigna por herencia, el COMO es propio de cada una. 
  El polimorfismo permite tratar a todos los objetos que instancio como Figuras, pero se construyen dentro de una clase hija, su 'tipo real'
  es el de la clase hija, aunque los trate como de tipo clase padre. Esto es UPCASTING, la fig2 de tipo figura, se comportara como figura,
  pero se construyo como un objeto de clase cuadrado, entonces ¿que hace? lo que hace una figura, ¿como lo hace? como un cuadrado.*/

}

