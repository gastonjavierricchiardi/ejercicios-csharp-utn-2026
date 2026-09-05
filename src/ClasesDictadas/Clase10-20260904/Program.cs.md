## 1) `Program.cs` — mismo código, comentado

```csharp
/*
    =========================================================
    PROGRAM
    =========================================================

    Este archivo funciona como punto de entrada del programa.

    Acá se crean los objetos concretos y se los hace
    interactuar entre sí para probar el modelo desarrollado:

        - Orador
        - General
        - VIP
        - Evento

    Después se realizan inscripciones, check-in
    y finalmente se solicita el resumen del evento.
*/


/*
    Código generado originalmente por la plantilla
    de consola de .NET.

    Queda comentado porque ya no lo necesitamos.
*/
//Console.WriteLine("Hello, World!");



/*
    =========================================================
    CREACIÓN DE UN ORADOR
    =========================================================

    Se crea un objeto concreto de tipo Orador.

    El constructor recibe:

        - DNI       -> 123
        - nombre    -> "Leonardo"
        - tema      -> "POO"

    Los datos DNI y nombre serán enviados por Orador
    al constructor de Asistente mediante base().

    El tema queda como dato particular de Orador.
*/
Orador orador = new Orador(123, "Leonardo", "POO");



/*
    =========================================================
    CREACIÓN DE UN ASISTENTE GENERAL
    =========================================================

    Se crea un objeto concreto de tipo General.

    El constructor recibe:

        - DNI
        - nombre

    General no agrega ningún atributo particular.
*/
General unGeneral = new General(1234, "Un asistente general");



/*
    =========================================================
    CREACIÓN DE UN VIP
    =========================================================

    Se crea un objeto concreto de tipo VIP.

    El constructor recibe:

        - DNI
        - nombre
        - regalo

    El regalo es el dato particular de VIP.
*/
VIP unVIP = new VIP(987, "Un asistente VIP", "Un termo");



/*
    =========================================================
    CREACIÓN DEL EVENTO
    =========================================================

    Se crea el objeto que será responsable de administrar:

        - participantes;
        - presentes;
        - inscripción;
        - check-in;
        - resumen.
*/
Evento elEvento = new Evento();



/*
    =========================================================
    INFORMACIÓN DEL EVENTO
    =========================================================

    Se asigna un valor a la property Informacion
    del objeto elEvento.
*/
elEvento.Informacion = "Clase de POO";



/*
    =========================================================
    INSCRIPCIÓN DEL ORADOR
    =========================================================

    Se envía el objeto orador al método
    AgregarParticipante().

    Aunque el objeto real es Orador,
    el método recibe un parámetro de tipo Asistente:

        AgregarParticipante(Asistente asistente)

    Esto es posible porque Orador ES UN Asistente.
*/
elEvento.AgregarParticipante(orador);



/*
    =========================================================
    INSCRIPCIÓN DEL VIP
    =========================================================

    También se agrega el objeto VIP.

    Nuevamente, VIP puede ser tratado como Asistente
    porque pertenece a la misma jerarquía.
*/
elEvento.AgregarParticipante(unVIP);



/*
    =========================================================
    CHECK-IN DEL ORADOR
    =========================================================

    Evento verifica:

        1. si el DNI está inscripto;
        2. si ya había realizado check-in;
        3. si puede registrarlo como presente.

    Si el ingreso es correcto, también ejecutará:

        asistente.InformarBeneficio()

    Como el objeto real es Orador, responderá
    con la implementación de Orador.
*/
elEvento.RegistrarCheckIn(orador);



/*
    =========================================================
    CHECK-IN DEL VIP
    =========================================================

    Se realiza el mismo procedimiento con el VIP.

    El llamado dentro de Evento será exactamente el mismo:

        asistente.InformarBeneficio()

    pero esta vez responderá la implementación de VIP.

    Ahí vemos el polimorfismo en funcionamiento.
*/
elEvento.RegistrarCheckIn(unVIP);



/*
    =========================================================
    RESUMEN FINAL
    =========================================================

    Evento calcula:

        - cantidad de inscriptos;
        - cantidad de presentes;
        - cantidad de ausentes.

    InformarResumen() devuelve un string.

    Console.WriteLine() muestra ese string en pantalla.
*/
System.Console.WriteLine(elEvento.InformarResumen());
```

