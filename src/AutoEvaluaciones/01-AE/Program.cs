// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* Cuál de las siguientes veriones respeta el encapsulamiento y por qué?
public class Puerta
{
    public bool abierta;
}

public class Puerta
{
    private bool abierta;
    public void Abrir() { abierta = true; }
    public void Cerrar() { abierta = false; }
}
*/

public class Puerta
{
    private bool abierta;
}

public class Program
{
    static void Main()
    {
        Puerta p = new Puerta();
        p.abierta = true;
    }
}





/* ¿Que ocurre al compilar el siguiente código?
a) Compila y ejecuta sin inconvenientes?
b) Falla la compilación, porque falta declarar el constructor de Puerta? -> esta erre <-
c) Compila, pero el valor asignado se pierde al finalizar el Main?
d) Falla la compilación, porque abierta es privada y no es accesible desde Program
*/