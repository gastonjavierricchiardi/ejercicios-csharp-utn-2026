// src/TrenesyDepositos/Program.cs
using System.Collections.Generic;

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

        /*Locomotora
        Peso propio: 1000kg
        Peso máximo de arrastre: 12000kg
        Velocidad Máx: 80 km/h.
        */
        Locomotora locomotora = new Locomotora(1000, 12000, 80);
        Console.WriteLine();
        Console.WriteLine("=== LOCOMOTORA ===");
        Console.WriteLine(
            $"Arrastre útil: {locomotora.ArrastreUtil()} kg."
        );

        // Formación: la formación necesita una lista de locomotoras.
        List<Locomotora> locomotoras = new List<Locomotora>
        {
            locomotora
        };

        // La formación contiene distintos tipos de vagones.
        List<Vagon> vagones = new List<Vagon>
        {
            vagonCarga,
            vagonPasajerosAngosto,
            vagonPasajerosAncho
        };

        Formacion formacion = new Formacion(
            locomotoras,
            vagones
        );

        Console.WriteLine();
        Console.WriteLine("=== FORMACIÓN ===");
        Console.WriteLine(
            $"Capacidad total de pasajeros: {formacion.TotalPasajeros()}"
        );

        // Hasta acá la formación, no tiene vagones que apliquen a la regla de 
        Console.WriteLine(
            $"Cantidad de vagones livianos: {formacion.CantidadVagonesLivianos()}"
        );

        // Creamos un vagón de carga de 2000 kg de capacidad.
        // Su peso máximo será 2000 + 160 = 2160 kg.
        // Por lo tanto, es un vagón liviano.
        VagonCarga vagonCargaLiviano = new VagonCarga(2000);

        // Lo agregamos a la lista de vagones que ya existe.
        vagones.Add(vagonCargaLiviano);

        Console.WriteLine(
            $"Cantidad de vagones livianos después de agregar uno: {formacion.CantidadVagonesLivianos()}"
        );



    }
}