# EJ26 — `Dependencia.cs`: explicación didáctica de los bucles y la recursividad

**Materia:** Programación II — C# — UTN — 2026  
**Ejercicio:** 26 — Empresa de correo  
**Patrón:** Composite  
**Archivo de código acompañado:** `Dependencia.cs`  
**Estado:** **PROPUESTO** — explicación del código que propuso el asistente. La compilación y la ejecución de esta versión todavía están **PENDIENTES**.

> **Alcance:** este documento explica el funcionamiento de la versión de `Dependencia.cs` presentada en la conversación. No agrega funcionalidades, no modifica las reglas acordadas y no sustituye el archivo `.cs`. El aumento de complejidad de esta implementación (búsquedas recursivas y métodos auxiliares) provino de la propuesta anterior del asistente.

---

## 1. ¿Qué problema debe resolver `Dependencia`?

En el modelo acordado, una `Sucursal` no administra otras unidades, mientras que una `Dependencia` sí puede hacerlo. Ambas heredan de `UnidadCorreo`.

Por eso, una dependencia guarda esta colección:

```csharp
private List<UnidadCorreo> unidades;
```

Esa lista puede incluir **sucursales y otras dependencias**:

```text
Sede central (Dependencia)
├── Dependencia A
│   ├── Sucursal S1
│   ├── Sucursal S2
│   └── Dependencia C
│       └── Sucursal S3
└── Dependencia B
    └── Sucursal S4
```

**Importante:** `unidades.Count` cuenta **todos** los elementos directos de la lista. En cambio, nuestras reglas requieren contar solamente las **sucursales directas** de una dependencia. Las sucursales que estén dentro de otra dependencia no se suman a ese conteo.

### Reglas acordadas para incorporar una sucursal

| Prioridad | Qué se busca                                         | Qué se hace                                                           |
| --------- | ---------------------------------------------------- | --------------------------------------------------------------------- |
| 1         | Una dependencia con **4 sucursales directas**        | Su cuarta sucursal pasa a ser dependencia y recibe la nueva sucursal. |
| 2         | Una dependencia con **0, 1 o 2 sucursales directas** | Se agrega allí la sucursal nueva.                                     |
| 3         | Una dependencia con **3 sucursales directas**        | Se agrega como cuarta sucursal temporal.                              |

Se busca entre las dependencias subordinadas de la sede central, **no en la sede central misma**. Si varias cumplen una condición, la primera encontrada sirve como elección arbitraria.

---

## 2. Mapa de los tres bucles

| Método                           | Bucle     | Para qué sirve                                                                          |
| -------------------------------- | --------- | --------------------------------------------------------------------------------------- |
| `ContarSucursales()`             | `foreach` | Contar cuántas sucursales directas tiene **una** dependencia.                           |
| `BuscarDependencia(...)`         | `foreach` | Recorrer unidades, encontrar dependencias candidatas y explorar sus dependencias hijas. |
| `TransformarCuartaSucursal(...)` | `for`     | Encontrar la **cuarta sucursal directa** y reemplazarla en su posición de la lista.     |

Además de los bucles, existe **recursividad** en `BuscarDependencia(...)`: el método se llama nuevamente sobre una dependencia subordinada para explorar otro nivel del árbol.

---

## 3. Primer bucle: `ContarSucursales()`

### ¿Qué necesitamos saber?

Cuántas sucursales contiene directamente una dependencia. No cuántos elementos tiene la lista y tampoco cuántas sucursales existen en todo su subárbol.

```csharp
private int ContarSucursales()
{
    int cantidad = 0;

    // Recorremos uno por uno los elementos directos de esta dependencia.
    foreach (UnidadCorreo unidad in unidades)
    {
        // Solo contamos aquellos cuyo objeto es una Sucursal.
        // Si es una Dependencia, no incrementamos el contador.
        if (unidad is Sucursal)
        {
            cantidad++;
        }
    }

    // Devolvemos la cantidad de sucursales directas encontradas.
    return cantidad;
}
```

### Recorrido manual

Supongamos que `unidades` contiene:

```text
Índice       0             1                2             3
Elemento     Sucursal S1   Dependencia C    Sucursal S2   Sucursal S3
```

