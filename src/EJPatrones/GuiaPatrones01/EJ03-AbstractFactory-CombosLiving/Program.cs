// EJ03-AbstractFactory
using System;
public class Program
{
    public static void Main() //static void Main(string[] args) // si tiene que recibir datos por consola
    {
        MostrarCombo(new FabricaModerna());
        MostrarCombo(new FabricaClasica());
    }
    private static void MostrarCombo(IFabricaLiving fabrica)
    {
        ISilla silla = fabrica.CrearSilla();
        IMesa mesa = fabrica.CrearMesa();

        silla.Mostrar();
        mesa.Mostrar();
    }
}