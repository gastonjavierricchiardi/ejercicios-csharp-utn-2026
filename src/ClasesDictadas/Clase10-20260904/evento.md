## 1) `Evento.cs` — mismo código, comentado

```csharp
/*
    =========================================================
    EVENTO
    =========================================================

    Evento es la clase encargada de administrar:

        - la información del evento;
        - los regalos disponibles;
        - los asistentes inscriptos;
        - los asistentes que realizaron check-in.

    En esta clase aparecen las dos colecciones centrales
    pedidas por el ejercicio:

        Dictionary<int, Asistente>
        HashSet<Asistente>
*/
public class Evento
{
    /*
        =====================================================
        INFORMACIÓN DEL EVENTO
        =====================================================

        Guarda información general del evento.

        El atributo es privado y se accede mediante
        una property pública.
    */
    private string informacion;

    public string Informacion
    {
        get { return informacion; }
        set { informacion = value; }
    }


    /*
        =====================================================
        REGALOS
        =====================================================

        Lista de regalos asociados al evento.

        La colección es de tipo:

            List<string>

        En el código trabajado en clase esta colección
        queda declarada, aunque todavía no interviene
        en AgregarParticipante(), RegistrarCheckIn()
        ni InformarResumen().
    */
    private List<string> regalos;

    public List<string> Regalos
    {
        get { return regalos; }
        set { regalos = value; }
    }


    /*
        =====================================================
        PARTICIPANTES
        =====================================================

        Guarda a todos los asistentes inscriptos.

        Se utiliza un Dictionary porque cada participante
        queda asociado directamente a una clave.

        La clave es:

            int -> DNI

        El valor es:

            Asistente -> objeto inscripto

        Conceptualmente:

            DNI -----> Asistente
    */
    private Dictionary<int, Asistente> participantes;

    public Dictionary<int, Asistente> Participantes
    {
        get { return participantes; }
        set { participantes = value; }
    }


    /*
        =====================================================
        PRESENTES
        =====================================================

        Guarda los asistentes que ya realizaron check-in.

        Se utiliza un HashSet porque necesitamos trabajar
        con elementos únicos y detectar si un asistente
        ya fue registrado.

        La comparación de los objetos Asistente se apoya
        en Equals() y GetHashCode(), que fueron redefinidos
        en la clase Asistente utilizando el DNI.
    */
    private HashSet<Asistente> presentes;

    public HashSet<Asistente> Presentes
    {
        get { return presentes; }
        set { presentes = value; }
    }


    /*
        =====================================================
        AGREGAR PARTICIPANTE
        =====================================================

        Recibe un Asistente y lo incorpora al Dictionary
        de participantes.

        Como el parámetro es del tipo Asistente,
        puede recibir cualquiera de sus subclases:

            - General
            - VIP
            - Orador
    */
    public void AgregarParticipante(Asistente asistente)
    {
        /*
            Si Participantes todavía no fue inicializado,
            se crea el Dictionary.

            Esta fue la estrategia utilizada en la
            implementación de clase.
        */
        if (this.Participantes == null)
        {
            this.Participantes = new Dictionary<int, Asistente>();
        }


        /*
            También se inicializa Presentes si todavía
            no existe.
        */
        if (this.Presentes == null)
        {
            this.Presentes = new HashSet<Asistente>();
        }


        /*
            ContainsKey() pregunta si el DNI ya existe
            como clave dentro del Dictionary.

            Solamente se agrega si todavía no existe.
        */
        if (!this.participantes.ContainsKey(asistente.DNI))
        {
            /*
                DNI del asistente -> clave
                asistente        -> valor
            */
            this.participantes.Add(asistente.DNI, asistente);
        }
    }


    /*
        =====================================================
        REGISTRAR CHECK-IN
        =====================================================

        Recibe un Asistente e intenta registrar
        su ingreso al evento.

        Debe resolver tres situaciones:

            1. No está inscripto.
            2. Ya había realizado check-in.
            3. Está inscripto y todavía no ingresó.
    */
    public void RegistrarCheckIn(Asistente asistente)
    {
        /*
            Igual que en AgregarParticipante(),
            primero se garantiza que las colecciones
            estén inicializadas.
        */
        if (this.Participantes == null)
        {
            this.Participantes = new Dictionary<int, Asistente>();
        }

        if (this.Presentes == null)
        {
            this.Presentes = new HashSet<Asistente>();
        }


        /*
            =================================================
            CASO 1: NO ESTÁ INSCRIPTO
            =================================================

            Se busca directamente el DNI dentro
            del Dictionary mediante ContainsKey().
        */
        if (!this.participantes.ContainsKey(asistente.DNI))
        {
            Console.WriteLine(
                $"El DNI {asistente.DNI} no está en la lista de inscriptos"
            );
        }
        else
        {
            /*
                =============================================
                CASO 2: YA REALIZÓ CHECK-IN
                =============================================

                El HashSet permite preguntar si ese
                asistente ya se encuentra registrado
                como presente.
            */
            if (this.presentes.Contains(asistente))
            {
                Console.WriteLine(
                    $"El DNI {asistente.DNI} ya ha realizado el check in."
                );
            }
            else
            {
                /*
                    =========================================
                    CASO 3: CHECK-IN CORRECTO
                    =========================================

                    El asistente estaba inscripto
                    y todavía no figuraba como presente.

                    Se agrega al HashSet.
                */
                this.presentes.Add(asistente);


                /*
                    Después se informa la bienvenida.

                    Acá aparece el polimorfismo:

                        asistente.InformarBeneficio()

                    Evento no necesita preguntar si el objeto
                    es General, VIP u Orador.

                    Cada objeto resuelve InformarBeneficio()
                    según su propia implementación.
                */
                Console.WriteLine(
                    $"El DNI {asistente.DNI} realizó el check in. " +
                    $"Le damos la bienvenida, estos son tus beneficios " +
                    $"{asistente.InformarBeneficio()}"
                );
            }
        }
    }


    /*
        =====================================================
        INFORMAR RESUMEN
        =====================================================

        Genera el resumen final del evento.

        Calcula:

            - cantidad de inscriptos;
            - cantidad de presentes;
            - cantidad de ausentes.
    */
    public string InformarResumen()
    {
        /*
            Contadores locales.
        */
        int totalInscriptos = 0;
        int totalPresentes = 0;


        /*
            Se recorre el Dictionary completo.

            Por cada participante encontrado,
            se aumenta el contador.
        */
        foreach (var unInscripto in participantes)
        {
            totalInscriptos++;
        }


        /*
            Se recorre el HashSet completo.

            Por cada asistente presente,
            se aumenta el contador.
        */
        foreach (var unPresente in presentes)
        {
            totalPresentes++;
        }


        /*
            Los ausentes se calculan como:

                inscriptos - presentes
        */
        int totalAusentes = totalInscriptos - totalPresentes;


        /*
            Se devuelve el resumen como string.
        */
        return $"El total de inscriptos es {totalInscriptos}, " +
               $"con un total de presentes de {totalPresentes}, " +
               $"con un total de ausentes de {totalAusentes}";
    }
}
```

