// EJ04-TemplatedMethod
using System;

public abstract class Bebida
{
    // 1. CAMPOS / ATRIBUTOS
    // 2. CONSTRUCTOR
    // 3. PROPIEDADES / GETTERS Y SETTERS
    // 4. MÉTODOS
    public void PrepararBebida()
    {
        HervirAgua();
        PrepararInfusion();
        ServirEnTaza();
        AgregarExtras();
    }
    private void HervirAgua()
    {
        System.Console.WriteLine("Hirviendo agua");
    }
    private void ServirEnTaza()
    {
        System.Console.WriteLine("Sirviendo en la taza");
    }

    // Métodos protegidos
    protected abstract void PrepararInfusion();
    protected abstract void AgregarExtras();
}

/*
## 1. ¿Por qué `private`?

En `Bebida.cs` tenemos:

```
private void HervirAgua()
private void ServirEnTaza()
```

Ambos pasos son idénticos para todas las bebidas.

Por eso los dejamos `private`:

- Solamente `Bebida` puede llamarlos directamente.
- `Te` y `Cafe` no necesitan acceder a ellos.
- Evitamos exponer operaciones internas que no deben utilizarse por separado desde afuera.

La clase base se encarga de ejecutarlos cuando corresponde.

## 2. ¿Por qué `protected`?

Los otros dos métodos son diferentes:

```
protected abstract void PrepararInfusion();
protected abstract void AgregarExtras();
```

Acá necesitamos que las clases hijas participen.

`Te` implementa sus pasos y `Cafe` hace lo mismo, mediante `protected override`.

`protected` permite que estos métodos sean accesibles desde la clase base y sus clases derivadas, pero no desde cualquier parte del programa.

## 3. La diferencia fundamental

| Visibilidad | `Bebida` | `Te` / `Cafe` | `Program` |
| ----------- | -------- | ------------- | --------- |
| `private`   | Sí       | No            | No        |
| `protected` | Sí       | Sí            | No        |
| `public`    | Sí       | Sí            | Sí        |

Hay un detalle importante: `private` no impide que una clase hija declare un método con el mismo nombre, pero sí impide que acceda directamente al método privado de la base.

Y el orden no se garantiza solamente con estas visibilidades. Se garantiza porque `PrepararBebida()` contiene la secuencia y no es `virtual`, de modo que las subclases no pueden sobrescribirla.

En nuestro diseño:

- `public` → lo que puede solicitar el usuario de la clase: `PrepararBebida()`.
- `private` → los pasos internos comunes.
- `protected` → los pasos que deben implementar las clases hijas.

Esta separación es justamente lo que hace interesante al patrón Template Method.
*/