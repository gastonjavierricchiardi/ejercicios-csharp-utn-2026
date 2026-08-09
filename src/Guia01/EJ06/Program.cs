/* Guia01\EJ06\Program.cs
6. Crear una clase `Fruta` con variables privadas `color`, `peso`, `esEstacional`.
    - Crear setters y getters.
    - Escribir una función llamada `EsComestible()` que devuelva verdadero cuando la fruta pesa menos de 200 gr y es de estación, y falso en cualquier otro caso.
    - Definir dos constructores de modo tal que la fruta pueda crearse con los valores `color`, `peso` y `estacional` al momento de instanciarse, o bien
    crearse sin valores iniciales.
*/
public class Program
{
    public static void Main()
    {
        // A) Crear con valores
        Fruta frutaA = new Fruta("Roja", 150, true);

        Console.WriteLine(
            $"Fruta A ---> {frutaA.GetColor()} {frutaA.GetPeso()} gramos. Estacional: {frutaA.GetEsEstacional()}"
        );

        // Esperado: True
        Console.WriteLine($"Fruta A ---> es comestible? {frutaA.EsComestible()}");


        // B) Crear sin valores y asignarlos posteriormente
        Fruta frutaB = new Fruta();

        frutaB.SetColor("Verde");
        frutaB.SetPeso(220);
        frutaB.SetEsEstacional(true);

        Console.WriteLine(
            $"Fruta B ---> {frutaB.GetColor()} {frutaB.GetPeso()} gramos. Estacional: {frutaB.GetEsEstacional()}"
        );

        // Esperado: False
        Console.WriteLine($"Fruta B ---> es comestible? {frutaB.EsComestible()}");


        // C) Crear con valores
        Fruta frutaC = new Fruta("Verde", 201, true);

        Console.WriteLine(
            $"Fruta C ---> {frutaC.GetColor()} {frutaC.GetPeso()} gramos. Estacional: {frutaC.GetEsEstacional()}"
        );

        // Esperado: False
        Console.WriteLine($"Fruta C ---> es comestible? {frutaC.EsComestible()}");


        // D) Peso < 200 pero NO es estacional
        Fruta frutaD = new Fruta("Amarilla", 150, false);

        Console.WriteLine(
            $"Fruta D ---> {frutaD.GetColor()} {frutaD.GetPeso()} gramos. Estacional: {frutaD.GetEsEstacional()}"
        );

        // Esperado: False
        Console.WriteLine($"Fruta D ---> es comestible? {frutaD.EsComestible()}");
    }
}