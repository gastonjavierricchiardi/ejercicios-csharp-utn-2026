# Clase 09 — 01/09/2026

## Diccionarios, conjuntos y miembros de clase

**Materia:** Programación II  
**Unidad:** 1 — Programación Orientada a Objetos  
**Clase:** 09  
**Fecha:** 01/09/2026  
**Nombre del archivo:** `09-Clase9-Transcripcion-Apunte-Consolidado.md`  
**Estado:** CONSOLIDADO

## Fuentes utilizadas

- `09 GMT20260901.txt` — transcripción de la clase.
- `09 Clase9 POO Unidad1.pdf` — PPT oficial de la Clase 09.
- `diagrama.dio` / diagrama de clase entregado.
- Código trabajado:
  - `Program.cs`
  - `Persona.cs`
  - `Empleado.cs`
  - `Proveedor.cs`
  - `Empresa.cs`
  - `ICosteable.cs`
  - `DatosContacto.cs`
  - `Logger.cs`

> **Criterio de consolidación:** se conserva el contenido académico efectivamente trabajado y se cruza con la PPT, el código y el diagrama. Las demostraciones en vivo se ordenan para hacerlas legibles, pero no se completan silenciosamente con teoría externa. Cuando el diagrama, la PPT y los archivos `.cs` no coinciden exactamente, la diferencia se deja indicada.

---

# 1. Objetivo de la clase

La clase continúa el trabajo con **colecciones** iniciado anteriormente y completa las colecciones principales que se utilizarán durante la cursada.

Los temas centrales son:

1. `Dictionary<K,V>`.
2. `HashSet<T>`.
3. Igualdad e identidad de objetos mediante `Equals()` y `GetHashCode()`.
4. Miembros `static`.
5. Valores de solo lectura mediante `static readonly`.

La PPT sintetiza el objetivo como:

> Completar las colecciones principales y presentar los miembros estáticos y las constantes.

El docente aclara que existen más tipos de colecciones en .NET, pero para los ejercicios de la cursada se trabajará con un conjunto reducido de herramientas y se priorizarán soluciones simples.

---

# 2. Repaso: polimorfismo y `List<T>`

La clase comienza retomando el ejemplo anterior de la calculadora de costos.

El diseño utiliza una colección:

```csharp
List<ICosteable>
```

La idea es que dentro de la lista puedan convivir objetos de clases diferentes siempre que puedan ser tratados mediante el mismo tipo `ICosteable`.

En el diseño previo aparecen, entre otros:

- `Empleado`;
- `Proveedor`;
- `Empresa`.

El criterio repasado es:

```text
objetos de distintas clases
        ↓
implementan el mismo contrato
        ↓
pueden verse como ICosteable
        ↓
pueden almacenarse juntos en List<ICosteable>
```

Esto vuelve a mostrar el polimorfismo mediante interfaces.

El docente remarca que una colección también es un **objeto** y que al instanciarla se debe indicar el tipo de elementos que podrá contener.

```csharp
var items = new List<ICosteable>();
```

No se puede agregar cualquier tipo de dato: solamente objetos compatibles con el tipo declarado para la colección.

---

# 3. Criterio de trabajo con colecciones

El docente insiste en no utilizar operaciones complejas de la API si todavía no fueron trabajadas.

Para los ejercicios de la cursada se priorizan mecanismos directos.

Ejemplo conceptual para acumular costos:

```csharp
var total = 0;

foreach (var item in costos)
{
    total += item.CalcularCosto();
}
```

La idea es resolver el problema con las herramientas conocidas antes de buscar operaciones más sofisticadas de las colecciones.

---

# 4. `Dictionary<K,V>`: clave y valor

Un `Dictionary` almacena pares:

```text
clave → valor
```

A diferencia de una `List`, donde el acceso puede realizarse por posición o mediante recorrido, en un diccionario el valor puede recuperarse utilizando una **clave**.

La clave debe identificar el dato con el mismo criterio utilizado al almacenarlo.

El docente lo relaciona conceptualmente con la idea de **posición única predecible** trabajada anteriormente, pero sin quedar limitado a un rango numérico que deba transformarse manualmente en una posición.

Ejemplo conceptual mencionado:

```text
patente → camión
legajo  → empleado
```

La clave puede representar un dato propio del dominio.

---

# 5. Tipos genéricos en `Dictionary<K,V>`

