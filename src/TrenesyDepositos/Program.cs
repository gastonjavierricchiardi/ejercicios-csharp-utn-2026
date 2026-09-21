// src/TrenesyDepositos/Program.cs
// gastonj@hotmail.com

using System;
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

        Console.WriteLine($"kilos de empuje faltantes: {formacion.KilosEmpujeFaltantes()} kg."); // Esperamos 0

        // Ahora probamos un caso inverso, agregamos un Vagón súper pesado.
        VagonCarga vagonCargaPesado = new VagonCarga(10000);
        vagones.Add(vagonCargaPesado);

        // Probamos si la formación puedeMoverse
        Console.WriteLine($"¿La formación puede moverse después de agregar el vagón pesado?: {formacion.PuedeMoverse()}"); // Esperamos falso

        // ahora probamos los KiloEmpujeFaltantes()
        Console.WriteLine($"kilos de empuje faltantes después de agregar el vagón pesado: {formacion.KilosEmpujeFaltantes()} kg."); // Esperamos 7780

        // Vemos si la formación es compleja
        Console.WriteLine($"¿La formación es compleja?: {formacion.EsCompleja()}");
        /*
        Veamos el vagon mas pesado que viene del punto 7 del enunciado.
        7. Dado un depósito, el conjunto formado por el vagón más pesado de cada formación; se
            espera un conjunto de vagones.
        Si bien, no queda claro que pide, voy a modelar que entregue el vagón mas pesado.
        */
        Vagon vagonMasPesado = formacion.VagonMasPesado();
        Console.WriteLine($"Peso máximo del vagón mas pesado: {vagonMasPesado.PesoMaximo()}");

        // Creamos la lista de formaciones del depósito.
        // Por ahora tenemos una sola formación.
        List<Formacion> formaciones = new List<Formacion> { formacion };

        // Creamos la lista de locomotoras sueltas disponibles en el depósito.
        List<Locomotora> locomotorasSueltas = new List<Locomotora>();

        Locomotora locomotoraSuelta = new Locomotora(1000, 10000, 80);
        locomotorasSueltas.Add(locomotoraSuelta);

        // Creamos el depósito.
        Deposito deposito = new Deposito(
            formaciones,
            locomotorasSueltas
        );

        Console.WriteLine();
        Console.WriteLine("=== AGREGAR LOCOMOTORA DESDE EL DEPÓSITO ===");
        Console.WriteLine($"Empuje faltante antes: {formacion.KilosEmpujeFaltantes()} kg");

        deposito.AgregarLocomotora(formacion);

        // Hacemos la prueba de ver si locomotora, salió de locomotorasSueltas
        int cantidadLocomotorasSueltas = 0;

        foreach (Locomotora locomotoraRestante in locomotorasSueltas)
        {
            cantidadLocomotorasSueltas++;
        }

        Console.WriteLine(
            $"Locomotoras sueltas después de agregar: {cantidadLocomotorasSueltas}"
        );

        Console.WriteLine($"Empuje faltante después: {formacion.KilosEmpujeFaltantes()} kg");
        Console.WriteLine($"¿La formación puede moverse?: {formacion.PuedeMoverse()}");

        // Pedimos al depósito el vagón más pesado de cada formación.
        List<Vagon> vagonesMasPesados = deposito.VagonesMasPesados();

        // Mostramos los resultados.
        Console.WriteLine();
        Console.WriteLine("=== VAGONES MÁS PESADOS DEL DEPÓSITO ===");

        foreach (Vagon vagon in vagonesMasPesados)
        {
            Console.WriteLine($"Peso máximo: {vagon.PesoMaximo()} kg");
        }

        Console.WriteLine($"¿El depósito necesita conductor experimentado? {deposito.NecesitaConductorExperimentado()}");

        // Vemos las excepciones.
        Console.WriteLine();
        Console.WriteLine("=== PRUEBA SIN LOCOMOTORAS DISPONIBLES ===");

        // Agregamos otro vagón para que vuelva a faltar empuje.
        VagonCarga otroVagonCarga = new VagonCarga(2000);
        vagones.Add(otroVagonCarga);

        Console.WriteLine($"Empuje faltante: {formacion.KilosEmpujeFaltantes()} kg");

        try
        {
            deposito.AgregarLocomotora(formacion);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("=== PRUEBA CON LOCOMOTORA INSUFICIENTE ===");

        // Esta locomotora tiene solamente 500 kg de arrastre útil.
        Locomotora locomotoraInsuficiente = new Locomotora(1000, 1500, 40);

        locomotorasSueltas.Add(locomotoraInsuficiente);

        Console.WriteLine(
            $"Empuje faltante: {formacion.KilosEmpujeFaltantes()} kg"
        );

        Console.WriteLine(
            $"Arrastre útil de la locomotora disponible: {locomotoraInsuficiente.ArrastreUtil()} kg"
        );

        try
        {
            deposito.AgregarLocomotora(formacion);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("=== PRUEBA FORMACIÓN EN MOVIMIENTO ===");

        // Agregamos una locomotora que sí alcanzaría.
        Locomotora locomotoraDisponible =
            new Locomotora(1000, 12000, 80);

        locomotorasSueltas.Add(locomotoraDisponible);

        // Ponemos la formación en movimiento.
        formacion.IniciarMovimiento();
        Console.WriteLine($"¿La formación está en movimiento?: {formacion.EstaEnMovimiento}");
        Console.WriteLine($"Empuje faltante antes: {formacion.KilosEmpujeFaltantes()} kg");

        // Intentamos agregar una locomotora.
        deposito.AgregarLocomotora(formacion);
        Console.WriteLine($"Empuje faltante después: {formacion.KilosEmpujeFaltantes()} kg");
        Console.WriteLine();
        Console.WriteLine("=== PRUEBA FORMACIÓN AJENA AL DEPÓSITO ===");

        List<Locomotora> locomotorasFormacionAjena = new List<Locomotora>
        {
            new Locomotora(
            1000,
            2000,
            50)
        };

        List<Vagon> vagonesFormacionAjena = new List<Vagon> { new VagonCarga(3000) };

        Formacion formacionAjena = new Formacion(
            locomotorasFormacionAjena,
            vagonesFormacionAjena
        );

        Console.WriteLine($"Empuje faltante antes: {formacionAjena.KilosEmpujeFaltantes()} kg");
        deposito.AgregarLocomotora(formacionAjena);
        Console.WriteLine($"Empuje faltante después: {formacionAjena.KilosEmpujeFaltantes()} kg");
    }
}