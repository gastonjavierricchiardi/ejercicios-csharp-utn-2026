# Patrones de Diseño tal como se vieron en la cursada

> **Modo de estudio:**  
> Este apunte está armado sobre el material oficial de la cursada.  
> Cuando aparece una explicación marcada como **[AMPLIACIÓN]**, significa que ayuda a entender, pero no conviene priorizarla por encima del apunte oficial en parcial.  
> Cuando aparece **[EXTRA]**, significa que fue visto verbalmente o agregado para comparar, pero no forma parte central del apunte oficial.

---

## Introducción a los patrones de diseño

A lo largo de la historia de la programación, los programadores han brindado solución a innumerables problemas, algunos de los cuales han sido —y siguen siendo— muy recurrentes.

Para evitar que los profesionales implementen estrategias que quizá no sean las mejores en términos de mantenibilidad, lectura y escalabilidad, el conocido grupo **Gang of Four** estudió los problemas con mayor recurrencia y el modo en que los desarrolladores supieron abordarlos, identificando los patrones que ofrecen mejores beneficios en relación con su implementación.

Tras un largo trabajo, en 1994 se edita el libro **Design Patterns: Elements of Reusable Object-Oriented Software**, que resulta ser el compendio de las mejores prácticas en términos de diseño, identificando **tres categorías de patrones**:

- **Creacionales:** estrategias para la creación de objetos.
- **Estructurales:** abordan la relación entre los objetos.
- **De comportamiento:** focalizan sobre la comunicación entre objetos.

Lo interesante de los patrones de diseño es que, en la mayoría de los casos, surgen como las propuestas más naturales para enfrentar un desafío, siempre y cuando el arquitecto se ciña a las buenas prácticas de la programación orientada a objetos.

Adicionalmente, el hecho de estar documentados permite que los responsables del desarrollo de una solución puedan manejar términos técnicos dentro de un mismo dominio, mejorando la comunicación.

Es importante tener presente que su mera existencia no implica su uso. Si las bases fundamentales de la programación orientada a objetos no fueron asimiladas, aplicar patrones puede agregar complejidad innecesaria.

En particular, el libro trabaja sobre errores comunes en la programación orientada a objetos, la importancia de programar pensando en interfaces y no en implementación, y el uso de la composición sobre la herencia.

---

# 1. Patrones creacionales

> **[OFICIAL]**  
> Estos patrones son herramientas que facilitan la creación de entidades, encapsulando el proceso de construcción.  
> De ese modo, si se necesita cambiar la estructura de un objeto, sus requerimientos o la manera en que estos se componen, las modificaciones se verían muy acotadas.

## Patrones creacionales vistos

- **Singleton**
- **Factory Method**
- **Abstract Factory**
- **Builder**

---

## 1.1 Singleton

### Propósito

> **[OFICIAL]**  
> Asegurar que una clase tenga una única instancia, a la vez que proporciona un punto de acceso global a dicha instancia.

### Aplicabilidad

1. Cuando se necesita controlar el acceso a algún recurso compartido.
2. Cuando se requiere acceder y controlar el acceso a variables globales o configuración compartida.

### Ventajas

1. Se puede tener la seguridad de que la clase tiene una única instancia.
2. Se obtiene un único punto de acceso a dicha instancia.
3. El _Singleton_ solo se inicializa realmente cuando se requiere por primera vez.

### Desventajas

1. Vulnera el principio de responsabilidad única (**SRP**), porque controla su propia instancia y además realiza su tarea principal.
2. Puede ocultar un mal diseño, vulnerando el principio de inversión de dependencia (**DIP**).
3. En entornos con múltiples hilos de ejecución, requiere tratamiento especial para evitar que varios hilos creen más de una instancia.

### Nota para parcial

Si el enunciado dice:

- “única instancia”
- “punto de acceso global”
- “configuración compartida”
- “controlar acceso a un recurso común”

entonces puede estar apuntando a **Singleton**.

### Conceptos asociados

- **SRP:** Single Responsibility Principle / Principio de Responsabilidad Única.
- **DIP:** Dependency Inversion Principle / Principio de Inversión de Dependencia.

---

## 1.2 Factory Method

### Propósito

> **[OFICIAL]**  
> Proporcionar una interfaz para crear objetos en una superclase, mientras permite a las subclases alterar el tipo de objetos que se crearán.

### Aplicabilidad

1. Cuando no se conocen de antemano las dependencias y los tipos exactos de los objetos con los que debe funcionar el código.
2. Cuando se quiere delegar en subclases la decisión de qué clase concreta instanciar.
3. Cuando se quiere desacoplar el código cliente de los productos concretos.

