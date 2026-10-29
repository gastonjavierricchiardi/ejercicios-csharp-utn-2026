## Ejercicios complementarios

### Ejercicio 3 - Composite: menú de una aplicación

Una aplicación de escritorio tiene un menú con opciones simples y submenús. Un submenú puede contener opciones y otros submenús, sin límite de profundidad.

Hay que mostrar el menú completo, con una sangría de dos espacios por nivel. El código que muestra el menú no debe preguntar si cada elemento es una opción o un submenú: alcanza con pedirle a la raíz que se muestre.

**Para verificar:** armar este menú y mostrarlo desde la raíz.

```text
Archivo
  Nuevo
  Abrir
  Recientes
    informe.txt
    notas.txt
  Salir
```

> **Para pensar:** si las opciones simples tuvieran que ofrecer "agregar hijo", ¿qué deberían hacer? Relacionarlo con ISP, como señala el material.
