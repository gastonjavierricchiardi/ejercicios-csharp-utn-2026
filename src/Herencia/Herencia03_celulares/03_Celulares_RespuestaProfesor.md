# Aclaración de ejercicio de Herencia (Celulares)

## Nuestra pregunta:

> Duda sobre el consumo de batería del iPhone — Ejercicio Celulares

```txt
de Gastón Javier Ricchiardi - jueves, 20 de agosto de 2026, 16:27
Número de respuestas: 1
En el enunciado dice:
```

“El Motorola G5 pierde 0,25 puntos de batería por cada llamada, y el iPhone pierde 0,1% de la duración de cada llamada en batería. Ambos celulares tienen 5 puntos de batería como máximo.”

No me queda claro cómo debe calcularse el consumo del iPhone.

Por ejemplo, si una llamada tiene una duración de 10 unidades, ¿el consumo debería calcularse como 10 \* 0,1, es decir 1 punto de batería, o se refiere literalmente al 0,1% de la duración?

¿Cuál es la fórmula que debemos utilizar?

Gracias profes.

---

## Respuesta del profesorado:

```
Re: Duda sobre el consumo de batería del iPhone — Ejercicio Celulares
de Andres Daniel Chimuris Gimenez - jueves, 20 de agosto de 2026, 22:05
```

Hola Gastón, ¿cómo estás?

Buena observación. El enunciado en ese punto puede prestarse a confusión.

Para este ejercicio, interpreten que el iPhone pierde 0,1 puntos de batería por cada unidad de duración de la llamada. Es decir, pueden calcularlo de la siguiente manera:

```csharp
consumo = duracionLlamada * 0.1;
```

Por ejemplo, si la llamada dura 10 unidades:

> 10 \* 0.1 = 1

por lo tanto, el iPhone perdería 1 punto de batería.

Si interpretáramos literalmente el 0,1% escrito en el enunciado, el cálculo sería diferente, porque 0,1% equivale a 0,001. Pero para los fines del ejercicio, tomen el valor como 0,1 puntos por unidad de duración.

Lo importante en este ejercicio es principalmente que puedan modelar correctamente los celulares, las personas, sus relaciones y los distintos comportamientos asociados al consumo y recarga de la batería.

Saludos, Andrés

---

# Resumen de lo charlado

### Lógica para el consumo de batería del iPhone

El enunciado marea porque dice "0,1%", pero el profe aclara que **no** hay que usar la equivalencia matemática del porcentaje (`0.001`). Hay que restar **0,1 puntos directos** por cada unidad de tiempo hablado.

Si lo pasamos a C#, la lógica dentro de tu método (por ejemplo, `HacerLlamada` o `ConsumirBateria`) debería verse así:

```csharp
// Fórmula confirmada por el profesor:
// consumo = duracionLlamada * 0.1;

public void ConsumirBateria(int duracionLlamada)
{
    double consumo = duracionLlamada * 0.1;
    this.bateria -= consumo;
}

```

_(Si la llamada dura 10 minutos/unidades, te va a descontar exactamente 1 punto entero de batería)._

**El "Takeaway" del profe:** No te enrosques de más con la matemática de los porcentajes. Lo que ellos van a evaluar en este ejercicio es que hayas podido armar bien las clases (Persona, Celular), que las hayas relacionado correctamente, y que los métodos modifiquen los atributos privados (como la batería) como corresponde.
