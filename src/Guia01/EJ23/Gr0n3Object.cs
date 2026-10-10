// EJ23
using System;
public class Gr0n3Object
{
    // 1. CAMPOS / ATRIBUTOS
    private string size;
    private string type;
    private string kind;
    // 2. CONSTRUCTOR
    public Gr0n3Object(
        string size,
        string type,
        string kind
    )
    {
        this.size = size;
        this.type = type;
        this.kind = kind;
    }
    // 3. PROPIEDADES / GETTERS Y SETTERS
    public string Size
    {
        get { return size; }
        //        set { size = value; }
    }

    public string Type
    {
        get { return type; }
        //        set { type = value; }
    }
    public string Kind
    {
        get { return kind; }
        //        set { kind = value; }
    }
    // 4. MÉTODOS
}