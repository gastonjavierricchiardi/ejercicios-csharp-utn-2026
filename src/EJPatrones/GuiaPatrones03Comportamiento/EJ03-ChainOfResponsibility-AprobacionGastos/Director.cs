// EJ03-CHAIN OF RESPONSIBILITY
public class Director : Approver
{
    // 1. CAMPOS / ATRIBUTOS

    // 2. CONSTRUCTOR

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public override void Approve(decimal amount)
    {
        //throw new NotImplementedException();
        System.Console.WriteLine($"${amount} aprobado por Director");
    }
}
