// EJ23
using System;
using System.Collections.Generic;
public class FlyingGr0n3
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public static List<Gr0n3Object> GetData(int id)
    {
        if (id == 1)
        {
            List<Gr0n3Object> objetos = new List<Gr0n3Object>();

            objetos.Add(new Gr0n3Object("big", "animal", "dog"));
            objetos.Add(new Gr0n3Object("medium", "human", "undefined"));

            return objetos;
        }

        if (id == 2)
        {
            return new List<Gr0n3Object>();
        }
        throw new Exception("Dispositivo inexistente" + id);
    }
}