using System.Collections.Generic;

public class Personaje
{
    // 1. CAMPOS / ATRIBUTOS
    private List<Habitacion> habitacionesRecorridas;
    private Habitacion? habitacionActual;
    private bool logroSalir;

    // 2. CONSTRUCTOR
    public Personaje()
    {
        habitacionesRecorridas = new List<Habitacion>();
        habitacionActual = null;
        logroSalir = false;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public void Recorrer(Laberinto laberinto)
    {
        habitacionesRecorridas.Clear();
        habitacionActual = null;
        logroSalir = false;

        Habitacion? habitacion =
            laberinto.ObtenerPrimeraHabitacion();

        while (habitacion != null)
        {
            if (!habitacion.PuedeAtravesarse())
            {
                return;
            }

            habitacionesRecorridas.Add(habitacion);
            habitacionActual = habitacion;

            habitacion = habitacion.Siguiente;
        }

        if (habitacionActual != null &&
            habitacionActual.Siguiente == null)
        {
            logroSalir = true;
        }
    }

    public int CantidadHabitacionesRecorridas()
    {
        return habitacionesRecorridas.Count;
    }

    public Habitacion? ObtenerHabitacionActual()
    {
        return habitacionActual;
    }

    public bool LogroSalir()
    {
        return logroSalir;
    }
}