# Guía de Ejercicios: Programación Orientada a Objetos

---

## Ejercicio 1: Clase Persona y Atributos Públicos
Crear una clase `Persona` que tenga los atributos públicos `nombre` y `apellido`.
* Crear una instancia y asignarle valores.
* Mostrar por pantalla los valores asignados.

---

## Ejercicio 2: Clase Vehiculo y Encapsulamiento Básico
Crear una clase `Vehiculo` que tenga los atributos públicos `marca`, `modelo` y un atributo privado `patente`.
* Crear una instancia y asignarle valores; notar que el atributo privado no está disponible para la asignación de valores.
* Mostrar por pantalla los valores asignados.

---

## Ejercicio 3: Clase Articulo y Métodos de Acceso
Crear una clase `Articulo` que tenga los atributos privados `marca` y `modelo`.
* Crear métodos públicos para la asignación de valores.
* Crear una instancia y asignarle valores.
* Notar que no es posible mostrar los valores por pantalla y analizar el motivo por el que esto ocurre.

---

## Ejercicio 4: Clase Cine y Métodos de Negocio
Crear una clase `Cine` que tenga los atributos privados `película` y `horario`.
* Crear métodos públicos para la asignación y recuperación de valores.
* Crear un método público `ObtenerCartelera()` que devuelva el nombre de la película y el horario.
* Crear una instancia y asignarle valores.
* Mostrar por pantalla los valores.

---

## Ejercicio 5: Clase Cine e Instanciación (`new`)
Crear una clase `Cine` que tenga los atributos privados `película` y `horario`.
* Crear métodos públicos para la asignación y recuperación de valores.
* Crear una instancia y asignarle valores.
* Mostrar por pantalla los valores.
* Crear una segunda instancia y asignarle valores.
* Mostrar por pantalla los valores.
* Cambiar los valores de la primera instancia.
* Mostrar en pantalla los valores de ambas instancias; concluir que la instrucción `new` crea objetos distintos.

---

## Ejercicio 6: Clase Fruta y Sobrecarga de Constructores
Crear una clase `Fruta` con variables privadas `color`, `peso`, `esEstacional`.
* Crear setters y getters.
* Escribir una función llamada `EsComestible()` que devuelva verdadero (`true`) cuando la fruta pesa menos de 200 gr y es de estación, y falso (`false`) en cualquier otro caso.
* Definir dos constructores de modo tal que la fruta pueda crearse con los valores `color`, `peso` y `esEstacional` al momento de instanciarse, o bien crearse sin valores iniciales.

---

## Ejercicio 7: Clase Ninja y Métodos con Parámetros
Crear una clase `Ninja` con las variables privadas `arteMarcial`, `arma`, `fuerza` (entero) y `salto` (entero).
* Crear setters y getters manualmente.
* Crear una función `Saltar()` que reciba un parámetro `multiplicador` (entero); imprimir por consola `salto` x `multiplicador`.
* Crear la función `Ataque()` que imprima por consola el arma que usa el ninja y el arte marcial.
* Crear dos instancias de `Ninja`, asignar distintos valores para cada uno de los atributos e invocar las funciones `Saltar()` y `Ataque()`.

---

## Ejercicio 8: Modelado sin Herencia
Crear una clase `Persona` que tenga los atributos privados `nombre` y `apellido`, con sus setters y getters.
* Crear una clase llamada `Visitante` con los mismos atributos.
* Crear una clase `Guardia` con los mismos atributos.
* Crear una instancia de cada una de las clases y asignarle valores.
* Mostrar por pantalla los valores.

---

## Ejercicio 9: Introducción a la Herencia
Crear una clase `Persona` que tenga los atributos privados `nombre` y `apellido`, con sus setters y getters.
* Crear una clase llamada `Visitante` que extienda de `Persona`.
* Crear una clase `Guardia` que extienda de `Persona`.
* Crear una instancia de cada una de las clases y asignarle valores.
* Mostrar por pantalla los valores; estudiar las ventajas del uso de la herencia.

---

## Ejercicio 10: Sobreescritura de Métodos (`Override`)
Continuando con el ejemplo anterior, realizar las siguientes modificaciones:
* Agregar en `Persona` el método `Presentarse()` que devuelva nombre y apellido de la persona.
* Crear una instancia de cada una de las clases y asignarle valores.
* Mostrar por pantalla los valores.
* Sobreescribir el método `Presentarse()` en la clase `Guardia` de modo tal que devuelva el siguiente mensaje:
  > *"Hola, mi nombre es <nombre y apellido> y soy el guardia."*
  
  *(Donde `<nombre y apellido>` debe ser reemplazado por el nombre y apellido del guardia)*.
* Mostrar por pantalla el resultado de invocar el método `Presentarse()` y advertir que la implementación en la clase `Guardia` tiene precedencia sobre la de su padre.

---

