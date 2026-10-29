## Ejercicios principales

### Ejercicio 1 - Adapter: termómetro importado

El sistema de monitoreo de un laboratorio muestra en un listado la temperatura de todos sus sensores. Todos los sensores propios se usan a través de la misma interfaz, que devuelve grados Celsius; un sensor propio marca hoy $25 °C.

Se compró un termómetro importado. Su librería expone un método con otro nombre que devuelve grados Fahrenheit (hoy, $98.6) y no se puede modificar. El listado tiene que incluir el termómetro nuevo sin casos especiales ni cambios en su código. Conversión: (F - 32) x 5/9.

**Para verificar:** mostrar el listado con un sensor propio y el termómetro importado.

- `Sensor local:` $25.0 °C
- `Sensor importado:` $37.0 °C

**Para pensar:**

¿por qué conviene que la pieza nueva componga al termómetro importado en lugar de heredar de él?