En un diccionario deben indicarse dos tipos:

```csharp
Dictionary<K, V>
```

donde:

- `K` representa el tipo de la clave;
- `V` representa el tipo del valor almacenado.

En el ejemplo trabajado:

```csharp
Dictionary<int, Empleado> empleados =
    new Dictionary<int, Empleado>();
```

Se interpreta como:

```text
clave  → int
valor  → Empleado
```

El `int` no significa automáticamente “legajo”.

El lenguaje no interpreta qué significado de negocio tiene la clave.

Es responsabilidad del diseño decidir que ese entero representa el `Legajo` y utilizar siempre ese mismo criterio para guardar y recuperar.

---

# 6. Agregar empleados al diccionario

El código trabajado agrega un empleado utilizando su legajo como clave:

```csharp
Dictionary<int, Empleado> empleados = new Dictionary<int, Empleado>();

empleados.Add(otroEmpleado.Legajo, otroEmpleado);
```

La relación queda conceptualmente:

```text
otroEmpleado.Legajo → otroEmpleado
```

El docente remarca que la clave debe ser adecuada para identificar unívocamente al objeto asociado.

Si el sistema decide utilizar `Legajo`, debe mantener ese criterio al realizar búsquedas posteriores.

---

# 7. Recuperar por clave

El acceso utilizado en C# durante la clase es:

```csharp
int legjoBuscado = otroEmpleado.Legajo;

Console.WriteLine(
    empleados[legjoBuscado].Saludar()
);
```

El índice entre corchetes no representa una posición de la colección.

Representa la **clave** utilizada para recuperar el valor.

Conceptualmente:

```text
legajoBuscado
      ↓
Dictionary<int, Empleado>
      ↓
Empleado
```

Una vez obtenido el objeto, se pueden utilizar sus miembros públicos.

---

# 8. `ContainsKey`, `Remove` y ausencia de valor

El docente muestra que antes de asumir que una clave existe puede verificarse mediante:

```csharp
empleados.ContainsKey(legajo)
```

En el diseño de `RRHH` se plantea conceptualmente un método:

```csharp
public Empleado ObtenerEmpleado(int legajo)
{
    if (empleados.ContainsKey(legajo))
        return empleados[legajo];

    return null;
}
```

La posibilidad de lanzar una excepción se menciona como un mecanismo posterior, todavía no trabajado en profundidad.

Para esta clase se utiliza `null` como representación de ausencia del objeto.

También se menciona:

```csharp
empleados.Remove(legajo);
```

que elimina utilizando la clave.

---

# 9. Recorrido de un diccionario

Un diccionario también puede recorrerse mediante `foreach`.

Código trabajado:

```csharp
foreach (var empleado in empleados)
{
    Console.WriteLine(
        $"clave:{empleado.Key} valor: {empleado.Value}"
    );
}
```

Cada elemento recorrido representa el par:

```text
Key
Value
```

Por lo tanto, durante el recorrido pueden consultarse ambos componentes.

El docente aclara que `var` se usa aquí principalmente para evitar escribir un tipo genérico largo.

---

# 10. `var` como inferencia de tipo

Durante las consultas aparece nuevamente `var`.

El docente explica que `var` permite que el compilador determine el tipo a partir del contexto.

Por ejemplo:

```csharp
var tercerEmpleado =
    new Empleado("Roberto", "Sanchez", 11222333, 50);
```

El tipo sigue determinándose en compilación.

No significa que la variable quede sin tipo.

También recuerda un caso en el que no conviene utilizarlo si se quiere expresar deliberadamente otro tipo de referencia:

```csharp
Persona unEmpleado =
    new Empleado("Leo", "Pinkas", 1213121, 20);
```

Si allí se utilizara `var`, la variable sería inferida como `Empleado` y ya no se estaría mostrando el upcasting que se quiere representar.

Criterio docente:

> Si `var` genera confusión, no es necesario utilizarlo.

---

# 11. La colección debe tener un responsable

Uno de los puntos de diseño más importantes de la clase aparece al trasladar el diccionario desde `Program` hacia una clase responsable.

En el diagrama se incorpora:

```text
RRHH
------------------------------
- empleados: Dictionary<int, Empleado>
------------------------------
+ CrearEmpleado(Empleado)
+ ObtenerEmpleado(legajo:int): Empleado
```

La idea es que `Program` sirve para probar el diseño, pero la lógica del ejercicio no debería quedar concentrada allí.

