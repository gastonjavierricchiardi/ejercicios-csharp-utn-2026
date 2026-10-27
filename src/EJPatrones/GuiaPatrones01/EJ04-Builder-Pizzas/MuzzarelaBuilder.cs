// EJ04-Builder
public class MuzzarelaBuilder : IPizzaBuilder
{
    // 1. CAMPOS / ATRIBUTOS
    private Pizza pizza;

    // 2. CONSTRUCTOR
    public MuzzarelaBuilder()
    {
        this.pizza = new Pizza();
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public void SetSize()
    {
        //throw new NotImplementedException();
        this.pizza.Size = "grande";
    }

    public void SetDough()
    {
        //throw new NotImplementedException();
        this.pizza.Dough = "a la piedra";
    }

    public void AddIngredients()
    {
        //throw new NotImplementedException();
        this.pizza.Ingredients.Add("muzzarella");
        this.pizza.Ingredients.Add("aceitunas");
    }

    public Pizza GetPizza()
    {
        //throw new NotImplementedException();
        return this.pizza;
    }
}
