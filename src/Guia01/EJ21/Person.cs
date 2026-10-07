// EJ21
public class Person
{
    // 1. CAMPOS / ATRIBUTOS
    private string name;
    private string lastName;
    private DateTime birthDate;

    // 2. CONSTRUCTOR
    public Person(
        string name,
        string lastName,
        DateTime birthDate
    )
    {
        this.name = name;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS
    public DateTime BirthDate
    {
        get { return birthDate; }
        //        set { birthDate = value; }
    }

    public string LastName
    {
        get { return lastName; }
        //        set { lastName = value; }
    }

    public string Name
    {
        get { return name; }
        //        set { name = value; }
    }
    // 4. MÉTODOS
}