// EJ03-CHAIN OF RESPONSIBILITY
using System;
public class Manager : Approver
{
    // 1. CAMPOS / ATRIBUTOS

    // 2. CONSTRUCTOR

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override void Approve(decimal amount)
    {
        //throw new NotImplementedException();
        if (amount <= 200000m)
        {
            System.Console.WriteLine($"${amount} aprobado por Gerente");
        }
        else
        {
            Forward(amount);
        }
    }
}