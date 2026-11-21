// Gimnasio_Strategy
using System.Collections.Generic;
public interface ICalculoCuota
{
    decimal CalcularCuota(
        List<Actividad> actividades,
        Promocion? promocion);
}