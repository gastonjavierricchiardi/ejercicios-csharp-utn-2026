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

> **Para pensar:** ¿cómo garantiza tu solución que el orden no cambie? Comparar con Strategy: ¿cuál usa herencia y cuál composición?