`RRHH` sería responsable de:

- administrar la colección;
- agregar empleados;
- buscar empleados;
- validar modificaciones;
- decidir qué información puede alterarse.

Conceptualmente:

```text
Program
   ↓
RRHH
   ↓
Dictionary<int, Empleado>
```

No se busca exponer libremente la colección para que cualquier objeto pueda modificarla directamente.

---

# 12. Encapsulamiento aplicado al `Legajo`

Al utilizar el `Legajo` como clave del diccionario aparece una consecuencia de diseño.

Si después de registrar al empleado alguien modifica libremente su legajo, la relación:

```text
clave → objeto
```

queda inconsistente respecto del estado actual del empleado.

El docente plantea entonces que, si el legajo no debería cambiar:

- no debería exponerse libremente un setter;
- debería establecerse al crear el empleado.

También observa que, si el legajo es necesario para identificar al empleado, un constructor vacío permite crear empleados con un legajo no configurado, por lo que el diseño debería revisarse.

Esta observación conecta nuevamente las colecciones con el encapsulamiento:

> El objeto y la clase responsable de la colección deben proteger los datos que sostienen la identidad utilizada por el sistema.

---

# 13. Las colecciones almacenan referencias

La clase vuelve sobre un concepto central de POO:

> Cuando una colección almacena objetos, mantiene referencias a esos objetos.

Si un empleado se agrega a un diccionario y luego se obtiene mediante su clave, la referencia recuperada corresponde al objeto almacenado.

Conceptualmente:

```text
otroEmpleado ──────┐
                   │
                   ▼
               [ objeto ]
                   ▲
                   │
empleados[legajo] ─┘
```

No se está creando automáticamente una copia independiente.

El docente usa esta explicación para advertir que entregar una referencia permite que otro código pueda modificar el mismo objeto, siempre dentro de lo que sus miembros públicos permitan.

---

# 14. `ContainsValue` e identidad

Además de `ContainsKey`, el docente menciona que un diccionario permite consultar si contiene determinado valor.

La discusión sirve para introducir el siguiente tema:

```text
¿qué significa que dos objetos sean iguales?
```

Con el comportamiento por defecto, dos objetos distintos que tengan datos iguales siguen siendo objetos distintos.

Esto lleva a diferenciar:

- **identidad / referencia**;
- **igualdad definida para el dominio**.

---

# 15. `HashSet<T>`: conjunto de elementos únicos

La segunda colección nueva de la clase es:

```csharp
HashSet<T>
```

Su característica principal es que no admite duplicados según el criterio de igualdad utilizado.

Ejemplo de la PPT:

```csharp
HashSet<int> numbers = new HashSet<int>();

numbers.Add(1); // true
numbers.Add(2); // true
numbers.Add(1); // false
```

`Add()` devuelve:

```text
true  → el elemento fue agregado
false → el elemento ya estaba
```

No se lanza una excepción simplemente porque el elemento ya exista.

La colección se utiliza cuando interesa garantizar unicidad.

---

# 16. `HashSet<T>` con objetos propios

Con datos simples como enteros el ejemplo es directo.

Con objetos propios aparece el problema central de la clase:

```text
¿cuándo consideramos que dos objetos representan el mismo elemento?
```

El docente trabaja este problema con `Empleado`.

Dos instancias diferentes pueden tener:

- nombres distintos;
- antigüedad distinta;
- referencias distintas;

pero compartir el mismo `Legajo`.

Si para el sistema el legajo define la identidad lógica del empleado, ese criterio debe expresarse en la clase.

---

# 17. Todos los objetos heredan de `object`

Durante la explicación el docente muestra los métodos que aparecen disponibles en cualquier objeto:

```text
Equals()
GetHashCode()
GetType()
ToString()
```

Estos miembros provienen de `object`.

La clase puede heredar de otra clase de la jerarquía y, en última instancia, continúa disponiendo de ese comportamiento común.

Para el caso trabajado, los métodos relevantes son:

```csharp
Equals()
GetHashCode()
```

---

# 18. `Equals()`: definir igualdad

En `Empleado` se redefine `Equals()` para establecer que dos empleados son iguales cuando poseen el mismo `Legajo`.

El archivo final entregado queda:

```csharp
public override bool Equals(object obj)
{
    return obj is Empleado
        && ((Empleado)obj).Legajo == this.Legajo;
}
```

