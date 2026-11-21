// Gimnasio_Strategy
using System.Collections.Generic;
public class Promocion
{
    // 1. CAMPOS / ATRIBUTOS
    private string nombre;
    private List<Actividad> actividades;
    private decimal porcentajeDescuento;
    // 2. CONSTRUCTOR
    public Promocion(
        string nombre,
        List<Actividad> actividades,
        decimal porcentajeDescuento)
    {
        this.nombre = nombre;
        this.actividades = actividades;
        this.porcentajeDescuento = porcentajeDescuento;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public decimal CalcularDescuento(
        List<Actividad> actividadesSocio,
        decimal cuotaPura)
    {
        int coincidencias = 0;

        foreach (Actividad actividadPromocion in actividades)
        {
            foreach (Actividad actividadSocio in actividadesSocio)
            {
                if (actividadPromocion == actividadSocio)
                {
                    coincidencias++;
                    break;
                }
            }
        }

        if (coincidencias >= 2)
        {
            return cuotaPura * porcentajeDescuento / 100m;
        }

        return 0m;
    }
}