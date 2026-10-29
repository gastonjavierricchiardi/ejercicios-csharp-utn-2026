### Ejercicio 4 - Facade: home theater

Un home theater tiene proyector, equipo de sonido y luces, y cada aparato tiene sus propias operaciones: encender, elegir entrada, ajustar el volumen, atenuar. Para ver una película siempre hay que hacer la misma secuencia: luces al 10%, proyector encendido en HDMI y sonido encendido con volumen 15. Al terminar, hay que deshacerla.

La familia que lo usa no quiere conocer los aparatos: solo quiere "ver película" y "terminar película". Los aparatos tienen que seguir pudiendo usarse por separado.

**Para verificar:** iniciar una película desde el código cliente con una sola llamada.

```text
Luces al 10%
Proyector encendido en HDMI
Sonido encendido, volumen 15
-- Disfrutá la película ---
```

> **Para pensar:** ¿qué pasa con tu solución si mañana se agrega un aparato nuevo, por ejemplo una consola? ¿Cuándo empieza a tener demasiadas responsabilidades?
