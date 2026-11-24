using System;
using System.Collections.Generic;

public class ConstructorLaberinto
{
    // 1. CAMPOS / ATRIBUTOS
    private Dictionary<int, int> minimosPorNivel;
    private Laberinto? laberinto;
    private bool habitacionesConstruidas;

    // 2. CONSTRUCTOR
    public ConstructorLaberinto()
    {
        minimosPorNivel = new Dictionary<int, int>();

        minimosPorNivel.Add(1, 10);
        minimosPorNivel.Add(2, 14);

        laberinto = null;
        habitacionesConstruidas = false;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public void ConfigurarMinimoHabitaciones(
        int nivel, int cantidad)
    {
        if (nivel <= 0 || cantidad <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(cantidad),
                "El nivel y la cantidad deben ser positivos.");
        }

        minimosPorNivel[nivel] = cantidad;
    }

    public void Iniciar(int nivel, Dificultad dificultad)
    {
        if (!minimosPorNivel.ContainsKey(nivel))
        {
            throw new ArgumentException(
                "El nivel no tiene una cantidad configurada.");
        }

        laberinto = new Laberinto(nivel, dificultad);
        habitacionesConstruidas = false;
    }

    public void ConstruirClasico(MaterialPared material)
    {
        if (material == MaterialPared.Agua)
        {
            throw new ArgumentException(
                "El laberinto clasico no admite agua.");
        }

        ConstruirHabitaciones(
            material, material, material, material);
    }

    public void ConstruirModernoUnaDeCada()
    {
        ConstruirHabitaciones(
            MaterialPared.Arbustos,
            MaterialPared.Madera,
            MaterialPared.Piedra,
            MaterialPared.Agua);
    }

    public void ConstruirModernoDosDeCada(
        MaterialPared primero,
        MaterialPared segundo)
    {
        if (primero == segundo)
        {
            throw new ArgumentException(
                "Deben seleccionarse dos materiales distintos.");
        }

        ConstruirHabitaciones(
            primero, primero, segundo, segundo);
    }

    public void ConstruirSoloAgua()
    {
        ConstruirHabitaciones(
            MaterialPared.Agua,
            MaterialPared.Agua,
            MaterialPared.Agua,
            MaterialPared.Agua);
    }

    private void ConstruirHabitaciones(
        MaterialPared material1,
        MaterialPared material2,
        MaterialPared material3,
        MaterialPared material4)
    {
        if (laberinto == null)
        {
            throw new InvalidOperationException(
                "Primero debe iniciarse el laberinto.");
        }

        if (habitacionesConstruidas)
        {
            throw new InvalidOperationException(
                "Las habitaciones ya fueron construidas.");
        }

        int cantidad = minimosPorNivel[laberinto.Nivel];

        MaterialPared[] materiales =
        {
            material1,
            material2,
            material3,
            material4
        };

        for (int i = 1; i <= cantidad; i++)
        {
            List<Pared> paredes = new List<Pared>();
            bool puertaAsignada = false;

            foreach (MaterialPared material in materiales)
            {
                if (material == MaterialPared.Agua)
                {
                    paredes.Add(new ParedAgua());
                }
                else
                {
                    bool tienePuerta = !puertaAsignada;

                    paredes.Add(
                        new ParedSolida(material, tienePuerta));

                    if (tienePuerta)
                    {
                        puertaAsignada = true;
                    }
                }
            }

            Habitacion habitacion =
                new Habitacion($"H{i}", paredes);

            laberinto.AgregarHabitacion(habitacion);
        }

        habitacionesConstruidas = true;
    }

    public Laberinto ObtenerLaberinto()
    {
        if (laberinto == null || !habitacionesConstruidas)
        {
            throw new InvalidOperationException(
                "El laberinto no fue construido.");
        }

        return laberinto;
    }
}