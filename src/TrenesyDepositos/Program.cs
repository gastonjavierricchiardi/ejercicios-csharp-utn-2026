// src/TrenesyDepositos/Program.cs
using System;
using System.Collections.Generic;
using System.Net;

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
        Console.WriteLine($"Peso máximo: {vagonCarga.PesoMaximo()} kg");


        Console.WriteLine();

        Console.WriteLine("=== VAGÓN DE PASAJEROS ANGOSTO ===");
        Console.WriteLine($"Cantidad de pasajeros: {vagonPasajerosAngosto.CantidadPasajeros()}");
        Console.WriteLine($"Peso máximo: {vagonPasajerosAngosto.PesoMaximo()} kg");


        Console.WriteLine();

        Console.WriteLine("=== VAGÓN DE PASAJEROS ANCHO ===");
        Console.WriteLine($"Cantidad de pasajeros: {vagonPasajerosAncho.CantidadPasajeros()}");
        Console.WriteLine($"Peso máximo: {vagonPasajerosAncho.PesoMaximo()} kg");

        /*Locomotora
        Peso propio: 1000kg
        Peso máximo de arrastre: 12000kg
        Velocidad Máx: 80 km/h.
        */
        Locomotora locomotora = new Locomotora(1000, 12000, 80);
        Console.WriteLine();
        Console.WriteLine("=== LOCOMOTORA ===");
        Console.WriteLine($"Arrastre útil: {locomotora.ArrastreUtil()} kg.");

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
        Console.WriteLine($"Capacidad total de pasajeros: {formacion.TotalPasajeros()}");

        // Hasta acá la formación no tiene vagones que cumplan la regla de vagón liviano. 
        Console.WriteLine($"Cantidad de vagones livianos: {formacion.CantidadVagonesLivianos()}");

        // Creamos un vagón de carga de 2000 kg de capacodad
        // Su peso máximo será 2000 + 160 = 2160 kg.
        // Por lo tanto, es un vagón liviano.
        VagonCarga vagonCargaLiviano = new VagonCarga(2000);

        // Lo agregamos a la lista de vagones que ya existe.
        vagones.Add(vagonCargaLiviano);

        Console.WriteLine($"Cantidad de vagones livianos después de agregar uno: {formacion.CantidadVagonesLivianos()}");

        // Creamos una locomotora más lenta para comprobar
        // cuál limita la velocidad máxima de la formación.
        Locomotora locomotoraLenta = new Locomotora(900, 10000, 60);
        // La agregamos a la formación:
        locomotoras.Add(locomotoraLenta);
        // Probamos la velocidad de la formación
        Console.WriteLine($"Velocidad máxima de la formación: {formacion.VelocidadMaxima()} Km/h");

        // Comprobamos la eficiencia de las FORMACIONES
        Console.WriteLine($"¿La formación es eficiente?: {formacion.EsEficiente()}");

        // Creamos una locomotora "No eficiente" para pruebas
        Locomotora locomotoraNoEficiente = new Locomotora(1000, 5000, 70);

        // La agregamos a la lista
        locomotoras.Add(locomotoraNoEficiente);
        Console.WriteLine($"¿La formación sigue siendo eficiente?: {formacion.EsEficiente()}");

        // Agregamos la prueba de: Si la formación puede moverse.
        Console.WriteLine($"¿La formación puede moverse?: {formacion.PuedeMoverse()}"); // Esperamos true

        // Si bien kiloEmpujeFaltantes() fue modelado a posterior de las pruebas, para no engordar el main, lo pruebo antes de el vagonCargaPesado

        Console.WriteLine($"kilos de empuje faltantes: {formacion.KilosEmpujeFaltantes()} kg."); // Espeeramos 0

        // Ahora probamos un caso inverso, agregamos un Vagón súper pesado.
        VagonCarga vagonCargaPesado = new VagonCarga(10000);
        vagones.Add(vagonCargaPesado);

        // Probamos si la formación puedeMoverse
        Console.WriteLine($"¿La formación puede moverse después de agregar el vagón pesado?: {formacion.PuedeMoverse()}"); // Esperamos falso

        // ahora probamos los KiloEmpujeFaltantes()
        Console.WriteLine($"kilos de empuje faltantes después de agregar el vagón pesado: {formacion.KilosEmpujeFaltantes()} kg."); // Espeeramos 0

        // Vemos si la formación es compleja
        Console.WriteLine($"¿La formación es compleja?: {formacion.EsCompleja()}");



    }
}

/*
Con los objetos que tenemos ahora, actualmente nuestra formación tiene este arrastre útil:

Locomotora original       → 11000 kg
Locomotora lenta          →  9100 kg
Locomotora no eficiente   →  4000 kg
                           --------
Total                     → 24100 kg
----------------------------------------
Y los vagones pesan cómo máximo:
Vagón carga          → 5160 kg
Pasajeros angosto    → 6400 kg
Pasajeros ancho      → 8000 kg
Carga liviano        → 2160 kg
                       -------
Total                → 21720 kg
Este vagón agrega
10000 + 160 =        → 10160 kg
                       -------
                     → 31880 kg

---------------------------------------
entonces: 24100 >= 21720 --> true
*/