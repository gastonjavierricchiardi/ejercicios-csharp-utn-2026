using System;

namespace MisClases;

public class EnvioNoAsegurableException : Exception
{
    public EnvioNoAsegurableException(string mensaje)
        : base(mensaje)
    {
    }
}