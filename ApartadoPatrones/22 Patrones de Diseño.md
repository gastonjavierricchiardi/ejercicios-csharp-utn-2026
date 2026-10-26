ARCHIVO: 22 Patrones de Diseño.pdf
Materia/Unidad: Programación II — Unidad 4 — Patrones de diseño
Fecha/Versión: No indicada en el PDF
Paginación: páginas 1 a 75 del PDF (diapositivas; no hay otra numeración visible)
Fuente: exclusivamente el PDF indicado. Las descripciones `IMG:` corresponden a figuras del documento.

# PATRONES DE DISEÑO
**Página 1.** Portada: «PATRONES DE DISEÑO».

# PERO PRIMERO…
**Página 2.** ¿Qué es un Patrón?

# DEFINICIÓN DE PATRÓN
**Página 3.**

**Definición (Alexander, arquitecto–urbanista):** Cada patrón describe un problema que ocurre reiteradamente en nuestro entorno y el núcleo de su solución, de modo que pueda reutilizarse sin resolver otra vez desde cero el mismo problema.

# ENTONCES…
**Página 4.** ¿Qué es un Patrón de Diseño?

# ¿QUÉ ES UN PATRÓN DE DISEÑO?
**Página 5.**

- **Definición:** «Es una regla que expresa la relación entre un contexto, un problema y una solución».
- **Definición (Erich Gamma):** Descripción de clases y objetos comunicándose entre sí, adaptada para resolver un problema general de diseño en un contexto particular.
- Se presenta a Erich Gamma como integrante de GoF (Gang of Four).

IMG: Tapa del libro *Design Patterns: Elements of Reusable Object-Oriented Software*, de Erich Gamma, Richard Helm, Ralph Johnson y John Vlissides.

# PATRONES DE DISEÑO
**Página 6.**

- El libro de Gamma define **23 patrones fundacionales**.
- Los patrones ya existían; Gamma y sus colaboradores contribuyeron a formalizarlos y a que fueran aceptados.
- Existen otros patrones y variaciones, pero los 23 iniciales son el punto de entrada para estudiarlos.

IMG: Tapa del libro *Design Patterns*.

# ¿CUÁLES SON LOS ELEMENTOS DE UN PATRÓN DE DISEÑO?
**Página 7.**

**Lista de cuatro elementos clave:**
1. **Nombre**.
2. **Problema**.
3. **Solución**.
4. **Consecuencias**.

# EL NOMBRE DE UN PATRÓN DE DISEÑO
**Página 8.**

- Permite contar con un vocabulario común y simplifica la comunicación.
- Aporta mayor abstracción: un solo nombre asocia problema, solución y consecuencias.
- Al mencionar un patrón se transmite un conjunto amplio de conocimiento que llevaría más tiempo explicar en detalle.

# EL PROBLEMA DE UN PATRÓN DE DISEÑO
**Página 9.**

- Indica **cuándo** utilizar un patrón.
- Proporciona el contexto del problema que debe resolverse.
- Puede contener precondiciones, estructuras y algoritmos comunes al problema.

# LA SOLUCIÓN DE UN PATRÓN DE DISEÑO
**Página 10.**

- Describe elementos del diseño, relaciones, responsabilidades y colaboraciones.
- No es una implementación concreta, sino un **template genérico**.
- La abstracción debe adaptarse al dominio en el que se utiliza.

# LAS CONSECUENCIAS DE UN PATRÓN DE DISEÑO
**Página 11.**

- Describen los resultados de aplicar el patrón.
- El impacto del diseño se manifiesta en **flexibilidad, extensibilidad y portabilidad**.
- Enumerar consecuencias explícitamente permite reconocer efectos que podrían pasar inadvertidos.

# BENEFICIOS DE UTILIZAR PATRONES DE DISEÑO
**Página 12.**

- Diseñar software orientado a objetos no es sencillo.
- Los diseños deben ser específicos para el problema actual, pero suficientemente generales para responder a problemas futuros.
- Conviene intentar reutilizar diseños anteriores, sin afrontar como nuevo un problema ya resuelto.

# BENEFICIOS DE UTILIZAR PATRONES DE DISEÑO
**Página 13.**

- No existe una secuencia mecánica de pasos que garantice un buen diseño; los patrones formalizan diseños probados y útiles.
- Aun cuando un patrón no resuelva exactamente el problema, puede servir como punto de partida e inspiración.

# ¿POR QUÉ UTILIZAR PATRONES DE DISEÑO?
**Página 14.**