El `foreach` hace lo siguiente:

| Vuelta | `unidad` es... | ¿Es `Sucursal`? | `cantidad` |
| ------ | -------------- | --------------- | ---------- |
| 1      | S1             | Sí              | 1          |
| 2      | C              | No              | 1          |
| 3      | S2             | Sí              | 2          |
| 4      | S3             | Sí              | 3          |

**Resultado:** `ContarSucursales()` devuelve `3`, aunque `unidades.Count` sea `4`.

**¿Por qué `foreach`?** Porque solamente necesitamos **leer** cada elemento y contar; no necesitamos saber en qué índice se encuentra ni reemplazarlo.

---

## 4. Segundo bucle: `BuscarDependencia(...)`

Este método busca una dependencia con determinada cantidad de sucursales directas.

```csharp
private Dependencia? BuscarDependencia(int cantidadMinima, int cantidadMaxima)
```

- `cantidadMinima`: cantidad mínima aceptada.
- `cantidadMaxima`: cantidad máxima aceptada.
- `Dependencia?`: devuelve una dependencia encontrada o `null` si no hay ninguna.

Por ejemplo, `BuscarDependencia(0, 2)` significa: «buscá una dependencia que tenga **entre cero y dos sucursales directas**».

### Código explicado

```csharp
private Dependencia? BuscarDependencia(
    int cantidadMinima,
    int cantidadMaxima
)
{
    // Recorremos las unidades directas de la dependencia actual.
    foreach (UnidadCorreo unidad in unidades)
    {
        // Solo podemos seleccionar o explorar objetos de tipo Dependencia.
        // Si encontramos una Sucursal, la salteamos: no tiene subordinados.
        if (unidad is Dependencia dependencia)
        {
            // Contamos solamente las sucursales directas de esta candidata.
            int cantidad = dependencia.ContarSucursales();

            // Verificamos si está dentro del rango solicitado.
            if (cantidad >= cantidadMinima &&
                cantidad <= cantidadMaxima)
            {
                // La encontramos: dejamos de buscar y la devolvemos.
                return dependencia;
            }

            // No cumplió el rango. Tal vez ALGUNA dependencia que está
            // dentro de ella sí lo cumpla. Por eso buscamos un nivel más abajo.
            Dependencia? encontrada =
                dependencia.BuscarDependencia(
                    cantidadMinima,
                    cantidadMaxima
                );

            // Si el recorrido profundo encontró una candidata, la devolvemos.
            if (encontrada != null)
            {
                return encontrada;
            }

            // Si no encontró nada, el foreach continúa con la siguiente
            // unidad de la lista actual.
        }
    }

    // Terminamos de recorrer toda esta rama sin encontrar candidatas.
    return null;
}
```

### ¿En qué momento aparece la recursividad?

En esta instrucción:

```csharp
Dependencia? encontrada = dependencia.BuscarDependencia(
    cantidadMinima,
    cantidadMaxima
);
```

`BuscarDependencia` está ejecutándose dentro de una dependencia y **vuelve a invocarse** sobre otra dependencia subordinada.

Ejemplo:

```text
Sede central
├── Dependencia A (3 sucursales)
│   └── Dependencia C (4 sucursales)
└── Dependencia B (2 sucursales)
```

Si llamamos desde la sede central a `BuscarDependencia(4, 4)`:

1. El `foreach` de la sede central encuentra **A**.
2. A tiene 3 sucursales directas: **no cumple** el rango 4–4.
3. Se ejecuta `A.BuscarDependencia(4, 4)`: entramos a buscar **dentro de A**.
4. Allí encontramos **C**, que tiene 4 sucursales: **sí cumple**.
5. Se devuelve C y terminan las llamadas pendientes.

**La búsqueda es en profundidad:** revisamos una dependencia y, si no cumple, exploramos sus subordinadas antes de pasar a la siguiente hermana.

### ¿Qué detiene la búsqueda?

- Si encuentra una candidata, ejecuta `return dependencia`.
- Si una búsqueda interna encuentra una candidata, ejecuta `return encontrada`.
- Si termina de recorrer una rama sin encontrar nada, ejecuta `return null`.

