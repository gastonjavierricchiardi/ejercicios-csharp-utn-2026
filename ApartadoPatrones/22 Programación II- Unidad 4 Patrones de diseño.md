ARCHIVO: 22 Programación II- Unidad 4 Patrones de diseño.pdf
Materia/Unidad: Programación II — Unidad 4: Patrones de diseño
Fecha/Versión: No indicada en el documento
Paginación: páginas reales impresas 72–84 (páginas 2–14 del PDF). Portada (página 1) y bibliografía (página 15) sin número impreso.
Criterio: ESTRICTO PDF ON. Exclusivamente el archivo indicado; sin completar con teoría externa.

# Programación II
## Unidad 4: Patrones de diseño.
**Portada — página 1 del PDF; sin número impreso.**

> “Los patrones de diseño identifican los problemas de diseño recurrentes y sus soluciones.” — Erich Gamma.

# Introducción a los patrones de diseño
**Página real: 72 (página 2 del PDF).**

- En la historia de la programación se han resuelto problemas, muchos de ellos recurrentes.
- El grupo **Gang of Four** estudió estos problemas y las soluciones propuestas por los desarrolladores, procurando identificar patrones beneficiosos en **mantenibilidad, lectura y escalabilidad**.
- En **1994** se publicó *Design Patterns: Elements of Reusable Object-Oriented Software*, compendio de prácticas de diseño.
- **Tres categorías de patrones:**
  - **Creacionales:** estrategias para crear objetos.
  - **Comportamiento:** comunicación entre objetos.
  - **Estructurales:** relaciones entre objetos.
- Los patrones suelen surgir naturalmente cuando se siguen buenas prácticas de **programación orientada a objetos**.
- Al estar documentados, permiten compartir terminología técnica y mejorar la comunicación dentro de un mismo dominio.
- **Advertencia del material:** su existencia no obliga a utilizarlos. Sin bases de POO, su uso puede no ser apropiado; además, el documento señala que algunos patrones históricos podrían no ser la solución más eficiente en lenguajes modernos.
- El libro trata errores comunes de POO, la importancia de **programar pensando en interfaces y no en implementación**, y de preferir **composición sobre herencia**.
- Referencia incluida en el documento: https://en.wikipedia.org/wiki/Design_Patterns

# Patrones creacionales
**Páginas reales: 73–78 (páginas 3–8 del PDF).**

**Definición:** Encapsulan el proceso de construcción de objetos para acotar los cambios cuando se modifica la estructura de una entidad, sus requisitos o sus componentes.

## Singleton
**Páginas reales: 73–74.**

- Controla la creación para garantizar **una sola instancia** de un objeto.
- Frente a una clase con funciones estáticas, el texto destaca que la instancia puede extenderse y sus métodos sobreescribirse.
- **Ejemplo de uso:** mantener en memoria una configuración del sistema, disponible para el resto del software.
- La clase debe contar con:
  - **Constructor privado**, que impida crear instancias externas mediante `new`.
  - Una **función estática** que cree la instancia y la almacene en un atributo de la propia clase.
  - Las funciones correspondientes al servicio ofrecido.

IMG: Diagrama Singleton con una única referencia a su instancia y un punto de acceso a ella (p. 73).

### Resumen — Singleton (tabla de las páginas 73–74)

**Propósito:** Asegura que una clase tenga una única instancia y proporciona un acceso global a ella.

**Aplicabilidad:**
- Controlar el acceso a recursos compartidos.
- Acceder y controlar el acceso a variables globales.

**Ventajas:**
1. Garantiza que exista una única instancia de la clase.
2. Proporciona un único punto de acceso a la instancia.
3. Se inicializa cuando se la necesita por primera vez.

**Desventajas:**
1. Vulnera el **Principio de responsabilidad única**.
2. Puede esconder un mal diseño y vulnerar el **Principio de Inversión de Dependencia**.
3. En sistemas con varios hilos requiere tratamiento especial para evitar la creación simultánea de más de una instancia.

## Factory method
**Páginas reales: 74–75.**

- Es semejante a Factory, pero la utilización de **interfaces** hace que la creación de objetos pueda tratarse genéricamente y automatizarse.
- Los productos cumplen una **interfaz** o clase abstracta.
- Las fábricas heredan de una clase abstracta encargada de producir objetos de la interfaz del producto.
- Cada subclase de fábrica decide **qué objeto concreto construir**.
- `Creator` es una clase abstracta con un método abstracto cuya implementación en `ConcreteCreator` devuelve un `ConcreteProduct` que respeta `Product`.

