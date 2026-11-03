// EJ03-COMPOSITE
using System;
using System.Collections.Generic;

public class SubMenu : IMenuItem
{
    // 1. CAMPOS / ATRIBUTOS
    private List<IMenuItem> items;
    private string name;
    // 2. CONSTRUCTOR
    public SubMenu(string name)
    {
        this.name = name;
        this.items = new List<IMenuItem>();
    }

    /* 3. PROPIEDADES / GETTERS Y SETTERS
    No son necesarios para este ejercicio
    public string Name
    {
        get { return name; }
        //set { name = value; }
    }
    public List<IMenuItem> Items
    {
        get { return items; }
        //set { items = value; }
    }*/

    // 4. MÉTODOS
    public void AddItem(IMenuItem item)
    {
        items.Add(item);
    }

    public void Show(int level)
    {
        //throw new NotImplementedException();
        string indentation = "";
        for (int i = 0; i < level; i++)
        {
            indentation += "  ";
        }

        System.Console.WriteLine($"{indentation}{name}");

        foreach (IMenuItem item in items)
        {
            item.Show(level + 1);
        }
    }
}