Así, el método puede subir de nuevo al nivel anterior después de explorar una rama. Se presupone que el modelo contiene una **jerarquía sin ciclos**, tal como venimos diseñando.

**¿Por qué `foreach`?** Porque buscamos una candidata; no necesitamos modificar posiciones de la lista durante esta búsqueda.

**¿Por qué la sede central no se elige a sí misma?** Porque el método evalúa únicamente las dependencias que aparecen **dentro de su lista**. No evalúa el objeto sobre el cual comenzó la llamada.

---

## 5. Tercer bucle: `TransformarCuartaSucursal(...)`

Este método se ejecuta sobre una dependencia que ya fue identificada como poseedora de **cuatro sucursales directas**.

Debe encontrar la cuarta, convertirla en una nueva `Dependencia` con el **mismo `Id` y `Nombre`**, ubicarla en el mismo lugar de la lista y poner a la sucursal recién incorporada bajo su control.

### ¿Por qué acá usamos `for` y no `foreach`?

Porque vamos a **reemplazar un elemento de la lista**. Para hacerlo necesitamos su posición exacta:

```csharp
unidades[i] = nuevaDependencia;
```

Un `for` nos permite manejar explícitamente el índice `i`.

### Código explicado

```csharp
private void TransformarCuartaSucursal(Sucursal nuevaSucursal)
{
    // Contador de sucursales encontradas; NO es el índice de la lista.
    int cantidad = 0;

    // i es la posición actual de la lista: 0, 1, 2, 3, etc.
    // Continuamos mientras existan posiciones por recorrer.
    for (int i = 0; i < unidades.Count; i++)
    {
        // Como la lista mezcla sucursales y dependencias,
        // solo contamos los objetos que sean Sucursal.
        if (unidades[i] is Sucursal sucursal)
        {
            // Encontramos otra sucursal directa.
            cantidad++;

            // ¿Es la cuarta SUCURSAL que aparece en el recorrido?
            if (cantidad == 4)
            {
                // Creamos una Dependencia usando la identidad de esa Sucursal.
                // No cambia el Id ni el Nombre del establecimiento.
                Dependencia nuevaDependencia =
                    new Dependencia(
                        sucursal.Id,
                        sucursal.Nombre
                    );

                // La sucursal que acaba de llegar pasa a depender de D4.
                nuevaDependencia.unidades.Add(nuevaSucursal);

                // Reemplazamos la antigua Sucursal por la nueva Dependencia
                // exactamente en la misma posición del árbol.
                unidades[i] = nuevaDependencia;

                // Ya terminó la transformación; salimos del método.
                return;
            }
        }
    }
}
```

### Diferencia fundamental entre `i` y `cantidad`

Imaginemos la lista:

```text
Índice i     Elemento              cantidad acumulada
0            Sucursal S1           1
1            Dependencia D2        1   (no se cuenta)
2            Sucursal S2           2
3            Sucursal S3           3
4            Sucursal S4           4   ← ¡esta es la cuarta sucursal!
```

En este ejemplo, cuando encontramos la cuarta sucursal:

- `cantidad == 4`.
- `i == 4`.

**No siempre coinciden.** `cantidad` dice cuántas sucursales encontramos, mientras que `i` marca la posición real del elemento que queremos reemplazar.

Por eso sería incorrecto suponer que la cuarta sucursal está siempre en `unidades[3]`.

### Antes y después

```text
ANTES
Dependencia A
├── Sucursal S1
├── Sucursal S2
├── Sucursal S3
└── Sucursal S4

LLEGA S5

DESPUÉS
Dependencia A
├── Sucursal S1
├── Sucursal S2
├── Sucursal S3
└── Dependencia D4 (mismo Id y Nombre de S4)
    └── Sucursal S5
```

La sucursal S4 **no cambió de lugar físico** según nuestro modelo: lo que cambió fue su papel administrativo. En C# se creó otro objeto de la clase `Dependencia` para representarlo.

**¿Por qué termina con `return`?** Porque solo hay que transformar **una** cuarta sucursal, no seguir modificando el resto de la lista.

---

## 6. ¿Cómo se conectan los métodos?

`IncorporarSucursal(...)` no tiene un bucle propio: **llama tres veces al método de búsqueda**, cada vez con un rango distinto. Los bucles están dentro de `BuscarDependencia` y de los otros auxiliares.

