// EJ04-TemplatedMethod
using System;

public class Te : Bebida
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS

    protected override void PrepararInfusion()
    {
        //throw new NotImplementedException();
        System.Console.WriteLine("Remojando el saquito");
    }
    protected override void AgregarExtras()
    {
        //throw new NotImplementedException();
        System.Console.WriteLine("Agregando limón");
    }
}