- Abren posibilidades para explorar mejoras de diseño.
- Adoptar el vocabulario compartido por la comunidad ahorra tiempo.
- Obligan a revisar el diseño y a no limitarse a una solución de compromiso inmediata.
  - Ayudan a equilibrar hasta cuándo dejar abiertas las posibilidades de cambio y cuándo cerrar una solución para implementarla.
- Documentan y facilitan reutilizar y compartir diseños de una forma sencilla y formal.

# CONSEJOS PARA APLICARLOS
**Página 15.**

- **Intent, Motivation y Applicability:** tres apartados usados para decidir si un patrón encaja en un problema. Traducción: intención, motivación y aplicabilidad.
- **Categorías de patrones:**
  - **Creacionales:** abstraen el proceso de instanciación.
  - **Estructurales:** definen estructuras de clases y objetos.
  - **De comportamiento:** se ocupan de asignar responsabilidades y de la comunicación entre objetos.
- No todo puede hacerse variable: Gamma recomienda encapsular la parte **más variable** de la aplicación.

# CÓMO NO USARLOS
**Página 16.**

- Flexibilizar partes del sistema añade **complejidad al diseño** y aumenta el costo de implementación.
- Aparecen dos fuerzas opuestas: **flexibilidad** y **simplicidad**.

IMG: Balanza conceptual con una flecha hacia «Flexibilidad» y otra hacia «Simplicidad».

# ¿EN QUÉ ETAPAS APLICARLOS?
**Página 17.**

- **Análisis:** aún se está aprendiendo el dominio; la diapositiva señala que es imposible aplicar patrones en esa etapa.
- **Diseño:** aunque el conocimiento es incompleto, un usuario experto puede ayudar a identificar qué partes cambiarán.
- **Desarrollo:** si aparece un patrón no previsto, corresponde actualizar el diseño.

# PUESTA EN COMÚN DE CONCEPTOS NECESARIOS
**Página 18.**

- **Clase abstracta:** no puede instanciarse y debe heredarse; establece estructura y comportamiento.
- **Herencia:** permite extender funcionalidad existente sin modificar la clase de origen.
- **Interfaz:** contiene firmas de métodos y constantes como contrato que implementan las clases; abstrae comportamiento común para los clientes.
- **Polimorfismo:** varias clases con comportamiento común responden de forma distinta al mismo método.
- **Sobrecarga:** métodos con un mismo nombre y firmas distintas, con funcionalidades diferentes.

# CLASIFICACIÓN DE PATRONES DE DISEÑO
**Página 19.**

- **De creación:** resuelven problemas de instanciación de objetos.
- **De estructura:** se centran en la forma estructural de las clases.
- **De comportamiento:** resuelven cuestiones del comportamiento de la aplicación durante la ejecución.

# SINGLETON
**Página 20.** Portada de la sección.

# SINGLETON (CREACIONAL)
**Página 21.**

- Es un **patrón de diseño creacional**.
- **Intención:** asegurar que una clase tenga **una única instancia** y ofrecer un **punto global de acceso** para obtenerla.

IMG: UML esquemático de `Singleton` con referencia privada a la instancia y método de acceso `Instance()`.

# SINGLETON
**Página 22.**

**Participantes:**
- `Singleton` (ejemplo: `LoadBalancer`): define el método `Instance` para que los clientes obtengan la única instancia.
- `Instance`: método de clase encargado de crear y mantener esa instancia.

**Colaboraciones:**
- Los clientes acceden a la única instancia mediante el método estático provisto.

# SINGLETON
**Página 23.**

**Consecuencias:**
- Frente a variables globales, permite reunir el estado en una instancia sin dispersar variables ni producir conflictos de nombres en un mismo `namespace`.
- Su configuración para una aplicación es sencilla y se utiliza en tiempo de ejecución (**run-time**).
- Como alternativa se mencionan métodos de clase (`static`), pero no pueden ser `virtual`; por eso no permiten redefinición y polimorfismo de la misma manera.

# SINGLETON
**Página 24.**

IMG: Esquema genérico `Singleton`: un método estático `Instance()` retorna `uniqueInstance`; incluye operaciones y datos de la clase. Debajo, analogía gráfica `Presidency` / `Election()` que retorna una instancia única.

# SINGLETON
**Página 25.**