```text
Sede central.IncorporarSucursal(nuevaSucursal)
    │
    ├── BuscarDependencia(4, 4)
    │      └── Si encuentra: TransformarCuartaSucursal(...) y terminar
    │
    ├── BuscarDependencia(0, 2)
    │      └── Si encuentra: agregar a esa dependencia y terminar
    │
    ├── BuscarDependencia(3, 3)
    │      └── Si encuentra: agregar como cuarta y terminar
    │
    └── Si ninguna existe: lanzar la excepción propuesta
```

Cada `return` impide que se ejecuten las prioridades siguientes. Por eso, **una misma sucursal nueva no se agrega dos veces**.

### Ejemplo de prioridad

Si una dependencia tiene 4 sucursales y otra tiene 2, primero se elige la de 4 para reorganizarla. Esa prioridad fue una **decisión de modelado validada en nuestra conversación**, no una regla expresamente ordenada por la consigna.

---

## 7. Archivo completo `Dependencia.cs`, con comentarios didácticos

> Es el mismo algoritmo propuesto anteriormente. Los cambios de este bloque son **comentarios explicativos**; no agregamos ni reemplazamos funcionalidades.

```csharp
using System;
using System.Collections.Generic;

public class Dependencia : UnidadCorreo
{
    // 1. CAMPOS / ATRIBUTOS

    // Colección de unidades DIRECTAS de esta dependencia.
    // Puede contener objetos Sucursal y Dependencia.
    private List<UnidadCorreo> unidades;

    // 2. CONSTRUCTOR
    public Dependencia(int id, string nombre) : base(id, nombre)
    {
        // Cada dependencia comienza con su propia lista vacía.
        unidades = new List<UnidadCorreo>();
    }

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS

    public void AgregarDependencia(Dependencia dependencia)
    {
        // Agrega una dependencia como hija directa.
        // No aplica las reglas de asignación de sucursales.
        unidades.Add(dependencia);
    }

    public void IncorporarSucursal(Sucursal nuevaSucursal)
    {
        // PRIORIDAD 1:
        // Recorremos las dependencias subordinadas buscando alguna
        // que tenga exactamente 4 SUCURSALES DIRECTAS.
        Dependencia? destino = BuscarDependencia(4, 4);

        if (destino != null)
        {
            // Si la encontramos, transformamos su cuarta sucursal
            // en dependencia y le asignamos la sucursal nueva.
            destino.TransformarCuartaSucursal(nuevaSucursal);
            return; // La incorporación ya terminó.
        }

        // PRIORIDAD 2:
        // Si ninguna tenía 4, buscamos una que tenga entre 0 y 2.
        destino = BuscarDependencia(0, 2);

        if (destino != null)
        {
            // Agregamos la nueva sucursal como hija directa.
            destino.unidades.Add(nuevaSucursal);
            return;
        }

        // PRIORIDAD 3:
        // Si ninguna tenía menos de 3, buscamos una con exactamente 3.
        destino = BuscarDependencia(3, 3);

        if (destino != null)
        {
            // Queda temporalmente con 4 sucursales directas.
            destino.unidades.Add(nuevaSucursal);
            return;
        }

        // PROPUESTO POR EL ASISTENTE:
        // La consigna no indica qué hacer si no existe ninguna
        // dependencia subordinada. Esta excepción representa esa decisión.
        throw new InvalidOperationException(
            "No existen dependencias para incorporar la sucursal."
        );
    }

    private int ContarSucursales()
    {
        // Empezamos sin ninguna sucursal contada.
        int cantidad = 0;

        // BUCLE 1 — FOREACH:
        // Recorremos los elementos DIRECTOS de esta dependencia.
        foreach (UnidadCorreo unidad in unidades)
        {
            // Una Dependencia no cuenta como Sucursal.
            // Tampoco contamos aquí las sucursales que tenga adentro.
            if (unidad is Sucursal)
            {
                cantidad++; // Encontramos una sucursal directa.
            }
        }

        return cantidad;
    }

    private Dependencia? BuscarDependencia(
        int cantidadMinima,
        int cantidadMaxima
    )
    {
        // BUCLE 2 — FOREACH:
        // Recorremos las unidades directas del objeto actual.
        foreach (UnidadCorreo unidad in unidades)
        {
            // Solo nos interesan objetos Dependencia.
            // Si es Sucursal, no puede contener otras unidades.
            if (unidad is Dependencia dependencia)
            {
                // Consultamos cuántas sucursales directas tiene.
                int cantidad = dependencia.ContarSucursales();

                // ¿Está en el rango que estamos buscando?
                if (cantidad >= cantidadMinima &&
                    cantidad <= cantidadMaxima)
                {
                    // Encontramos una candidata: terminamos.
                    return dependencia;
                }

                // RECURSIVIDAD:
                // Si esta dependencia no cumple, buscamos DENTRO
                // de sus dependencias hijas, con el mismo rango.
                Dependencia? encontrada =
                    dependencia.BuscarDependencia(
                        cantidadMinima,
                        cantidadMaxima
                    );

                // ¿Encontramos una candidata en un nivel inferior?
                if (encontrada != null)
                {
                    return encontrada;
                }

                // Si no encontramos ninguna en esa rama,
                // continuamos con el siguiente elemento del foreach.
            }
        }

        // No apareció ninguna dependencia candidata en esta rama.
        return null;
    }

    private void TransformarCuartaSucursal(
        Sucursal nuevaSucursal
    )
    {
        // Cuenta las sucursales directas encontradas.
        // NO es el índice de la lista.
        int cantidad = 0;

        // BUCLE 3 — FOR:
        // Necesitamos el índice i porque vamos a REEMPLAZAR
        // un elemento concreto de la colección.
        for (int i = 0; i < unidades.Count; i++)
        {
            // Solo avanzamos el contador cuando el elemento
            // actual es una Sucursal.
            if (unidades[i] is Sucursal sucursal)
            {
                cantidad++;

                // Buscamos la cuarta SUCURSAL, que no tiene
                // por qué estar en el índice 3 de la lista.
                if (cantidad == 4)
                {
                    // Creamos el nuevo objeto Dependencia conservando
                    // el identificador y nombre de la antigua sucursal.
                    Dependencia nuevaDependencia =
                        new Dependencia(
                            sucursal.Id,
                            sucursal.Nombre
                        );

                    // La sucursal recién incorporada quedará a cargo
                    // de la dependencia que acabamos de crear.
                    nuevaDependencia.unidades.Add(nuevaSucursal);

                    // Sustituimos S4 por D4 en la MISMA posición
                    // dentro de la lista de su dependencia supervisora.
                    unidades[i] = nuevaDependencia;

                    // Ya hicimos el reemplazo; no seguimos recorriendo.
                    return;
                }
            }
        }
    }
}
```

