// src/Herencia/Herencia01_figurasGeometricas/Program.cs
// Gastón Ricchiardi (gastonj@hotmail.com)
public class Program
{
    public static void Main()
    {
        // Crear objetos y probar el ejercicio
        // Pruena Cuadrado
        Cuadrado cuadrado1 = new Cuadrado("Cuadrado", "Rojo", 4);
        Console.WriteLine(cuadrado1.ObtenerInformacion());

        Cuadrado cuadrado2 = new Cuadrado("Cuadrado", "Azul", 6);
        Console.WriteLine(cuadrado2.ObtenerInformacion());

        Console.WriteLine();

        // Prueba Circulo

        Circulo circulo1 = new Circulo("Circulo", "Verde", 5);
        Console.WriteLine(circulo1.ObtenerInformacion());

        Circulo circulo2 = new Circulo("Circulo", "Amarillo", 2);
        Console.WriteLine(circulo2.ObtenerInformacion());

        Console.WriteLine();

        // Pruebas Triangulo
        Triangulo triangulo1 = new Triangulo("Triangulo", "Azul", 3, 4, 3, 4, 5);
        Console.WriteLine(triangulo1.ObtenerInformacion());

        Triangulo triangulo2 = new Triangulo("Triangulo", "Violeta", 6, 4, 5, 5, 6);
        Console.WriteLine(triangulo2.ObtenerInformacion());





    }
}
