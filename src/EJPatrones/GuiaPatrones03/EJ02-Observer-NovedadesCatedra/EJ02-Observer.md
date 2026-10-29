### Ejercicio 2 - Observer: novedades de la cátedra

La cátedra tiene un canal de novedades. Cada alumno puede suscribirse para recibir las novedades por email o por la app, y darse de baja cuando quiera. Cada vez que se publica una novedad, la reciben todos los suscriptos en ese momento.

El canal no debe conocer los medios de aviso concretos, porque más adelante se puede sumar WhatsApp.

**Para verificar:** suscribir a Ana (email) y a Luis (app), publicar una novedad, dar de baja a Luis y publicar otra.

```text
Ana recibió por email: Se suspenden las clases del viernes
Luis recibió en la app: Se suspenden las clases del viernes
Ana recibió por email: Ya están las notas del parcial
```

> **Para pensar:** ¿qué tendrías que tocar para sumar WhatsApp? ¿Qué pasaría si un suscriptor se diera de baja justo mientras recibe una novedad?
