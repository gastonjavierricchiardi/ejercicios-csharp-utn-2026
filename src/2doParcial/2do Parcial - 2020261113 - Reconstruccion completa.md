# 2do Parcial — Programación II — C# 2026

**Reconstrucción completa de las 17 preguntas del examen del 13/11/2026**  
**Estado del documento:** RECONSTRUIDO / VERIFICADO CONTRA MATERIAL DE CÁTEDRA; no es una exportación oficial del intento corregido de Moodle.  
**Versión:** 1.0 — 14/11/2026

## 0. Alcance, procedencia y criterios

- **Base documental:** captura de «2do Parcial» compartida en el chat, PDF de la sección **Parciales** de Moodle y el intercambio completo de preguntas, desplegables y UML desarrollado durante el intento.
- **Importante sobre el PDF recibido:** `screencapture-tup-utnba-centrodeelearning-course-section-php-2026-11-13-17_33_49_ocred.pdf` muestra la sección del curso y las reglas generales (página 1); **no contiene el detalle de las 17 preguntas ni su revisión**. Por eso, los enunciados, opciones y bloques se reconstruyen desde los mensajes e imágenes de esta conversación.
- **Respuestas:** corresponden a las resoluciones seleccionadas/validadas durante esta conversación, contrastadas con los apuntes 2026. La calificación **10/10 fue informada posteriormente por el estudiante**, pero no está visible en las capturas suministradas para esta reconstrucción. Por tanto, la calificación global **no sustituye** a una corrección oficial pregunta por pregunta.
- **UML:** los PNG/SVG adjuntos son **redibujos fieles en contenido y distribución general**, no copias digitales de los PNG originales mostrados en Moodle. Se han mantenido los cinco espacios vacíos de cada diagrama, los elementos fijos y las relaciones relevantes. La tipografía especial de cada bloque (normal/cursiva) no puede certificarse exactamente a partir de la transcripción de esta conversación: consultar la captura original para diferencias tipográficas finas.
- **Desplegables:** cada pregunta conserva las opciones presentadas, incluso cuando varias listas son idénticas; el marcador `[n]` indica el espacio correspondiente.
- **Criterio de cátedra:** para la preparación del examen se prioriza el material oficial **C# 2026**. Las discrepancias conceptuales se registran, nunca se corrigen silenciosamente en el texto de la consigna.

## 1. Condiciones de evaluación

| Dato | Valor |
|---|---|
| Apertura | Viernes 13/11/2026, 18:00 |
| Cierre | Viernes 13/11/2026, 22:00 |
| Preguntas cortas | 14 |
| Diagramas UML a completar | 3 |
| Total | **17** |
| Intentos permitidos | 1 |
| Duración máxima | **45 minutos** |
| Calificación para aprobar | **6,00/10,00** (60 %) |
| Navegación | Irreversible; sin posibilidad de modificar respuestas enviadas |
| Requisito de acceso | Haber aprobado el primer parcial o su recuperatorio |

### Leer atentamente — reglas publicadas