IMG: UML de Factory Method con `Creator`, `ConcreteCreator`, `Product` y `ConcreteProduct` (p. 74).

### Resumen — Factory method (tabla de las páginas 74–75)

**Propósito:** Proporcionar una interfaz de creación en la superclase, dejando que sus subclases determinen los tipos concretos que se crean.

**Aplicabilidad:** Cuando se desconocen de antemano las dependencias y los tipos exactos de objetos con que trabajará el código.

**Ventajas:**
1. Evita acoplamiento fuerte entre el creador y los productos concretos.
2. **Responsabilidad única:** el código que crea el producto puede ubicarse en un lugar específico para facilitar el mantenimiento.
3. **Abierto/cerrado:** permite introducir nuevos tipos de productos sin alterar el código cliente existente.

**Desventajas:**
1. Puede requerir muchas subclases.

## Abstract factory
**Páginas reales: 75–76.**

- Frente a Factory Method, que ofrece un producto por fábrica, **Abstract factory crea conjuntos de productos de una familia**.
- **Ejemplo del PDF:** una preparación de cóctel formada por una bebida base y un agregado; se mencionan Gin & Tonic y Campari con jugo de naranja.
- `AbstractFactory` define la interfaz o clase abstracta que implementan `ConcretFactory1` y `ConcretFactory2` (nombres impresos en el documento).
- Las fábricas crean componentes que cumplen las interfaces `AbstractProductA` y `AbstractProductB`.
- `ConcretFactory1` produce `ProductA1` y `ProductB1`; `ConcretFactory2` produce `ProductA2` y `ProductB2`.
- En la analogía: `AbstractProductA` representa las bebidas alcohólicas; `AbstractProductB`, los agregados.

IMG: UML de dos fábricas concretas que producen dos familias correspondientes de productos A y B (p. 75).

### Resumen — Abstract factory (tabla de la página 76)

**Propósito:** Crear familias de objetos relacionados sin precisar las clases concretas.

**Aplicabilidad:** Cuando el código opera con familias de productos relacionados y se busca no depender de sus clases concretas, ya sea por desconocimiento previo o por extensibilidad futura.

**Ventajas:**
1. Los productos de una misma fábrica son compatibles entre sí.
2. Evita acoplamiento fuerte entre los productos concretos y el cliente.
3. **Responsabilidad única:** agrupa el código de creación para facilitar el mantenimiento.
4. **Abierto/cerrado:** permite nuevos tipos de productos sin romper código cliente existente.

**Desventajas:**
1. Puede requerir muchas clases, subclases e interfaces.

## Builder
**Páginas reales: 76–78.**

- Permite **construir objetos complejos paso a paso**.
- Con el mismo código de construcción se pueden producir distintos tipos o representaciones de un objeto.
- Es útil cuando crear un objeto implica numerosos parámetros y/o pasos.
- Se separa la construcción del objeto de su propia clase, delegándola a un **constructor o builder**.
- Como algunos pasos pueden ser opcionales, ejecutar distintas combinaciones produce configuraciones diferentes.
- **Participantes del diagrama (p. 77):**
  - `Builder`: interfaz que declara los pasos de construcción.
  - Constructores concretos: implementan esos pasos de diversas maneras.
  - `Product`: objeto resultante.
  - `Director`: decide el **orden** de ejecución de los pasos y puede reutilizar configuraciones específicas.
  - `Client`: asocia uno de los constructores con `Director`.

IMG: UML de `Client`, `Builder`, constructores concretos, `Director` y productos resultantes (p. 77).

### Resumen — Builder (tabla de las páginas 77–78)

**Propósito:** Construir objetos complejos por pasos y permitir distintas representaciones usando el mismo código de construcción.

**Aplicabilidad:**
- Evitar constructores complejos con muchos parámetros.
- Crear diferentes representaciones de determinados objetos.

**Ventajas:**
1. Construcción paso a paso.
2. Reutilización del código de construcción para distintas representaciones.
3. **Responsabilidad única:** separación entre construcción compleja y lógica de negocio del producto.

**Desventajas:**
1. La complejidad general del código aumenta porque se incorporan varias clases nuevas.