La lógica es:

```text
obj debe ser Empleado
        ↓
comparar su Legajo
        ↓
con this.Legajo
```

Por lo tanto, para este ejemplo:

```text
Empleado A
Legajo = 11222333

Empleado B
Legajo = 11222333

Equals() → true
```

aunque se trate de dos instancias diferentes.

---

# 19. `==` no fue redefinido

El docente distingue explícitamente el operador:

```csharp
==
```

del método:

```csharp
Equals()
```

En el código se prueban ambos:

```csharp
var esElMismo =
    tercerEmpleado == otroEmpleado;

var esIgual =
    tercerEmpleado.Equals(otroEmpleado);
```

En este ejercicio se redefine `Equals()`, pero **no se redefine el operador `==`**.

Por lo tanto, la demostración busca contrastar:

```text
==       → referencia / identidad del objeto
Equals() → criterio redefinido por Legajo
```

---

# 20. `GetHashCode()`

El segundo método sobreescrito es `GetHashCode()`.

El archivo final queda:

```csharp
public override int GetHashCode()
{
    return this.Legajo;
}
```

El criterio trabajado es que `GetHashCode()` debe estar relacionado con el mismo dato utilizado por `Equals()`.

En este ejemplo:

```text
Equals()      → usa Legajo
GetHashCode() → usa Legajo
```

La explicación del docente remarca que si dos objetos son considerados iguales, deben producir un hash compatible con ese mismo criterio.

---

# 21. Prueba concreta con `HashSet<Empleado>`

El código de clase crea:

```csharp
HashSet<Empleado> listaUnicaEmpleados =
    new HashSet<Empleado>();
```

Primero agrega dos empleados con legajos diferentes:

```csharp
listaUnicaEmpleados.Add((Empleado)unEmpleado);
listaUnicaEmpleados.Add(otroEmpleado);
```

Luego crea una tercera instancia:

```csharp
var tercerEmpleado =
    new Empleado(
        "Roberto",
        "Sanchez",
        11222333,
        50
    );
```

`tercerEmpleado` comparte el legajo de `otroEmpleado`.

Después se intenta agregar:

```csharp
var result =
    listaUnicaEmpleados.Add(tercerEmpleado);
```

La intención de la prueba es verificar que el conjunto no incorpore al tercer objeto porque, según el criterio definido en `Equals()` y `GetHashCode()`, ya existe un empleado con ese legajo.

Los demás datos pueden ser distintos: el criterio de unicidad elegido para este ejemplo es el `Legajo`.

---

# 22. Igualdad, identidad y diseño

El punto conceptual no es solamente aprender dos métodos de C#.

La clase utiliza `Equals()` y `GetHashCode()` para mostrar que el sistema debe decidir:

```text
¿qué hace que dos objetos sean considerados iguales?
```

El criterio depende del objeto y del problema modelado.

En este caso se decide:

```text
Empleado
   ↓
Legajo
   ↓
criterio de igualdad
```

Esto vuelve a colocar una responsabilidad dentro de la propia clase `Empleado`.

---

# 23. Diferencia con `GenericSet<T>` del apunte

El apunte general de Unidad 1 contiene además una implementación propia:

```csharp
GenericSet<T>
```

Ese ejemplo trabaja la unicidad mediante una función de clave:

```text
getKey
```

y `Persona` expone:

```csharp
GetKey()
```

La clase práctica del 01/09 no utiliza ese `GenericSet<T>`.

El código trabajado utiliza directamente:

```csharp
HashSet<Empleado>
```

y redefine:

```csharp
Equals()
GetHashCode()
```

Por lo tanto, deben mantenerse separados los dos mecanismos:

```text
GenericSet<T> del apunte
→ compara mediante una clave recibida por getKey

Código real de Clase 09
→ usa HashSet<Empleado>
→ redefine Equals()
→ redefine GetHashCode()
```

No corresponde afirmar que el `GenericSet<T>` trabajado anteriormente utilice internamente `Equals()` o `GetHashCode()`.

---

# 24. Miembros `static`

La PPT presenta la diferencia entre:

```text
miembro de instancia
miembro de clase
```

Un miembro de instancia pertenece al objeto particular.

Un miembro marcado como:

```csharp
static
```

pertenece a la clase y se comparte a nivel de clase.

El acceso se realiza utilizando el nombre de la clase.

