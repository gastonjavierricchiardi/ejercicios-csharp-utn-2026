### Ejercicio 4 - Template Method: máquina de bebidas

Una máquina expendedora prepara té y café. Las dos bebidas siguen la misma secuencia: hervir agua, preparar la infusión, servir en la taza y agregar extras. Hervir y servir son idénticos para todas; preparar y agregar extras cambian (té: saquito y limón; café: filtrado, azúcar y leche).

El fabricante va a sumar bebidas, como el mate cocido. Ninguna bebida nueva debe poder alterar el orden de la secuencia ni repetir el código de los pasos comunes.

**Para verificar:** preparar un té y un café.

```text
Té
Hirviendo agua
Remojando el saquito
Sirviendo en la taza
Agregando limón

Café
Hirviendo agua
Filtrando el café
Sirviendo en la taza
Agregando azúcar y leche
```

> **Para pensar:**

1. ¿cómo garantiza tu solución que el orden no cambie?

> Comparar con Strategy:

2. ¿cuál usa herencia y cuál composición?

---

### 1. ¿Cómo garantiza la solución que el orden no cambie?

La clase abstracta `Bebida` define el método `PrepararBebida()`, que establece el orden de los cuatro pasos de preparación.

Como este método no es `virtual`, las clases hijas no pueden sobrescribirlo para modificar la secuencia.

Las clases `Te` y `Cafe` solamente implementan los métodos abstractos `PrepararInfusion()` y `AgregarExtras()`, conservando el orden definido en la clase base.

### 2. Comparación con Strategy: ¿cuál usa herencia y cuál composición?

**Template Method utiliza herencia.** Las clases `Te` y `Cafe` heredan de `Bebida` y redefinen determinados pasos mediante `override`, reutilizando el comportamiento común.

**Strategy utiliza composición.** Un objeto mantiene una referencia a una estrategia y delega en ella un comportamiento que puede cambiar.

La diferencia principal es que **Template Method permite variar pasos de un algoritmo sin cambiar su estructura**, mientras que **Strategy permite intercambiar algoritmos mediante objetos diferentes**.