# Patrones estructurales
**Páginas reales: 78–81 (páginas 8–11 del PDF).**

**Definición:** Proponen maneras de tratar objetos uniformemente o de organizarlos en estructuras prácticas para su manipulación.

## Adapter
**Página real: 78.**

- Encapsula objetos que exponen operaciones distintas, a menudo imposibles de modificar, para utilizarlos mediante **una interfaz común**.
- **Ejemplo:** subsistemas o bibliotecas que hacen tareas similares, como controladores de impresoras.
- La interfaz `Adapter` (o una clase abstracta) declara `operation()`.
- `ConcreteAdapter` implementa `operation()` y mantiene una referencia al objeto `Adaptee`, que expone `adapedOperation()`.
- La operación adaptadora llama a la operación existente en el objeto adaptado.

IMG: UML de `Adapter`, `ConcreteAdapter` y `Adaptee`, además del cliente (p. 78). Se conserva la grafía `adapedOperation()` utilizada por el PDF.

## Composite
**Página real: 79.**

- Permite estructuras **arborescentes o rizomáticas**, como menús con opciones y submenús.
- Según el documento, es especialmente útil cuando el comportamiento de **ramas** y **hojas** es distinto; si no lo fuera, podría bastar una clase con una lista de elementos de su mismo tipo.
- La interfaz `Component` (o clase abstracta) incluye `add()`, `remove()`, `getChild()` para la estructura y `operation()` para el comportamiento del componente.
- `Leaf` (hoja) es el elemento terminal; desarrolla `operation()`.
- `Composite` (rama) implementa su operación y mantiene una colección de `Component`, que puede contener tanto ramas como hojas.
- Las operaciones de la estructura permiten gestionar sus componentes internos.
- **Problema señalado en el PDF:** puede contradecir el **Principio de segregación de interfaces**, porque las hojas quedan obligadas a contemplar métodos de gestión de hijos que no necesitan o no pueden realizar.

IMG: UML con `Component`, `Leaf`, `Composite` y colección `children` (p. 79).

## Decorator
**Páginas reales: 79–80.**

- Se usa para **agregar funcionalidad** a un objeto, evitando modificar estructuras complejas o que no pueden cambiarse.
- `ConcreteComponent` es el objeto ya existente que realiza la operación; idealmente implementa `Component`.
- `Decorator` es una clase abstracta que implementa o hereda `Component` y guarda un atributo del mismo tipo, formando una composición.
- `ConcreteDecorator` hereda de `Decorator`, agrega características y contiene el componente original.
- El cliente invoca al decorador, que **delega** la operación en `ConcreteComponent` y ejecuta las tareas añadidas en algún momento de la cadena.

IMG: UML de `Component`, `ConcreteComponent`, `Decorator` y `ConcreteDecorator`; la figura representa la extensión de operaciones mediante composición (p. 80).

## Facade
**Páginas reales: 80–81.**

- Oculta la complejidad de un sistema mediante **una clase o interfaz de alto nivel**.
- Expone al consumidor un conjunto limitado de funciones.
- La implementación de la fachada coordina los componentes internos que busca enmascarar.

IMG: Diagrama con `Facade` como punto de acceso entre el cliente y los elementos de un sistema complejo (p. 81).

# Patrones de comportamiento
**Páginas reales: 81–84 (páginas 11–14 del PDF).**

**Definición:** Proponen mecanismos de **comunicación entre objetos** para distribuir responsabilidades de forma práctica y favorecer el mantenimiento.

## Strategy
**Página real: 81.**

- Patrón representativo del **polimorfismo**.
- Utiliza **composición** para que los objetos varíen su comportamiento según criterios definidos por el programador.
- `Context` contiene un atributo tipado como la interfaz o clase abstracta `Strategy`.
- `Strategy` declara `execute()`; las clases `ConcreteStrategyA` y `ConcreteStrategyB` implementan esa operación.
- Permite que objetos similares respondan de modo distinto e incluso **cambiar el comportamiento durante la ejecución**.

IMG: UML de `Context`, `Strategy`, `ConcreteStrategyA` y `ConcreteStrategyB` (p. 81).

## Observer
**Páginas reales: 81–82.**

- Permite que varios objetos **respondan a un cambio de estado o evento** en otro objeto al que observan.
- El observado funciona como **avisador**, notificando a los interesados para que ellos realicen las acciones correspondientes.
- `ConcreteSubject`: sujeto concreto observado, cuyo estado o acción interesa a los observadores.
- `Subject`: interfaz que define:
  - `attach()` para suscribir observadores.
  - `detach()` para desuscribirlos.
  - `notify()` para comunicar cambios o eventos.