---

## 2) `Program.md` — explicación didáctica

````md
# `Program.cs`

## 1. ¿Qué responsabilidad tiene?

`Program.cs` no representa una entidad del dominio
como `Asistente`, `VIP`, `Orador` o `Evento`.

Su función en este ejercicio es poner en funcionamiento
el modelo.

Conceptualmente:

```text
Program
   |
   +-- crea asistentes
   |
   +-- crea el evento
   |
   +-- inscribe participantes
   |
   +-- registra check-in
   |
   +-- solicita el resumen
```

Es el lugar donde podemos observar cómo interactúan
los objetos que modelamos.

---

# 2. Creación del `Orador`

La primera instancia es:

```csharp
Orador orador = new Orador(123, "Leonardo", "POO");
```

Tenemos:

```text
variable       -> orador
tipo           -> Orador
DNI            -> 123
nombre         -> Leonardo
tema           -> POO
```

Conceptualmente:

```text
new Orador(123, "Leonardo", "POO")
              |
              v
            Orador
              |
              +-- DNI = 123
              +-- Nombre = "Leonardo"
              +-- Tema = "POO"
```

Al construirlo intervienen dos clases:

```text
Orador
   |
   +-- tema
   |
   +-- base(documento, nombre)
            |
            v
        Asistente
            |
            +-- DNI
            +-- Nombre
```

---

# 3. Creación del `General`

Después se crea:

```csharp
General unGeneral =
    new General(1234, "Un asistente general");
```

Este objeto tiene:

```text
DNI    = 1234
Nombre = "Un asistente general"
```

Como `General` no agrega estado particular,
esos datos quedan administrados por `Asistente`.

---

# 4. Un detalle importante sobre `unGeneral`

El objeto:

```csharp
General unGeneral =
    new General(1234, "Un asistente general");
```

se crea, pero en este `Program.cs` después
**no se agrega al evento**.

No aparece:

```csharp
elEvento.AgregarParticipante(unGeneral);
```

Tampoco aparece:

```csharp
elEvento.RegistrarCheckIn(unGeneral);
```

Por lo tanto, en esta ejecución:

```text
unGeneral
    |
    v
existe como objeto

pero

NO está inscripto en elEvento
```

Esto es importante para entender posteriormente
el resultado del resumen.

---

# 5. Creación del `VIP`

Se crea:

```csharp
VIP unVIP =
    new VIP(987, "Un asistente VIP", "Un termo");
```

Sus datos quedan conceptualmente así:

```text
VIP
 |
 +-- DNI = 987
 |
 +-- Nombre = "Un asistente VIP"
 |
 +-- Regalo = "Un termo"
```

DNI y Nombre corresponden a `Asistente`.

Regalo corresponde específicamente a `VIP`.

---

# 6. Creación de `Evento`

Después se crea:

```csharp
Evento elEvento = new Evento();
```

Ahora tenemos un objeto encargado de administrar
a los asistentes.

Conceptualmente:

```text
elEvento
    |
    v
  Evento
    |
    +-- Participantes
    +-- Presentes
    +-- Informacion
    +-- Regalos
```

En este momento las colecciones todavía no fueron
inicializadas por `Program`.

La implementación de `Evento` se encargará de hacerlo
cuando se invoquen los métodos correspondientes.

---

# 7. Asignación de `Informacion`

Se ejecuta:

```csharp
elEvento.Informacion = "Clase de POO";
```

Esto utiliza la property:

```csharp
public string Informacion
{
    get { return informacion; }
    set { informacion = value; }
}
```

Por lo tanto:

```text
elEvento
    |
    +-- Informacion
            |
            v
      "Clase de POO"
```