---

## 8. Qué está validado y qué falta comprobar

**VALIDADO como decisión de diseño:** usamos Composite con una clase base `UnidadCorreo`, `Sucursal` como hoja y `Dependencia` como nodo que puede contener otras unidades. La sede central es una `Dependencia` raíz y no se elige como destino directo.

**VALIDADO como interpretación acordada:** la búsqueda prioriza reorganizar una dependencia de cuatro sucursales; la antigua cuarta conserva su `Id` y `Nombre` al pasar a ser representada por una dependencia.

**PROPUESTO por el asistente:** tres búsquedas por rangos, recorrido recursivo en profundidad, elección de la primera candidata y excepción cuando faltan dependencias. La consigna no exige esta implementación concreta.

**PENDIENTE:** compilar esta versión, ejecutar casos de prueba y controlar que la estructura resultante sea la esperada.

### Idea principal para recordar

- **Primer `foreach`:** cuento **sucursales**.
- **Segundo `foreach`:** busco **dependencias** y, mediante recursividad, bajo por el árbol.
- **`for`:** encuentro la **posición exacta** de la cuarta sucursal y la reemplazo.
- **`IncorporarSucursal`:** coordina las **tres prioridades** y termina apenas resuelve una.

> **No es necesario memorizar cada línea de golpe.** El primer objetivo es distinguir qué pregunta resuelve cada recorrido. Después podremos revisar si conviene simplificar la implementación, pero ese sería un cambio de diseño separado de esta explicación.
