En C# se llama **método `Main`** y es el **punto de entrada** del programa.

El equivalente a tu estructura de TypeScript sería:

```csharp
public class Program
{
    public static void Main()
    {
    }
}
```

Comparación directa:

```text
TypeScript                    C#
--------------------------------------------------
function main(): void         static void Main()
main();                       no hace falta llamarlo
export {};                    no hace falta
```

En C#, `Main()` lo ejecuta automáticamente .NET al iniciar el programa.

Y dentro de una **clase común** como `Articulo`, tu orden puede mantenerse igual:

```csharp
public class Articulo
{
    // 1. ATRIBUTOS

    // 2. CONSTRUCTOR

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS (Comportamiento)
}
```

Mientras que `Program.cs` queda para el punto de entrada:

```csharp
public class Program
{
    public static void Main()
    {
        // Crear objetos y probar el ejercicio
    }
}
```
