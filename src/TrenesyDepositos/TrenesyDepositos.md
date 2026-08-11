# Ejercicio - Trenes y Depósitos

Una administradora ferroviaria necesita una aplicación que le ayude a manejar las formaciones que tiene disponibles en distintos depósitos.

Una formación es lo que habitualmente llamamos "un tren", tiene una o varias locomotoras, y uno o varios vagones. Hay vagones de pasajeros y vagones de carga.

En cada depósito hay:
* Formaciones ya armadas.
* Locomotoras sueltas que pueden ser agregadas a una formación.

---

## 🚃 Vagones

### Vagón de Pasajeros
De cada vagón de pasajeros se conoce el **largo** en metros y el **ancho útil** también en metros.

La cantidad de pasajeros que puede transportar un vagón de pasajeros es:
* **Si el ancho útil es de hasta 2.5 metros:** `metros de largo * 8`
* **Si el ancho útil es de más de 2.5 metros:** `metros de largo * 10`

*Ejemplo:* Si tenemos dos vagones de pasajeros, los dos de 10 metros de largo, uno de 2 metros de ancho útil y otro de 3 metros de ancho útil, entonces el primero puede llevar 80 pasajeros y el segundo puede llevar 100.

> **Nota:** Un vagón de pasajeros no puede llevar carga.

---

### Vagón de Carga
De cada vagón de carga se conoce la **carga máxima** que puede llevar, en kilos. 

> **Nota:** Un vagón de carga no puede llevar ningún pasajero. No hay vagones mixtos.

---

### Peso Máximo de un Vagón
El peso máximo de un vagón, medido en kilos, se calcula así:
* **Vagón de pasajeros:** `cantidad de pasajeros que puede llevar * 80`
* **Vagón de carga:** `carga máxima que puede llevar + 160` *(en cada vagón de carga van dos guardas)*

---

## 🚂 Locomotoras

De cada locomotora se sabe: su **peso**, el **peso máximo que puede arrastrar** y su **velocidad máxima**.

*Ejemplo:* Puedo tener una locomotora que pesa 1000 kg, puede arrastrar hasta 12000 kg y su velocidad máxima es de 80 km/h. Obviamente se tiene que arrastrar a ella misma, entonces no le puedo cargar 12000 kg de vagones, solamente 11000 kg; diremos que este es su **"arrastre útil"**.

---

## 🏢 Operaciones e Integración

Una locomotora puede ser agregada a una formación sólo si la formación se encuentra en el depósito detenida o en depósito. Si la formación ya está en movimiento no se debe hacer nada.

Tener en cuenta que:
* El peso útil de la locomotora a agregar debe ser mayor o igual a los kilos de empuje que le faltan a la formación.
* En caso de que no existan locomotoras disponibles se debe arrojar un error.

---

## 🎯 Requerimientos

Generar el diagrama de clases y código que permita saber:

1. **Total de pasajeros:** El total de pasajeros que puede transportar una formación.
2. **Vagones livianos:** Cuántos vagones livianos tiene una formación; un vagón es liviano si su peso máximo es menor a 2500 kg.
3. **Velocidad máxima:** La velocidad máxima de una formación, que es el mínimo entre las velocidades máximas de sus locomotoras.
4. **Eficiencia de formación:** Si una formación es eficiente; es eficiente si cada una de sus locomotoras arrastra, al menos, 5 veces su peso (el de la locomotora misma).
5. **Capacidad de movimiento:** Si una formación puede moverse. Una formación puede moverse si el arrastre útil total de las locomotoras es mayor o igual al peso máximo total de los vagones.
6. **Empuje faltante:** Cuántos kilos de empuje le faltan a una formación para poder moverse, que es:
   * `0` si ya se puede mover.
   * `peso máximo total de los vagones - arrastre útil total de las locomotoras` en caso contrario.
7. **Vagón más pesado por depósito:** Dado un depósito, el conjunto formado por el vagón más pesado de cada formación; se espera un conjunto de vagones.
8. **Conductor experimentado:** Si un depósito necesita un conductor experimentado. Un depósito necesita un conductor experimentado si alguna de sus formaciones es compleja. Una formación es compleja si:
   * Tiene más de 20 unidades (sumando locomotoras y vagones), **o**
   * El peso total (sumando locomotoras y vagones) es de más de 10000 kg.
9. **Agregar locomotora:** Agregar una locomotora a una formación. Evaluar distintos escenarios.