IMG: Diagrama UML del ejemplo `SessionManager` y `Usuario`:
- `Usuario`: atributos `Apellido: String` y `Nombre: String`; operaciones `Apellido()` y `Nombre()`.
- `SessionManager`: campos `_instance: SessionManager` y `_usuario: Usuario`; operaciones `getInstane(): SessionManager` (grafía visible en el diagrama), `getUsuario(): Usuario`, `new()` (privada) y `setUsuario(Usuario): int`.
- Se muestra una autorreferencia de `SessionManager` y una relación hacia `Usuario`.
- La figura usa las denominaciones impresas en el PDF, sin adaptación de código a C#.

# TEMPLATE METHOD
**Página 26.** Portada de la sección.

# TEMPLATE METHOD (COMPORTAMIENTO)
**Página 27.**

- **Intención:** definir el **esqueleto de un algoritmo** dentro de una operación y permitir que las subclases redefinan ciertos pasos **sin cambiar la estructura** del algoritmo.

IMG: UML con `AbstractClass`, `TemplateMethod()` y operaciones primitivas `PrimitiveOperation1()` / `PrimitiveOperation2()` implementadas en `ConcreteClass`.

# TEMPLATE METHOD
**Página 28.**

**Participantes:**
- `AbstractClass` (`Application`):
  - Declara operaciones primitivas abstractas cuyos pasos implementarán las subclases.
  - Implementa el `template method` que define el esqueleto y llama a operaciones primitivas, operaciones de la propia clase y de otros objetos.
- `ConcreteClass` (`MyApplication`): implementa las operaciones primitivas para los pasos específicos.

# TEMPLATE METHOD
**Página 29.**

**Colaboraciones:**
- `ConcreteClass` deja los pasos invariantes del algoritmo en manos de `AbstractClass` mediante el `template method`.

**Aplicaciones (usar cuándo):**
- Se desean implementar una sola vez los pasos que no varían y delegar los variables a subclases.
- Es necesario reunir comportamiento común en una clase para evitar duplicación de código.
- Se busca controlar puntos de extensión con operaciones **hook** invocadas desde el `template method`.

# TEMPLATE METHOD
**Página 30.**

**Consecuencias:**
- Técnica importante de reutilización de código, especialmente en bibliotecas.

**Tipos de operaciones que puede llamar un `template method`:**
1. Operaciones concretas de `ConcreteClass` o del cliente.
2. Operaciones concretas de `AbstractClass` útiles para todas las subclases.
3. Operaciones primitivas abstractas.
4. **Factory Methods** (otro patrón).
5. **Hook operations**: ofrecen comportamiento común, pueden redefinirse y a menudo no hacen nada por defecto.

# TEMPLATE METHOD
**Página 31.**

**Consecuencias (continuación):**
- Es importante distinguir operaciones **hook** (su redefinición es opcional) de las **abstractas** (la subclase debe implementarlas).
- La diapositiva señala el uso de `abstract` en .NET para indicar las operaciones que corresponda implementar.

# TEMPLATE METHOD
**Página 32.**

IMG: UML de ejemplo con una clase base `Juego` y dos tipos de juegos derivados. Ilustra un algoritmo común cuyas operaciones específicas se redefinen en las subclases; no se adjunta código fuente de este ejemplo.

# COMPOSITE
**Página 33.** Portada de la sección.

# COMPOSITE (ESTRUCTURAL)
**Página 34.**

**Propósito:**
- Componer objetos en estructuras de **árbol** que representan jerarquías **parte–todo**.
- Permitir que el cliente trate uniformemente a objetos individuales y compuestos.

IMG: Árbol que diferencia un **nodo** (tiene hijos) de una **hoja** (no tiene hijos).

# COMPOSITE
**Página 35.**

**Aplicabilidad:**
- Representar jerarquías todo–parte.
- Permitir que el cliente ignore la distinción entre los objetos individuales y las composiciones y los trate de forma uniforme.

**Ejemplo conceptual:** contenedores con elementos que, a su vez, pueden ser contenedores.

# COMPOSITE
**Página 36.**

IMG: UML general:
- `Client` utiliza `Component`.
- `Leaf` y `Composite` especializan `Component`.
- `Component` expone `Operation()`, `Add(in Component)`, `Remove(in Component)` y `GetChild(index: int)`.
- `Composite` mantiene `children` y realiza una operación sobre cada hijo; `Leaf` define la operación individual.

# COMPOSITE
**Página 37.**

**Consecuencias:**
- Define jerarquías con objetos primitivos y compuestos.
- Simplifica el cliente porque trata uniformemente las estructuras.
- Facilita incorporar nuevos tipos de componentes.
- Puede conducir a un diseño demasiado general.

