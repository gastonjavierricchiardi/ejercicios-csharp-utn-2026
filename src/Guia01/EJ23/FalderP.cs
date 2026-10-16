// EJ23
using System.Collections.Generic;
public class FalderP
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public List<Perr177> GetData()
    {
        List<Perr177> unidades = new List<Perr177>();

        // Primera unidad terrestre
        List<Perr177Data> datos1 = new List<Perr177Data>();

        datos1.Add(new Perr177Data(
            FPType.HUMAN,
            "rande",
            FPGender.MALE
        ));

        datos1.Add(new Perr177Data(
            FPType.HUMAN,
            "niranipi",
            FPGender.FEMALE
        ));
        unidades.Add(new Perr177(11, datos1));

        // Segunda unidad terrestre, sin detecciones
        List<Perr177Data> datos2 = new List<Perr177Data>();

        unidades.Add(new Perr177(12, datos2));

        return unidades;
    }
}