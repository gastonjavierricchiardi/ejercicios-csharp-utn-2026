// EJ23
using System.Collections.Generic;
public class FalderPAdapter : IFuenteVigilancia
{
    // 1. CAMPOS / ATRIBUTOS
    private FalderP falderP;

    // 2. CONSTRUCTOR
    public FalderPAdapter(FalderP falderP)
    {
        this.falderP = falderP;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public List<RegistroVigilancia> ObtenerRegistros()
    {
        List<Perr177> unidades = falderP.GetData();

        List<RegistroVigilancia> registros =
            new List<RegistroVigilancia>();

        foreach (Perr177 unidad in unidades)
        {
            foreach (Perr177Data dato in unidad.Datos)
            {
                string tipo = "No humano";

                if (dato.Type == FPType.HUMAN)
                {
                    tipo = "Humano";
                }

                string tamanio = "Mediano";

                if (dato.Size == "rande")
                {
                    tamanio = "Grande";
                }
                else if (dato.Size == "pichitito")
                {
                    tamanio = "Pequeño";
                }

                string observaciones = "No aplica";

                if (dato.Type == FPType.HUMAN)
                {
                    observaciones = dato.Gender.ToString();
                }

                RegistroVigilancia registro =
                    new RegistroVigilancia(
                        unidad.Id,
                        tipo,
                        tamanio,
                        observaciones
                    );

                registros.Add(registro);
            }
        }

        return registros;
    }
}
