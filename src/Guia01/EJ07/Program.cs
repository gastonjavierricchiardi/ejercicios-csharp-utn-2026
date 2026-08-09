/* Guia01\EJ07\Program.cs
7. Crear una clase `Ninja` con las variables privadas `arteMarcial`, `arma`, `fuerza` (entero) y `salto` (entero).
    - Crear setters y getters manualmente.
    - Crear una función `Saltar()` que reciba un parámetro `multiplicador` (entero); imprimir por consola `salto` x parámetro.
    - Crear la función `Ataque()` que imprima por consola el arma que usa el ninja y el arte marcial.
    - Crear dos instancias de `Ninja`, asignar distintos valores para cada uno de los atributos e invocar las funciones `Saltar()` y `Ataque()`.
*/
public class Program
{
    public static void Main()
    {
        Ninja ninja1 = new Ninja();

        ninja1.SetArteMarcial("Karate");
        ninja1.SetArma("Katana");
        ninja1.SetFuerza(80);
        ninja1.SetSalto(3);

        ninja1.Saltar(2);
        ninja1.Ataque();

        Console.WriteLine();

        Ninja ninja2 = new Ninja();

        ninja2.SetArteMarcial("Jiu-Jitsu");
        ninja2.SetArma("Nunchaku");
        ninja2.SetFuerza(65);
        ninja2.SetSalto(5);

        ninja2.Saltar(3);
        ninja2.Ataque();
    }
}

/*
Primer ninja
6 → salto = 3 × multiplicador = 2.
Arma: Katana - Arte marcial: Karate → salida de Ataque().
Segundo ninja
15 → salto = 5 × multiplicador = 3.
Arma: Nunchaku - Arte marcial: Jiu-Jitsu → salida de Ataque().
La línea vacía entre ambos ninjas viene de Console.WriteLine();.
*/