### Ventajas

1. Evita un acoplamiento fuerte entre el creador y los productos concretos.
2. Respeta **SRP**, porque permite mover el código de creación de producto a un lugar específico del programa.
3. Respeta **OCP**, porque permite incorporar nuevos tipos de productos sin romper el código cliente existente.

### Desventajas

1. Puede requerir la implementación de muchas subclases.

### Nota para parcial

Si el enunciado dice:

- “una superclase define la creación”
- “las subclases deciden qué objeto crear”
- “crear objetos sin acoplarse al producto concreto”

entonces puede estar apuntando a **Factory Method**.

### Conceptos asociados

- **SRP:** Single Responsibility Principle / Principio de Responsabilidad Única.
- **OCP:** Open/Closed Principle / Principio Abierto/Cerrado.

---

## 1.3 Abstract Factory

### Propósito

> **[OFICIAL]**  
> Permite crear familias de objetos relacionados sin necesidad de especificar sus clases concretas.

### Aplicabilidad

1. Cuando el código debe funcionar con familias de productos relacionados.
2. Cuando no se desea que el cliente dependa de clases concretas.
3. Cuando se busca permitir futura extensibilidad.
4. Cuando se necesita asegurar compatibilidad entre productos de una misma familia.

### Ventajas

1. Los productos que se obtienen de una fábrica son compatibles entre sí.
2. Se evita un acoplamiento fuerte entre productos concretos y el código cliente.
3. Respeta **SRP**, porque mueve el código de creación a un lugar específico.
4. Respeta **OCP**, porque permite incorporar nuevas familias de productos sin descomponer el código cliente existente.

### Desventajas

1. Puede requerir la implementación de muchas clases, subclases e interfaces.

### Nota para parcial

Si el enunciado dice:

- “familia de objetos relacionados”
- “productos compatibles”
- “tema oscuro / tema claro”
- “botón oscuro, checkbox oscuro, botón claro, checkbox claro”

entonces puede estar apuntando a **Abstract Factory**.

### Diferencia clave con Factory Method

- **Factory Method:** crea un producto por fábrica.
- **Abstract Factory:** crea familias de productos relacionados.

### Conceptos asociados

- **SRP:** Single Responsibility Principle / Principio de Responsabilidad Única.
- **OCP:** Open/Closed Principle / Principio Abierto/Cerrado.

---

## 1.4 Builder

### Propósito

> **[OFICIAL]**  
> Construir objetos complejos paso a paso. El patrón permite producir distintos tipos y representaciones de un objeto empleando el mismo código de construcción.

### Aplicabilidad

1. Cuando se quieren evitar constructores complejos y con muchos parámetros.
2. Cuando se necesitan crear distintas representaciones de ciertos objetos.
3. Cuando el objeto se construye en varios pasos.
4. Cuando algunos pasos de construcción pueden ser opcionales.

### Ventajas

1. Permite construir objetos paso a paso.
2. Permite reutilizar el mismo código de construcción para distintas representaciones de productos.
3. Respeta **SRP**, porque separa el código de construcción complejo de la lógica de negocio del producto.

### Desventajas

1. La complejidad general del código aumenta, porque _Builder_ implica crear varias clases nuevas.

### Nota para parcial

Si el enunciado dice:

- “objeto complejo”
- “muchos parámetros”
- “muchos pasos”
- “distintas configuraciones”
- “mismo proceso de construcción con distintos resultados”

entonces puede estar apuntando a **Builder**.

### Conceptos asociados

- **SRP:** Single Responsibility Principle / Principio de Responsabilidad Única.

---

# 2. Patrones estructurales

> **[OFICIAL]**  
> Ofrecen estrategias para que los objetos puedan ser tratados uniformemente u organizarse de modo tal que resulte en una estructura práctica para la manipulación de las entidades.

## Patrones estructurales vistos

- **Adapter**
- **Composite**
- **Decorator**
- **Facade**

---

## 2.1 Adapter

### Propósito

> **[OFICIAL]**  
> Encapsular el código de modo tal que un conjunto de objetos que exponen funciones diferentes, y que por lo general no pueden ser modificados, sean tratados mediante una interfaz común.

### Propósito reformulado

1. Unificar interfaces incompatibles bajo una interfaz común.
2. Permitir que el cliente use una API objetivo mientras el adaptador traduce hacia la clase adaptada.
3. Reutilizar código existente sin modificarlo.

### Aplicabilidad

