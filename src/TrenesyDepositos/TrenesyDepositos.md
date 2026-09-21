# Original

## Ejercicio – trenes y depósitos

Una administradora ferroviaria necesita una aplicación que le ayude a manejar las formaciones que tiene disponibles en distintos depósitos.

Una formación es lo que habitualmente llamamos “un tren”, tiene una o varias locomotoras, y uno o varios vagones. Hay vagones de pasajeros y vagones de carga.

**En cada depósito hay:** formaciones ya armadas, y locomotoras sueltas que pueden ser agregadas a una formación.

De cada vagón de pasajeros se conoce el largo en metros, y el ancho útil también en metros.
La cantidad de pasajeros que puede transportar un vagón de pasajeros es:

- Si el ancho útil es de hasta 2.5 metros: metros de largo multiplicados por 8.
- Si el ancho útil es de más de 2.5 metros: metros de largo multiplicados por 10.

Por ejemplo, si tenemos dos vagones de pasajeros, los dos de 10 metros de largo, uno de 2 metros de ancho útil, y otro de 3 metros de ancho útil, entonces el primero puede llevar 80 pasajeros, y el segundo puede llevar 100.

Un vagón de pasajeros no puede llevar carga.

De cada vagón de carga se conoce la carga máxima que puede llevar, en kilos. Un vagón de carga no puede llevar ningún pasajero.

No hay vagones mixtos.

El peso máximo de un vagón, medido en kilos, se calcula así:

Para un vagón de pasajeros: cantidad de pasajeros que puede llevar multiplicado por 80.
Para un vagón de carga: la carga máxima que puede llevar + 160 (en cada vagón de carga van dos guardas).

De cada locomotora se sabe: su peso, el peso máximo que puede arrastrar, y su velocidad máxima. Por ejemplo, puedo tener una locomotora que pesa 1000 kg, puede arrastrar hasta 12000 kg, y su velocidad máxima es de 80 km/h. Obviamente se tiene que arrastrar a ella misma, entonces no le puedo cargar 12000 kg de vagones, solamente 11000; diremos que este es su “arrastre útil”.

Una locomotora puede ser agregada a una formación sólo si la formación se encuentra en el depósito detenida o en depósito. Si la formación ya está en movimiento no se debe hacer nada.

Tener en cuenta que:
El peso útil de la locomotora a agregar debe ser mayor o igual a los kilos de empuje que le faltan a la formación.
En caso de que no existan locomotoras disponibles se debe arrojar un error.

## Generar el diagrama de clases y código que permita saber:

1. El total de pasajeros que puede transportar una formación
2. Cuántos vagones livianos tiene una formación; un vagón es liviano si su peso máximo es menor a 2500 kg
3. La velocidad máxima de una formación, que es el mínimo entre las velocidades máximas de las locomotoras.
4. Si una formación es eficiente; es eficiente si cada una de sus locomotoras arrastra, al menos, 5 veces su peso (el de la locomotora misma).
5. Si una formación puede moverse. Una formación puede moverse si el arrastre útil total de las locomotoras es mayor o igual al peso máximo total de los vagones.
6. Cuántos kilos de empuje le faltan a una formación para poder moverse, que es: 0 si ya se puede mover, y (peso máximo total de los vagones – arrastre útil total de las locomotoras) en caso contrario.
7. Dado un depósito, el conjunto formado por el vagón más pesado de cada formación; se espera un conjunto de vagones.
8. Si un depósito necesita un conductor experimentado. Un depósito necesita un conductor experimentado si alguna de sus formaciones es compleja. Una formación es compleja si: tiene más de 20 unidades (sumando locomotoras y vagones), o el peso total (sumando locomotoras y vagones) es de más de 10000 kg.
9. Agregar una locomotora a una formación. Evaluar distintos escenarios.

---

# Trenes y Depósitos

Este ejercicio modela el funcionamiento básico de una empresa ferroviaria que administra formaciones dentro de distintos depósitos.

Una **formación** está compuesta por una o más locomotoras y uno o más vagones. A su vez, los vagones pueden ser de pasajeros o de carga, y cada tipo posee reglas propias para calcular su capacidad y su peso máximo.

El objetivo principal del ejercicio es distribuir correctamente las responsabilidades entre las distintas clases y utilizar herencia, clases abstractas, polimorfismo, colecciones y excepciones.

## Modelo principal

El sistema se divide en las siguientes entidades:

- `Vagon`
- `VagonCarga`
- `VagonPasajeros`
- `Locomotora`
- `Formacion`
- `Deposito`

### Vagon

`Vagon` es una clase abstracta que representa las características comunes de todos los vagones.

Define los comportamientos:

- `PesoMaximo()`
- `CantidadPasajeros()`
- `EsLiviano()`

