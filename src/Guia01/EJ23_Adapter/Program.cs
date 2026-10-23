// EJ23 --> adapter
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // 1. Crear el sistema
        SistemaVigilancia sistema = new SistemaVigilancia();

        // 2. Recuperar los datos de vigilancia
        List<RegistroVigilancia> registros =
            sistema.FetchSurveillanceData();

        // 3. Imprimir los resultados
        sistema.PrintInfo(registros);
    }
}