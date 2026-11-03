// EJ01-Strategy
public class Order
{
    // 1. CAMPOS / ATRIBUTOS
    private double weightKg;
    private IShippingStrategy shippingStrategy;

    // 2. CONSTRUCTOR
    public Order(
        double weightKg,
        IShippingStrategy shippingStrategy
        )
    {
        this.weightKg = weightKg;
        this.shippingStrategy = shippingStrategy;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public void SetShippingStrategy(IShippingStrategy strategy)
    {
        this.shippingStrategy = strategy;
    }

    public double CalculateShippingCost()
    {
        return shippingStrategy.CalculateCost(weightKg);
    }
}
