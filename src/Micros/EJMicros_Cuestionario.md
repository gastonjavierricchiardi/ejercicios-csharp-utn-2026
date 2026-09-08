## lista genérica para encarar cualquier ejercicio de modelado POO.

Sin adaptarla a ningún caso particular:

1. **¿Qué es?** → posibles **clases / entidades**.

- - Micros
- - Personas
    - Apurados
    - Claustrofobicos
    - Fiaca
    - Moderados
    - Obsecuentes

2. **¿Qué información tiene?** → **atributos / estado**.
3. **¿Qué sabe hacer?** → **métodos / responsabilidades**.
4. **¿Qué debe tener obligatoriamente al nacer?** → **constructor**.
5. **¿Qué información puede leerse y cuál puede modificarse desde afuera?** → **encapsulamiento**.
6. **¿Qué objeto necesita conocer a qué otro objeto?** → posibles **relaciones / referencias**.
7. **¿Una clase ES UNA otra clase?** → posible **herencia**.
8. **¿Qué características o comportamientos son comunes?** → posible **clase base**.
9. **¿Qué características o comportamientos son particulares?** → posibles **subclases**.
10. **¿Hay uno o varios objetos relacionados?** → revisar **multiplicidades / colecciones**.
11. **¿Alguna relación es solamente temporal o el objeto conserva la referencia?** → distinguir **uso** de una relación permanente.
12. **¿Cada responsabilidad quedó en el objeto que realmente debería conocerla o resolverla?** → chequeo final del diseño.

La pregunta que conviene tener siempre arriba de todas es:

> **¿Quién debería ser responsable de esto?**

Eso encaja con el criterio trabajado en la cursada: el objeto administra su propio estado y el diseño parte de identificar objetos, información, comportamiento y relaciones.
