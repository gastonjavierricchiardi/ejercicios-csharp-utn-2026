### Ejercicio 2 - Decorator: café con agregados

Una cafetería vende café ($1500) y permite sumarle agregados: leche ($300), crema ($400) y chocolate ($500), en cualquier combinación y hasta repetidos (doble chocolate). El ticket muestra la descripción completa y el precio final.

La carta de agregados cambia seguido. Sumar un agregado nuevo no debe obligar a crear una clase por cada combinación posible ni a modificar las clases existentes.

**Para verificar:** armar un café con leche y chocolate y mostrar su ticket.

```text
Café, leche, chocolate: $2300
```

> **Para pensar:** ¿cuántas clases harían falta para cubrir todas las combinaciones usando solo herencia? ¿Y con tu solución?

**Respuesta:** Utilizando únicamente herencia, necesitaríamos crear clases específicas para cada combinación de agregados. Como se permiten agregados repetidos sin límite, la cantidad de combinaciones posibles sería ilimitada.

Con el patrón **Decorator**, utilizamos cinco clases (`Coffee`, `CoffeeDecorator` y los tres decoradores concretos), más la interfaz `ICoffee`. Esto permite combinar y repetir agregados sin crear nuevas clases ni modificar las existentes.