## Ejercicio 11: Extensión de Clases y Métodos de Interacción
Continuando con el ejemplo anterior, realizar las siguientes modificaciones:
* Agregar en `Visitante` el atributo privado `dni` (numérico) con sus setters y getters correspondientes.
* Agregar en `Guardia` el método público `ControlarDocumento()` que reciba como parámetro el DNI de la persona y devuelva el mensaje:
  > *"Adelante persona con dni <dni>"*
  
  *(Donde `<dni>` es el valor recibido por parámetro)*.
* Crear una instancia de cada una de las clases y asignarle valores.
* Mostrar por pantalla los valores.

---

## Ejercicio 12: Paso de Parámetros y Objetos
Continuando con el ejemplo anterior, realizar las siguientes modificaciones:
* Modificar la clase `Guardia` para que el método público `ControlarDocumento()` devuelva el mensaje:
  > *"Adelante <nombre completo del visitante> con dni <dni>"*
  
  *(Reemplazando respectivamente con el nombre completo del visitante y su DNI)*.
* Crear una instancia de cada una de las clases y asignarle valores.
* Mostrar por pantalla los valores.
* Analizar si es posible pasar un único parámetro al método `ControlarDocumento()` y estudiar las ventajas y desventajas que tendría asociado.

---

## Ejercicio 13: Kokumo Technologies - Sistema de Tracción de Robot (Polimorfismo / Composición)
El laboratorio **Kokumo Technologies** está desarrollando el prototipo de un robot explorador cuyo sistema de tracción puede ser personalizado para que se adapte mejor al terreno.

El robot, llamado **KT-2020**, tiene las siguientes características:
* **Número de serie:** `KT-2020-P`
* **Potencia de tracción base (PTB):** `10 hp`
* **Tracción:** Cualquiera de las dos opciones desarrolladas.

Los sistemas de tracción disponibles son:
1. **Rueda de caucho:** Ideal para entornos urbanos, su uso le resta `1 hp` al PTB y permite el rodado de hasta `100 km`; cuando se gasta, debe reemplazarse.
2. **Oruga:** Para todo tipo de terreno, le permite avanzar hasta `400 km` antes de requerir reemplazo y resta `3 hp` al PTB. Incorpora sensores `Meke-M0` que le permiten conocer la temperatura.

**Consignas:**
* Analizar, diseñar, diagramar las relaciones e implementar el código.
* Crear instancias de cada una de las clases y asignarle al robot los distintos sistemas de tracción, procurando mostrar por pantalla los siguientes datos entre las distintas asignaciones:
  * Número de serie.
  * Potencia de tracción final.
  * Tipo de tracción.
  * Cuánto puede avanzar.
  * Datos sobre cualquier característica adicional que posea.

---

## Ejercicio 14: Sistema de Montaje para Drones de Vigilancia
Una empresa de seguridad que se dedica a la vigilancia mediante el empleo de drones ha desarrollado un sistema de montaje que permitirá que los drones puedan cargar, además de la cámara de vigilancia, una herramienta accionable a distancia.

Actualmente el sistema de anclaje admite:
* **Sensor infrarrojo:** Pesa `250 gramos`.
* **Taser:** Pesa `300 gramos`.
* **Brazo robótico:** Pesa `500 gramos`.

**Reglas de penalización por peso:**
* El dron puede soportar hasta `200 gramos` sin sufrir penalizaciones de velocidad (`5 mts/s`) ni altura (`100 mts`).
* Por cada `50 gramos` extras, el dron reduce su velocidad en `2%` y la altura en `5%`.

**Consignas:**
* Analizar, diseñar, diagramar las relaciones e implementar el código.
* Crear instancias de cada una de las clases y asignarle al dron las distintas herramientas, procurando mostrar por pantalla los siguientes datos entre las distintas asignaciones:
  * Velocidad final.
  * Altura máxima final.
  * Tipo de herramienta que lleva.

---

## Ejercicio 15: Sistema de Gestión de Flota Naval (Marina de Caballito)
La Marina del reino de Caballito quiere desarrollar un sistema que le permita gestionar su flota de navíos. Por el momento únicamente se requiere presentar ante las autoridades un posible diseño en el que se expongan las relaciones entre las entidades que modelarán los datos.

**Entidades y características:**
* **Acorazados:** Flotabilidad, solidez, estabilidad, blindaje, potencia de fuego, velocidad crucero y nombre de bautismo.
* **Destructores:** Potencia de fuego, altos índices de maniobrabilidad y estabilidad a velocidad máxima, flotabilidad, solidez, velocidad crucero y nombre.
* **Barco Hospital ("Sibelancia"):** Único en su tipo, excelente flotabilidad, estabilidad extrema. Capacidad de carga para brindar servicios a `75 pacientes`.
* **Lanchas de Salvataje Médico ("La gaucha" y "El gaucho"):** Destinadas a salvatajes rápidos, motor fuera de borda, elevada flotabilidad (muy rápidas), estabilidad reducida (afecta maniobrabilidad). Poseen una grúa pequeña para subir/arriar objetos de hasta `300 kilos`.

**Consignas:**
* Analizar, diseñar, diagramar las relaciones e implementar el código.
* Crear instancias de los distintos barcos, asignar valores y mostrar por pantalla.

