// /Persona.cs
public class Persona
{
    private string name;
    private string LastName;
    /*
    Si lo accedes así directo: unaPersona.name = "Gastón     _Javier";
    con = y el public, lo pisas, lo tenes que usar private
    */

    /*
    Si lo que queremos ahora es una property
    Metodo()        // paréntesis
    Property { }    // llaves
    */
    //public string LastName { get; set; }

    public string LastName
    {
        get { return lastName.Trim().ToUpper(); }
        set { lastName = value; }

        /*
        Lo termina haciendo así, saca el:
        private string lastName;

        y pone:

        get {return field.Trim().ToUpper();}
        set {field =value.Trim();}
        */
    }

    public string GetName()
    {
        // return name;
        return name.Trim().ToUpper();
    }
    public void SetName(string value)
    {
        name = value.Trim();
    }
}

/*
1. El **Stack overflow** viene de `LastName`: la property se llama a sí misma sin parar.

```csharp
public string LastName
{
    get { return LastName.Trim().ToUpper(); }
    set { LastName = value; }
}
```

Cuando hacés:

```csharp
unaPersona.LastName = "ricchi";
```

entra al `set`:

```text
set → LastName = value
          ↓
       llama al set
          ↓
       llama al set
          ↓
       llama al set...
```

Por eso te dice:

```text
Repeated 261662 times:
at Persona.set_LastName(System.String)
```

2. Necesitás un **atributo privado de respaldo** para guardar realmente el apellido, igual que ya hacés con `name`:

```csharp
public class Persona
{
    private string name;
    private string lastName;

    public string LastName
    {
        get { return lastName.Trim().ToUpper(); }
        set { lastName = value.Trim(); }
    }

    public string GetName()
    {
        return name.Trim().ToUpper();
    }

    public void SetName(string value)
    {
        name = value.Trim();
    }
}
```

Ahora queda clarísimo:

```text
LastName   → property pública
lastName   → atributo privado donde guardamos el dato
```

3. Y el warning de `name` y ahora también `lastName` es **otro tema distinto**: C# te avisa que los `string` podrían arrancar sin valor. No es lo que produjo el `Stack overflow`.

Primero quedémonos con esta idea, que es la importante: **una property personalizada no debe hacer `LastName = ...` dentro de su propio `set`; necesita guardar el valor en otro campo, por ejemplo `lastName`.**

*/