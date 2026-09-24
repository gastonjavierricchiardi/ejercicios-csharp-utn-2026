// src\Guia01\EJ17\Program.cs
// Gastón (gastonj@hotmail.com)
using System;
public class Program

{
    public static void Main()// static void Main(string[] args){}
    {
        Analizador analizador = new Analizador();

        // Mamshka de madera, creamos las 3 para meterlas una dentro de la otra.

        Objeto mamushkaInterior = new Objeto(
            Material.Madera,
            250 //cm3
            );

        Objeto mamushkaIntermedia = new Objeto(
        Material.Madera,
        500//cm3
        );

        Objeto mamushkaExterior = new Objeto(
            Material.Madera,
            1000 // cm3 para que quepan la anteriores adentro
        );

        mamushkaIntermedia.AgregarContenido(mamushkaInterior);
        mamushkaExterior.AgregarContenido(mamushkaIntermedia);

        System.Console.WriteLine("=== Mamushka ===");
        analizador.Analizar(mamushkaExterior);

        // Portafolio de cuero vacio

        Objeto portafolios = new Objeto(
            Material.Cuero,
            3000 // Volumen de prueba
        );

        System.Console.WriteLine("=== Portafolios ===");
        analizador.Analizar(portafolios);

        // Botiquín plástico

        Objeto gasa = new Objeto(
            Material.Textil,
            100
        );
        Objeto aguaOxigenada = new Objeto(
            Material.Liquido,
            250
        );

        Objeto botiquin = new Objeto(
            Material.Plastico,
            2000
        );

        // Agregamos las cosas dentro del botiquin...
        // jajaj despues vemos que pasa si nos excedemos
        botiquin.AgregarContenido(gasa);
        botiquin.AgregarContenido(aguaOxigenada);

        System.Console.WriteLine("=== Botiquín ===");
        analizador.Analizar(botiquin);

        // BOLSA DE CUERO

        Objeto peine = new Objeto(
            Material.Plastico,
            150 // volumen de prueba en cm3
        );

        Objeto bolsa = new Objeto(
            Material.Cuero,
            5000 // volumen de prueba en cm3
        );

        bolsa.AgregarContenido(peine);
        bolsa.AgregarContenido(botiquin);

        Console.WriteLine("=== Bolsa ===");
        analizador.Analizar(bolsa);


    }
}