El código final conserva un ejemplo en `Persona`:

```csharp
public static string FormatearTexto(string valor)
{
    return valor.Trim().ToUpper();
}
```

Y en `Program.cs` aparece:

```csharp
Empleado.FormatearTexto("dsfsdfsd");
```

El objetivo es mostrar un comportamiento que puede utilizarse sin crear primero una instancia específica para invocarlo.

---

# 25. Regla de acceso de `static`

La PPT fija la regla:

```text
miembro de instancia → miembro static
sí puede

miembro static → miembro de instancia
no puede directamente
```

Un método de instancia dispone de un objeto concreto y puede utilizar un miembro de clase.

En cambio, un método `static` no trabaja sobre una instancia particular y no dispone de `this`.

---

# 26. `static readonly`

En `Empleado` aparece:

```csharp
public static readonly double CargasSociales = 1.4;
```

Luego el costo del empleado utiliza ese valor:

```csharp
public double CalcularCosto()
{
    return SueldoBruto * CargasSociales;
}
```

Y desde `Program.cs` se accede mediante la clase:

```csharp
Console.WriteLine(
    $"Las cargas sociales son {Empleado.CargasSociales}"
);
```

La PPT presenta la combinación:

```text
static + readonly
```

como un valor:

- perteneciente a la clase;
- compartido;
- de solo lectura una vez establecido según las reglas vistas.

En el material de la clase se utiliza esta combinación para representar una **constante a nivel de clase**.

---

# 27. Relación entre el código y el diagrama

El diagrama utilizado durante la clase conserva elementos de ejercicios anteriores y agrega nuevos elementos mientras se explica.

Entre los elementos relevantes aparecen:

```text
Persona
Empleado
Proveedor
Empresa
ICosteable
CalculadoraCostos
RRHH
DatosContacto
Categoria
Trainee
Junior
Logger
```

Para Clase 09 son especialmente importantes:

```text
CalculadoraCostos
- costos: List<ICosteable>

RRHH
- empleados: Dictionary<int, Empleado>
```

Esto muestra dos objetos responsables de administrar colecciones diferentes:

```text
CalculadoraCostos
        ↓
List<ICosteable>

RRHH
        ↓
Dictionary<int, Empleado>
```

El criterio docente vuelve a ser:

> la colección forma parte del estado de un objeto responsable y no debería quedar expuesta sin control.

---

# 28. Criterio UML reafirmado durante la clase

Ante una consulta sobre parámetros de métodos, el docente vuelve a aclarar que en el UML se coloca aquello que **aporta información al diseño**.

Por ejemplo:

```text
ObtenerEmpleado(legajo:int): Empleado
```

indica claramente que la búsqueda se realiza por legajo.

En cambio, escribir un nombre redundante para un parámetro cuyo tipo ya comunica suficientemente la intención puede no aportar demasiado.

Criterio:

> En el diagrama, agregar información cuando ayuda a comprender el diseño; no completar mecánicamente por completar.

---

# 29. Diferencias entre diagrama y archivos finales

El material entregado no es una fotografía perfectamente sincronizada entre UML y código.

## `ICosteable`

En el diagrama aparece:

```text
+ CalcularCosto(): double
+ Descripcion(): string
```

Sin embargo, el archivo final `ICosteable.cs` contiene solamente:

```csharp
public interface ICosteable
{
    public double CalcularCosto();
}
```

La transcripción muestra que el docente habla de `Descripcion()` como parte del diseño que venían utilizando, pero el archivo `.cs` disponible no la contiene.

Por lo tanto:

> **No se agrega `Descripcion()` silenciosamente al código consolidado.**

## `Empresa`

El diagrama muestra a `Empresa` vinculada con `ICosteable`.

El archivo final disponible declara:

```csharp
public class Empresa
```

y contiene:

```csharp
public double CalcularCosto()
{
    return 0;
}
```

pero no declara explícitamente:

```csharp
: ICosteable
```

La diferencia se conserva como parte del estado real del material entregado.

## `RRHH`

`RRHH` aparece y se desarrolla en el diagrama y en la explicación, pero no existe un archivo `RRHH.cs` entre los archivos entregados de esta clase.

Por lo tanto se considera:

> **DISEÑO TRABAJADO EN CLASE**, no implementación final disponible.

---

# 30. Código final relevante de `Empleado`