Este es el código trabajado en clase: el profesor además dejó aclarado posteriormente que `Participantes` y `Presentes` fueron inicializados dentro de los métodos para evitar utilizarlos sin inicializar, aunque indicó que existen otras alternativas que verán progresivamente.

---

## 2) `Evento.md` — explicación didáctica

````md
# Clase `Evento`

## 1. ¿Qué representa?

`Evento` representa al objeto encargado de administrar
el control de acceso.

Hasta ahora teníamos objetos que representaban personas:

```text
Asistente
   |
   +-- General
   +-- VIP
   +-- Orador
```

Pero necesitamos otro objeto que coordine a esos asistentes.

Ese objeto es:

```text
Evento
```

Su responsabilidad principal es administrar:

```text
Evento
   |
   +-- participantes inscriptos
   +-- asistentes presentes
   +-- inscripción
   +-- check-in
   +-- resumen
```

---

## 2. Estado de `Evento`

La clase posee cuatro atributos:

```csharp
private string informacion;
private List<string> regalos;
private Dictionary<int, Asistente> participantes;
private HashSet<Asistente> presentes;
```

Conceptualmente:

```text
Evento
   |
   +-- informacion
   |
   +-- regalos
   |
   +-- participantes
   |
   +-- presentes
```

---

# 3. `Informacion`

