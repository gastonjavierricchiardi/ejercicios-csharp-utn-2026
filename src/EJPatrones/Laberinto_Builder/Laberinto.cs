using System.Collections.Generic;

public class Laberinto
{
    // 1. CAMPOS / ATRIBUTOS
    private int nivel;
    private Dificultad dificultad;
    private List<Habitacion> habitaciones;

    // 2. CONSTRUCTOR
    public Laberinto(int nivel, Dificultad dificultad)
    {
        this.nivel = nivel;
        this.dificultad = dificultad;
        habitaciones = new List<Habitacion>();
    }

    // 3. PROPIEDADES
    public int Nivel
    {
        get { return nivel; }
    }

    public Dificultad Dificultad
    {
        get { return dificultad; }
    }

    public int CantidadHabitaciones
    {
        get { return habitaciones.Count; }
    }

    // 4. MÉTODOS
    internal void AgregarHabitacion(Habitacion habitacion)
    {
        if (habitaciones.Count > 0)
        {
            Habitacion ultima =
                habitaciones[habitaciones.Count - 1];

            ultima.EnlazarSiguiente(habitacion);
        }

        habitaciones.Add(habitacion);
    }

    public Habitacion? ObtenerPrimeraHabitacion()
    {
        if (habitaciones.Count == 0)
        {
            return null;
        }

        return habitaciones[0];
    }
}