/* src/Guia01/EJ16/Program.cs
16. Una empresa de logística que se encarga de realizar envíos, pone a disposición de sus clientes dos tipos de vehículos:
    - Una camioneta con capacidad para llevar cómodas, heladeras y lavarropas.
    - Un auto con espacio suficiente como para llevar televisores, bicicletas plegables y cajas pequeñas.

    Modelar las entidades teniendo en cuenta las siguientes consideraciones:
    - Los vehículos deben ofrecer el método `Cargar()` para ir incrementando su carga, razón por la cual la función debe recibir el dato por parámetro.
    - Mediante el empleo del método `ListarItems()` el vehículo deberá facilitar el listado que compone la carga.
    - Todos los elementos poseen una descripción, dimensiones y un número que los identifica pero, además, resulta de interés:
      - **i. Cómodas:** superficie y cantidad de cajones.
      - **ii. Heladeras:** voltaje al que trabaja y si posee freezer.
      - **iii. Lavarropas:** voltaje al que trabaja, carga y revoluciones de centrifugado.
      - **iv. Televisores:** voltaje al que trabaja, si es de LED o LCD y si es inteligente.
      - **v. Bicicletas:** tamaño de rodado, si son eléctricas y cantidad de cambios.

    Analizar, diseñar, diagramar las relaciones e implementar el código considerando que la capacidad máxima de carga del auto es de 5 elementos, mientras que para la camioneta es de 10.
*/


using System;

public class Program
{
    public static void Main(string[] args)
    {
        // =========================
        // ELEMENTOS
        // =========================

        Televisor televisor = new Televisor(
            "Televisor",
            0.60,
            1.00,
            0.10,
            1,
            220,
            TipoPantalla.LED,
            true
        );

        Bicicleta bicicleta = new Bicicleta(
            "Bicicleta",
            1.00,
            1.70,
            0.50,
            2,
            29,
            false,
            21
        );

        CajaPequena caja = new CajaPequena(
            "Caja pequeña",
            0.30,
            0.30,
            0.30,
            3
        );

        Comoda comoda = new Comoda(
            "Cómoda",
            0.90,
            1.20,
            0.50,
            4,
            1.08,
            6
        );

        Heladera heladera = new Heladera(
            "Heladera",
            1.80,
            0.70,
            0.70,
            5,
            220,
            true
        );

        Lavarropas lavarropas = new Lavarropas(
            "Lavarropas",
            0.85,
            0.60,
            0.60,
            6,
            220,
            8,
            1200
        );


        // =========================
        // AUTO
        // =========================

        Auto auto = new Auto();

        auto.Cargar(televisor);
        auto.Cargar(bicicleta);
        auto.Cargar(caja);

        // No debería cargarse
        auto.Cargar(heladera);

        // Completamos capacidad
        auto.Cargar(caja);
        auto.Cargar(caja);

        // Sexto elemento: no debería cargarse
        auto.Cargar(caja);


        Console.WriteLine("=== CARGA DEL AUTO ===");

        foreach (Elemento elemento in auto.ListarItems())
        {
            Console.WriteLine(
                $"{elemento.NumeroIdentificador} - {elemento.Descripcion}"
            );
        }


        Console.WriteLine();


        // =========================
        // CAMIONETA
        // =========================

        Camioneta camioneta = new Camioneta();

        camioneta.Cargar(comoda);
        camioneta.Cargar(heladera);
        camioneta.Cargar(lavarropas);

        // No debería cargarse
        camioneta.Cargar(televisor);

        // Completamos capacidad
        camioneta.Cargar(comoda);
        camioneta.Cargar(comoda);
        camioneta.Cargar(comoda);
        camioneta.Cargar(comoda);
        camioneta.Cargar(comoda);
        camioneta.Cargar(comoda);
        camioneta.Cargar(comoda);

        // Elemento número 11: no debería cargarse
        camioneta.Cargar(heladera);


        Console.WriteLine("=== CARGA DE LA CAMIONETA ===");

        foreach (Elemento elemento in camioneta.ListarItems())
        {
            Console.WriteLine(
                $"{elemento.NumeroIdentificador} - {elemento.Descripcion}"
            );
        }
    }
}