1. Cuando se requiere integrar subsistemas o bibliotecas que realizan tareas similares pero exponen interfaces distintas.
2. Cuando hay una clase existente que se quiere usar, pero su interfaz no coincide con lo que el cliente necesita.
3. Cuando se trabaja con código legado que no conviene o no se puede modificar.
4. **[AMPLIACIÓN]** Cuando se busca hacer una migración gradual de una API sin romper al cliente.

### Ventajas

1. Reutiliza código existente o legado sin modificarlo.
2. Desacopla al cliente de las clases concretas.
3. Permite agregar nuevos adaptadores sin cambiar el cliente.
4. Puede simplificar pruebas porque el cliente trabaja contra una interfaz común.

### Desventajas

1. Agrega una capa extra de indirección.
2. Puede aumentar la cantidad de clases.
3. Si hay muchas variantes, pueden proliferar demasiados _adaptadores_.

### Nota para parcial

Si el enunciado dice:

- “sistema legado”
- “interfaz incompatible”
- “adaptar una clase existente”
- “traducir llamadas”
- “usar una clase que no cumple la interfaz esperada”

entonces puede estar apuntando a **Adapter**.

### Notas al pie del patrón

- **Mockear:**  
  **[AMPLIACIÓN]** En pruebas, “mockear” significa reemplazar un objeto real por uno falso o simulado para probar una parte del sistema sin depender de todo lo demás.  
  Ejemplo: en vez de usar un servicio real de pagos, uso un objeto falso que responde como si fuera el servicio.

- **Overhead:**  
  **[AMPLIACIÓN]** Es el costo adicional que aparece por agregar una capa más. Puede ser costo de procesamiento, memoria, complejidad o mantenimiento.  
  En Adapter, el overhead aparece porque la llamada no va directo al objeto real, sino que pasa por el adaptador.

- **API:**  
  **[AMPLIACIÓN]** Es una interfaz de comunicación. En este contexto, es la forma en que una clase, módulo o sistema ofrece operaciones para que otro código pueda usarlo.

- **Código legado:**  
  **[AMPLIACIÓN]** Es código viejo o existente que sigue funcionando, pero que quizá no fue diseñado con las necesidades actuales. Muchas veces no conviene tocarlo directamente.

### Conceptos asociados

- **OCP:** Open/Closed Principle / Principio Abierto/Cerrado.

---

## 2.2 Composite

### Propósito

> **[OFICIAL]**  
> Generar estructuras arborescentes o rizomáticas, como menús que pueden contener opciones o conjuntos de opciones agrupadas en submenús.

### Propósito reformulado

Tratar objetos simples, llamados hojas, y objetos compuestos, llamados ramas o compuestos, de manera uniforme mediante una misma interfaz.

### Aplicabilidad

1. Cuando se necesitan estructuras arborescentes, como menús, carpetas, escenas o jerarquías.
2. Cuando el cliente debe usar hojas y compuestos de la misma forma.
3. Cuando se quiere representar una relación parte-todo.
4. Cuando ramas y hojas tienen comportamiento distinto. Si no tienen comportamiento distinto, podría alcanzar una clase con una lista de elementos del mismo tipo.

### Ventajas

1. El cliente no necesita distinguir entre hoja y compuesto.
2. Facilita agregar nuevos tipos de componentes.
3. Permite composición recursiva.
4. Permite organizar jerarquías de objetos de forma clara.

### Desventajas

1. Puede ir contra **ISP**, porque las hojas pueden quedar obligadas a implementar métodos de estructura como `add`, `remove` o `getChild`, aunque no puedan usarlos.
2. Puede volver el diseño demasiado general.
3. Puede ser sobre-ingeniería si la estructura es simple.

### Nota para parcial

Si el enunciado dice:

- “estructura de árbol”
- “parte-todo”
- “menú y submenú”
- “carpetas y archivos”
- “hojas y compuestos”
- “tratar objetos individuales y compuestos de forma uniforme”

entonces puede estar apuntando a **Composite**.

### Notas al pie del patrón

- **Sobre-ingeniería:**  
  **[AMPLIACIÓN]** Es cuando se arma una solución más compleja de lo necesario. En patrones, pasa cuando aplicamos un patrón para un problema simple que podía resolverse con una estructura mucho más sencilla.

- **Parte-todo:**  
  Significa que hay objetos que forman parte de otros. Por ejemplo: una carpeta contiene archivos y otras carpetas.

### Conceptos asociados

- **OCP:** Open/Closed Principle / Principio Abierto/Cerrado.
- **ISP:** Interface Segregation Principle / Principio de Segregación de Interfaces.

---

## 2.3 Decorator

### Propósito

> **[OFICIAL]**  
> Extender las funcionalidades de un objeto, evitando realizar cambios en estructuras complejas o imposibles de ser modificadas.

