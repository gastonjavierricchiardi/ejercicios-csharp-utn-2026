/* /src/Guia01/EJ15/Program.cs
Gastón Ricchiardi (gastonj@hotmail.com)
15. La Marina del reino de Caballito quiere desarrollar un sistema que le permita gestionar su flota de navíos; por el momento únicamente se requiere presentar ante las autoridades un posible diseño en el que se expongan las relaciones entre las entidades que modelarán los datos.
    - De los acorazados se requiere saber la flotabilidad, la solidez, la estabilidad, blindaje y potencia de fuego, además de la velocidad crucero y el nombre con el que fue bautizado.
    - Los destructores se caracterizan por la potencia de fuego y altos índices de maniobrabilidad y estabilidad cuando alcanza su velocidad máxima, aunque también se necesita registrar la flotabilidad, solidez, la velocidad crucero y nombre.
    - Hay únicamente un barco hospital, llamada "Sibelancia", con excelente flotabilidad y una estabilidad extrema que la hace ideal para su trabajo; posee una capacidad de carga que le permite brindar servicios a setenta y cinco pacientes.
    - "La gaucha" y "El gaucho" son dos lanchas destinadas a brindar servicio médico que se emplean para salvatajes rápidos; poseen motor fuera de borda, una elevada flotabilidad que le permite ir muy rápido, aunque debido a que la estabilidad no es muy buena, la maniobrabilidad se ve afectada; ambas poseen una grúa pequeña que les permite subir y/o arriar objetos de hasta trescientos kilos.

    Analizar, diseñar, diagramar las relaciones e implementar el código.
    Crear instancias de los distintos barcos, asignar valores y mostrar por pantalla.*/
public class Program
{
    public static void Main()
    //static void Main(string[] args)
    {
        // Creamos un acorazado con valores de prueba:
        Acorazado acorazado = new Acorazado(
            "Ara Caballito",
            "Alta",
            "Alta",
            "Alta",
            "Pesado",
            "Alta",
            25
        );

        // Mostramos los primeros datos heredados de `Navio`
        Console.WriteLine("ACORAZADO");
        Console.WriteLine($"Nombre           : {acorazado.Nombre}");
        Console.WriteLine($"Flotabilidad     : {acorazado.Flotabilidad}");
        Console.WriteLine($"Estabilidad      : {acorazado.Estabilidad}");
        // Agregamos lo nuevo
        Console.WriteLine($"Solidez          : {acorazado.Solidez}");
        Console.WriteLine($"Blindaje         : {acorazado.Blindaje}");
        Console.WriteLine($"Potencia de fuego: {acorazado.PotenciaFuego}");
        Console.WriteLine($"Velocidad crucero: {acorazado.VelocidadCrucero}");

        Console.WriteLine();

        Destructor destructor = new Destructor(
                    "ARA Demoledor",
                    "Alta",
                    "Alta",
                    "Alta",
                    "Alta",
                    "Muy alta",
                    30
                );

        Console.WriteLine("DESTRUCTOR");
        Console.WriteLine($"Nombre           : {destructor.Nombre}");
        Console.WriteLine($"Flotabilidad     : {destructor.Flotabilidad}");
        Console.WriteLine($"Estabilidad      : {destructor.Estabilidad}");
        Console.WriteLine($"Solidez          : {destructor.Solidez}");
        Console.WriteLine($"Potencia de fuego: {destructor.PotenciaFuego}");
        Console.WriteLine($"Maniobrabilidad  : {destructor.Maniobrabilidad}");
        Console.WriteLine($"Velocidad crucero: {destructor.VelocidadCrucero}");

        Console.WriteLine();
        // Creamos el BarcoHospital
        BarcoHospital sibelancia = new BarcoHospital(
                    "Sibelancia",
                    "Excelente",
                    "Extrema",
                    75
                );

        Console.WriteLine("BARCO HOSPITAL");
        Console.WriteLine($"Nombre               : {sibelancia.Nombre}");
        Console.WriteLine($"Flotabilidad         : {sibelancia.Flotabilidad}");
        Console.WriteLine($"Estabilidad          : {sibelancia.Estabilidad}");
        Console.WriteLine($"Cantidad de pacientes: {sibelancia.CapacidadPacientes}");

        Console.WriteLine();
        // Lancha médica "laGaucha"
        LanchaMedica laGaucha = new LanchaMedica(
            "La Gaucha",
            "Elevada",
            "No muy buena",
            "Afectada",
            "Fuera de borda",
            300
        );
        Console.WriteLine("LANCHA MÉDICA");
        Console.WriteLine($"Nombre         : {laGaucha.Nombre}");
        Console.WriteLine($"Flotabilidad   : {laGaucha.Flotabilidad}");
        Console.WriteLine($"Estabilidad    : {laGaucha.Estabilidad}");
        Console.WriteLine($"Maniobrabilidad: {laGaucha.Maniobrabilidad}");
        Console.WriteLine($"Tipo de motor  : {laGaucha.TipoMotor}");
        Console.WriteLine($"Capacidad grúa : {laGaucha.CapacidadGrua} kg.");

        Console.WriteLine();
        // Lancha médica "elGaucho"
        LanchaMedica elGaucho = new LanchaMedica(
            "El Gaucho",
            "Elevada",
            "No muy buena",
            "Afectada",
            "Fuera de borda",
            300
        );
        Console.WriteLine("LANCHA MÉDICA");
        Console.WriteLine($"Nombre         : {elGaucho.Nombre}");
        Console.WriteLine($"Flotabilidad   : {elGaucho.Flotabilidad}");
        Console.WriteLine($"Estabilidad    : {elGaucho.Estabilidad}");
        Console.WriteLine($"Maniobrabilidad: {elGaucho.Maniobrabilidad}");
        Console.WriteLine($"Tipo de motor  : {elGaucho.TipoMotor}");
        Console.WriteLine($"Capacidad grúa : {elGaucho.CapacidadGrua} kg.");
    }
}