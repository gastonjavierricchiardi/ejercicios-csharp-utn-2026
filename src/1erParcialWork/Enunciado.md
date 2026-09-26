# 🧠 Enunciado del problema

Transportes del Litoral mueve encomiendas entre ciudades. Toda encomienda que entra al sistema recibe un número de guía irrepetible y queda asentada con su destino, los kilómetros hasta ese destino, el peso en kilos y la tarifa por kilómetro que se le aplica.

**Cómo se cobra:**

Al costo por distancia, que sale de multiplicar los kilómetros por la tarifa por kilómetro del envío, se le suma lo que corresponda según el tipo:

- La documentación paga un adicional fijo de $1.000, sin importar el peso.
- Los paquetes pagan $300 por kilo.
- La carga pesada paga $200 por kilo y tiene, para cada envío, un peso máximo admitido propio. Al superarlo se aplica un recargo de $20.000.

**Cómo se despacha:**

Los envíos registrados quedan pendientes y salen a ruta en el mismo orden en que entraron al sistema.

El personal de depósito necesita poder consultar cuál es el próximo envío sin sacarlo de la fila y, posteriormente, despacharlo.

Un envío despachado deja de estar pendiente, pero sigue figurando en el historial.

**Qué se asegura:**

Los paquetes y la carga pesada admiten seguro. La documentación no.

De todo envío asegurable debe poder conocerse el valor declarado de la mercadería y una descripción de la cobertura. Esta información debe estar definida como un contrato que el envío cumple.

Además, el historial completo de envíos se consulta en el orden en que fueron registrados, estén despachados o no. Un mismo destino puede repetirse muchas veces a lo largo del día.

**Casos de uso:**

- Mostrador:

* - CU-01 · Registrar un envío: registrar un envío con su número de guía.
* - CU-02 · Ubicar un envío: ubicar un envío por número de guía.
* - CU-03 · Rechazar registro duplicado: rechazar el registro si la guía ya fue utilizada.
* - CU-04 · Calcular costo: calcular el costo de un envío.
* - CU-05 · Contratar seguro: contratar seguro para un envío. Si no es asegurable, la operación se interrumpe mediante una excepción propia.

- Depósito:

* - CU-06 · Consultar próximo envío: consultar el próximo envío a despachar, sin retirarlo de los pendientes.
* - CU-07 · Despachar envío: despachar el próximo envío, quitándolo de los pendientes.
* - CU-08 · Consultar historial: listar el historial completo en orden de registro.

- Gerencia:

* - CU-09 · Facturación: calcular cuánto facturó la empresa por todos sus envíos.
* - CU-10 · Costo promedio: calcular cuánto cuesta en promedio un envío que tiene seguro contratado.

- Programa principal:

* - El programa principal debe demostrar los siguientes casos:

* Los tres tipos de envío.
* Una carga pesada que exceda el máximo admitido.
* Un registro rechazado por número de guía repetido.
* Un intento de asegurar documentación.

El despacho de dos envíos, verificando que salen en el orden correcto.