### Propósito reformulado

Agregar responsabilidades a objetos dinámicamente envolviéndolos con _decoradores_ que mantienen la misma interfaz del componente.

### Aplicabilidad

1. Cuando no se puede o no se quiere modificar la clase existente.
2. Cuando se necesitan variantes combinables de comportamiento.
3. Cuando se quiere evitar crear demasiadas subclases.
4. Cuando se quiere agregar funcionalidad en tiempo de ejecución.

### Ventajas

1. Permite agregar comportamiento sin tocar la clase original.
2. Es más flexible que la herencia estática.
3. Permite combinar decoradores.
4. Cada decorador puede representar una responsabilidad puntual.

### Desventajas

1. Aumenta la cantidad de objetos pequeños.
2. Puede dificultar la depuración.
3. El orden de aplicación de los decoradores puede afectar el resultado si cada capa depende del estado acumulado.
4. Si se abusa, el diseño puede volverse fragmentado o difícil de leer.

### Nota para parcial

Si el enunciado dice:

- “agregar responsabilidades”
- “envolver un objeto”
- “extender funcionalidad sin modificar la clase”
- “sumar capas”
- “bebida + leche + azúcar + crema”

entonces puede estar apuntando a **Decorator**.

### Notas al pie del patrón

- **Wrapper / envoltorio:**  
  Es una clase que envuelve a otra para agregar, adaptar o controlar su comportamiento.

- **Runtime / tiempo de ejecución:**  
  **[AMPLIACIÓN]** Significa “mientras el programa está corriendo”.  
  En _Decorator_, se pueden agregar capas durante la ejecución, no necesariamente dejando todo fijo desde el diseño.

- **Orden de aplicación:**  
  **[AMPLIACIÓN]** En algunos casos, decorar A+B puede no dar lo mismo que B+A si cada decorador calcula sobre el resultado anterior.

### Conceptos asociados

- **OCP:** Open/Closed Principle / Principio Abierto/Cerrado.
- **SRP:** Single Responsibility Principle / Principio de Responsabilidad Única.

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

# 3. Patrones de comportamiento

> **[OFICIAL]**  
> Los patrones de comportamiento ofrecen estrategias de comunicación entre los objetos para que las responsabilidades sean llevadas a cabo de forma práctica y eficiente para el mantenimiento de código.

## Patrones de comportamiento vistos

- **Strategy**
- **Observer**
- **Chain of Responsibility**
- **Template Method**

## Patrón extra visto verbalmente

- **State** **[EXTRA]**

---

## 3.1 Strategy

### Propósito

> **[OFICIAL]**  
> _Strategy_ propone la composición como herramienta para que los objetos cambien su comportamiento según los criterios que el programador defina.

### Propósito reformulado

Definir una familia de algoritmos, encapsular cada uno y hacerlos intercambiables para que el contexto pueda variar su comportamiento sin modificarse.

### Aplicabilidad

1. Cuando se tienen varias variantes del mismo algoritmo.
2. Cuando se quiere evitar un `if` o `switch` grande para decidir comportamiento.
3. Cuando se necesita cambiar el algoritmo en tiempo de ejecución.
4. Cuando muchas clases relacionadas solo difieren en comportamiento.
5. Cuando se quiere probar cada algoritmo de manera aislada.

### Ventajas

1. Permite agregar nuevas estrategias sin tocar el contexto.
2. Separa el algoritmo del objeto que lo utiliza.
3. Elimina condicionales extensos.
4. Permite cambiar comportamiento en tiempo de ejecución.
5. Facilita pruebas aisladas de cada estrategia.

### Desventajas

1. Aumenta la cantidad de clases u objetos.
2. El cliente o el contexto debe elegir la estrategia adecuada.
3. Puede generar _overhead_ en la comunicación entre `Strategy` y _Context_.
4. Puede ser excesivo si solo hay una variante simple.

### Nota para parcial

Si el enunciado dice:

- “distintos algoritmos”
- “intercambiar comportamiento”
- “elegir estrategia”
- “QuickSort / ShellSort”
- “cambiar algoritmo en runtime”
- “evitar switch por tipo de algoritmo”

entonces puede estar apuntando a **Strategy**.

### Notas al pie del patrón

- **Context:**  
  Es la clase que usa la estrategia. No implementa directamente el algoritmo, sino que delega en un objeto Strategy.

- **Strategy:**  
  Es la interfaz o clase abstracta que define el comportamiento común de las estrategias concretas.

- **ConcreteStrategy:**  
  Es cada implementación concreta del algoritmo.

