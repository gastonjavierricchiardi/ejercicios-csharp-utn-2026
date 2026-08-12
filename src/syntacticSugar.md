Se llama **syntactic sugar** — en español, **azúcar sintáctico**.

1. Es una forma de escribir algo de manera **más corta o cómoda**, sin cambiar lo que conceptualmente hace el código.

2. Por ejemplo, en C#:

```csharp
public string GetNombre()
{
    return this.nombre;
}
```

puede escribirse:

```csharp
public string GetNombre() => this.nombre;
```

3. Entonces sí: lo que estabas recordando como “sugar code” seguramente era **syntactic sugar**. Para los ejercicios, igual seguimos primero la forma que esté usando la cátedra.
