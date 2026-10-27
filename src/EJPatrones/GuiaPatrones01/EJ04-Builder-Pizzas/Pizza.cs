// EJ04-Builder
using System;
using System.Collections.Generic;
public class Pizza
{
    // 1. CAMPOS / ATRIBUTOS
    private string size;
    private string dough;
    private List<String> ingredients;

    // 2. CONSTRUCTOR
    public Pizza()
    {
        this.size = "";
        this.dough = "";
        this.ingredients = new List<string>();
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Size
    {
        get { return size; }
        set { size = value; }
    }
    public string Dough
    {
        get { return dough; }
        set { dough = value; }
    }
    public List<String> Ingredients
    {
        get { return ingredients; }
        set { ingredients = value; }
    }

    // 4. MÉTODOS
    public void Mostrar()
    {
        string textoIngredientes = "";

        foreach (string ingrediente in this.Ingredients)
        {
            if (textoIngredientes != "")
            {
                textoIngredientes = textoIngredientes + ", ";
            }

            textoIngredientes = textoIngredientes + ingrediente;
        }

        Console.WriteLine("Pizza " + this.Size + ", masa " + this.Dough + ": " + textoIngredientes);
    }
}
