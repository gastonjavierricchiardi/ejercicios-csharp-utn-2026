// EJ02-Decorator
public class MilkDecorator : CoffeeDecorator
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public override string GetDescription()
    {
        return base.GetDescription() + ", leche";
    }

    public override int GetPrice()
    {
        return base.GetPrice() + 300;
    }
}