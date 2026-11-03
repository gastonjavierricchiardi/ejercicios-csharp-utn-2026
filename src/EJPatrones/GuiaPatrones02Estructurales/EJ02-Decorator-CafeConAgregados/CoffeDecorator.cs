// EJ02-Decorator
public abstract class CoffeeDecorator : ICoffee
{
    // 1. CAMPOS / ATRIBUTOS
    private ICoffee coffee;

    // 2. CONSTRUCTOR
    public CoffeeDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public virtual string GetDescription()
    {
        //throw new NotImplementedException();
        return coffee.GetDescription();
    }
    public virtual int GetPrice()
    {
        //throw new NotImplementedException();
        return coffee.GetPrice();
    }
}