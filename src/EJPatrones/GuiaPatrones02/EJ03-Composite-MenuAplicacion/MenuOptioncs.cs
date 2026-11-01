// EJ03-COMPOSITE
public class MenuOption : IMenuItem
{
    // 1. CAMPOS / ATRIBUTOS
    private string name;

    // 2. CONSTRUCTOR
    public MenuOption(string name)
    {
        this.name = name;
    }
    /* 3. PROPIEDADES / GETTERS Y SETTERS
        No se implementan getters ni setters porque ninguna
        otra clase necesita acceder o modificar el nombre.
    public string Name
    {
        get { return name; }
        // set { name = value; }
    }*/

    // 4. MÉTODOS
    public void Show(int level)
    {
        string indentation = "";

        for (int i = 0; i < level; i++)
        {
            indentation += "  ";
        }
        System.Console.WriteLine($"{indentation}{name}");
    }
}