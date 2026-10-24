using System;

public class CapacidadCargaExcedidaException : Exception
{
    public CapacidadCargaExcedidaException(string mensaje)
        : base(mensaje)
    {
    }
}