- **Runtime / tiempo de ejecución:**  
  **[AMPLIACIÓN]** Significa que el comportamiento puede cambiar mientras el programa corre.

- **Inyectar una estrategia:**  
  **[AMPLIACIÓN]** Significa pasarle al contexto qué estrategia debe usar, normalmente por constructor, setter o método.

- **Overhead:**  
  **[AMPLIACIÓN]** En Strategy, puede aparecer porque el contexto delega el trabajo en otro objeto en vez de resolverlo directamente.

### Conceptos asociados

- **OCP:** Open/Closed Principle / Principio Abierto/Cerrado.
- **SRP:** Single Responsibility Principle / Principio de Responsabilidad Única.
- **Polimorfismo:** varias clases responden de manera diferente ante un mismo llamado.

---

## 3.2 Observer

### Propósito

> **[OFICIAL]**
> Permitir que varios objetos puedan actuar en consecuencia cuando un tercero, el observado, adopta un determinado estado o realiza alguna acción específica.

### Propósito reformulado

Definir una dependencia _uno-a-muchos_ para que, al cambiar un objeto llamado _Subject_, todos sus dependientes llamados `Observers` sean notificados y actualizados automáticamente.

### Aplicabilidad

1. Cuando varias partes deben reaccionar ante un mismo evento o cambio de estado.
2. Cuando se quiere agregar o quitar suscriptores dinámicamente.
3. Cuando se busca desacoplar el emisor de los receptores.
4. Cuando el objeto observado debe notificar a varios interesados.

### Ventajas

1. Desacopla el emisor de los receptores.
2. Permite agregar nuevos observadores sin modificar el Subject.
3. Permite notificación automática ante cambios.
4. Sirve para sistemas de eventos.

### Desventajas

1. Puede ser más difícil seguir el flujo del programa.
2. El orden de notificación puede no ser evidente.
3. Puede producir efectos en cascada.
4. Puede haber referencias colgantes si no se desuscriben observadores.

### Nota para parcial

Si el enunciado dice:

- “uno a muchos”
- “suscriptores”
- “observadores”
- “notificar”
- “cuando cambia el sujeto”
- “attach / detach / notify”
- “update”

entonces puede estar apuntando a **Observer**.

### Notas al pie del patrón

- **Subject:**  
  Es el objeto observado. Guarda una lista de observadores y los notifica.

- **Observer:**  
  Es el objeto interesado en enterarse de los cambios del _Subject_.

- **attach:**  
  Método para suscribir un observador.

- **detach:**  
  Método para desuscribir un observador.

- **notify:**  
  Método que avisa a los observadores.

- **update:**  
  Método que ejecuta cada observador al ser notificado.

- **Event-driven:**  
  **[AMPLIACIÓN]** Significa “orientado a eventos”. El programa reacciona cuando algo ocurre.

- **Leak / fuga de memoria o referencia:**  
  **[AMPLIACIÓN]** Puede pasar si un observador queda suscripto aunque ya no debería estarlo. El _Subject_ conserva una referencia y eso puede causar problemas.

- **Efecto cascada:**  
  **[AMPLIACIÓN]** Ocurre cuando una notificación dispara otra, y esa dispara otra más.

### Conceptos asociados

- **OCP:** Open/Closed Principle / Principio Abierto/Cerrado.
- **Desacoplamiento:** el Subject no necesita conocer en detalle qué hace cada Observer.

---

## 3.3 Chain of Responsibility

### Propósito

> **[OFICIAL]**
> `Chain of Responsibility` es un “pasamanos” en el que las funciones se van pasando un mismo objeto y, aquella a la que le competa, realizará la acción que le corresponda.

### Propósito reformulado

Evitar acoplar el emisor de una solicitud con su receptor, encadenando manejadores que intentan procesar la solicitud uno por vez.

### Aplicabilidad

1. Cuando hay varios objetos posibles para manejar una solicitud.
2. Cuando no se quiere acoplar el cliente al receptor concreto.
3. Cuando se necesita una cadena de validaciones.
4. Cuando se trabaja con niveles de responsabilidad.
5. Cuando se modelan filtros, permisos, autorizaciones, middleware o cadenas de mando.

### Ventajas

1. Desacopla el cliente del receptor concreto.
2. Permite agregar, quitar o reordenar manejadores.
3. Cada eslabón tiene una responsabilidad puntual.
4. Permite reutilizar handlers en distintas cadenas.

### Desventajas

1. No garantiza que alguien procese la solicitud.
2. Puede ser difícil depurar el recorrido.
3. Si la cadena es larga, puede agregar latencia o complejidad.
4. Si la lógica de corte está mal diseñada, la solicitud puede circular de más o perderse.

