// Gimnasio_Strategy
using System.Collections.Generic;
public class CuotaPorActividades : ICalculoCuota
{
    // 1. CAMPOS / ATRIBUTOS

    // 2. CONSTRUCTOR

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public decimal CalcularCuota(
        List<Actividad> actividades,
        Promocion? promocion)
    {
        decimal cuotaPura = 0m;

        foreach (Actividad actividad in actividades)
        {
            cuotaPura += actividad.PrecioMensual;
        }

        decimal descuento = 0m;

        if (promocion != null)
        {
            descuento = promocion.CalcularDescuento(
                actividades,
                cuotaPura);
        }

        return cuotaPura - descuento;
    }
}