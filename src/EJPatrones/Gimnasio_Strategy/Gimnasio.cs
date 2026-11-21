// Gimnasio_Strategy
using System.Collections.Generic;
public class Gimnasio
{
    // 1. CAMPOS / ATRIBUTOS
    private List<Promocion> promociones;
    private Promocion? promocionVigente;

    // 2. CONSTRUCTOR
    public Gimnasio()
    {
        promociones = new List<Promocion>();
        promocionVigente = null;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public void AgregarPromocion(Promocion promocion)
    {
        promociones.Add(promocion);
    }

    public void EliminarPromocion(Promocion promocion)
    {
        promociones.Remove(promocion);

        if (promocionVigente == promocion)
        {
            promocionVigente = null;
        }
    }

    public void EstablecerPromocionVigente(Promocion promocion)
    {
        if (promociones.Contains(promocion))
        {
            promocionVigente = promocion;
        }
    }

    public decimal CalcularCuota(Socio socio)
    {
        return socio.CalcularCuota(promocionVigente);
    }
}