### Nota para parcial

Si el enunciado dice:

- “cadena”
- “pasar la solicitud”
- “hasta que alguien la maneje”
- “sucesor”
- “handler”
- “cadena de mando”
- “validaciones secuenciales”
- “evitar acoplar emisor y receptor”

entonces puede estar apuntando a **Chain of Responsibility**.

### Notas al pie del patrón

- **Handler:**  
  Interfaz o clase abstracta que define el método para manejar la solicitud.

- **ConcreteHandler:**  
  Cada clase concreta que intenta resolver la solicitud o pasarla al siguiente.

- **Successor / sucesor:**  
  Es el siguiente eslabón de la cadena.

- **Middleware:**  
  **[AMPLIACIÓN]** Es una cadena de funciones intermedias que procesan una solicitud antes de llegar al destino final. Es común en servidores web.

- **Latencia:**  
  **[AMPLIACIÓN]** Es demora. En una cadena muy larga, la solicitud puede tardar más en resolverse.

### Conceptos asociados

- **OCP:** Open/Closed Principle / Principio Abierto/Cerrado.
- **Composición:** la cadena se arma mediante referencias entre objetos.

---

## 3.4 Template Method

### Propósito

> **[OFICIAL]**  
> Es útil cuando un proceso siempre requiere que se ejecuten los mismos pasos, pero admitiendo algunas variaciones en la implementación, todas ellas delegables a subclases.

### Propósito reformulado

Definir el esqueleto de un algoritmo en una operación, dejando que las subclases implementen ciertos pasos sin modificar la estructura general.

### Aplicabilidad

1. Cuando un proceso tiene siempre el mismo orden de pasos.
2. Cuando solo varían algunos pasos específicos.
3. Cuando se quiere evitar duplicar el flujo general en varias clases.
4. Cuando se quiere controlar desde una clase base el orden de ejecución.

### Ventajas

1. Reutiliza el flujo común.
2. Evita duplicación de código.
3. Asegura que todas las variantes respeten la misma estructura.
4. Permite definir hooks o pasos opcionales.

### Desventajas

1. Es menos flexible que _Strategy_ si se necesita cambiar todo el algoritmo en tiempo de ejecución.
2. Acopla por herencia.
3. Cambiar el orden general del proceso puede ser costoso.
4. Puede generar muchas subclases si hay muchas variantes.

### Nota para parcial

Si el enunciado dice:

- “mismos pasos”
- “estructura fija”
- “varían algunos pasos”
- “la clase base define el esqueleto”
- “las subclases implementan detalles”
- “templateMethod”
- “subMethod”

entonces puede estar apuntando a **Template Method**.

### Notas al pie del patrón

- **Template method:**  
  Es el método que define el esqueleto del algoritmo.

- **SubMethod / operación primitiva:**  
  Es el paso que implementan las subclases.

- **Hook:**  
  **[AMPLIACIÓN]** Es un método que puede tener comportamiento por defecto y que una subclase puede redefinir si lo necesita.

- **Pipeline:**  
  **[AMPLIACIÓN]** Es una secuencia fija de pasos. En `Template Method`, el _pipeline_ está definido en la clase base.

### Conceptos asociados

- **OCP:** Open/Closed Principle / Principio Abierto/Cerrado.
- **Herencia:** mecanismo central del patrón.
- **Reutilización:** la clase base concentra los pasos comunes.

---

## 3.5 State

> **[EXTRA / FUERA DEL APUNTE CENTRAL]**  
> Este patrón fue visto verbalmente o como complemento. No conviene priorizarlo por encima de los patrones centrales de la Unidad 4, salvo que el docente lo haya mencionado para el parcial.

### Propósito

Permitir que un objeto cambie su comportamiento cuando cambia su estado interno, delegando la lógica específica de cada estado en clases separadas.

La idea se relaciona con una máquina de estados finitos: el programa puede estar en un número finito de estados y comportarse distinto en cada uno.

### Aplicabilidad

1. Cuando un objeto se comporta distinto según su estado actual.
2. Cuando hay muchos estados o el código de esos estados cambia seguido.
3. Cuando una clase está llena de condicionales grandes que dependen del valor de campos internos.
4. Cuando hay código duplicado entre estados o transiciones parecidas.

### Ventajas

1. Separa el código de cada estado en clases distintas.
2. Permite agregar estados nuevos sin romper los existentes.
3. Simplifica el contexto al sacar los `if` o `switch` grandes de máquina de estados.

### Desventajas