El atributo:

```csharp
private string informacion;
```

guarda información general relacionada con el evento.

Se accede mediante:

```csharp
public string Informacion
{
    get { return informacion; }
    set { informacion = value; }
}
```

Por ejemplo, posteriormente desde `Program.cs` veremos:

```csharp
elEvento.Informacion = "Clase de POO";
```

---

# 4. `Regalos`

La clase declara:

```csharp
private List<string> regalos;
```

y su property:

```csharp
public List<string> Regalos
{
    get { return regalos; }
    set { regalos = value; }
}
```

Por lo tanto, `Evento` puede mantener una colección
de textos que representan regalos.

La colección utilizada es:

```csharp
List<string>
```

En el código trabajado en esta clase, `Regalos`
queda declarado pero no interviene todavía en:

```text
AgregarParticipante()
RegistrarCheckIn()
InformarResumen()
```

---

# 5. `Dictionary<int, Asistente>`

Una de las partes centrales del ejercicio es:

```csharp
private Dictionary<int, Asistente> participantes;
```

Un `Dictionary` trabaja con pares:

```text
clave -> valor
```

En este caso:

```text
int       -> Asistente
DNI       -> participante
```

Por ejemplo, conceptualmente:

```text
Dictionary participantes

123  -> Orador Leonardo
987  -> VIP
1234 -> General
```

El DNI funciona como clave.

Esto permite buscar directamente por DNI,
que era uno de los requisitos del ejercicio.

---

# 6. ¿Por qué el valor es `Asistente`?

El Dictionary se declara:

```csharp
Dictionary<int, Asistente>
```

y no:

```text
Dictionary<int, General>
Dictionary<int, VIP>
Dictionary<int, Orador>
```

Esto permite guardar juntos objetos
de toda la jerarquía.

Conceptualmente:

```text
Dictionary<int, Asistente>
          |
          +-- General
          +-- VIP
          +-- Orador
```

Por ejemplo:

```text
123  -> Orador
987  -> VIP
1234 -> General
```

Todos pueden tratarse como `Asistente`.

---

# 7. `HashSet<Asistente>`

La segunda colección central es:

```csharp
private HashSet<Asistente> presentes;
```

Este conjunto guarda a quienes ya realizaron
el check-in.

Conceptualmente:

```text
participantes
Dictionary<int, Asistente>

    todos los inscriptos
             |
             |
             v

presentes
HashSet<Asistente>

    quienes ingresaron
```

El `HashSet` trabaja con elementos únicos.

Por eso resulta útil para detectar que una persona
no realice el check-in dos veces.

---

# 8. Relación con `Equals()` y `GetHashCode()`

En `Asistente` habíamos redefinido:

```csharp
public override bool Equals(object? obj)
{
    return ((Asistente)obj).DNI == this.DNI;
}
```

y:

```csharp
public override int GetHashCode()
{
    return this.DNI;
}
```

Ahora vemos para qué resulta importante esa decisión.

`Evento` utiliza:

```csharp
HashSet<Asistente>
```

y necesita determinar si un asistente ya está presente.

Conceptualmente:

```text
HashSet<Asistente>
        |
        v
¿este Asistente ya existe?
        |
        v
     Equals()
        +
   GetHashCode()
        |
        v
       DNI
```

Entonces el DNI es el criterio utilizado para
determinar la igualdad entre asistentes.

---

# 9. `AgregarParticipante()`

El método recibe:

```csharp
public void AgregarParticipante(Asistente asistente)
```

Esto significa que puede recibir cualquier objeto
que sea un `Asistente`.

Por ejemplo:

```text
General
VIP
Orador
```

Todos pueden entrar por el mismo parámetro:

```text
Asistente asistente
```

---

# 10. Inicialización de las colecciones

Lo primero que hace el método es comprobar:

```csharp
if (this.Participantes == null)
{
    this.Participantes =
        new Dictionary<int, Asistente>();
}
```

