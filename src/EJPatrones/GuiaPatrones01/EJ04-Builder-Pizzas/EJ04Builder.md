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

# Análisis.

1. tamaño
2. masa
3. los ingredientes