El archivo entregado de `Empleado` concentra dos de los temas principales de la clase:

```csharp
public class Empleado : Persona, ICosteable
{
    public static readonly double CargasSociales = 1.4;

    public double SueldoBruto { get; set; }
    public int Legajo { get; set; }
    public int Antiguedad { get; set; }

    public double CalcularCosto()
    {
        return SueldoBruto * CargasSociales;
    }

    public override bool Equals(object obj)
    {
        return obj is Empleado
            && ((Empleado)obj).Legajo == this.Legajo;
    }

    public override int GetHashCode()
    {
        return this.Legajo;
    }
}
```

En una misma clase aparecen:

```text
static readonly
Equals()
GetHashCode()
```

aplicados sobre un ejemplo concreto del dominio utilizado durante varias clases.

---

# 31. Qué quedó firme al finalizar la Clase 09

Al cerrar esta clase deberíamos poder reconocer y explicar:

1. que una colección es un objeto que almacena referencias a otros objetos;
2. que `Dictionary<K,V>` trabaja con pares clave-valor;
3. que `K` define el tipo de la clave y `V` el tipo del valor;
4. que el significado de la clave lo decide el diseño, no el lenguaje;
5. que la clave debe utilizarse de manera consistente al guardar y recuperar;
6. cómo utilizar `Add`, acceso por `[clave]`, `ContainsKey`, `Remove` y `foreach`;
7. que durante el recorrido de un diccionario se dispone de `Key` y `Value`;
8. que una colección debería ser administrada por el objeto responsable cuando forma parte del dominio;
9. que al trabajar con objetos seguimos manipulando referencias;
10. que `HashSet<T>` representa una colección sin duplicados;
11. que `Add()` en un `HashSet` devuelve `true` o `false` según pueda agregar;
12. la diferencia conceptual entre identidad por referencia e igualdad;
13. que todos los objetos disponen de `Equals()` y `GetHashCode()` provenientes de `object`;
14. que esos métodos pueden redefinirse para expresar el criterio de igualdad del dominio;
15. que en el ejemplo de `Empleado` la igualdad se define mediante `Legajo`;
16. que `==` no fue redefinido en el ejercicio;
17. que el `HashSet<Empleado>` utiliza el criterio definido para evitar empleados duplicados;
18. qué diferencia existe entre un miembro de instancia y un miembro `static`;
19. que los miembros `static` se acceden a nivel de clase;
20. la regla de acceso: instancia → `static` sí; `static` → instancia no directamente;
21. que `static readonly` se utiliza en el material como valor compartido y de solo lectura a nivel de clase.

---

# 32. Idea central de la clase

La Clase 09 conecta tres ideas que hasta ahora podían verse separadas.

```text
COLECCIONES
    │
    ├── Dictionary
    │      └── identificar por una clave
    │
    └── HashSet
           └── garantizar unicidad
                   │
                   ▼
          IGUALDAD DE OBJETOS
          Equals / GetHashCode
```

Y, paralelamente:

```text
OBJETO / INSTANCIA
      │
      └── miembros propios de cada objeto

CLASE
      │
      └── miembros static compartidos
              │
              └── static readonly
```

La clase no se limita a presentar nuevas estructuras de datos.

También vuelve sobre criterios centrales de diseño orientado a objetos:

- quién administra una colección;
- qué dato identifica a un objeto;
- qué significa considerar iguales dos objetos;
- qué estado pertenece a cada instancia;
- qué información pertenece conceptualmente a la clase.

---

# Estado final

**TRANSCRIPCIÓN / APUNTE CONSOLIDADO — CLASE 09**

Fuentes cruzadas:

```text
PPT
+ transcripción
+ código
+ UML
```

Estado de los puntos principales:

```text
Dictionary<K,V>              → VALIDADO
HashSet<T>                   → VALIDADO
Equals()                     → VALIDADO EN CLASE Y CÓDIGO
GetHashCode()                → VALIDADO EN CLASE Y CÓDIGO
== vs Equals()               → VALIDADO EN CLASE Y CÓDIGO
referencias en colecciones   → VALIDADO
RRHH administra Dictionary   → VALIDADO COMO DISEÑO
static                       → VALIDADO EN PPT Y CÓDIGO
static readonly              → VALIDADO EN PPT Y CÓDIGO
GenericSet<T> con getKey     → MATERIAL DEL APUNTE; MECANISMO DISTINTO
```
