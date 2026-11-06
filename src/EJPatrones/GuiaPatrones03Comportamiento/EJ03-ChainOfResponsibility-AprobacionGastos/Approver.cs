// EJ03-CHAIN OF RESPONSIBILITY
using System;
public abstract class Approver
{
    // 1. CAMPOS / ATRIBUTOS
    private Approver? next;

    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public void SetNext(Approver next)
    {
        this.next = next;
    }

    public abstract void Approve(decimal amount);

    protected void Forward(decimal amount)
    {
        if (next != null)
        {
            next.Approve(amount);
        }
        else
        {
            System.Console.WriteLine($"${amount} no pudo ser aprovado");
        }
    }
}
