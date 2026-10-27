// EJ04-Builder
public class PizzaDirector
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    public Pizza BuildPizza(IPizzaBuilder builder)
    {
        builder.SetSize();
        builder.SetDough();
        builder.AddIngredients();

        return builder.GetPizza();
    }
}