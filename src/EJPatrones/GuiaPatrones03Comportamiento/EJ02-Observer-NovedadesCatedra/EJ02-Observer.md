### Ejercicio 2 - Observer: novedades de la cátedra

La cátedra tiene un canal de novedades. Cada alumno puede suscribirse para recibir las novedades por email o por la app, y darse de baja cuando quiera. Cada vez que se publica una novedad, la reciben todos los suscriptos en ese momento.

El canal no debe conocer los medios de aviso concretos, porque más adelante se puede sumar WhatsApp.

**Para verificar:** suscribir a Ana (email) y a Luis (app), publicar una novedad, dar de baja a Luis y publicar otra.

```text
Ana recibió por email: Se suspenden las clases del viernes
Luis recibió en la app: Se suspenden las clases del viernes
Ana recibió por email: Ya están las notas del parcial
```

**Para pensar:**

1. ¿qué tendrías que tocar para sumar WhatsApp?

Crearía una nueva clase `WhatsAppSubscriber` que implemente `IObserver` y defina su propia versión de `Update(string news)`.

No sería necesario modificar `NewsChannel` por que el canal trabaja con la interfaz y no con los medios concretos.

Eso permite extender las formas de notificación respetando el principio **OCP** (abierto/cerrado)

2. ¿Qué pasaría si un suscriptor se diera de baja justo mientras recibe una novedad?

Nuestra implementación contempla este caso mediante esta instrucción:

> `List<IObserver> recipients = new List<IObserver>(observers);`

Al copiar la colección antes de recorrerla

- Evitamos modificar la lista que utiliza el `foreach`.
- Los suscriptores incluidos al comenzar la publicación siguen siendo destinatarios de esa novedad.
- La baja se refleja en las publicaciones siguientes.

Es la decisión de implementación que mantiene estable el conjunto de destinatarios durante cada publicación.w
