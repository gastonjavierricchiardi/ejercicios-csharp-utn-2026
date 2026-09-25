// src\Program.cs
// gastonj@hotmail.com

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Mueble silla = new Mueble(
            "Silla",
            10000,
            10
        );

        MesaCuadrada mesa = new MesaCuadrada(
            "Mesa cuadrada",
            20000,
            5,
            1,
            1
        );

        Placard placard = new Placard(
            "Placard",
            50000,
            2,
            2,
            1,
            1
        );

        List<ItemVenta> items = new List<ItemVenta>();

        items.Add(new ItemVenta(silla, 2));
        items.Add(new ItemVenta(mesa, 1));
        items.Add(new ItemVenta(placard, 1)); // sacamos el 1 y reemplazamos por 3 para ver
        // Que no haya stock

        Venta venta = new Venta();

        double total = venta.RealizarVenta(items);

        Console.WriteLine($"Precio total de la venta: ${total}");
    }
}