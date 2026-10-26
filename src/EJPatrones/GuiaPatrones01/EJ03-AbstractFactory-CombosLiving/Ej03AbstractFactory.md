### Ejercicio 3 - Abstract Factory: combos de living

Una mueblería online vende combos de living formados por una silla y una mesa. Hay dos líneas: Moderna (silla de acero, mesa de vidrio) y Clásica (silla y mesa de roble). Hubo reclamos porque se entregaron combos mezclados, con una silla moderna y una mesa clásica.

El año próximo se suma una línea Nórdica. El código que arma y muestra los combos tiene que hacer imposible mezclar líneas, y agregar una línea no debe obligar a modificarlo.

**Para verificar:** mostrar un combo de cada línea con el mismo código.

```text
Silla moderna de acero
Silla clásica de roble
Mesa moderna de vidrio
Mesa clásica de roble
```

> **Para pensar:**

1. ¿qué tendrías que cambiar si el combo sumara un tercer mueble, por ejemplo un sillón?

2. Compararlo con la analogía del cóctel del material.

---

# Respuesta preguntas:

1. Si el combo incorpora un **tercer producto** (`Sillon`) habría que modificar la estructura del patrón, porque ya no alcanza con solo crear silla y mesa.

**Habría que agregar**:

a. Un nuevo producto abstracto

```csharp
public interface ISillon
{
    void Mostrar();
}
```

b. Los productos concretos de cada línea

EJ:

- `SillonModerno`
- `SillonClasico`

c. La fábrica abstracta

```Csharp
ISillon CrearSillon();
```

d. Todas las fábricas concretas

Cada fabrica concreta tendría que implementar su nuevo método.

- `FabricaModerna` --> devuelve `SillonModerno`
- `FabricaClasica` --> devuelve `SillonClasico`

e. y por último el cliente.

```CSharp
ISillon sillon = fabrica.CrearSillon();
sillon.Mostrar();

```

---

2. Compararlo con la analogía del cóctel del material.

**Comparación con la analogía del cóctel**:

_AbstractFactory_ permite permite crear una familia formada por una bebida alcohólica y un agregado, como gin con tónica o Campari con jugo de naranja.

Agregar un sillón al combo equivale a agregar un tercer componente obligatorio a cada cóctel. Esto requiere ampliar la fábrica abstracta y todas las fabricas concretas para que puedan crear ese nuevo producto. Por lo tanto facilita agregar nuevas familias de productos, pero incorporar un nuevo tipo de producto a todas las familias require modificar las fábricas existentes.
