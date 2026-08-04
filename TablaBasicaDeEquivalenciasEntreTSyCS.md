## 1. Idea general

Los conceptos de POO son casi iguales: clases, objetos, constructores, `this`, herencia, interfaces, métodos, visibilidad y `static`. La diferencia principal es que **C# exige una sintaxis y un tipado más rígidos**.

## 2. Equivalencias principales

| TypeScript                       | C#                          |
| -------------------------------- | --------------------------- |
| `archivo.ts`                     | `Archivo.cs`                |
| `nombre: string`                 | `string nombre`             |
| `edad: number`                   | `int edad` / `double edad`  |
| `activo: boolean`                | `bool activo`               |
| `constructor()`                  | `public NombreClase()`      |
| `console.log()`                  | `Console.WriteLine()`       |
| `` `Hola ${nombre}` ``           | `$"Hola {nombre}"`          |
| `function main(): void`          | `static void Main()`        |
| `extends Persona`                | `: Persona`                 |
| `implements IPersona`            | `: IPersona`                |
| `import ... from ...`            | `using Namespace;`          |
| `string[]`                       | `string[]` o `List<string>` |
| `string \| null`                 | `string?`                   |
| `===`                            | `==`                        |
| `public`, `private`, `protected` | iguales                     |
| `static`                         | igual                       |

En TypeScript:

```typescript
public nombre: string;

getNombre(): string {
    return this.nombre;
}
```

En C#:

```csharp
public string nombre;

public string GetNombre()
{
    return this.nombre;
}
```

## 3. Mismo ejemplo en ambos lenguajes

```typescript
// TypeScript
class Persona {
  public nombre: string;

  constructor(nombre: string) {
    this.nombre = nombre;
  }

  public saludar(): void {
    console.log(`Hola, soy ${this.nombre}`);
  }
}
```

```csharp
// C#
public class Persona
{
    public string nombre;

    public Persona(string nombre)
    {
        this.nombre = nombre;
    }

    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {this.nombre}");
    }
}
```

La regla visual más importante es:

```text
TypeScript: nombre: tipo
C#:         tipo nombre
```
