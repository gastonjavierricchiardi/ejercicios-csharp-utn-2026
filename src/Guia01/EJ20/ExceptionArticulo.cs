// Ej20
using System;
public class ExceptionArticulo : Exception
{
    // 1. Constructor
    public ExceptionArticulo(string mensaje)
    : base(mensaje) { }
}