# COMPOSITE - EJEMPLO
**Página 38.**

- **Consigna:** desarrollar un sistema para manejar distintos menús de un restaurante, pues cambian completamente según el momento del día.

# COMPOSITE - EJEMPLO
**Página 39.**

IMG: Árbol de menús: un menú raíz contiene varios menús y elementos finales; algunos submenús vuelven a contener otros submenús. Los nodos compuestos representan menús y las hojas representan opciones individuales.

# COMPOSITE - EJEMPLO
**Página 40.**

IMG: UML del caso restaurante:
- `MenuComponent`: atributos `Descripcion`, `Nombre` y `Precio` (tipo `String` en la figura); métodos `AgregarHijo()`, `EliminarHijo()`, `Descripcion()`, `Imprimir()`, `Nombre()` y `Precio()`.
- `MenuItem`: especializa `MenuComponent` y define `Descripcion()`, `Imprimir()`, `Nombre()` y `Precio()`.
- `Menu`: especializa `MenuComponent`, dispone de `AgregarHijo()` / `EliminarHijo()` y redefine métodos de consulta e impresión.
- Un `Menu` puede contener uno o muchos elementos `MenuComponent`, incluidos otros menús.
- Nota del diagrama: ambas clases sobrescriben `Imprimir`.

# COMPOSITE (NOTAS)
**Página 41.**

- Crear una interfaz que actúe como **«mínimo denominador común»** para poder intercambiar contenedores y contenidos.
- Las clases de contenedor y contenido implementan dicha interfaz.
- Las operaciones sobre hijos (`AddChild()`, `RemoveChild()`) normalmente pertenecerían a `Composite`; para tratar uniformemente `Leaf` y `Composite`, pueden desplazarse a `Component`.
- Los contenedores aprovechan el polimorfismo para delegar operaciones en los contenidos.

IMG: Repetición del diagrama general `Client`–`Component`–`Leaf`/`Composite`.

# DECORATOR
**Página 42.** Portada de la sección.

# DECORATOR (ESTRUCTURAL)
**Página 43.**

**Propósito:** asignar responsabilidades adicionales a un objeto **dinámicamente**, como alternativa flexible a la herencia para extender funcionalidades.

**También conocido como:** `Wrapper (Envoltorio)`.

# DECORATOR
**Página 44.**

**Estructura:**

IMG: UML general de `Component`, `ConcreteComponent`, `Decorator` y decoradores concretos. `Decorator` conserva una referencia a un `Component`, comparte la interfaz de operación y permite que un decorador concreto agregue acciones antes o después de delegar en el objeto envuelto.

# DECORATOR
**Página 45.**

**Consecuencias:**
- Más flexibilidad que la herencia estática: las responsabilidades se agregan dinámicamente.
- Evita sobrecargar de funciones las clases superiores de la jerarquía.
- Un decorador y su componente **no son idénticos**; conviene no apoyarse en la identidad de objetos.
- Puede generar **muchos objetos pequeños**.

# DECORATOR - EJEMPLO
**Página 46.**

**Consigna:** calcular el costo de una bebida y sus agregados.

| Bebida | Precio |
|---|---:|
| Café solo | $10 |
| Café expreso | $12 |
| Café descafeinado | $15 |
| Té tradicional | $8 |

| Condimento | Precio |
|---|---:|
| Leche | $2 |
| Crema | $4 |
| Edulcorante | $1 |
| Azúcar | $0.50 |

- Cada bebida y condimento tiene un costo propio; la combinación determina el costo total.

# DECORATOR - EJEMPLO
**Página 47.**

**Secuencia del ejemplo:**
1. Pedimos un café.
2. Le agregamos crema.
3. Le agregamos azúcar.
4. Calculamos el costo.

# DECORATOR - EJEMPLO
**Página 48.**

- Repite la secuencia de la página 47.

IMG: Diagrama de envoltorios concéntricos que ilustran la composición de una bebida y sus agregados mediante llamadas a `cost()`; la ilustración usa términos del ejemplo gráfico en inglés.

# DECORATOR - EJEMPLO
**Página 49.**

IMG: UML del caso bebidas:
- Clase base `Bebida`, con costo y descripción y operaciones para obtenerlos.
- Bebidas concretas: `CafeSolo`, `CafeExpreso`, `CafeDescafeinado` y `TeTradicional`.
- Decorador de agregados `AgregadoBebida`, relacionado con `Bebida`.
- Agregados concretos: `Leche`, `Crema`, `Edulcorante` y `Azucar`.
- El costo y la descripción se obtienen mediante objetos que envuelven una bebida.

