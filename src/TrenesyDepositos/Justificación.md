# Justificación de la solución

Para resolver el ejercicio separé el problema en las clases `Vagon`, `Locomotora`, `Formacion` y `Deposito`.

En el caso de los vagones, usé una clase abstracta `Vagon` porque tanto los vagones de carga como los de pasajeros comparten algunos comportamientos, pero los resuelven de forma distinta. Por ejemplo, ambos pueden informar su peso máximo y su cantidad de pasajeros, pero cada tipo hace ese cálculo de acuerdo con sus propios datos.

`VagonCarga` y `VagonPasajeros` heredan de `Vagon` y sobreescriben esos métodos. De esta manera, `Formacion` puede trabajar directamente con una lista de `Vagon` sin tener que preguntar en cada momento qué tipo concreto de vagón está recorriendo.

También dejé en `Vagon` el método `EsLiviano()`, porque el propio vagón conoce su peso máximo y puede determinar si cumple o no con esa condición. Así, `Formacion` solamente se encarga de recorrer sus vagones y contar aquellos que sean livianos.

La clase `Formacion` concentra los cálculos que dependen del conjunto de locomotoras y vagones, como la cantidad total de pasajeros, la velocidad máxima, la eficiencia, el empuje faltante o si la formación es compleja. También administra su propia lista de locomotoras, por lo que el depósito no modifica esa colección directamente.

`Deposito` se encarga de trabajar con las formaciones que contiene y con las locomotoras sueltas disponibles. Para agregar una locomotora a una formación primero verifica que esa formación pertenezca al depósito y que no esté en movimiento. Después busca una locomotora cuyo arrastre útil alcance para cubrir el empuje faltante. Si la encuentra, la agrega a la formación y la elimina de la lista de locomotoras sueltas.

Finalmente, en `Program.cs` fui probando cada comportamiento con distintos casos: formaciones que pueden y no pueden moverse, locomotoras eficientes y no eficientes, falta de empuje, locomotoras insuficientes, ausencia de locomotoras disponibles y formaciones en movimiento. Esto me permitió verificar cada parte antes de continuar con la siguiente.
