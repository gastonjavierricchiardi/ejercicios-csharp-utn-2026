// src/TrenesyDepositos/Program.cs

public class Program
{
    public static void Main()
    {
        // Creamos un vagón de carga con capacidad máxima de 5000 kg.
        VagonCarga vagonCarga = new VagonCarga(5000);

        // Vagón de pasajeros de 10 m de largo y 2 m de ancho útil.
        VagonPasajeros vagonPasajerosAngosto =
            new VagonPasajeros(10, 2);

        // Vagón de pasajeros de 10 m de largo y 3 m de ancho útil.
        VagonPasajeros vagonPasajerosAncho =
            new VagonPasajeros(10, 3);


        Console.WriteLine("=== VAGÓN DE CARGA ===");
        Console.WriteLine(
            $"Peso máximo: {vagonCarga.PesoMaximo()} kg"
        );


        Console.WriteLine();

        Console.WriteLine("=== VAGÓN DE PASAJEROS ANGOSTO ===");
        Console.WriteLine(
            $"Cantidad de pasajeros: {vagonPasajerosAngosto.CantidadPasajeros()}"
        );
        Console.WriteLine(
            $"Peso máximo: {vagonPasajerosAngosto.PesoMaximo()} kg"
        );


        Console.WriteLine();

        Console.WriteLine("=== VAGÓN DE PASAJEROS ANCHO ===");
        Console.WriteLine(
            $"Cantidad de pasajeros: {vagonPasajerosAncho.CantidadPasajeros()}"
        );
        Console.WriteLine(
            $"Peso máximo: {vagonPasajerosAncho.PesoMaximo()} kg"
        );
    }
}