1. Puede ser excesivo si la máquina de estados tiene pocos estados.
2. Agrega más clases.
3. Puede parecerse estructuralmente a `Strategy` y generar confusión.

### Nota para parcial

Si el enunciado dice:

- “el objeto cambia de comportamiento según su estado”
- “estado interno”
- “transiciones”
- “Ready / Playing / Locked”
- “máquina de estados”
- “evitar muchos if por estado”

entonces puede estar apuntando a **State**.

### Notas al pie del patrón

- **Estado interno:**  
  Es una condición actual del objeto que afecta cómo se comporta.

- **Transición:**  
  Cambio de un estado a otro.

- **Máquina de estados finitos:**  
  **[AMPLIACIÓN]** Modelo donde un objeto solo puede estar en uno de varios estados definidos y cambia de estado según ciertos eventos.

- **if/switch grandes:**  
  **[AMPLIACIÓN]** Muchas condiciones que revisan el estado actual del objeto. `State` busca reemplazar esa lógica por clases separadas.

### Conceptos asociados

- **SRP:** Single Responsibility Principle / Principio de Responsabilidad Única.
- **OCP:** Open/Closed Principle / Principio Abierto/Cerrado.

---

# 4. Patrones que suelen confundirse

| #   | Categoría                     | Patrones que se confunden                      | Por qué se confunden                                                 | Pregunta clave para decidir                                                                  | Elegiría...                                                                                                                                                  |
| --- | ----------------------------- | ---------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| A   | Creacionales                  | Factory Method vs Abstract Factory             | Ambos crean objetos y desacoplan al cliente de clases concretas.     | ¿Necesito crear un producto puntual o una familia de productos relacionados?                 | **Factory Method** si una subclase decide qué producto crear. Abstract Factory si creo familias compatibles.                                                 |
| B   | Creacionales                  | Builder vs Factory Method / Abstract Factory   | Todos participan en la creación de objetos.                          | ¿El problema es qué objeto crear o cómo construirlo paso a paso?                             | **Builder** si el objeto es complejo, con muchos pasos o configuraciones. **Factory / Abstract Factory** si el foco es elegir el tipo de objeto.             |
| C   | Estructurales                 | Adapter vs Decorator                           | Ambos pueden envolver un objeto.                                     | ¿Estoy adaptando una interfaz incompatible o agregando responsabilidades?                    | **Adapter** si traduzco una interfaz. **Decorator** si agrego funcionalidad manteniendo la interfaz.                                                         |
| D   | Estructurales                 | Composite vs Decorator                         | Ambos usan composición y pueden tener estructuras parecidas.         | ¿Estoy armando una estructura árbol parte-todo o agregando capas de funcionalidad?           | **Composite** si hay hojas y compuestos tratados uniformemente. **Decorator** si agrego extras dinámicamente.                                                |
| E   | Comportamiento vs Estructural | Chain of Responsibility vs Decorator           | Ambos pueden formar una cadena de objetos.                           | ¿La cadena decide quién atiende la solicitud o suma funcionalidades por capas?               | **Chain of Responsibility** si la solicitud pasa hasta que alguien la maneje. **Decorator** si cada capa agrega comportamiento.                              |
| F   | Comportamiento                | Template Method vs Strategy                    | Ambos resuelven variaciones de algoritmos.                           | ¿El algoritmo cambia completo en runtime o solo cambian pasos dentro de una estructura fija? | **Strategy** si quiero intercambiar algoritmos. **Template Method** si la estructura general es fija y varían pasos.                                         |
| G   | Comportamiento                | Observer vs Strategy / Chain of Responsibility | Puede confundirse cualquier comunicación entre objetos con Observer. | ¿Hay un objeto observado que notifica a varios suscriptores?                                 | **Observer** si hay relación uno-a-muchos con notificación. Strategy si se elige algoritmo. **Chain of Responsibility** si se pasa una solicitud por cadena. |
| H   | Estructurales                 | Facade vs interfaz gigante                     | Ambos pueden aparecer como una clase de acceso a muchas cosas.       | ¿La clase simplifica el subsistema o se volvió una mega-API?                                 | **Facade** si ofrece pocas operaciones claras. Si tiene demasiados métodos públicos, conviene dividir en varias fachadas.                                    |
| I   | Creacionales / Diseño         | Singleton vs Static / variables globales       | Ambos dan acceso global o centralizado.                              | ¿Necesito una única instancia controlada o solo funciones o valores de clase?                | **Singleton** si debe existir una única instancia. **Static** si no necesito instancia ni polimorfismo.                                                      |
| J   | Comportamiento                | State vs Strategy                              | Estructuralmente se parecen: contexto + objeto delegado.             | ¿Cambio la forma de hacer algo o el objeto cambia porque está en otro estado?                | **Strategy** si son distintas maneras de hacer. **State** si son distintas maneras de estar.                                                                 |

