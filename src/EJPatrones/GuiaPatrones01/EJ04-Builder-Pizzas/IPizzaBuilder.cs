// EJ04-Builder
public interface IPizzaBuilder
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS
    void SetSize();
    void SetDough();
    void AddIngredients();

    Pizza GetPizza();
}