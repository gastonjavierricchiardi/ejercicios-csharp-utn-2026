// GuiaPatrones01/EJ01-Singleton
using System;

public class ReporteManager
{
    // 1. CAMPOS / ATRIBUTOS
    private Configuracion config;
    // 2. CONSTRUCTOR
    public ReporteManager()
    {
        config = Configuracion.GetInstance();
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public void ImprimirReporte()
    {
        System.Console.WriteLine($"Reporte - Idioma actual: {config.Idioma}");
    }
}