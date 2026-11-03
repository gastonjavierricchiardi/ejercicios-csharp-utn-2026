// EJ01-Strategy
public class StandardShipping : IShippingStrategy
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public double CalculateCost(double weightKg)
    {
        //throw new NotImplementedException();
        return weightKg * 1000;
    }
}