# DECORATOR – EJEMPLO EN VB.NET
**Página 50.**

**Código ilustrado en la diapositiva (VB.NET, sin traducir ni corregir):**

```vbnet
Dim cafecito As Bebida

cafecito = New CafeSolo()
cafecito = New Leche(cafecito)
cafecito = New Azucar(cafecito)

Console.WriteLine(cafecito.GetDescripcion)
Console.ReadKey()
```

**Salida mostrada:**

```text
Café sólo, Leche, Azucar
```

IMG: Captura de la consola con la descripción de la bebida decorada.

# DECORATOR Y COMPOSITE
**Página 51.**

- Sus diagramas estructurales son similares.
- Ambos usan composición recursiva para organizar una cantidad abierta de objetos.
- **Decorator:** agrega responsabilidades sin utilizar subclases.
- **Composite:** se centra en representar estructuras, no en el «embellecimiento» de un objeto.

# STRATEGY
**Página 52.** Portada de la sección.

# STRATEGY (COMPORTAMIENTO)
**Página 53.**

**Intención:** mantener un conjunto de algoritmos entre los cuales el objeto cliente pueda elegir e intercambiarlos **dinámicamente** según sus necesidades.

IMG: UML con `Context`, `Strategy` y `ConcreteStrategyA` / `ConcreteStrategyB` / `ConcreteStrategyC`.

# STRATEGY
**Página 54.**

IMG: UML general del patrón. `Context` mantiene la referencia `strategy` a `Strategy`, cuyo contrato `AlgorithmInterface()` implementan varias estrategias concretas.

# STRATEGY
**Página 55.**

**Participantes:**
- `Strategy` (`SortStrategy`): declara la interfaz común para todos los algoritmos; el contexto la utiliza para invocar la implementación concreta.
- `ConcreteStrategy` (`QuickSort`, `ShellSort`, etc.): implementa un algoritmo conforme a esa interfaz.
- `Context` (`SortedList`):
  - Se configura con una instancia de `ConcreteStrategy`.
  - Conserva una referencia de tipo `Strategy`.
  - Puede definir una interfaz que permita a la estrategia acceder a sus datos.

# STRATEGY
**Página 56.**

**Colaboraciones:**
- `Strategy` y `Context` colaboran para implementar el algoritmo.
- El contexto puede pasar todos los datos necesarios o pasarse a sí mismo para que `Strategy` consulte los datos.
- `Context` delega en la estrategia almacenada las solicitudes de sus clientes.
- Habitualmente los clientes crean y asignan la estrategia al contexto; luego interactúan solo con el contexto.

# STRATEGY
**Página 57.**

**Aplicación (usar cuando):**
- Clases relacionadas se diferencian principalmente por su comportamiento.
- Existen varias versiones del mismo algoritmo, implementadas mediante una jerarquía de clases.
- No se desea mostrar al cliente estructuras de datos complejas propias del algoritmo.
- Una clase contiene muchos comportamientos elegidos mediante numerosas condiciones.

# STRATEGY
**Página 58.**

**Consecuencias (+):**
- Permite definir **familias de algoritmos** relacionados y reutilizar comportamiento común entre estrategias concretas.
- Es una alternativa a crear subclases de `Context` para cada algoritmo: evita mezclar entidades con algoritmos y permite cambiar el comportamiento dinámicamente.
- Reduce las evaluaciones condicionales (`switch`) porque el contexto invoca a la estrategia asignada.

# STRATEGY
**Página 59.**

**Consecuencias (−):**
- Los clientes deben conocer las estrategias disponibles y seleccionar la apropiada; conviene usar Strategy cuando cambiar de algoritmo sea relevante para el cliente.
- Existe **overhead** en la comunicación `Strategy`–`Context`: una interfaz común puede obligar a pasar datos que algunas estrategias no necesitan. Una opción mencionada es pasarles el contexto.
- Aumenta la cantidad de objetos. Si resulta problemático, pueden utilizarse estrategias sin estado y compartirlas.

# STRATEGY
**Página 60.**

IMG: UML de otro ejemplo, con `Client`, `SortAlgorithm2`, `SortAscending` y `SortDescending`. Las clases concretas redefinen `compare()` para ordenar ascendente o descendentemente; la clase base muestra el proceso de ordenamiento.

