// EJ04-Builder
public class NapolitanaBuilder : IPizzaBuilder
{
    // 1. CAMPOS / ATRIBUTOS
    private Pizza pizza;
    // 2. CONSTRUCTOR
    public NapolitanaBuilder()
    {
        this.pizza = new Pizza();
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS

    public void SetSize()
    {
        //throw new NotImplementedException();
        this.pizza.Size = "mediana";
    }

    public void SetDough()
    {
        //throw new NotImplementedException();
        this.pizza.Dough = "fina";
    }

    public void AddIngredients()
    {
        //throw new NotImplementedException();
        this.pizza.Ingredients.Add("muzzarella");
        this.pizza.Ingredients.Add("tomate");
        this.pizza.Ingredients.Add("ajo");
    }

    public Pizza GetPizza()
    {
        //throw new NotImplementedException();
        return this.pizza;
    }
}
