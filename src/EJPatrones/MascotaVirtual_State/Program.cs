using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== MASCOTA CONTENTA ===");
        Mascota contenta = new Mascota(new EstadoContenta());
        Verificar("Puede jugar", contenta.PuedeJugar());
        contenta.Comer();
        Verificar("Comer suma 1", contenta.NivelContenta == 1);
        contenta.Jugar();
        Verificar("Jugar suma 2", contenta.NivelContenta == 3);

        Console.WriteLine("\n=== MASCOTA HAMBRIENTA ===");
        Mascota hambrienta = new Mascota(new EstadoHambrienta());
        Verificar("No puede jugar", !hambrienta.PuedeJugar());
        hambrienta.Jugar();
        Verificar("Jugar no cambia el nivel", hambrienta.NivelContenta == 0);
        hambrienta.Comer();
        Verificar("Comer no suma puntos", hambrienta.NivelContenta == 0);
        hambrienta.Jugar();
        Verificar("Tras comer, juega como contenta", hambrienta.NivelContenta == 2);

        Console.WriteLine("\n=== ABURRIDA HACE MENOS DE 80 MINUTOS ===");
        Mascota aburridaReciente = new Mascota(
            new EstadoAburrida(DateTime.Now.AddMinutes(-79)));
        Verificar("Puede jugar", aburridaReciente.PuedeJugar());
        aburridaReciente.Comer();
        aburridaReciente.Jugar();
        Verificar("Comer no cambia el estado; jugar si", aburridaReciente.NivelContenta == 0);
        aburridaReciente.Comer();
        Verificar("Tras jugar, comer suma 1", aburridaReciente.NivelContenta == 1);

        Console.WriteLine("\n=== ABURRIDA HACE MAS DE 80 MINUTOS ===");
        Mascota aburridaAntigua = new Mascota(
            new EstadoAburrida(DateTime.Now.AddMinutes(-81)));
        aburridaAntigua.Comer();
        Verificar("Comer cambia de estado sin sumar", aburridaAntigua.NivelContenta == 0);
        aburridaAntigua.Jugar();
        Verificar("Tras comer, jugar suma 2", aburridaAntigua.NivelContenta == 2);
    }

    private static void Verificar(string descripcion, bool condicion)
    {
        Console.WriteLine($"{descripcion}: {(condicion ? "OK" : "ERROR")}");
    }
}