---

# 8. Inscripción del `Orador`

Se ejecuta:

```csharp
elEvento.AgregarParticipante(orador);
```

Pero el método está definido como:

```csharp
public void AgregarParticipante(Asistente asistente)
```

Aunque enviamos:

```text
Orador
```

el método recibe:

```text
Asistente
```

Esto es posible por la relación de herencia:

```text
Orador ES UN Asistente
```

Conceptualmente:

```text
orador
  |
  | Orador
  v
AgregarParticipante(Asistente asistente)
```

Dentro de `Evento`, finalmente se almacena:

```text
Dictionary<int, Asistente>

123 -> orador
```

---

# 9. Inscripción del `VIP`

Después ocurre lo mismo con:

```csharp
elEvento.AgregarParticipante(unVIP);
```

El objeto real es:

```text
VIP
```

pero el método puede recibirlo como:

```text
Asistente
```

El Dictionary queda conceptualmente:

```text
participantes

DNI       Asistente
-----------------------------
123  ->   Orador
987  ->   VIP
```

El `General` no aparece porque nunca fue agregado.

---

# 10. Situación antes del check-in

Hasta este momento tenemos:

```text
OBJETOS CREADOS

Orador
General
VIP
Evento
```

Pero dentro del evento están inscriptos solamente:

```text
Dictionary participantes

123 -> Orador
987 -> VIP
```

Y todavía nadie realizó check-in:

```text
HashSet presentes

vacío
```

---

# 11. Check-in del `Orador`

Se ejecuta:

```csharp
elEvento.RegistrarCheckIn(orador);
```

Dentro de `Evento` ocurre conceptualmente:

```text
DNI 123
   |
   v
¿está en participantes?
   |
   Sí
   |
   v
¿está en presentes?
   |
   No
   |
   v
Agregar a presentes
```

Después:

```csharp
asistente.InformarBeneficio();
```

Como el objeto real es un `Orador`,
se ejecuta:

```csharp
Orador.InformarBeneficio()
```

que devuelve algo equivalente a:

```text
Acceso total y dará la charla de POO
```

---

# 12. Primer elemento del `HashSet`

Después del check-in del Orador:

```text
presentes

Orador DNI 123
```

Ahora el `HashSet<Asistente>` contiene
un elemento.

---

# 13. Check-in del `VIP`

Después se ejecuta:

```csharp
elEvento.RegistrarCheckIn(unVIP);
```

La lógica vuelve a ser exactamente la misma:

```text
¿está inscripto?
        |
       Sí
        |
        v
¿ya está presente?
        |
       No
        |
        v
registrar check-in
```

Pero cuando `Evento` realiza:

```csharp
asistente.InformarBeneficio();
```

esta vez el objeto real es un `VIP`.

Por lo tanto se ejecuta:

```csharp
VIP.InformarBeneficio()
```

y la respuesta incorpora:

```text
"Un termo"
```

---

# 14. Acá vemos el polimorfismo

Los dos llamados realizados por `Program` son:

```csharp
elEvento.RegistrarCheckIn(orador);

elEvento.RegistrarCheckIn(unVIP);
```

Dentro de `Evento`, ambos terminan haciendo:

```csharp
asistente.InformarBeneficio();
```

Es exactamente el mismo llamado.

Sin embargo:

```text
                 InformarBeneficio()
                         |
              +----------+----------+
              |                     |
              v                     v
           Orador                  VIP
              |                     |
              v                     v
      Acceso total...       Charlas + backstage
       charla POO               + termo
```

Esto representa:

> mismo llamado, distintas respuestas según el objeto real.

---

# 15. Estado final de las colecciones

Después de ambos check-in:

## `participantes`

```text
Dictionary<int, Asistente>

123 -> Orador
987 -> VIP
```

Cantidad:

```text
2
```

## `presentes`

```text
HashSet<Asistente>

Orador DNI 123
VIP DNI 987
```

Cantidad:

```text
2
```

