// EJ02-Decorator
public class CreamDecorator : CoffeeDecorator
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public CreamDecorator(ICoffee coffee) : base(coffee)
    {
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public override string GetDescription()
    {
        return base.GetDescription() + ", crema";
    }

    public override int GetPrice()
    {
        return base.GetPrice() + 400;
    }
}