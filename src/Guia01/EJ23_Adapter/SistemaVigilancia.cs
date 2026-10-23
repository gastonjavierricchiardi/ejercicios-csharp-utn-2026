// EJ22
using System;
using System.Collections.Generic;
public class SistemaVigilancia
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public List<RegistroVigilancia> FetchSurveillanceData()
    {
        List<RegistroVigilancia> registros =
            new List<RegistroVigilancia>();

        // Consultamos los drones del 1 al 10.
        for (int id = 1; id <= 10; id++)
        {
            try
            {
                IFuenteVigilancia fuente =
                    new Gr0n3Adapter(id);

                List<RegistroVigilancia> detecciones = fuente.ObtenerRegistros();

                foreach (RegistroVigilancia registro in detecciones)
                {
                    registros.Add(registro);
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error al consultar dron " + id + ": " + ex.Message);
            }
        }

        // Consultamos el sistema terrestre una sola vez.
        FalderP falderP = new FalderP();

        IFuenteVigilancia fuenteTerrestre = new FalderPAdapter(falderP);

        List<RegistroVigilancia> deteccionesTerrestres = fuenteTerrestre.ObtenerRegistros();

        foreach (RegistroVigilancia registro in deteccionesTerrestres)
        {
            registros.Add(registro);
        }

        return registros;
    }

    public void PrintInfo(List<RegistroVigilancia> registros)
    {
        foreach (RegistroVigilancia registro in registros)
        {
            Console.WriteLine("Dispositivo  : " + registro.IdDispositivo);
            Console.WriteLine("Tipo         : " + registro.Tipo);
            Console.WriteLine("Tamaño       : " + registro.Tamanio);
            Console.WriteLine("Observaciones: " + registro.Observaciones);
            Console.WriteLine();
        }
    }


}