# FACADE
**Página 61.** Portada de la sección.

# FACADE (ESTRUCTURAL)
**Página 62.**

**Intención:** proporcionar una **interfaz unificada** para un conjunto de interfaces de un subsistema. Esa interfaz de alto nivel facilita su utilización.

# FACADE
**Página 63.**

**CONDICIONES DE USO:**
- Se necesita una interfaz simple para acceder a un sistema complejo.
- Existen muchas dependencias entre los sistemas implementados y sus clientes.

# FACADE
**Página 64.**

IMG: Comparación visual entre numerosos clientes conectados directamente a las clases de un subsistema y los mismos clientes que utilizan una `Fachada` para simplificar las dependencias.

# FACADE - EJEMPLO
**Página 65.**

IMG: Diagrama de clases de un compilador. El objeto `Compilador` actúa como fachada frente a clases del subsistema relacionadas con análisis léxico, sintáctico, nodos de programa y generación de código.

# FACADE - EJEMPLO
**Página 66.**

**Participantes:**
- **Fachada (`Compilador`):**
  - Conoce las clases responsables del subsistema para cada petición.
  - Delega solicitudes de clientes en objetos adecuados del subsistema.
- **Clases del subsistema** (`Lexico`, `Sintactico`, `NodoPrograma`, etc.):
  - Implementan la funcionalidad del subsistema.
  - Realizan las tareas que la fachada solicita.
  - No conocen a la fachada ni mantienen una relación con ella.

# FACADE - EJEMPLO
**Página 67.**

**Colaboración:**
- Los clientes solicitan operaciones a `Fachada`, que las dirige a los objetos apropiados del subsistema.
- Los objetos internos realizan el trabajo; la fachada puede adaptar la solicitud entre interfaces.
- El cliente que utiliza la fachada no necesita acceder directamente a las clases del subsistema.

# FACADE - EJEMPLO
**Página 68.**

**Consecuencias:**
- Oculta a los clientes la complejidad del subsistema, reduce la cantidad de objetos con los que interactúan y facilita el uso.
- Favorece el **bajo acoplamiento** entre subsistema y clientes, permitiendo modificar componentes internos con menor impacto externo.
- No prohíbe el acceso directo a clases del subsistema cuando sea necesario; permite equilibrar facilidad de uso y generalidad.

# OBSERVER
**Página 69.** Portada de la sección.

# OBSERVER (COMPORTAMIENTO)
**Página 70.**

**Intención:** definir una dependencia **uno a muchos** entre objetos, de modo que, cuando uno cambia su estado, **notifica** el cambio a todos sus dependientes.

# OBSERVER
**Página 71.**

- Se necesita consistencia entre clases relacionadas sin perder independencia.
- Los cambios de estado de uno o varios objetos deben producir comportamiento en otros.

# OBSERVER
**Página 72.**

IMG: UML con `Subject`, `Observer`, `ConcreteSubject` y `ConcreteObserver`. `Subject` administra observadores y notifica; `Observer` declara `Update()`. El observador concreto consulta el estado de su sujeto.

# OBSERVER
**Página 73.**

IMG: Repite el diagrama estructural `Subject` / `Observer` / `ConcreteSubject` / `ConcreteObserver` de la página anterior.

# OBSERVER - EJEMPLO
**Página 74.**

IMG: Variante del diagrama UML con nombres en español: `Sujeto`, `Observador`, `SujetoConcreto` y `ObservadorConcreto`; operaciones para asociar, quitar y notificar observadores, y para actualizar el observador.

# OBSERVER - EJEMPLO
**Página 75.**

**PARTICIPANTES:**
- **Sujeto:**
  - Conoce sus observadores; puede tener cualquier número de ellos.
  - Ofrece una interfaz para añadir o quitar observadores.
- **Observador:**
  - Define la interfaz de actualización que reciben quienes necesitan ser notificados.
- **SujetoConcreto:**
  - Almacena el estado relevante para los observadores concretos.
  - Notifica a sus observadores cuando cambia ese estado.
- **ObservadorConcreto:**
  - Mantiene una referencia a un `SujetoConcreto`.
  - Guarda un estado que debe ser consistente con el del sujeto.
  - Implementa la actualización de `Observador` para mantener esa consistencia.

---

**Alcance de la fuente:** Este PDF desarrolla los siete patrones anteriores. No contiene una implementación completa en C# de ellos. El código incluido en la página 50 es VB.NET y se conserva como en la diapositiva.