---

# 5. Reglas express para parcial

## 5.1 Por categoría

- Crear objetos → **Singleton / Factory Method / Abstract Factory / Builder**
- Organizar o envolver objetos → **Adapter / Composite / Decorator / Facade**
- Comunicación o comportamiento variable → **Strategy / Observer / Chain of Responsibility / Template Method**
- Estados internos del objeto → **State** **[EXTRA]**

---

## 5.2 Por palabras clave

| Palabra o idea del enunciado            | Patrón probable             |
| --------------------------------------- | --------------------------- |
| Única instancia / punto global          | **Singleton**               |
| Subclases deciden qué crear             | **Factory Method**          |
| Familias de productos relacionados      | **Abstract Factory**        |
| Construcción paso a paso                | **Builder**                 |
| Interfaz incompatible / sistema legado  | **Adapter**                 |
| Árbol / parte-todo / hojas y compuestos | **Composite**               |
| Agregar responsabilidades por capas     | **Decorator**               |
| Simplificar subsistema complejo         | **Facade**                  |
| Algoritmos intercambiables              | **Strategy**                |
| Uno-a-muchos / notificar suscriptores   | **Observer**                |
| Cadena de handlers / pasamanos          | **Chain of Responsibility** |
| Estructura fija con pasos variables     | **Template Method**         |
| Comportamiento según estado interno     | **State**                   |

---

# 6. Glosario de conceptos ampliados

## Mockear

**[AMPLIACIÓN]**  
Mockear es simular un objeto real con uno falso para poder probar una parte del sistema sin depender de componentes externos.

Ejemplo simple:

- En vez de consultar una base de datos real, uso un objeto falso que devuelve datos ya preparados.
- En vez de usar un servicio real de pagos, uso un objeto falso que responde “pago aprobado”.

Sirve mucho para pruebas.

---

## Overhead

**[AMPLIACIÓN]**  
Overhead es el costo extra que aparece por agregar una capa, una abstracción o una delegación.

Puede ser:

- más memoria;
- más objetos;
- más llamadas entre clases;
- más complejidad de lectura;
- más mantenimiento.

No siempre es malo. A veces se acepta ese costo para lograr flexibilidad, reutilización o desacoplamiento.

---

## Runtime

**[AMPLIACIÓN]**  
Runtime significa “tiempo de ejecución”, es decir, mientras el programa está corriendo.

Ejemplo:

- En Strategy, puedo cambiar el algoritmo durante la ejecución.
- En Decorator, puedo agregar nuevas capas durante la ejecución.
- En State, el objeto puede cambiar su comportamiento al cambiar su estado interno.

---

## API

**[AMPLIACIÓN]**  
API es una interfaz de comunicación. En Programación II puede entenderse como el conjunto de métodos o servicios que una clase, módulo o sistema ofrece para ser usado por otros.

---

## God object

**[AMPLIACIÓN]**  
Un God object es una clase que hace demasiado. Suele tener muchas responsabilidades, muchos métodos y mucho conocimiento del sistema.

Es una señal de mal diseño porque rompe la separación de responsabilidades.

---

## Leak

**[AMPLIACIÓN]**  
Leak significa fuga. En Observer, puede pasar si un observador queda suscripto cuando ya no debería estarlo. El Subject sigue guardando su referencia y eso puede traer problemas.

---

## Middleware

**[AMPLIACIÓN]**  
Middleware es una capa intermedia que procesa una solicitud antes de llegar al destino final. Se parece mucho a Chain of Responsibility cuando una request pasa por varios handlers.

---

## Hook

**[AMPLIACIÓN]**  
Un hook es un método que permite personalizar una parte de un algoritmo. En Template Method, un hook puede tener comportamiento por defecto y una subclase puede redefinirlo si lo necesita.

---

# 7. Cierre para estudio intensivo

## Lista oficial principal

1. Singleton
2. Factory Method
3. Abstract Factory
4. Builder
5. Adapter
6. Composite
7. Decorator
8. Facade
9. Strategy
10. Observer
11. Chain of Responsibility
12. Template Method

## Extra visto verbalmente

13. State

## Prioridad para parcial

1. Saber reconocer el patrón por el enunciado.
2. Saber justificar por qué aplica.
3. Saber diferenciarlo de patrones parecidos.
4. Saber ubicarlo en su categoría.
5. Saber explicar qué principio SOLID favorece o puede complicar.