- `Observer`: interfaz que exige `update()`.
- `ConcretObserver` / observador concreto: implementa `update()` (se conserva la forma usada en el texto del PDF).
- El sujeto guarda referencias a observadores mediante `attach()`; ante un cambio ejecuta `notify()`, que llama a `update()` de cada suscripto.
- Como `update()` no recibe parámetros, el observador puede necesitar una referencia al sujeto por composición para consultar su estado. El texto presenta como alternativa menos habitual el acceso por un contexto compartido.

IMG: UML de `Subject`, `ConcreteSubject`, `Observer` y observador concreto, con notificación a múltiples observadores (p. 82).

## Chain of responsibility
**Páginas reales: 82–83.**

- Al igual que Decorator, utiliza una **cadena de objetos conectados mediante composición**; la motivación es distinta.
- **Decorator** añade responsabilidades; **Chain of responsibility** transfiere una petición entre responsables y cada uno evalúa si le corresponde actuar.
- **Ejemplo del PDF:** una cadena de mando que transmite una orden entre rangos hasta llegar a quien debe ejecutarla.
- **Aclaración expresa del documento (p. 83):** el primer diagrama no es completamente preciso: la relación `successor` debe considerarse **una agregación de un solo elemento**.
- Otra representación usa una estructura similar a Composite y un responsable terminal; el enlace continúa siendo de un único elemento.
- `Handler`: interfaz o clase abstracta que define `HandleRequest()`, método que suele recibir un objeto o parámetros a evaluar; también pueden recibirse desde el constructor.
- `Concretehandler1` y `Concretehandler2`: implementan o heredan `Handler` y pueden enlazarse mediante una referencia a otro `Handler`.
- El `Client` invoca `HandleRequest()` en el primer manejador; cada eslabón evalúa la petición y la transmite al siguiente, hasta el final de la cadena.

IMG: Dos diagramas de `Client`, `Handler`, `ConcreteHandler1` y `ConcreteHandler2` que muestran el sucesor y la cadena de responsabilidades (p. 83).

## Template Method
**Páginas reales: 83–84.**

- Sirve para procesos que necesitan **siempre la misma secuencia de pasos**, pero con variaciones de implementación delegadas en **subclases**.
- **Ejemplo:** un procedimiento con validación de datos, reglas de negocio y persistencia mantiene la estructura, pero varían los datos, reglas y valores según la entidad.
- `AbstractClass`: clase abstracta que implementa `templateMethod()` con la secuencia común.
- Dentro de esa secuencia se llama a `subMethod()`, un método **abstracto y protegido**.
- `ConcreteClass`: subclase que implementa `subMethod()`.
- Cada implementación de `subMethod()` puede producir comportamiento específico sin modificar la estructura definida por `templateMethod()`.

IMG: UML de `AbstractClass` con `templateMethod()` y `#subMethod()`; `ConcreteClass` proporciona `subMethod()` (p. 84).

# Bibliografía utilizada:
**Página 15 del PDF; sin número real impreso.**

- Luis Joyanes Aguilar, Ignacio Zahonero Martínez. *Programación en C*. Segunda Edición. España: McGRAW-HILL/INTERAMERICANA DE ESPAÑA. S.A.U., 2005. ISBN-84: 481-9844-1.
- Brian W. Kernighan, Rob Pike. *La práctica de la programación*. Pearson Educación. Méjico (2000).
- Debugging with CodeBlocks: http://wiki.codeblocks.org/index.php?title=Debugging_with_Code::Blocks
- Bibliotecas: https://es.wikipedia.org/wiki/Biblioteca_(inform%C3%A1tica)
- Enlace dinámico: https://es.wikipedia.org/wiki/Enlace_din%C3%A1mico
- Enlace estático: https://es.wikipedia.org/wiki/Enlace_est%C3%A1tico

---

**Nota de fidelidad:** Este PDF es conceptual y contiene diagramas UML; no presenta bloques de código de implementación completos. Se conservan los nombres de patrones, clases y operaciones usados en su texto y se indican los diagramas como `IMG:`. Los criterios y las observaciones atribuidos al documento no fueron corregidos con teoría externa.
