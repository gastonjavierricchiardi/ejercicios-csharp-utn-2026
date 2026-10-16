// EJ23
/*
Reducido:
1. Los que más te sirven para Programación II:
| `ctor`      | **Constructor de la clase actual**    |
| `prop`      | Propiedad automática `{ get; set; }`  |
| `propfull`  | Propiedad completa + atributo privado |
| `propg`     | Propiedad con `get` privado           |
| `foreach`   | `foreach (...)`                       |
| `try`       | `try/catch`                           |
| `tryf`      | `try/finally`                         |
| `cw`        | `Console.WriteLine(...)`              |
| `enum`      | enumeración                           |
*/
public class Perr177Data
{
    // 1. CAMPOS / ATRIBUTOS
    private FPType type;
    private string size;
    private FPGender gender;
    // 2. CONSTRUCTOR
    public Perr177Data(
        FPType type,
        string size,
        FPGender gender
    )
    {
        this.type = type;
        this.size = size;
        this.gender = gender;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public FPType Type
    {
        get { return type; }
        ///    set { type = value; }
    }
    public string Size
    {
        get { return size; }
        //set { size = value; }
    }
    public FPGender Gender
    {
        get { return gender; }
        //        set { gender = value; }
    }
    // 4. MÉTODOS
}