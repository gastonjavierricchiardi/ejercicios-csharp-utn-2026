### Ejercicio 2 - Factory Method: avisos de turnos

Un sistema de turnos médicos avisa al paciente cuando se confirma un turno. Hoy el aviso sale solo por email, pero ya se pidió SMS y más adelante llegarán las notificaciones push.

El código que confirma turnos no debe cambiar cada vez que aparezca un canal nuevo ni saber qué clase concreta envía el aviso. Cada canal decide cómo se crea su propio aviso, y todos los avisos se envían de la misma manera.

**Para verificar:** confirmar un turno y notificarlo por todos los canales disponibles.

```text
[EMAIL] Turno confirmado
[SMS] Turno confirmado
```

> **Para pensar:** ¿qué clases tuviste que agregar y cuáles modificar para sumar el SMS? ¿Y para sumar push? Relacionarlo con OCP.

---

## ¿Qué ocurre si necesitamos agregar notificaciones Push?

Actualmente tenemos dos canales funcionando:

| Canal         | Producto concreto   | Creador concreto |
| ------------- | ------------------- | ---------------- |
| Email         | `EmailNotification` | `EmailCreator`   |
| SMS           | `SmsNotification`   | `SmsCreator`     |
| Push (futuro) | `PushNotification`  | `PushCreator`    |

Para incorporar Push, siguiendo el patrón, agregaríamos dos clases:

1. `PushNotification`

Implementaría `INotification` y definiría cómo enviar una notificación Push mediante `Send(string message)`.

2. `PushCreator`

Heredaría de `NotificationCenter` y sobrescribiría `CreateNotification()` para devolver un objeto `PushNotification`.

### ¿Qué clases NO deberíamos modificar?

- `INotification`: el contrato `Send()` sigue siendo el mismo.
- `NotificationCenter`: ya define cómo crear y utilizar notificaciones mediante el Factory Method.
- `Appointment`: sigue confirmando turnos sin necesitar conocer el canal concreto.
- Las implementaciones existentes de Email y SMS.

Sí cambiaría `Program.cs` si quisiéramos agregar una llamada para probar Push, porque ahí decidimos qué creador utilizar.

Esto es importante: OCP no significa que nunca podamos modificar ningún archivo. Significa que podemos agregar una funcionalidad sin modificar el código existente que debe permanecer estable.

## Relación con SOLID: OCP

OCP — Open/Closed Principle (principio abierto/cerrado).

Una clase debe estar:

- Abierta a la extensión: podemos agregar nuevas funcionalidades.
- Cerrada a la modificación: no necesitamos alterar su implementación existente cada vez que incorporamos una variante.

En nuestro ejercicio, el nuevo canal se agrega creando clases nuevas que respetan las abstracciones existentes.

Por eso Factory Method favorece el cumplimiento de OCP.

## Para anotar sobre el código impreso

| Archivo                             | Comentario para el margen                                   |
| ----------------------------------- | ----------------------------------------------------------- |
| `INotification.cs`                  | Contrato común para todos los canales.                      |
| `NotificationCenter.cs`, línea 3    | Factory Method: cada creador decide qué producto construir. |
| `EmailCreator.cs` y `SmsCreator.cs` | Encapsulan la creación concreta.                            |
| `Appointment.cs`                    | No necesita conocer Email, SMS ni futuros canales.          |
| `Program.cs`                        | Selecciona qué creador o producto utilizar.                 |

Frase de examen:

> Factory Method permite extender el sistema incorporando nuevos productos y creadores concretos sin modificar las abstracciones ni el código cliente que trabaja con ellas, favoreciendo el principio OCP.

### Estado

VALIDADO: Email y SMS implementados y ejecutados correctamente.

VALIDADO: relación conceptual entre Factory Method y OCP explicada en clase.
