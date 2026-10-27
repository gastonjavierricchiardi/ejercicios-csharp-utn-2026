### Ejercicio 4 - Builder: pizzas de la carta

Una pizzería registra sus pedidos en un sistema. Cada pizza tiene tamaño, tipo de masa y una lista de ingredientes. El constructor actual de la pizza ya recibe seis parámetros, varios con `null`, y es fácil confundir el orden.

Todas las pizzas de la carta se arman con el mismo proceso (primero el tamaño, después la masa, por último los ingredientes); lo que cambia es el contenido de cada paso. Se pide poder construir las pizzas de la carta reutilizando ese proceso y sumar pizzas nuevas sin tocar la clase de la pizza.

**Para verificar:** construir una muzzarella (grande, a la piedra, con aceitunas) y una napolitana (mediana, masa fina, con tomate y ajo) con el mismo proceso.

```text
Pizza grande, masa a la piedra: muzzarella, aceitunas
Pizza mediana, masa fina: muzzarella, tomate, ajo
```

**Para pensar:**

1. ¿quién conoce el orden de los pasos y quién el contenido de cada uno?
2. ¿Qué se gana separándolos?

---

# Respuestas

1. ¿quién conoce el orden de los pasos y quién el contenido de cada uno?

El Director (`PizzaDirector`) conoce el orden de los pasos de construcción de la pizza.

En nuestro ejercicio, el método `BuildPizza()` establece la siguiente secuencia.

```CSharp
build.SetSize();
build.SetDough();
build.AddIngredients();
```

Los **Builders concretos** (`MuzzarellaBuilder` y `NapolitanaBuilder`) conocen el contenido de cada paso, es decir el tamaño, la masa y los ingredientes correspondientes de cada receta.

---

2. ¿Qué se gana separándolos?

Se consigue reutilizar un mismo proceso de construcción para obtener productos diferentes, sin repetir la secuencia de pasos para cada receta.

---

**Además**:

- Flexibilidad: podemos agregar nuevas pizzas creando otros Builders concretos, sin modificar Pizza ni PizzaDirector, siempre que se mantengan los mismos pasos.
- Menor acoplamiento: el Director trabaja con IPizzaBuilder y no necesita conocer las recetas concretas.
- Separación de responsabilidades (SRP): el Director organiza el proceso y cada Builder concreto define el contenido de su receta.

**Conclusión para el apunte**:

> Builder separa el orden de construcción del contenido de cada paso. El Director controla cómo se organiza el proceso, mientras que los Builders concretos determinan qué características tendrá el producto. Esto permite reutilizar el proceso, incorporar nuevas variantes y mantener las responsabilidades separadas.
