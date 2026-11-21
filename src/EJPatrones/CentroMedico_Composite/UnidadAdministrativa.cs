// CentroMedico
using System.Collections.Generic;
public class UnidadAdministrativa : BaseSanitaria
{
    // 1. CAMPOS / ATRIBUTOS
    private List<CentroAtencion> bases;

    // 2. CONSTRUCTOR
    public UnidadAdministrativa(
        string nombre,
        string direccion
        ) : base(nombre, direccion)
    {
        bases = new List<CentroAtencion>();
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public void Agregar(CentroAtencion baseSanitaria)
    {
        bases.Add(baseSanitaria);

    }

    public void Eliminar(CentroAtencion baseSanitaria)
    {
        bases.Remove(baseSanitaria);
    }

    //
    public override int ObtenerCantidadAmbulancias()
    {
        //throw new NotImplementedException();
        int total = 0;
        foreach (CentroAtencion baseSanotaria in bases)
        {
            total += baseSanotaria.ObtenerCantidadAmbulancias();
        }
        return total;
    }

    public override int ObtenerPersonal()
    {
        //throw new NotImplementedException();
        int total = 0;
        foreach (CentroAtencion baseSanitaria in bases)
        {
            total += baseSanitaria.ObtenerPersonal();
        }
        return total;
    }

    public override decimal ObtenerTiempoMedio()
    {
        //throw new NotImplementedException();
        if (bases.Count == 0)
        {
            return 0;
        }
        decimal total = 0;

        foreach (CentroAtencion baseSanitaria in bases)
        {
            total += baseSanitaria.ObtenerTiempoMedio();
        }

        return total / bases.Count;
    }
}