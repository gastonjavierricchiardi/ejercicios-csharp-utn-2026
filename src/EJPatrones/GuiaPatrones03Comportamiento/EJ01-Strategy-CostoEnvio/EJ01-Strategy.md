### Ejercicio 1 - Strategy: costo de envío

Una tienda online ofrece tres formas de envío: estándar ($1000 por kg), express ($1800 por kg) y retiro en local (sin cargo). En el checkout, el cliente puede cambiar de opción todas las veces que quiera antes de pagar.

El área comercial avisó que cada mes habrá promociones de envío con reglas nuevas. El pedido tiene que calcular su costo de envío sin `if` ni `switch` según el tipo de envío, y sumar una forma de envío no debe obligar a modificar el pedido.

**Para verificar:** con un pedido de 3 kg, cambiar la forma de envío tres veces y mostrar el costo en cada caso.

```text
Estándar: $3000
Express: $5400
Retiro en local: $0
```

> **Para pensar:** ¿qué principio SOLID se rompería si el cálculo estuviera dentro del pedido con un `switch`? ¿Cómo sumarías una promo de "envío gratis desde 5 kg"?
