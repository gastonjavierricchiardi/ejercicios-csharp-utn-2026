# Ejercicio Reservas

Se desea implementar un sistema para administrar las reservas de habitaciones del hotel Grand Splendid.

El hotel cuenta con habitaciones de distinta categoría, a saber:

- Simple: $100 por día.
- Doble: $250 por día.
- Suite: $500 por día.

De cada habitación se conoce la cantidad máxima de personas que pueden ocuparla, su precio y los regímenes alimenticios disponibles según la habitación. Al día de hoy, el hotel sólo maneja los regímenes:

- SA: sólo alojamiento. No incrementa el valor de la habitación.
- MP: media pensión. Es un 25% al valor de la habitación.
- PC: pensión completa. Es un 75% al valor de la habitación.

Es importante tener en cuenta que el hotel planea agregar nuevos regímenes en un futuro.

Para calcular el precio de una habitación, el hotel diferencia entre temporada alta y temporada baja.

| Temporada Alta | Temporada Baja |
| --- | --- |
| `(precio de la habitación + régimen)* días * 1.20` | `(precio de la habitación + régimen / 2)* días * 1.10` |

La aplicación deberá permitir crear, eliminar y listar reservas.

Una reserva posee fecha de ingreso, fecha de egreso, cliente, habitaciones reservadas y precio.

Al momento de generar una reserva, el sistema deberá verificar que todas las habitaciones seleccionadas estén disponibles.

Una habitación sólo puede estar disponible o reservada.

Si se intenta reservar una habitación y la misma se encuentra reservada, la operación deberá arrojar una excepción informando del error.

El precio de la reserva se obtiene sumando el precio de todas las habitaciones que posee la reserva.

Se asume que un usuario selecciona, de un listado, las habitaciones que quiere reservar y luego intenta realizar la reserva.

**Se pide:**

1. Elabore un diagrama de clases adecuado para la resolución de este problema.
2. Implemente los métodos necesarios para realizar una reserva.
3. Implemente un mecanismo que permita a un usuario del sistema cambiar de forma automática de temporada.
4. En caso de haber implementado algún patrón de diseño Indique cuál, y qué requerimiento intenta resolver con el mismo.