- Vas a encontrar **14 preguntas cortas y de resolución rápida y 3 diagramas a completar**.
- ⏱️ Tenés un **tiempo máximo asignado** para completarlas y la **hora tope para enviar las respuestas es 22.00hs**.
- ✅ Necesitás tener al menos el **60% correcto** para aprobar esta parte.
- 🚫 **No podés volver atrás en las preguntas ni cambiar respuestas ya enviadas.**
- Si llegás a tener algún inconveniente podes ingresar al [Zoom habilitado](https://tup.utnba.centrodeelearning.com/mod/zoomutnba/view.php?id=8214) para que algún profe/tutor te asista.
- Sólo podrán rendir este parcial quienes hayan **aprobado el 1er parcial o su recuperatorio**.

### Registro del intento (captura de Moodle)

| Campo | Valor |
|---|---|
| Intento | 1 |
| Estado | Finalizado |
| Comenzado | Viernes 13/11/2026, 18:18 |
| Completado | Viernes 13/11/2026, 18:47 |
| Duración que informa Moodle | **29 minutos 22 segundos** |
| Disponibilidad de revisión indicada | 13/11/2026, 22:00 |
| Más intentos | No permitidos |

---

## 2. Preguntas y resoluciones

### Pregunta 1 — Memoria: heap, stack y política de gestión

**Tipo:** completar tres espacios mediante desplegables.

**Enunciado reconstruido:**

> Completá cada espacio eligiendo la opción correcta de la lista desplegable.  
> Las estructuras de datos dinámicas se alojan en el segmento de memoria llamado **[1]**. Las llamadas a funciones, con sus parámetros y variables locales, se apilan en el **[2]** que el sistema operativo maneja con una política **[3]**.

**Opciones de los desplegables** (la misma lista apareció en los tres):

| Orden | Opción |
|---:|---|
| 1 | `stack` |
| 2 | `LIFO` |
| 3 | `segmento de código` |
| 4 | `heap` |
| 5 | `FIFO` |
| 6 | `sin política fija` |

**Resolución:**

| Espacio | Respuesta |
|---|---|
| [1] | **heap** |
| [2] | **stack** |
| [3] | **LIFO** |

**Fundamento breve:** las estructuras dinámicas utilizan el heap; el stack apila llamadas a funciones y se administra siguiendo el orden último en entrar, primero en salir.  
**Fuente:** `20 Programación II- Unidad 3 Estructuras de datos.pdf`, p. **68**.  
**Estado:** VALIDADA contra el apunte.

---

### Pregunta 2 — SOLID: segregación de interfaces

**Enunciado:**

> En el ejemplo de segregación de interfaces del apunte, BookPrinter implementa solo IBookPrinter, mientras que PaperBookPrinter implementa IBookPrinter e IPaperBookPrinter. ¿Qué se logra con esa división?

**Opciones:**

a. Que PaperBookPrinter no pueda imprimir sin papel  
b. Que BookPrinter no esté obligada a implementar HasPaper, un método que no necesita  
c. Que las dos impresoras hereden de una misma clase base  
d. Que BookPrinter pueda reemplazar a PaperBookPrinter en cualquier contexto

**Respuesta seleccionada:** **b.** Que `BookPrinter` no esté obligada a implementar `HasPaper`, un método que no necesita.

**Fundamento breve:** el ISP propone interfaces específicas para evitar exigir operaciones ajenas a una clase.  
**Fuente:** `16 Programación II- Unidad 2 Principios S.O.L.I.D.pdf`, apartados *Interface Segregation*, ejemplo 42.6, pp. **63–64** aproximadamente; la sección comienza en la p. 63 y el código de ejemplo en la siguiente página según el diseño del PDF.  
**Estado:** VALIDADA contra el apunte.

---

### Pregunta 3 — UML con bloques: armado de computadoras

**Tipo:** diagrama de clases UML con **cinco espacios vacíos** y bloques arrastrables.

**Enunciado:**

> Una casa de computación arma equipos paso a paso: procesador, memoria y, opcionalmente, placa de video. Ofrece configuraciones predefinidas (oficina y gamer) que siempre se arman con los mismos pasos en el mismo orden; la clase que conoce esas configuraciones no debe depender de un constructor concreto. Al terminar, el constructor entrega la computadora armada.
>
> Arrastrá cada bloque al recuadro punteado que corresponde. Prestá atención a la tipografía: hay bloques con el mismo texto en letra normal y en cursiva. No se usan todos los bloques.

**Esqueleto UML** (redibujado desde la captura del chat, con los espacios sin resolver):

![Pregunta 3: esqueleto UML Builder reconstruido](Parcial_2_2026_assets/uml_03_builder_esqueleto_reconstruido.png)

**Todos los bloques disponibles en la captura (en orden):**

| Orden | Bloque |
|---:|---|
| 1 | `Director` |
| 2 | `IFabricaPc` |
| 3 | `Abstract Factory` |
| 4 | `-builder: IBuilderPc` |
| 5 | `+ObtenerResultado(): Computadora` |
| 6 | `Facade` |
| 7 | `-builder: BuilderPc` |
| 8 | `Cliente` |
| 9 | `Builder` |
| 10 | `+ObtenerResultado(): void` |
| 11 | `IBuilderPc` |

**Asignación de espacios:**

| Posición | Ubicación del diagrama | Bloque correcto |
|---:|---|---|
| [1] | Patrón | **Builder** |
| [2] | Nombre de la clase superior izquierda | **Director** |
| [3] | Atributo de `Director` | **`-builder: IBuilderPc`** |
| [4] | Nombre de la interfaz superior derecha | **IBuilderPc** |
| [5] | Último método de `BuilderPc` | **`+ObtenerResultado(): Computadora`** |

**Bloques no utilizados:** `IFabricaPc`, `Abstract Factory`, `Facade`, `-builder: BuilderPc`, `Cliente`, `+ObtenerResultado(): void`.

**Fundamento breve:** `Director` define secuencias de armado y depende de `IBuilderPc`; `BuilderPc` implementa esa interfaz, construye el producto y devuelve una `Computadora`.  
**Fuente:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, pp. **76–77**, *Builder*.  
**Estado:** VALIDADA contra el modelo del patrón y la captura.  
**Nota:** la versión editable del esqueleto está en `Parcial_2_2026_assets/uml_03_builder_esqueleto_reconstruido.svg`.

---

### Pregunta 4 — Aplicabilidad de Builder

**Enunciado:**

> Según el apunte, ¿en qué situaciones es aplicable el patrón Builder?

**Opciones:**

a. Para garantizar que exista una única instancia de un objeto complejo  
b. Para notificar a varios objetos cuando cambia el estado de otro  
c. Para evitar constructores complejos con muchos parámetros y para crear distintas representaciones de ciertos objetos  
d. Para unificar bajo una interfaz común objetos con funciones distintas

**Respuesta seleccionada:** **c.** Para evitar constructores complejos con muchos parámetros y para crear distintas representaciones de ciertos objetos.

**Fundamento breve:** Builder separa y organiza la construcción de objetos complejos paso a paso.  
**Fuente:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, p. **77**, tabla *Builder — Aplicabilidad*.  
**Estado:** VALIDADA contra el apunte.

---

### Pregunta 5 — Colas: uso de los punteros first y last

**Enunciado:**

> ¿Por qué la cola del apunte mantiene dos punteros, uno al frente y otro al final?

**Opciones:**

a. Para mantener los elementos ordenados  
b. Para poder recorrerla en ambos sentidos  
c. Para que la lectura no sea destructiva  
d. Para insertar por el final y extraer por el frente sin tener que recorrer la estructura

**Respuesta seleccionada:** **d.** Para insertar por el final y extraer por el frente sin tener que recorrer la estructura.

**Fundamento breve:** `first` referencia el frente desde el que se extrae; `last`, el final donde se inserta.  
**Fuentes:** `20 Programación II- Unidad 3 Estructuras de datos.pdf`, pp. **74–75**; `20 Estructuras - Pilas y Colas.pdf`, diapositivas **10–11**.  
**Estado:** VALIDADA contra el apunte.

---

### Pregunta 6 — Familias de patrones de diseño

**Tipo:** completar tres espacios mediante desplegables.

**Enunciado reconstruido:**

> Según el apunte, los patrones creacionales son estrategias para **[1]**; los de comportamiento se focalizan en **[2]**; y los estructurales abordan **[3]**.

**Opciones de los tres desplegables** (lista idéntica en cada uno):

| Orden | Opción |
|---:|---|
| 1 | la persistencia de objetos |
| 2 | la creación de objetos |
| 3 | la relación entre los objetos |
| 4 | la comunicación entre objetos |
| 5 | la herencia entre clases |

**Resolución:**

| Espacio | Respuesta |
|---|---|
| [1] | **la creación de objetos** |
| [2] | **la comunicación entre objetos** |
| [3] | **la relación entre los objetos** |

**Fundamento breve:** coincide con las tres familias descriptas en el apunte de patrones.  
**Fuente:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, p. **72**.  
**Estado:** VALIDADA contra el apunte.

---

### Pregunta 7 — Identificación del patrón Factory Method

**Enunciado:**

> Entre los patrones vistos en la cátedra, ¿cuál resuelve mejor la siguiente situación?
>
> Una herramienta de oficina tiene una clase abstracta Aplicacion que abre, guarda y cierra documentos. Cada aplicación concreta, como el editor de textos o la planilla de cálculo, decide qué tipo de documento crear, pero todos respetan la interfaz IDocumento.

**Opciones:**

a. Builder  
b. Prototype  
c. Abstract Factory  
d. Factory Method

**Respuesta seleccionada:** **d. Factory Method**.

**Fundamento breve:** cada clase concreta decide qué producto crear bajo el contrato `IDocumento`, mientras la aplicación base conserva las operaciones generales.  
**Fuente:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, p. **74**, *Factory Method*.  
**Estado:** VALIDADA contra el apunte.

---

### Pregunta 8 — UML con bloques: menú y submenús

**Tipo:** diagrama de clases UML con **cinco espacios vacíos** y bloques arrastrables.

**Enunciado:**

> Una aplicación tiene un menú con opciones y submenús; cada submenú puede contener opciones y otros submenús. Cualquier elemento del menú se muestra de la misma forma, y un submenú se muestra junto con todo lo que contiene. Las opciones son terminales: no contienen otros elementos.
>
> Arrastrá cada bloque al recuadro punteado que corresponde. Prestá atención a la tipografía: hay bloques con el mismo texto en letra normal y en cursiva. No se usan todos los bloques.

**Esqueleto UML** (redibujado desde la captura del chat, con los espacios sin resolver):

![Pregunta 8: esqueleto UML Composite reconstruido](Parcial_2_2026_assets/uml_08_composite_esqueleto_reconstruido.png)

**Todos los bloques disponibles (orden mostrado en la captura):**

| Orden | Bloque |
|---:|---|
| 1 | `Composite` |
| 2 | `MenuPrincipal` |
| 3 | `SubMenu` |
| 4 | `Decorator` |
| 5 | `OpcionMenu` |
| 6 | `IElementoMenu` |
| 7 | `-elementos: List<IElementoMenu>` |
| 8 | `-elementos: List<OpcionMenu>` |
| 9 | `Iterator` |
| 10 | `IOpcion` |
| 11 | `-elemento: IElementoMenu` |

**Asignación de espacios:**

| Posición | Ubicación del diagrama | Bloque correcto |
|---:|---|---|
| [1] | Patrón | **Composite** |
| [2] | Nombre de la interfaz superior | **IElementoMenu** |
| [3] | Nombre de la clase inferior izquierda | **OpcionMenu** |
| [4] | Nombre de la clase inferior derecha | **SubMenu** |
| [5] | Atributo en `SubMenu` | **`-elementos: List<IElementoMenu>`** |

**Bloques no utilizados:** `MenuPrincipal`, `Decorator`, `-elementos: List<OpcionMenu>`, `Iterator`, `IOpcion`, `-elemento: IElementoMenu`.

**Fundamento breve:** `OpcionMenu` es una hoja; `SubMenu` puede contener una lista de `IElementoMenu`, lo que permite incluir tanto hojas como submenús (estructura recursiva).  
**Fuentes:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, p. **79**; `22 Patrones de Diseño.pdf`, pp. **34–41**, *Composite*.  
**Estado:** VALIDADA contra los apuntes y la captura.  
**Nota:** la versión SVG está en `Parcial_2_2026_assets/uml_08_composite_esqueleto_reconstruido.svg`.

---

### Pregunta 9 — Comportamiento intercambiable: Strategy vs. State

**Tipo:** un desplegable.

**Enunciado:**

> Leé la situación y elegí, de la lista desplegable, el patrón visto en la cátedra que mejor la resuelve.
>
> Un reproductor de música tiene un único botón Play. Si está detenido, empieza a reproducir; si está reproduciendo, pausa; si está en pausa, retoma. El reproductor tiene que cambiar de comportamiento durante la ejecución, y se quiere evitar una cadena de if delegando el comportamiento en un objeto intercambiable con una interfaz común.
>
> Patrón: **[1]**

**Opciones del desplegable:**

| Orden | Opción |
|---:|---|
| 1 | Strategy |
| 2 | State |
| 3 | Factory Method |
| 4 | Template Method |
| 5 | Abstract Factory |
| 6 | Command |
| 7 | Singleton |
| 8 | Observer |

**Respuesta seleccionada para el parcial:** **Strategy**.

**Fundamento y discrepancia documentada:** la consigna pide expresamente un patrón **visto en la cátedra**; las fuentes de 2026 describen `Strategy` como un mecanismo para encapsular comportamientos intercambiables, variar su uso en ejecución y evitar condicionales. `State`, también presente como opción en Moodle, describiría de forma más específica las transiciones entre detenido/reproduciendo/pausado, pero **no se incluyó entre los patrones estudiados en los materiales 2026 del proyecto**. Durante el intento se detectó esta diferencia y se revisó la respuesta; la elección final fue `Strategy`.

**Fuentes:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, p. **81**; `22 Patrones de Diseño.pdf`, pp. **53–59**, *Strategy*.  
**Estado:** VALIDADA para el marco de la cátedra 2026; **discrepancia técnica explícita** respecto de State. No confundir con un fallo de transcripción.

---

### Pregunta 10 — SOLID: inversión de dependencias (DIP)

**Enunciado:**

> Según el apunte, ¿cuál es la ventaja de aplicar el principio de inversión de dependencias?

**Opciones:**

a. Se garantiza que cada clase tenga una única instancia  
b. Se oculta la implementación real de una clase a la que la usa: si la primera cambia, la segunda no necesita modificarse  
c. Se permite que una subclase cambie el comportamiento de su clase base  
d. Se evita tener que declarar interfaces

**Respuesta seleccionada:** **b.** Se oculta la implementación real de una clase a la que la usa: si la primera cambia, la segunda no necesita modificarse.

**Fundamento breve:** depender de abstracciones reduce el acoplamiento del código cliente con implementaciones concretas.  
**Fuente:** `16 Programación II- Unidad 2 Principios S.O.L.I.D.pdf`, *Dependency Inversion*, pp. **64–65** aproximadamente.  
**Estado:** VALIDADA contra el apunte.

---

### Pregunta 11 — Cadena de verificaciones de un préstamo

**Enunciado:**

> Entre los patrones vistos en la cátedra, ¿cuál resuelve mejor la siguiente situación?
>
> Una solicitud de préstamo pasa por una serie de verificaciones: datos personales, historial crediticio y límite de endeudamiento. La solicitud pasa de una verificación a la siguiente, cualquiera puede rechazarla y deben poder agregarse verificaciones nuevas sin modificar las existentes.

**Opciones:**

a. Observer  
b. Builder  
c. Chain of Responsibility  
d. Template Method

**Respuesta seleccionada:** **c. Chain of Responsibility**.

**Fundamento breve:** cada manejador puede procesar/rechazar la solicitud o delegarla al siguiente de la cadena, que se puede extender agregando eslabones.  
**Fuente:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, p. **83**, *Chain of Responsibility*.  
**Estado:** VALIDADA contra el apunte.

---

### Pregunta 12 — UML con bloques: familias de muebles

**Tipo:** diagrama de clases UML con **cinco espacios vacíos** y bloques arrastrables.

**Enunciado:**

> Una mueblería vende líneas de estilo moderno y de estilo clásico. Cuando el cliente elige un estilo, la silla y la mesa que se le ofrecen tienen que ser del mismo estilo; nunca se combinan piezas de estilos distintos. El código cliente trabaja solo con interfaces y no conoce las clases concretas de los muebles.
>
> Arrastrá cada bloque al recuadro punteado que corresponde. Prestá atención a la tipografía: hay bloques con el mismo texto en letra normal y en cursiva. No se usan todos los bloques.

**Esqueleto UML** (redibujado desde la captura del chat, con los espacios sin resolver):

![Pregunta 12: esqueleto UML Abstract Factory reconstruido](Parcial_2_2026_assets/uml_12_abstract_factory_esqueleto_reconstruido.png)

**Todos los bloques disponibles (orden mostrado en la captura):**

| Orden | Bloque |
|---:|---|
| 1 | `SillaModerna` |
| 2 | `MesaModerna` |
| 3 | `IFabricaMuebles` |
| 4 | `Abstract Factory` |
| 5 | `Factory Method` |
| 6 | `IFabricaSillas` |
| 7 | `Builder` |
| 8 | `+CrearSilla(): SillaModerna` |
| 9 | `MesaClasica` |
| 10 | `SillaClasica` |
| 11 | `+CrearSilla(): ISilla` |

**Asignación de espacios:**

| Posición | Ubicación del diagrama | Bloque correcto |
|---:|---|---|
| [1] | Patrón | **Abstract Factory** |
| [2] | Nombre de la interfaz superior | **IFabricaMuebles** |
| [3] | Método faltante de la interfaz | **`+CrearSilla(): ISilla`** |
| [4] | Clase producto inferior izquierda (implementa `ISilla`) | **SillaModerna** |
| [5] | Clase producto inferior derecha (implementa `IMesa`) | **MesaModerna** |

**Bloques no utilizados:** `Factory Method`, `IFabricaSillas`, `Builder`, `+CrearSilla(): SillaModerna`, `MesaClasica`, `SillaClasica`.

**Fundamento breve:** `IFabricaMuebles` define los métodos que producen las interfaces de producto `ISilla` e `IMesa`; cada fábrica concreta entrega la familia coherente de un estilo.  
**Fuente:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, pp. **75–76**, *Abstract Factory*.  
**Estado:** VALIDADA contra el apunte y la captura.  
**Nota:** la versión SVG está en `Parcial_2_2026_assets/uml_12_abstract_factory_esqueleto_reconstruido.svg`.

---

### Pregunta 13 — Notificadores y creación de mensajes

**Tipo:** un desplegable.

**Enunciado:**

> Leé la situación y elegí, de la lista desplegable, el patrón visto en la cátedra que mejor la resuelve.
>
> La clase abstracta Notificador tiene el método Enviar, que arma y despacha un mensaje. El notificador por correo debe usar un mensaje de correo y el notificador por SMS, un mensaje de texto; ambos mensajes implementan IMensaje. Se van a agregar notificadores nuevos sin modificar Enviar.
>
> Patrón: **[1]**

**Opciones del desplegable:**

| Orden | Opción |
|---:|---|
| 1 | Factory Method |
| 2 | Strategy |
| 3 | Builder |
| 4 | Template Method |
| 5 | Prototype |
| 6 | Adapter |
| 7 | Abstract Factory |
| 8 | Singleton |

**Respuesta seleccionada:** **Factory Method**.

**Fundamento breve:** una clase abstracta define el flujo general (`Enviar`) y las subclases deciden el producto concreto (`IMensaje`) a crear.  
**Fuente:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, p. **74**, *Factory Method*.  
**Estado:** VALIDADA contra el apunte.

---

### Pregunta 14 — Singleton frente a funciones estáticas

**Enunciado:**

> Según el apunte, ¿qué ventaja tiene un Singleton frente a una clase con funciones estáticas?

**Opciones:**

a. No necesita tratamiento especial en entornos con múltiples hilos  
b. Respeta mejor el principio de responsabilidad única  
c. Es más plástico: puede ser extendido y sus métodos sobreescritos  
d. Consume menos memoria porque no crea ningún objeto

**Respuesta seleccionada:** **c.** Es más plástico: puede ser extendido y sus métodos sobreescritos.

**Fundamento breve:** una instancia de Singleton puede participar en herencia y polimorfismo; una función estática no se sobreescribe de la misma manera.  
**Fuente:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, p. **73**, *Singleton*.  
**Estado:** VALIDADA contra el apunte.

---

### Pregunta 15 — Cine en casa y Facade

**Tipo:** completar **dos desplegables**.

**Enunciado:**

> Leé la situación y elegí, de la lista desplegable, el patrón visto en la cátedra que mejor la resuelve.
>
> Para ver una película en un sistema de cine en casa hay que encender el proyector, bajar la pantalla, encender el receptor, elegir la entrada de audio, atenuar las luces e iniciar el reproductor. Se quiere ofrecer una única operación MirarPelicula() que haga todo eso, sin que quien la usa conozca cada aparato.
>
> Patrón: **[1]**  
> Familia del patrón: **[2]**

**Opciones del primer desplegable (Patrón):**

| Orden | Opción |
|---:|---|
| 1 | Factory Method |
| 2 | Singleton |
| 3 | Composite |
| 4 | Mediator |
| 5 | Abstract Factory |
| 6 | Facade |
| 7 | Adapter |
| 8 | Command |

**Opciones del segundo desplegable (Familia):**

| Orden | Opción |
|---:|---|
| 1 | Estructural |
| 2 | De comportamiento |
| 3 | Creacional |

**Resolución:**

| Espacio | Respuesta |
|---|---|
| [1] | **Facade** |
| [2] | **Estructural** |

**Fundamento breve:** la fachada ofrece una operación unificada de alto nivel que oculta la coordinación interna del subsistema.  
**Fuentes:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, p. **80**; `22 Patrones de Diseño.pdf`, pp. **62–68**, *Facade*.  
**Estado:** VALIDADA contra los apuntes.

---

### Pregunta 16 — Mueblería y familias de productos

**Tipo:** un desplegable (el enunciado y las opciones fueron recibidos en mensajes separados).

**Enunciado:**

> Leé la situación y elegí, de la lista desplegable, el patrón visto en la cátedra que mejor la resuelve.
>
> Una mueblería virtual vende líneas de muebles de estilo moderno y de estilo clásico. Cuando el cliente elige un estilo, la silla, la mesa y el sofá que se le muestran tienen que ser todos de ese mismo estilo; nunca se combinan piezas de estilos distintos.
>
> Patrón: **[1]**

**Opciones del desplegable:**

| Orden | Opción |
|---:|---|
| 1 | Abstract Factory |
| 2 | Composite |
| 3 | Decorator |
| 4 | Factory Method |
| 5 | Bridge |
| 6 | Singleton |
| 7 | Adapter |
| 8 | Builder |

**Respuesta seleccionada:** **Abstract Factory**.

**Fundamento breve:** permite producir conjuntos compatibles de productos relacionados (silla, mesa, sofá) para cada estilo sin mezclar familias.  
**Fuente:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, pp. **75–76**, *Abstract Factory*.  
**Estado:** VALIDADA contra el apunte.

---

### Pregunta 17 — Observer: métodos de Subject

**Enunciado:**

> En el Observer del apunte, ¿qué métodos obliga a implementar la interfaz Subject?

**Opciones:**

a. `update()`  
b. `subscribe()`, `publish()` y `handleRequest()`  
c. `add()`, `remove()` y `getChild()`  
d. `attach()`, `detach()` y `notify()`

**Respuesta seleccionada:** **d.** `attach()`, `detach()` y `notify()`.

**Fundamento breve:** `Subject` administra observadores mediante alta, baja y notificación; la operación `update()` corresponde a `Observer`.  
**Fuente:** `22 Programación II- Unidad 4 Patrones de diseño.pdf`, p. **82**, *Observer*.  
**Estado:** VALIDADA contra el apunte.

---

## 3. Matriz de resoluciones

| Pregunta | Tipo | Resultado reconstruido | Referencia principal |
|---:|---|---|---|
| 1 | Desplegables (3) | `heap` / `stack` / `LIFO` | Unidad 3, p. 68 |
| 2 | Opción múltiple | b — ISP / `HasPaper` | Unidad 2, ISP |
| 3 | UML (5 espacios) | Builder / Director / `-builder: IBuilderPc` / IBuilderPc / `+ObtenerResultado(): Computadora` | Unidad 4, pp. 76–77 |
| 4 | Opción múltiple | c — Builder | Unidad 4, p. 77 |
| 5 | Opción múltiple | d — `first` y `last` | Unidad 3, pp. 74–75 |
| 6 | Desplegables (3) | creación / comunicación / relación entre objetos | Unidad 4, p. 72 |
| 7 | Opción múltiple | d — Factory Method | Unidad 4, p. 74 |
| 8 | UML (5 espacios) | Composite / IElementoMenu / OpcionMenu / SubMenu / `List<IElementoMenu>` | Unidad 4, p. 79 |
| 9 | Desplegable (1) | Strategy — con discrepancia State | Unidad 4, p. 81 |
| 10 | Opción múltiple | b — DIP | Unidad 2, DIP |
| 11 | Opción múltiple | c — Chain of Responsibility | Unidad 4, p. 83 |
| 12 | UML (5 espacios) | Abstract Factory / IFabricaMuebles / `+CrearSilla(): ISilla` / SillaModerna / MesaModerna | Unidad 4, pp. 75–76 |
| 13 | Desplegable (1) | Factory Method | Unidad 4, p. 74 |
| 14 | Opción múltiple | c — Singleton | Unidad 4, p. 73 |
| 15 | Desplegables (2) | Facade / Estructural | Unidad 4, p. 80 |
| 16 | Desplegable (1) | Abstract Factory | Unidad 4, pp. 75–76 |
| 17 | Opción múltiple | d — `attach()`, `detach()`, `notify()` | Unidad 4, p. 82 |

**Control de integridad:** 17 preguntas; 14 preguntas cortas y 3 UML; UML 3 + 8 + 12; cada UML contiene cinco espacios; los desplegables múltiples se preservan explícitamente; no se declara ninguna corrección individual de Moodle que no se haya podido observar.

## 4. Fuentes conservadas para futuras verificaciones

1. `16 Programación II- Unidad 2 Principios S.O.L.I.D.pdf` (especialmente ISP y DIP).
2. `20 Programación II- Unidad 3 Estructuras de datos.pdf` (memoria, pila, cola).
3. `20 Estructuras - Pilas y Colas.pdf` (material visual de estructuras).
4. `22 Programación II- Unidad 4 Patrones de diseño.pdf` (patrones de diseño del programa 2026).
5. `22 Patrones de Diseño.pdf` (ampliación visual y conceptual).
6. Captura de «2do Parcial» y PDF de la sección «Parciales» de Moodle.
7. Conversación de resolución del segundo parcial (13–14/11/2026).

**Nota editorial final:** esta reconstrucción está preparada para estudiar, archivar y revisar el parcial. Si se dispone luego del informe de revisión con la corrección oficial de Moodle, se podrá añadir una columna **«Respuesta oficial / puntaje por ítem»**, sin alterar el registro original reconstruido.
