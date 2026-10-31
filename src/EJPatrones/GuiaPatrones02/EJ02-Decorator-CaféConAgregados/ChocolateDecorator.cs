// EJ02-Decorator
using System;
public class ChocolateDecorator : CoffeeDecorator
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    public ChocolateDecorator(ICoffee coffee) : base(coffee)
    {
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public override string GetDescription()
    {
        return base.GetDescription() + ", chocolate";
    }

    public override int GetPrice()
    {
        return base.GetPrice() + 500;
    }
}