Los métodos `PesoMaximo()` y `CantidadPasajeros()` son abstractos porque su implementación depende del tipo concreto de vagón.

El método `EsLiviano()` pertenece a `Vagon`, ya que cada vagón conoce su propio peso máximo y puede determinar si pesa menos de `2500 kg`.

## Tipos de vagones

### VagonPasajeros

Un vagón de pasajeros conoce:

- su largo;
- su ancho útil.

La cantidad de pasajeros depende de su ancho:

- si el ancho útil es menor o igual a `2.5 m`, puede transportar `largo × 8` pasajeros;
- si el ancho útil es mayor a `2.5 m`, puede transportar `largo × 10` pasajeros.

Su peso máximo se calcula considerando `80 kg` por pasajero.

### VagonCarga

Un vagón de carga conoce su carga máxima.

Su peso máximo se obtiene sumando:

```text
carga máxima + 160 kg
```

Los `160 kg` adicionales representan el peso de dos guardas.

Como no transporta pasajeros, `CantidadPasajeros()` devuelve `0`.

## Locomotora

Una locomotora conoce:

- su peso;
- el peso máximo que puede arrastrar;
- su velocidad máxima.

El arrastre útil se calcula descontando su propio peso:

```text
arrastre útil = peso máximo de arrastre - peso propio
```

También puede determinar si es eficiente.

Una locomotora se considera eficiente cuando su arrastre útil es al menos cinco veces su propio peso.

## Formacion

`Formacion` administra sus locomotoras y vagones.

Entre sus responsabilidades se encuentran:

- calcular la cantidad total de pasajeros;
- contar los vagones livianos;
- determinar la velocidad máxima de la formación;
- determinar si todas sus locomotoras son eficientes;
- saber si posee suficiente capacidad de arrastre para moverse;
- calcular los kilos de empuje faltantes;
- determinar si la formación es compleja;
- obtener su vagón más pesado;
- incorporar una locomotora;
- administrar su estado de movimiento.

La velocidad máxima de una formación queda determinada por la locomotora más lenta.

Una formación puede moverse cuando la suma del arrastre útil de sus locomotoras es suficiente para soportar el peso máximo total de sus vagones.

Si no puede moverse, `KilosEmpujeFaltantes()` informa cuánto arrastre adicional necesita.

Una formación es considerada compleja cuando:

- posee más de `20` unidades entre locomotoras y vagones; o
- su peso total supera los `10000 kg`.

## Deposito

`Deposito` administra:

- las formaciones que se encuentran en él;
- las locomotoras sueltas disponibles.

Entre sus responsabilidades se encuentran:

- obtener el vagón más pesado de cada formación;
- determinar si alguna formación necesita un conductor experimentado;
- agregar una locomotora disponible a una formación.

Para agregar una locomotora se verifican distintas condiciones:

1. La formación debe pertenecer al depósito.
2. La formación no debe estar en movimiento.
3. Debe existir una locomotora suelta cuyo arrastre útil sea suficiente para cubrir el empuje faltante.
4. Si se encuentra una locomotora adecuada:
   - se agrega a la formación;
   - se elimina de la lista de locomotoras sueltas.

5. Si no existe una locomotora disponible que pueda cumplir la necesidad de arrastre, se genera una excepción.

## Conceptos aplicados

En la resolución del ejercicio se utilizan principalmente:

- Programación Orientada a Objetos;
- encapsulamiento;
- herencia;
- clases abstractas;
- polimorfismo;
- sobreescritura de métodos;
- colecciones genéricas con `List<T>`;
- recorrido de colecciones mediante `foreach`;
- delegación de responsabilidades;
- propiedades de solo lectura;
- manejo de excepciones con `try`, `catch` y `throw`.

## Pruebas realizadas

En `Program.cs` se probaron distintos escenarios, entre ellos:

- cálculo de pasajeros;
- cálculo del peso máximo de cada tipo de vagón;
- identificación de vagones livianos;
- velocidad máxima de una formación;
- locomotoras eficientes y no eficientes;
- formaciones que pueden y no pueden moverse;
- cálculo del empuje faltante;
- formaciones complejas;
- búsqueda del vagón más pesado;
- incorporación de locomotoras desde un depósito;
- eliminación de la locomotora utilizada de la lista de locomotoras sueltas;
- intento de agregar locomotoras insuficientes;
- falta de locomotoras disponibles;
- intento de agregar locomotoras a una formación en movimiento;
- intento de modificar una formación que no pertenece al depósito.

De esta manera, el ejercicio permite integrar distintos conceptos de Programación Orientada a Objetos dentro de un mismo modelo y comprobar el comportamiento de cada responsabilidad mediante casos concretos.
