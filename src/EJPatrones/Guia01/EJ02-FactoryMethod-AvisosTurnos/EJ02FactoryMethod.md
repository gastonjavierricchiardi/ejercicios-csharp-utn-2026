### Ejercicio 2 - Factory Method: avisos de turnos

Un sistema de turnos médicos avisa al paciente cuando se confirma un turno. Hoy el aviso sale solo por email, pero ya se pidió SMS y más adelante llegarán las notificaciones push.

El código que confirma turnos no debe cambiar cada vez que aparezca un canal nuevo ni saber qué clase concreta envía el aviso. Cada canal decide cómo se crea su propio aviso, y todos los avisos se envían de la misma manera.

**Para verificar:** confirmar un turno y notificarlo por todos los canales disponibles.

```text
[EMAIL] Turno confirmado
[SMS] Turno confirmado
```

> **Para pensar:** ¿qué clases tuviste que agregar y cuáles modificar para sumar el SMS? ¿Y para sumar push? Relacionarlo con OCP.
