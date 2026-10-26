## 1) Método base: no busques “palabras mágicas”, buscá **problemas de diseño**

Cuando leés un enunciado, marcá 3 cosas:

| Qué busco                   | Pregunta mental                                                      | Ejemplo                                       |
| --------------------------- | -------------------------------------------------------------------- | --------------------------------------------- |
| **Estructura**              | ¿Hay objetos simples y objetos compuestos/anidados?                  | Menú con submenús, itinerario con itinerarios |
| **Comportamiento variable** | ¿Hay varias formas de hacer el mismo cálculo/proceso?                | calcular costo según paquete/tarifa           |
| **Creación variable**       | ¿El problema está en crear objetos sin acoplarse a clases concretas? | crear documentos, productos, familias         |

Composite aparece cuando hay jerarquías **todo-parte** y el cliente debe tratar objetos individuales y compuestos uniformemente.
Strategy aparece cuando hay algoritmos/comportamientos intercambiables.

---

## 2) Guía rápida por patrón visto en cursada

| Señal del enunciado                                                                       | Pensá en                    | Pregunta clave                                                     |
| ----------------------------------------------------------------------------------------- | --------------------------- | ------------------------------------------------------------------ |
| “contiene”, “anidado”, “parte-todo”, “hojas y ramas”, “individuales y compuestos”         | **Composite**               | ¿Un objeto puede contener otros del mismo tipo general?            |
| “agregar responsabilidades”, “decorar”, “envolver”, “sumar funcionalidades dinámicamente” | **Decorator**               | ¿Quiero sumar comportamiento sin modificar la clase base?          |
| “adaptar interfaz existente”, “sistema legado”, “cliente espera otra interfaz”            | **Adapter**                 | ¿Tengo algo que funciona pero no encaja con la interfaz requerida? |
| “simplificar subsistema complejo”, “ocultar complejidad”                                  | **Facade**                  | ¿Necesito una puerta simple hacia muchas clases internas?          |
| “varios algoritmos”, “distintas formas de calcular”, “cambiar en runtime”                 | **Strategy**                | ¿La acción es la misma pero cambia la forma de resolverla?         |
| “varios objetos reciben aviso”, “notificar cambios”, “suscriptores”                       | **Observer**                | ¿Un objeto avisa a muchos?                                         |
| “cadena”, “pasamanos”, “varios intentan manejar una solicitud”                            | **Chain of Responsibility** | ¿La solicitud pasa por responsables hasta que alguien la atiende?  |
| “mismos pasos, algunos pasos varían”, “esqueleto fijo del algoritmo”                      | **Template Method**         | ¿La estructura general no cambia, pero subclases completan pasos?  |
| “crear objetos sin saber clase concreta exacta”                                           | **Factory Method**          | ¿Una fábrica crea un producto y las subclases deciden cuál?        |
| “familias de objetos relacionados”                                                        | **Abstract Factory**        | ¿Necesito crear varios productos compatibles entre sí?             |
| “construcción paso a paso”, “muchos parámetros”, “objeto complejo”                        | **Builder**                 | ¿El problema principal es armar un objeto complejo?                |
| “única instancia global”                                                                  | **Singleton**               | ¿Debe existir una sola instancia controlada?                       |

Factory Method y Abstract Factory están diferenciados en el material: uno crea un elemento por fábrica; el otro crea familias relacionadas.
Observer y Chain también aparecen como patrones distintos: uno notifica cambios a observadores; el otro pasa una solicitud por una cadena.

---

## 3) Aplicado a TravelNow

En TravelNow:

| Frase del enunciado                                                                    | Detección                       |
| -------------------------------------------------------------------------------------- | ------------------------------- |
| “Itinerarios que contengan excursiones, estadías o incluso otros itinerarios anidados” | **Composite**                   |
| “calcular la duración total de cualquier itinerario”                                   | Operación común del `Component` |
| “El costo final varía según el tipo de paquete”                                        | **Strategy**                    |
| “agregar nuevos tipos en el futuro sin modificar la lógica principal”                  | **OCP + Strategy**              |

Entonces, para este práctico, tu razonamiento debería ser:

**Composite** para modelar `Excursion`, `Estadia` e `Itinerario`.
**Strategy** para modelar `PaqueteEconomico`, `PaquetePremium` y futuros paquetes.
