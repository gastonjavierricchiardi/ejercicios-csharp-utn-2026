# Patrones de Diseño tal como se vieron en la cursada

## Introducción a los patrones de diseño

- **Estructurales:** abordan la relación entre los objetos.

# 2. Patrones estructurales

> **[OFICIAL]**  
> Ofrecen estrategias para que los objetos puedan ser tratados uniformemente u organizarse de modo tal que resulte en una estructura práctica para la manipulación de las entidades.

## Patrones estructurales vistos

- Adapter
- Composite
- Decorator
- **Facade**

---

## 2.4 Facade

### Propósito

> **[OFICIAL]**  
> Esconder la complejidad de un sistema detrás de una clase o interfaz de alto nivel, encapsulando toda lógica.

### Propósito reformulado

Proveer una interfaz unificada y simple a un conjunto de interfaces de un subsistema.

### Aplicabilidad

1. Cuando se necesita simplificar el uso de un sistema complejo.
2. Cuando se quiere desacoplar al cliente de muchas clases internas.
3. Cuando se quiere ofrecer un punto de entrada estable.
4. Cuando hay muchas dependencias entre clientes y clases internas del subsistema.

### Ventajas

1. Reduce la complejidad percibida por el cliente.
2. Disminuye el acoplamiento entre cliente y subsistema.
3. Encapsula secuencias de llamadas complejas.
4. Hace más simple el uso de un conjunto de clases internas.

### Desventajas

1. Puede transformarse en una clase demasiado grande si se le cargan demasiadas responsabilidades.
2. Puede ocultar demasiado el subsistema.
3. Para casos avanzados, quizá igual haya que acceder a clases internas.
4. Si la fachada está mal diseñada, se vuelve otra capa de código difícil de mantener.

### Nota para parcial

Si el enunciado dice:

- “simplificar un subsistema complejo”
- “interfaz de alto nivel”
- “ocultar complejidad”
- “punto único de acceso”
- “el cliente no debe conocer muchas clases internas”

entonces puede estar apuntando a **Facade**.

### Notas al pie del patrón

- **God object:**  
  **[AMPLIACIÓN]** Es una clase que hace demasiado. Tiene muchas responsabilidades, muchos métodos y termina concentrando lógica que debería estar distribuida.  
  En _Facade_, el riesgo aparece cuando la fachada deja de simplificar y se convierte en una mega-clase.

- **Mega-API:**  
  **[AMPLIACIÓN]** Es una interfaz enorme con muchas operaciones. Puede parecer una fachada, pero si no simplifica, probablemente está mal diseñada.

### Conceptos asociados

- **Acoplamiento:** grado de dependencia entre clases o módulos.
- **Subsistema:** conjunto de clases que colaboran para resolver una parte del sistema.

---