Después hace lo mismo con:

```csharp
if (this.Presentes == null)
{
    this.Presentes =
        new HashSet<Asistente>();
}
```

Conceptualmente:

```text
¿Participantes existe?

     NO
      |
      v
crear Dictionary


¿Presentes existe?

     NO
      |
      v
crear HashSet
```

Esta fue la estrategia utilizada durante la clase.

El profesor aclaró posteriormente que se hizo
para evitar intentar utilizar una colección
que todavía no estuviera inicializada.

También indicó que existen otras formas de hacerlo
y que algunas pueden resultar más elegantes,
pero se verán progresivamente.

---

# 11. Evitar DNI duplicados

Después aparece:

```csharp
if (!this.participantes.ContainsKey(asistente.DNI))
```

`ContainsKey()` pregunta:

```text
¿este DNI ya está dentro del Dictionary?
```

Si la respuesta es NO:

```csharp
this.participantes.Add(
    asistente.DNI,
    asistente
);
```

Conceptualmente:

```text
AgregarParticipante(asistente)
            |
            v
¿existe DNI?
       |
   +---+---+
   |       |
  Sí      No
   |       |
   |       v
   |     Add()
   |
 no agrega
```

El DNI se utiliza como clave:

```text
asistente.DNI -> asistente
```

---

# 12. `RegistrarCheckIn()`

El método es:

```csharp
public void RegistrarCheckIn(Asistente asistente)
```

Su responsabilidad es decidir qué hacer
cuando una persona intenta ingresar.

La lógica tiene tres caminos:

```text
RegistrarCheckIn()
        |
        v
¿está inscripto?
    |
 +--+--+
 |     |
No     Sí
 |      |
avisa   v
       ¿ya ingresó?
          |
       +--+--+
       |     |
      Sí    No
       |     |
     avisa   v
           registrar
           bienvenida
           beneficios
```

---

# 13. Primer caso: no está inscripto

La condición es:

```csharp
if (!this.participantes.ContainsKey(asistente.DNI))
```

Si el DNI no existe en el Dictionary:

```csharp
Console.WriteLine(
    $"El DNI {asistente.DNI} no está en la lista de inscriptos"
);
```

Por lo tanto:

```text
Dictionary
     |
     v
ContainsKey(DNI)
     |
    false
     |
     v
No está inscripto
```

---

# 14. Segundo caso: ya había ingresado

Si está inscripto, se consulta:

```csharp
this.presentes.Contains(asistente)
```

Ahora la pregunta no se realiza sobre el Dictionary.

Se realiza sobre:

```text
HashSet<Asistente>
```

Conceptualmente:

```text
Está inscripto
      |
      v
¿está en Presentes?
      |
     Sí
      |
      v
"ya ha realizado el check in"
```

---

# 15. Tercer caso: check-in correcto

Si:

```text
está inscripto
```

y además:

```text
NO está en presentes
```

se ejecuta:

```csharp
this.presentes.Add(asistente);
```

Ahora queda registrado como presente.

Después se muestra la bienvenida.

---

# 16. El polimorfismo dentro de `Evento`

Esta línea es especialmente importante:

```csharp
asistente.InformarBeneficio()
```

`Evento` trabaja solamente con:

```text
Asistente
```

No necesita hacer algo como:

```text
si es General...
si es VIP...
si es Orador...
```

Simplemente envía el mismo mensaje:

```text
InformarBeneficio()
```

y cada objeto responde según su tipo real.

Conceptualmente:

```text
             Evento
                |
                | InformarBeneficio()
                v
            Asistente
                |
       +--------+--------+
       |        |        |
    General    VIP     Orador
       |        |        |
       v        v        v
 respuesta   respuesta  respuesta
 propia      propia     propia
```

Este es el punto donde el polimorfismo
de la jerarquía se utiliza efectivamente.

---

# 17. Interacción entre `Dictionary` y `HashSet`

Las dos colecciones cumplen responsabilidades
diferentes.

## Dictionary

```csharp
Dictionary<int, Asistente>
```

responde:

```text
¿Quién está inscripto?
```

