# Protocolo para detectar patrones de diseño — Programación II · C# · 2026

> **Estado: VALIDADO COMO PROTOCOLO DE TRABAJO (2026).**
>
> **Objetivo:** analizar consignas de ejercicios o parciales y **proponer, contrastar y justificar** patrones, sin elegirlos automáticamente por palabras clave.
>
> **Fuentes de referencia:** `22 Programación II- Unidad 4 Patrones de diseño.pdf` (material oficial), material de clases 2026 y apuntes revisados `01.Patrones de Disenio`, `02.Solo diferencias de Patrones de disenio` y `03.Mapa Mental de Patrones de disenio`.
>
> **Alcance:** los **12 patrones del PDF oficial**. Su inclusión en ese PDF no implica que todos hayan sido desarrollados en clase. En las clases registradas hasta el **23/10/2026** se trabajaron conceptualmente los cuatro creacionales; para el resto, el desarrollo docente sigue **PENDIENTE de validar** con las clases posteriores. `State` no forma parte de la lista de este PDF y no se utiliza como opción oficial en este protocolo.

---

## Regla central

**No busques “palabras mágicas”: buscá problemas de diseño.** Una palabra del enunciado es una *pista*, no una prueba. Un patrón se justifica por la necesidad que resuelve y por las responsabilidades y relaciones entre objetos.

**Orden obligatorio:** **1. Detectar → 2. Contrastar → 3. Justificar.**

Si no hay evidencia suficiente, registrar **PENDIENTE**. Si una solución simple satisface la consigna sin introducir un patrón, **no forzarlo**.

---

## PASO 1 — DETECTAR: ¿qué problema plantea la consigna?

Primero, separar **lo que el enunciado exige** de **la solución que imaginamos**. Identificar los objetos y las operaciones relevantes, sin definir todavía clases de patrones.

| Qué busco | Pregunta mental | Pista típica (no concluyente) |
| --- | --- | --- |
| **Estructura** | ¿Hay objetos simples y compuestos que deban tratarse de manera uniforme? | Menú con submenús; itinerarios que contienen otros itinerarios |
| **Comportamiento variable** | ¿Hay distintas formas de realizar una operación? ¿Deben intercambiarse? | Calcular costos mediante distintas políticas |
| **Creación variable** | ¿La dificultad es crear productos sin depender de clases concretas o construirlos por etapas? | Crear documentos, familias de componentes u objetos complejos |
| **Comunicación entre objetos** | ¿Quién solicita, notifica o deriva una operación? | Avisos a suscriptores; solicitudes que recorren responsables |

**Salida de este paso:** una frase que nombre el **problema de diseño**, sin dar todavía por confirmado ningún patrón.

---

## PASO 2 — CONTRASTAR: ¿qué patrón podría resolverlo?

Usar la tabla siguiente para formular **candidatos**. Las preguntas ayudan a distinguirlos; la columna de señales **no equivale a un diagnóstico**.

### Guía rápida — los 12 patrones del PDF oficial

| Señal posible del enunciado | Patrón candidato | Pregunta para contrastar |
| --- | --- | --- |
| «Contiene», «anidado», «parte-todo», «hojas y compuestos» | **Composite** | ¿El cliente necesita tratar elementos individuales y agrupaciones uniformemente? |
| «Sumar funcionalidades», «envolver», «capas» | **Decorator** | ¿Se agrega comportamiento alrededor de un objeto manteniendo su interfaz? |
| «Interfaz incompatible», «sistema legado» | **Adapter** | ¿El cliente espera una interfaz distinta de la que ofrece el objeto existente? |
| «Simplificar un subsistema complejo» | **Facade** | ¿Se necesita una entrada sencilla que coordine varias clases del subsistema? |
| «Algoritmos distintos», «formas alternativas de calcular» | **Strategy** | ¿Hay algoritmos o políticas intercambiables que conviene encapsular y delegar? |
| «Suscriptores», «notificar cambios», «uno a muchos» | **Observer** | ¿Un objeto observado debe notificar cambios a varios observadores? |
| «Cadena», «derivar una solicitud», «varios responsables» | **Chain of Responsibility** | ¿La solicitud pasa entre manejadores que pueden atenderla y/o continuar el recorrido? |
| «Esqueleto fijo», «algunos pasos varían» | **Template Method** | ¿Una clase base define el orden general y las subclases especializan pasos? |
| «Subclases deciden qué crear» | **Factory Method** | ¿Un método de creación definido en un creador permite que subclases elijan el producto concreto? |
| «Familias de productos relacionados» | **Abstract Factory** | ¿La creación debe producir **varios productos compatibles** sin depender de sus clases concretas? |
| «Muchos pasos o parámetros», «representaciones distintas» | **Builder** | ¿El problema principal es **cómo construir** un objeto complejo, paso a paso? |
| «Única instancia», «acceso global controlado» | **Singleton** | ¿La clase debe controlar que exista **una sola instancia** y ofrecer acceso a ella? |

### Confusiones que hay que descartar

