https://dancing-cactus-4a8714.netlify.app

Ejercicio - Tienda Online
Un comercio que se dedica a la venta de artículos electrónicos, desea desarrollar una tienda online para
venta de sus artículos. Del primer análisis surge que sólo se pondrán a la venta 3 productos:
Webcam
Headset
Kit Teclado/Mouse
A su vez, el gerente de logística nos indica que existen 3 versiones distintas de cada producto, cada una
con su valor y características particulares. Las versiones disponibles para cada producto son: Platinum,
Gold y Starter.
Por otra parte, el gerente de ventas nos comunica que con el objetivo de incrementar el volumen de las
ventas iniciales, se decidió vender combos de productos según la versión de cada uno. Por ejemplo, el
combo Starter sólo tendrá productos Webcam + Headsets + Kit Teclado/Mouse de tipo Starter.
El gerente de ventas nos aclara que en otras ocasiones intentaron realizar este tipo de ventas, y tuvieron
varios inconvenientes debido a fallas en el armado de los combos. Los clientes se incomodan bastante
cuando reciben productos que no combinan (por ejemplo: solicitar un Combo Platinum y recibir allí un
headset de nivel Starter) y los devuelven.
Por último, el gerente de ventas nos dice que si la tienda de ventas tiene éxito, en un corto plazo agregarán
nuevos combos y nuevos productos a los combos y también necesitarán cambiar los productos que se
incluyen en cada combo.
Se pide:

1. Presentar un diagrama de clases que permita abordar una solución al problema planteado.
2. Codificar dicha solución.
   Consideraciones:
   La solución debe garantizar un 100% de efectividad en el armado de los combos.
   La solución debe ser lo suficientemente flexible de forma tal que no sea necesario cambiar el código
   al sumar nuevos productos y/o combos.

---

Yo lo explicaría así, utilizando la terminología de la cátedra:

> Identificamos que el problema principal es la creación de familias de productos compatibles entre sí, por lo que pensamos en utilizar el patrón Abstract Factory.
>
> Sin embargo, si definimos un método de fabricación por cada tipo de producto, al incorporar uno nuevo tendríamos que modificar la interfaz y sus implementaciones, afectando el principio Open/Closed.
>
> Por eso proponemos adaptar el patrón utilizando colecciones y configuraciones. Delegamos la creación de los productos a la fábrica y dejamos que el propio combo garantice su consistencia mediante el encapsulamiento y la validación de sus componentes.

**La clave de nuestra propuesta:** no depender de clases concretas para cada versión, sino de objetos configurables que permitan extender la solución sin modificar la lógica existente.

La configuración externa todavía está pendiente de definir.

---
