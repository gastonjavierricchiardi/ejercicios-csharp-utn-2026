// EJ04-TemplatedMethod
using System;

public class Cafe : Bebida
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    protected override void PrepararInfusion()
    {
        //throw new NotImplementedException();
        System.Console.WriteLine("Filtrando el café");
    }

    protected override void AgregarExtras()
    {
        //throw new NotImplementedException();
        System.Console.WriteLine("Agregando azúcar y leche");
    }
}