// Gimnasio_Strategyusing System.Collections.Generic;
public class CuotaPaseLibre : ICalculoCuota
{
    // 1. CAMPOS / ATRIBUTOS
    private decimal precioMensual;

    // 2. CONSTRUCTOR
    public CuotaPaseLibre(decimal precioMensual)
    {
        this.precioMensual = precioMensual;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public decimal CalcularCuota(
        List<Actividad> actividades,
        Promocion? promocion)
    {
        return precioMensual;
    }
}