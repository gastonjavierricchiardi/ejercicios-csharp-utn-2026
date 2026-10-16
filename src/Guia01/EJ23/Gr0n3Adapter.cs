// EJ23
using System.Collections.Generic;
public class Gr0n3Adapter : IFuenteVigilancia
{
    // 1. CAMPOS / ATRIBUTOS
    private int idDispositivo;
    // 2. CONSTRUCTOR
    public Gr0n3Adapter(int idDispositivo)
    {
        this.idDispositivo = idDispositivo;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public List<RegistroVigilancia> ObtenerRegistros()
    {
        List<Gr0n3Object> objetos = FlyingGr0n3.GetData(idDispositivo);

        List<RegistroVigilancia> registros = new List<RegistroVigilancia>();

        foreach (Gr0n3Object objeto in objetos)
        {
            string tipo = "No humano";

            if (objeto.Type == "human")
            {
                tipo = "Humano";
            }

            string tamanio = "Pequeño";

            if (objeto.Size == "big")
            {
                tamanio = "Grande";
            }
            else if (objeto.Size == "medium")
            {
                tamanio = "Mediano";
            }

            string observaciones = "No aplica";

            if (objeto.Type == "animal")
            {
                observaciones = objeto.Kind;
            }

            RegistroVigilancia registro = new RegistroVigilancia(
                    idDispositivo,
                    tipo,
                    tamanio,
                    observaciones
                );

            registros.Add(registro);
        }

        return registros;
    }
}