y permite buscar utilizando:

```text
DNI
```

## HashSet

```csharp
HashSet<Asistente>
```

responde:

```text
¿Quién ya realizó check-in?
```

Por eso ambas colecciones trabajan juntas:

```text
            EVENTO
              |
      +-------+-------+
      |               |
      v               v

Dictionary         HashSet
participantes      presentes

inscriptos         ingresaron
      |               |
      +-------+-------+
              |
              v
         Check-in
```

---

# 18. `InformarResumen()`

El método:

```csharp
public string InformarResumen()
```

calcula tres valores:

```text
totalInscriptos
totalPresentes
totalAusentes
```

Primero inicializa:

```csharp
int totalInscriptos = 0;
int totalPresentes = 0;
```

---

# 19. Contar inscriptos

Se recorre:

```csharp
foreach (var unInscripto in participantes)
{
    totalInscriptos++;
}
```

Por cada elemento del Dictionary:

```text
totalInscriptos + 1
```

Conceptualmente:

```text
participantes
     |
   foreach
     |
     v
totalInscriptos
```

---

# 20. Contar presentes

Después se recorre:

```csharp
foreach (var unPresente in presentes)
{
    totalPresentes++;
}
```

Por cada elemento del HashSet:

```text
totalPresentes + 1
```

---

# 21. Calcular ausentes

Los ausentes se obtienen mediante:

```csharp
int totalAusentes =
    totalInscriptos - totalPresentes;
```

Por ejemplo:

```text
3 inscriptos
-
2 presentes
=
1 ausente
```

---

# 22. Resultado del resumen

Finalmente devuelve:

```csharp
return $"El total de inscriptos es {totalInscriptos}, con un total de presentes de {totalPresentes}, con un total de ausentes de {totalAusentes}";
```

Por ejemplo:

```text
El total de inscriptos es 3,
con un total de presentes de 2,
con un total de ausentes de 1
```

---

# 23. Responsabilidad de `Evento`

## Qué tiene

```text
Informacion
Regalos
Participantes
Presentes
```

## Qué sabe hacer

```text
AgregarParticipante()
RegistrarCheckIn()
InformarResumen()
```

Por lo tanto:

```text
Evento
   |
   +-- administra inscripciones
   |
   +-- administra check-in
   |
   +-- utiliza Dictionary
   |
   +-- utiliza HashSet
   |
   +-- utiliza polimorfismo
   |
   +-- informa el resumen
```

---

# 24. Vista completa del modelo hasta este punto

```text
                     Asistente
                    <<abstract>>
                         ▲
              ┌──────────┼──────────┐
              |          |          |
           General      VIP      Orador
                         |          |
                       regalo      tema


                         Evento
                           |
             +-------------+-------------+
             |                           |
             v                           v
Dictionary<int, Asistente>       HashSet<Asistente>
      participantes                   presentes
             |                           |
             |                           |
             +-------------+-------------+
                           |
                           v
                     RegistrarCheckIn()
                           |
                           v
                 asistente.InformarBeneficio()
                           |
                           v
                      POLIMORFISMO
```

---

# 25. Idea central

`Evento` es el punto en el que se integran
los conceptos principales del ejercicio:

```text
                 EVENTO
                    |
       +------------+------------+
       |            |            |
       v            v            v
  Dictionary     HashSet     Polimorfismo
       |            |            |
       v            v            v
 inscriptos     presentes   beneficios
```

`Dictionary` resuelve la búsqueda directa
de inscriptos por DNI.

`HashSet` permite registrar quiénes ya ingresaron
y detectar repetidos.

La jerarquía `Asistente` permite que `Evento`
solicite:

```csharp
asistente.InformarBeneficio();
```

sin necesitar conocer si está trabajando
con un `General`, un `VIP` o un `Orador`.

De esta manera, `Evento` concentra la
responsabilidad de administrar el acceso,
mientras cada tipo de asistente conserva
la responsabilidad de informar sus propios beneficios.
````

Este bloque respeta exactamente la implementación entregada por el profesor, incluida la inicialización de las colecciones dentro de `AgregarParticipante()` y `RegistrarCheckIn()`.
