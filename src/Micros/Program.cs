// /src/Micros/Program.cs

public class Program
{
    public static void Main()
    {
        /*
        40 = Capacidad de pasajeros sentados
        20 = Capacidad de pasajeros parados
        130= El Volumen M3*/
        Micro micro = new Micro(40, 20, 130);

        Apurado apurado = new Apurado();
        MostrarResultado("Apurado", apurado.AceptaSubir(micro));

        Claustrofobico claustrofobico = new Claustrofobico();
        MostrarResultado("Claustrofobico", claustrofobico.AceptaSubir(micro));

        // Probamos un fiaca con el micro en 40 plazas y debería subir
        Fiaca fiaca = new Fiaca();
        MostrarResultado("Fiaca", fiaca.AceptaSubir(micro));

        // Completamos el micro para chequear que el fiaca no pueda subir.
        for (int i = 0; i < 39; i++)
        {
            micro.SubirPasajero(new Apurado());
        }

        // Todavía queda 1 asiento libre.
        MostrarResultado("Fiaca con 39 asientos ocupados", fiaca.AceptaSubir(micro));

        // Ocupamos el último asiento
        micro.SubirPasajero(new Apurado());

        // Ya no quedan asientos sentados, aunque aún haya lugares parados.
        MostrarResultado("Fiaca con 40 asientos ocupados", fiaca.AceptaSubir(micro));

        // El moderado se crea con su pretensión
        Moderado moderado20 = new Moderado(20);
        MostrarResultado("Moderado que exige 20 lugares libres", moderado20.AceptaSubir(micro));
        // Creamos un moderado con 21 (que sobrepasa)
        Moderado moderado21 = new Moderado(21);
        MostrarResultado("Moderado que exige 21 lugares libres", moderado21.AceptaSubir(micro));

        /*
        Obsecuente cuyo jefe es Fiaca.
        Como ya no quedan asientos, el Fiaca no acepta subir.
        El Obsecuente debe tomar la misma decisión.*/
        Obsecuente obsecuenteFiaca = new Obsecuente(fiaca);
        MostrarResultado(
            "Obsecuente con un jefe fiaca",
            obsecuenteFiaca.AceptaSubir(micro));

        /*
        Obsecuente cuyo jefe es Apurado.
        el apurado "siempre acepta subir".*/
        Obsecuente obsecuenteApurado = new Obsecuente(apurado);
        MostrarResultado(
            "Obsecuente con jefe apurado",
            obsecuenteApurado.AceptaSubir(micro)
        );

        /* Ahora podemos probar el requerimiento 
        “preguntarle a una persona si es jefe”.*/
        MostrarEsJefe("Fiaca", fiaca.EsJefe());
        MostrarEsJefe("Apurado", apurado.EsJefe());
        MostrarEsJefe("Claustrofobico", claustrofobico.EsJefe());

        // Probamos que cualquier persona pueda tener Jefe
        Fiaca fiacaConJefe = new Fiaca(claustrofobico);
        MostrarEsJefe(
            "Claustrofobico después de asignarle un subordinado",
            claustrofobico.EsJefe()
            );


        // Probamos de subir un pasajero y luego bajarlo
        Apurado pasajeroPrueba = new Apurado();
        micro.SubirPasajero(pasajeroPrueba);
        Console.WriteLine($"Lugares libres antes de bajar: {micro.LugaresLibres()}");
        micro.BajarPasajero(pasajeroPrueba);
        Console.WriteLine($"Lugares libres después de bajar: {micro.LugaresLibres()}");

        // No mezclamos nada, creamos un nuevo micro de prueba
        Micro microPrimerPasajero = new Micro(2, 1, 130);

        MostrarMicroVacio(microPrimerPasajero.PrimerPasajero() == null);

        Apurado primerPasajeroPrueba = new Apurado();
        Apurado segundoPasajeroPrueba = new Apurado();

        microPrimerPasajero.SubirPasajero(primerPasajeroPrueba);
        microPrimerPasajero.SubirPasajero(segundoPasajeroPrueba);

        MostrarPrimerPasajero(
            microPrimerPasajero.PrimerPasajero() == primerPasajeroPrueba
        );
    }

    private static void MostrarResultado(string persona, bool acepta)
    {
        if (acepta == true)
        {
            Console.WriteLine($"{persona} SI acepta subir");
        }
        else
        {
            Console.WriteLine($"{persona} NO acepta subir");
        }
    }

    private static void MostrarEsJefe(string persona, bool esJefe)
    {
        if (esJefe == true)
        {
            Console.WriteLine($"{persona} SI es jefe");
        }
        else
        {
            Console.WriteLine($"{persona} NO es jefe");
        }
    }

    private static void MostrarMicroVacio(bool estaVacio)
    {
        if (estaVacio == true)
        {
            Console.WriteLine("El micro está vacío");
        }
        else
        {
            Console.WriteLine("El micro tiene pasajeros");
        }
    }

    private static void MostrarPrimerPasajero(bool esElEsperado)
    {
        if (esElEsperado == true)
        {
            Console.WriteLine("El primer pasajero es el esperado");
        }
        else
        {
            Console.WriteLine("El primer pasajero NO es el esperado");
        }
    }
}