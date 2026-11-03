### Ejercicio 1 - Singleton: configuración compartida

Una aplicación de consola tiene tres módulos (facturación, reportes y una pantalla de opciones) que leen la configuración general: nombre de la aplicación e idioma. Hoy cada módulo crea su propio objeto de configuración, y cuando el usuario cambia el idioma desde la pantalla de opciones, los reportes siguen saliendo en español.

Se necesita que todos los módulos usen siempre la misma configuración y que ningún módulo pueda crear una propia por error. El idioma por defecto es `"es"`.

**Para verificar:** desde un módulo cambiar el idioma a `"en"`, leerlo desde otro y comprobar que ambos trabajan con el mismo objeto.

```text
Idioma leído desde config2: en
¿Misma instancia? True
```

> **Para pensar:** ¿qué mecanismo del lenguaje impide que un módulo cree su propia configuración? ¿Por qué el material advierte que el Singleton puede vulnerar SRP y DIP?
