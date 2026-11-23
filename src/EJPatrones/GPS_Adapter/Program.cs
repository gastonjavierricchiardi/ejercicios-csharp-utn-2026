// GPS_Adapter
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Posición geográfica: Buenos Aires.
        CoordenadaGeografica posicion =
            new CoordenadaGeografica(-34.6037, -58.3816);

        // Módulo GPS original.
        List<string> satelites = new List<string>
        {
            "Satelite 1",
            "Satelite 2",
            "Satelite 3"
        };

        ModuloGPS moduloGPS =
            new ModuloGPS(satelites, posicion);

        // Adaptador utilizado mediante su interfaz.
        IProveedorPosicionUTM proveedor =
            new AdaptadorGPS(moduloGPS);

        // El cliente obtiene coordenadas UTM.
        CoordenadaUTM posicionUTM =
            proveedor.ObtenerPosicionUTM();

        Console.WriteLine("=== COORDENADAS UTM ===");
        Console.WriteLine($"Este: {posicionUTM.Este:F2}");
        Console.WriteLine($"Norte: {posicionUTM.Norte:F2}");
        Console.WriteLine($"Zona: {posicionUTM.Zona}");
        Console.WriteLine($"Hemisferio: {posicionUTM.Hemisferio}");
    }
}
