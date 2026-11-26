using System;

public class HabitacionReservadaException : Exception
{
    public HabitacionReservadaException(string mensaje)
        : base(mensaje)
    {
    }
}