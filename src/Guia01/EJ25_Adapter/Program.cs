// EJ24 --> EJ25

using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)  // Crear objetos y probar el ejercicio
    {
        // Creamos la lista de molinetes
        List<IMolinete> molinetes = new List<IMolinete>();

        // Incorporamos los molinetes mediante sus adaptadores
        molinetes.Add(new GiraMaxAdapter(new GiraMax(12, 5)));
        molinetes.Add(new MolinitAdapter(new Molinit(8, 3)));

        // Incorporamos el molinete del EJ 25
        molinetes.Add(new RotativityAdapter(new Rotativity(20, 9)));

        // Consultamos todos de la misma manera

        foreach (IMolinete molinete in molinetes)
        {
            System.Console.WriteLine("Ingresos  : " + molinete.ObtenerIngresos());
            System.Console.WriteLine("Egresos   : " + molinete.ObtenerEgresos());
            System.Console.WriteLine();
        }
    }
}