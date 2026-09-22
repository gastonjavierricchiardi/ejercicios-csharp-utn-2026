# Práctica 1er Parcial

Los empleados de una mueblería necesitan una aplicación que los asista en su operatoria diaria de venta de muebles. La mueblería vende muebles de todo tipo, sillas, mesas, placares, mesas de luz, mesas ratonas, etc. De cada mueble se conoce su nombre, su precio unitario y la cantidad que la mueblería posee, es decir su stock.

Cuando la mueblería realiza una venta, la misma puede estar compuesta por una cantidad `X` de muebles de distintos tipos. Los muebles son envíados al comprador mediante un flete perteneciente a la misma mueblería.

Se requiere que la aplicación calcule e informe el precio final de la venta sabiendo que el mismo se compone de:

- El precio unitario x la cantidad de cada mueble.
- Algunos muebles, como las mesas (de todo tipo) y los placares ocupan un volumen considerable dentro del flete, por lo que su precio varía en función del volumen
  ocupado. En el caso de las mesas, según la tabla de la misma, los casos pueden ser:
- - Mesa redonda. Volumen = Pi x r2 x h. Siendo _r_ el radio de la tabla y _h_ la altura de la mesa
- - Mesa cuadrada. Volumen = L2 x h. Siendo _l_ el lado de la tabla y _h_ la altura de la mesa
- - Mesa rectangular. Volumen = L1 x L2 x h. Siendo _l_ los lados de la tabla y _h_ la altura de la mesa

## En el caso de los placares el volumen se obtiene igual que en las mesas rectangulares.

En base al volumen:

- Si v < 1m3 al precio del producto se le adiciona un 20% de su valor unitario
- Si 1m3 <= v <= 2m3 al precio del producto se le adiciona un 50% de su valor unitario.
- Si v > 2m3 al precio del producto se le adiciona un 75% de su valor unitario.

Por último la mueblería le suma al monto total de la venta un monto fijo que depende del tiempo que le lleve cargar el flete. De esta manera si el tiempo requerido para cargar el flete es mayor a 1hs, se le suma $10000 al monto total de la venta. Si el tiempo requerido para cargar el flete es mayor a 3hs, se le suma $100000 al monto total de la venta. En otros casos se suma $0.

### Se pide:

1. Diagrama de clases completo de la solución
2. Codificar los métodos necesarios para obtener el precio total de una venta.
3. Desarrolle un breve código de ejemplo, mostrando el uso de la aplicación.

### Consideraciones:

- El punto de entrada para el punto 2, debe ser el método realizarVenta(muebles) →
  number
- En caso de no contar con la cantidad de muebles requerida se deberá arrojar un
  error que indique lo sucedido
- Asuma que existe la clase Cronometro con 2 métodos estáticos:
- - iniciar(): void
- - detener(): number. Devuelve la cantidad de minutos transcurridos desde que
    se inició.