---

## Ejercicio 16: Sistema de Carga y Logística de Vehículos
Una empresa de logística dispone de dos tipos de vehículos para envíos:
* **Camioneta:** Capacidad para llevar cómodas, heladeras y lavarropas (Capacidad máxima: `10 elementos`).
* **Auto:** Espacio suficiente para llevar televisores, bicicletas plegables y cajas pequeñas (Capacidad máxima: `5 elementos`).

**Consideraciones del modelo:**
* Los vehículos deben ofrecer el método `Cargar()` para ir incrementando su carga (recibe el ítem por parámetro).
* Mediante el método `ListarItems()` el vehículo facilita la lista de su carga.
* Todos los elementos poseen: `descripción`, `dimensiones` y un `número identificador`.

**Atributos específicos por ítem:**
1. **Cómodas:** Superficie y cantidad de cajones.
2. **Heladeras:** Voltaje de trabajo y si posee freezer.
3. **Lavarropas:** Voltaje de trabajo, capacidad de carga y revoluciones de centrifugado.
4. **Televisores:** Voltaje de trabajo, tecnología (LED/LCD) y si es Smart TV.
5. **Bicicletas:** Tamaño de rodado, si es eléctrica y cantidad de cambios.

**Consignas:**
* Analizar, diseñar, diagramar las relaciones e implementar el código respetando las capacidades máximas de carga (Auto: 5, Camioneta: 10).

---

## Ejercicio 17: Scanner Aduanero de Objetos y Contenedores (Juancito Jaquer)
Juancito Jaquer fabricó un scanner para aduanas fronterizas capaz de analizar un objeto, obtener información básica y advertir si este actúa como contenedor de otro objeto.

**Propiedades detectadas por el scanner:**
* **Material:** Metal, cuero, madera, vidrio, plástico, líquido, textil, goma, u "otro".
* **Volumen:** En centímetros cúbicos (cm³).
* **Contenido:** Lista de objetos que contiene.

**Clasificación de objetos según su estructura:**
* **Simple:** No contiene a ningún objeto ni se encuentra contenido en otro.
* **Contenedor:** Contiene al menos un objeto, pero no se encuentra contenido por ningún otro.
* **Contenido:** Se encuentra dentro de un objeto, pero no contiene nada.
* **Sambuchito:** Está contenido en un objeto y a la vez contiene a otro objeto.

**Consignas:**
* Analizar, diseñar, diagramar las relaciones e implementar el código.
* Realizar pruebas con:
  1. Una Mamushka de madera de varios niveles.
  2. Un portafolios vacío de cuero.
  3. Un botiquín de plástico que contiene gasa y agua oxigenada.
  4. Una bolsa de cuero que contiene un peine y un botiquín.

---

## Ejercicio 18: Sistema de Gestión Inmobiliaria (Arquitectura en Capas)
Una inmobiliaria requiere un sistema para dar de alta y gestionar inmuebles (Departamentos y Casas) persistidos en memoria.

**Requerimientos del Inmueble:**
* **Datos Catastrales (Obligatorios):** Provincia, barrio, calle, altura y código postal.
* **Información de Ambientes:** Cantidad, tipo y dimensiones.
* **Contacto (Obligatorio):** Nombre, apellido, teléfono y/o correo electrónico (al menos uno de los dos medios).
* **Observaciones:** Texto opcional.
* **Características generales:** Barrio privado (sí/no), ambientes luminosos (sí/no), conexión a red de gas (sí/no), red cloacal (sí/no).

**Diferenciación por tipo de inmueble:**
* **Departamentos:** Piso, número/letra, admisión de mascotas (sí/no).
* **Casas:** Quincho (sí/no), pileta (sí/no).

**Consignas:**
* Diseñar la solución aplicando una **arquitectura por capas** (Presentación, Lógica de Negocio, Datos/Persistencia).
* Validar que todos los campos requeridos estén completos antes de dar de alta.
* Persistir en memoria empleando la colección que resulte más conveniente.
* Desde el método `Main`, crear distintos inmuebles, almacenarlos en memoria y luego recuperarlos para mostrar sus propiedades por pantalla.

---

## Ejercicio 19: Control de Gastos, Ventas y Listas de Precios para Mueblería
Una empresa de venta de muebles necesita un sistema para dar de alta artículos, asignarles costo de producción y manejar precios de venta según modalidad (mayorista/minorista).

**Estructura de datos:**
* **Artículo:** Nombre, costo de producción y observación opcional.
* **Lista de Precios:** Nombre identificador, fecha tope de vigencia, indicador de tipo (Mayorista / Minorista) y el detalle de artículos con sus respectivos precios de venta.

**Consignas:**
* Analizar el problema, modelar las entidades involucradas, realizar el diagrama de clases e implementar la solución.
* Crear un conjunto acotado de artículos y mostrar sus detalles por pantalla.
* Crear al menos una lista de precios mayorista y una minorista, asignando precios y mostrando el resultado completo por pantalla.