- **Factory Method vs. Abstract Factory:** un creador delega en sus subclases la elección de un producto **vs.** una fábrica permite crear una familia de productos relacionados.
- **Builder vs. fábricas:** construir **paso a paso** un objeto complejo **vs.** decidir **qué tipo de producto** instanciar.
- **Adapter vs. Decorator:** adaptar una **interfaz** **vs.** añadir **comportamiento** conservando la interfaz del componente.
- **Composite vs. Decorator:** representar **parte-todo** con hojas y compuestos **vs.** envolver un componente para ampliarlo.
- **Strategy vs. Template Method:** cambiar la **estrategia delegada** **vs.** mantener un **esqueleto de algoritmo** cuyos pasos especializan subclases.
- **Observer vs. Chain of Responsibility:** difundir **notificaciones** a suscriptores **vs.** encaminar una **solicitud** entre responsables.
- **Chain of Responsibility vs. Decorator:** procesar/derivar solicitudes en una cadena **vs.** sumar funcionalidades por capas.

**Salida de este paso:** uno o más **candidatos** y una razón para **descartar alternativas**. No hace falta proponer un patrón para cada señal.

---

## PASO 3 — JUSTIFICAR: ¿realmente corresponde aplicar el patrón?

Antes de confirmarlo, responder:

1. **Necesidad:** ¿qué requisito o dificultad **explícita** resuelve este patrón?
2. **Diseño:** ¿qué objetos, responsabilidades, contratos o relaciones del patrón aparecen o habría que modelar? ¿Se pueden justificar a partir del dominio?
3. **Costo y alternativas:** ¿por qué no alcanza una clase, una interfaz, herencia/composición simple o polimorfismo sin el patrón? ¿Qué complejidad adicional introduce?

**Criterio de decisión:**

- **VALIDADO PARA EL EJERCICIO:** el enunciado y el diseño respaldan la elección; puede explicarse por qué corresponde y qué alternativa se descartó.
- **PROPUESTO:** hay indicios razonables, pero falta completar una justificación o revisar el modelado.
- **PENDIENTE:** el enunciado no aporta datos suficientes para elegir; no inventar requisitos.
- **NO APLICA:** el patrón agrega complejidad sin resolver una necesidad de la consigna.
- **HISTÓRICO:** ejemplo o solución de una cursada anterior; útil para comparar, no prueba de exigencia oficial 2026.

**Salida de este paso:** una justificación breve, sin código por defecto. **Después** de validar la elección, y solo si el ejercicio lo requiere, avanzar al UML y a la implementación en C#.

---

## Ejemplo del apunte anterior: TravelNow — HISTÓRICO / pendiente de validar para 2026

Este caso estaba incluido en la guía original. **No se identificó como ejercicio de las clases 2026 consultadas**. Se conserva **como práctica de aplicación del protocolo**, no como solución oficial de la cursada vigente.

| Frase registrada en el apunte | Problema detectable | Candidato | Estado y validación necesaria |
| --- | --- | --- | --- |
| «Itinerarios que contengan excursiones, estadías o incluso otros itinerarios anidados» | Estructura parte-todo recursiva | **Composite** | **PROPUESTO:** confirmar que el sistema deba tratar excursiones, estadías e itinerarios bajo operaciones comunes |
| «Calcular la duración total de cualquier itinerario» | Calcular una operación sobre elementos y agrupaciones | **Composite** | **PROPUESTO:** `CalcularDuracion()` podría ser operación común; hay que revisar responsabilidades reales |
| «El costo final varía según el tipo de paquete» | Comportamiento variable | **Strategy** | **PENDIENTE:** la variación por sí sola no obliga a Strategy; comprobar si se requieren políticas intercambiables |
| «Agregar nuevos tipos en el futuro sin modificar la lógica principal» | Extensibilidad | **OCP**; quizá **Strategy** | **PENDIENTE:** OCP es un principio, no demuestra que Strategy sea la única solución |

### Aplicación de los tres pasos a TravelNow

1. **Detectar:** hay composición de itinerarios y variaciones posibles en el costo.
2. **Contrastar:** **Composite** es buen candidato si las partes y el conjunto se usan uniformemente; **Strategy** solo si el cálculo se organiza como políticas intercambiables, no solo por existir paquetes diferentes.
3. **Justificar:** verificar con la consigna completa las responsabilidades de `Excursion`, `Estadia` e `Itinerario`, y recién después decidir si hacen falta estrategias como `PaqueteEconomico` y `PaquetePremium`. Esos nombres se conservan del ejemplo anterior, **no son implementación validada para 2026**.

**Conclusión del ejemplo:** *Composite* y *Strategy* son **hipótesis de diseño**, no patrones confirmados exclusivamente por las frases aisladas.

---

## Ficha mínima para aplicar el protocolo a cualquier ejercicio

> **Consigna / ejercicio:** …  
> **1. DETECTAR — problema de diseño:** …  
> **2. CONTRASTAR — patrón(es) candidato(s) y alternativa descartada:** …  
> **3. JUSTIFICAR — evidencia, relaciones entre objetos y costo:** …  
> **Estado:** VALIDADO PARA EL EJERCICIO / PROPUESTO / PENDIENTE / NO APLICA / HISTÓRICO  
> **Próxima acción:** ninguna / revisar consigna / modelar UML / implementar C#

**Regla para parciales:** la respuesta oficial de la cátedra tiene prioridad. Si una interpretación técnica difiere, registrarla como observación **sin reemplazar la respuesta oficial**.