---

# 16. ¿Dónde quedó el `General`?

Aunque se creó:

```csharp
General unGeneral =
    new General(1234, "Un asistente general");
```

nunca se ejecutó:

```csharp
elEvento.AgregarParticipante(unGeneral);
```

Por eso:

```text
OBJETOS CREADOS = 3 asistentes

pero

INSCRIPTOS EN EL EVENTO = 2 asistentes
```

Este punto muestra una diferencia importante:

```text
crear un objeto
        ≠
inscribirlo en Evento
```

---

# 17. Solicitud del resumen

Finalmente se ejecuta:

```csharp
System.Console.WriteLine(
    elEvento.InformarResumen()
);
```

Hay dos operaciones distintas.

Primero:

```csharp
elEvento.InformarResumen()
```

`Evento` calcula y devuelve un `string`.

Después:

```csharp
System.Console.WriteLine(...)
```

muestra ese resultado en pantalla.

Conceptualmente:

```text
Evento
   |
   | InformarResumen()
   v
string
   |
   | Console.WriteLine()
   v
Consola
```

---

# 18. Cálculo realizado por `Evento`

Como solamente se inscribieron:

```text
Orador
VIP
```

tenemos:

```text
totalInscriptos = 2
```

Los dos hicieron check-in:

```text
totalPresentes = 2
```

Por lo tanto:

```text
totalAusentes
=
totalInscriptos - totalPresentes

2 - 2 = 0
```

El resumen correspondiente a esta ejecución será:

```text
El total de inscriptos es 2,
con un total de presentes de 2,
con un total de ausentes de 0
```

---

# 19. Flujo completo de `Program.cs`

Podemos leer todo el archivo como una secuencia:

```text
CREAR OBJETOS
     |
     +-- Orador
     +-- General
     +-- VIP
     |
     v
CREAR EVENTO
     |
     v
ASIGNAR INFORMACIÓN
     |
     v
INSCRIBIR
     |
     +-- Orador
     +-- VIP
     |
     v
CHECK-IN
     |
     +-- Orador
     +-- VIP
     |
     v
INFORMAR RESUMEN
```

---

# 20. Vista completa de la ejecución

```text
Program
   |
   +-- new Orador(...)
   |
   +-- new General(...)
   |
   +-- new VIP(...)
   |
   +-- new Evento()
            |
            +-- AgregarParticipante(orador)
            |          |
            |          v
            |     Dictionary
            |
            +-- AgregarParticipante(unVIP)
            |          |
            |          v
            |     Dictionary
            |
            +-- RegistrarCheckIn(orador)
            |          |
            |          +-- HashSet
            |          |
            |          +-- InformarBeneficio()
            |                  |
            |                  v
            |               Orador
            |
            +-- RegistrarCheckIn(unVIP)
            |          |
            |          +-- HashSet
            |          |
            |          +-- InformarBeneficio()
            |                  |
            |                  v
            |                 VIP
            |
            +-- InformarResumen()
                       |
                       v
                  Console
```

---

# 21. Idea central

`Program.cs` permite observar cómo todas las piezas
del modelo trabajan juntas:

```text
                   Program
                      |
          +-----------+-----------+
          |                       |
          v                       v
      Asistentes                Evento
          |                       |
    +-----+-----+          +------+------+
    |     |     |          |             |
General  VIP  Orador   Dictionary      HashSet
                         |               |
                         v               v
                    inscriptos        presentes
                         \               /
                          \             /
                           +-----------+
                                 |
                                 v
                         RegistrarCheckIn()
                                 |
                                 v
                         InformarBeneficio()
                                 |
                                 v
                           POLIMORFISMO
```

El archivo no contiene la lógica interna de inscripción
o check-in.

Esa responsabilidad permanece en `Evento`.

Tampoco decide qué beneficios tiene cada asistente.

Esa responsabilidad permanece en cada subclase de
`Asistente`.

`Program.cs` se limita a crear los objetos
y provocar su interacción.
````
