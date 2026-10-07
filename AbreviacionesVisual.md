# Abreviaciones:

1. Los que más te sirven para Programación II:

| Escribís    | Genera                                |
| ----------- | ------------------------------------- |
| `ctor`      | **Constructor de la clase actual**    |
| `prop`      | Propiedad automática `{ get; set; }`  |
| `propfull`  | Propiedad completa + atributo privado |
| `propg`     | Propiedad con `get` privado           |
| `if`        | `if (...) { }`                        |
| `else`      | `else { }`                            |
| `for`       | `for (...)`                           |
| `forr`      | `for` recorriendo **al revés**        |
| `foreach`   | `foreach (...)`                       |
| `while`     | `while (...)`                         |
| `do`        | `do { } while (...)`                  |
| `switch`    | `switch (...)`                        |
| `try`       | `try/catch`                           |
| `tryf`      | `try/finally`                         |
| `lock`      | `lock (...)`                          |
| `using`     | bloque `using`                        |
| `cw`        | `Console.WriteLine(...)`              |
| `class`     | estructura de una clase               |
| `struct`    | estructura de un `struct`             |
| `interface` | interfaz                              |
| `enum`      | enumeración                           |
| `svm`       | `static void Main(...)`               |

Por ejemplo, estando adentro de:

```csharp
public class Persona
{
    ctor
}
```

hacés **Tab Tab** y Visual Studio reconoce el nombre de la clase:

```csharp
public class Persona
{
    public Persona()
    {

    }
}
```

2. Para vos me quedaría especialmente con esta **chuleta corta**:

```text
ctor      → constructor
prop      → propiedad automática
propfull  → propiedad + campo privado
cw        → Console.WriteLine
if        → if
for       → for
forr      → for inverso
foreach   → foreach
while     → while
switch    → switch
try       → try/catch
class     → clase
```

3. Y hay algo todavía mejor: podés ver **exactamente todos los que tenés instalados en TU Visual Studio** con **Ctrl + K, Ctrl + X → Visual C#**. La lista puede variar según versión/workloads instalados. [Microsoft Learn](https://learn.microsoft.com/en-us/visualstudio/ide/code-snippets?view=visualstudio&utm_source=chatgpt.com)
