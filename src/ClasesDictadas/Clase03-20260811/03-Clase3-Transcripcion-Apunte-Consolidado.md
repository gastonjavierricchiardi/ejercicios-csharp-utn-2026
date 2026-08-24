# Programación II · Unidad 1 · Clase 3
## Apunte consolidado de la clase — Construcción de objetos, sobrecarga y herencia

**Estado:** consolidado a partir de la PPT guía de Clase 3, la transcripción de la clase, el código trabajado en vivo y el apunte oficial de Unidad 1.

> Objetivo de la clase: crear e inicializar objetos respetando el encapsulamiento e introducir sobrecarga y herencia.

---

## 1. Encapsulamiento: el objeto administra su propio estado

La idea central de esta clase no es simplemente aprender a escribir `get` y `set`.

El profesor remarcó que, en POO, **el objeto debe ser responsable de administrar su propio estado**. Por eso, por convención, los atributos se mantienen privados y el acceso desde el exterior se realiza mediante una interfaz controlada por el propio objeto.

```csharp
private string name;
```

Si `name` es `private`, desde afuera de la clase no se puede hacer:

```csharp
unaPersona.name = "Gastón";
```

El acceso debe pasar por métodos o properties que la clase exponga.

Esto permite que el objeto pueda decidir qué hacer cuando recibe o devuelve un dato: validar, limpiar espacios, modificar el formato, limitar valores, etc.

Ejemplo trabajado en clase:

```csharp
public string GetName()
{
    return name;
}

public void SetName(string name)
{
    this.name = name.Trim();
}
```

La idea importante es:

**atributo privado → acceso controlado por el objeto**

Los getters y setters son una consecuencia de esa decisión de encapsulamiento.

---

## 2. Getters y setters

Un **getter** permite leer un valor.

```csharp
public string GetName()
{
    return name;
}
```

Un **setter** permite modificarlo.

```csharp
public void SetName(string name)
{
    this.name = name;
}
```

Se usan como métodos:

```csharp
unaPersona.SetName("Gastón");

string nombre = unaPersona.GetName();
```

No es obligatorio tener siempre ambos.

Un atributo puede quedar:

- solo para lectura;
- solo para escritura;
- para lectura y escritura.

La decisión depende de lo que el objeto deba permitir.

---

## 3. Properties de C#

C# ofrece una forma abreviada para representar el caso frecuente de un dato con acceso mediante `get` y `set`.

```csharp
public string LastName { get; set; }
```

Desde el código que usa el objeto, una property se utiliza con sintaxis similar a un atributo:

```csharp
unaPersona.LastName = "Ricchi";

string apellido = unaPersona.LastName;
```

En cambio, con getters y setters tradicionales se invocan métodos:

```csharp
unaPersona.SetName("Gastón");

string nombre = unaPersona.GetName();
```

También puede declararse una property solo con el acceso que se quiera habilitar.

```csharp
public int Id { get; }
```

### Qué quiso mostrar el profesor

Para los casos simples, getters/setters tradicionales y properties cumplen el mismo objetivo de encapsular el acceso.

La ventaja práctica de la property es que permite escribir menos código.

### Importante sobre la demostración de la property completa

Durante la clase el profesor intentó expandir una property para agregar lógica interna y tuvo varias correcciones de sintaxis en vivo. Él mismo aclaró que **no era algo en lo que quisiera hacer hincapié todavía**.

Por lo tanto, para esta clase queda como contenido firme:

```csharp
public string LastName { get; set; }
```

La forma completa de una property con lógica interna queda **pendiente de una explicación posterior**, y no conviene tomar el tramo fallido de la demostración como modelo de sintaxis.

---

## 4. Convenciones de nombres mencionadas

El profesor aclaró las convenciones que pretende utilizar en los ejemplos.

### PascalCase

Para nombres como:

- clases;
- métodos;
- properties;
- namespaces.

Ejemplos:

```csharp
Persona
GetName
LastName
CalcularBonoAntiguedad
```

### camelCase

Para variables y parámetros.

Ejemplos:

```csharp
unaPersona
name
lastName
apellido
```

El uso de `_name` con guion bajo fue mencionado como una convención posible, pero **no como una obligación de la cátedra**.

También indicó que `this` puede utilizarse para evitar confusiones sin necesidad de recurrir al guion bajo.

---

## 5. `new`, objeto y referencia

Para crear un objeto se utiliza `new`.

```csharp
Persona unaPersona = new Persona();
```

La idea presentada en clase es:

```text
unaPersona
    │
    │ referencia
    ▼
objeto Persona
```

`unaPersona` no es el objeto mismo: es una variable que mantiene una **referencia** al objeto creado.

El objeto ocupa un espacio de memoria y contiene su propio estado.

A sus miembros públicos se accede mediante el punto:

```csharp
unaPersona.GetName();
unaPersona.LastName;
```

### Reasignación de una referencia

También se mostró:

```csharp
unaPersona = new Persona();
```

La variable `unaPersona` pasa a referenciar un objeto nuevo.

El profesor introdujo además la idea del **Garbage Collector**: si un objeto deja de tener referencias, la plataforma puede recuperar posteriormente esa memoria. Fue una explicación conceptual y no un tema para implementar manualmente.

---

## 6. Constructor

El constructor es el método especial que se ejecuta al crear una instancia.

Tiene el mismo nombre que la clase y **no declara tipo de retorno**.

```csharp
public Persona()
{
}
```

Es el lugar donde se colocan los valores o condiciones que deben cumplirse al crear el objeto.

### Constructor vacío

```csharp
public Persona()
{
    this.name = "Juan";
    this.LastName = "Perez";
}
```

Entonces:

```csharp
Persona unaPersona = new Persona();
```

crea una persona ya inicializada con esos valores.

### Constructor con parámetros

```csharp
public Persona(string name, string lastName)
{
    this.name = name;
    this.LastName = lastName;
}
```

Permite crear directamente:

```csharp
Persona unaPersona = new Persona("pepe", "loco");
```

Esto evita crear primero el objeto y luego realizar varios setters separados.

### Regla clave

Si una clase no declara constructores, está disponible el constructor vacío implícito.

Pero si se declara algún constructor propio:

```csharp
public Persona(string name, string lastName)
{
}
```

el constructor vacío deja de estar disponible automáticamente.

Si también se quiere permitir:

```csharp
new Persona();
```

hay que declarar explícitamente:

```csharp
public Persona()
{
}
```

---

## 7. Constructor y datos que no pueden modificarse después

El profesor relacionó los constructores con el encapsulamiento.

Si un dato es obligatorio para crear el objeto, puede pedirse en el constructor.

Si además ese dato no debe cambiar posteriormente, no se expone un setter.

La idea es:

```text
dato obligatorio
      ↓
constructor

dato no modificable después
      ↓
sin setter
```

Así el objeto puede nacer con un estado válido sin permitir que ese valor sea reemplazado libremente luego.

---

## 8. `this`

`this` hace referencia al objeto actual.

Su uso más importante en esta clase fue resolver nombres iguales entre un atributo y un parámetro.

```csharp
public Persona(string name)
{
    this.name = name;
}
```

Se interpreta así:

```text
this.name  → atributo del objeto
name       → parámetro recibido
```

También puede utilizarse aunque no exista ambigüedad:

```csharp
return this.name;
```

El profesor aclaró que en esos casos es opcional. Él suele escribirlo por preferencia personal, aunque el IDE pueda marcarlo como redundante.

Por lo tanto:

**para la cátedra no es obligatorio escribir `this` cuando no hace falta desempatar.**

---

## 9. Sobrecarga — overloading

La sobrecarga permite tener métodos con el **mismo nombre** pero con diferentes parámetros.

Ejemplo conceptual:

```csharp
public string ContactInfo(string name, string lastName)
{
    // ...
}

public string ContactInfo(string name, string lastName, int dni)
{
    // ...
}
```

El compilador determina qué versión utilizar según los argumentos de la llamada.

```csharp
ContactInfo("Juan", "Perez");
ContactInfo("Juan", "Perez", 12345678);
```

### Qué puede cambiar

Para que exista una sobrecarga válida deben cambiar los parámetros en:

- cantidad;
- tipo;
- orden de tipos.

### Qué NO diferencia una firma

El nombre del parámetro no alcanza.

Estas dos versiones entran en conflicto:

```csharp
public string GetClientInfo(int account)
public string GetClientInfo(int id)
```

Para el compilador ambas reciben exactamente un `int`.

### Idea que remarcó el profesor

La sobrecarga permite mantener **un mismo nombre para operaciones conceptualmente similares**, evitando crear nombres diferentes o llenar un único método de condiciones para detectar qué parámetros recibió.

Además, la selección de la sobrecarga se resuelve en compilación.

---

## 10. Herencia

La herencia fue presentada como el primer mecanismo que empieza a mostrar de manera clara la **reutilización** dentro de POO.

Ejemplo trabajado:

```csharp
public class Empleado : Persona
{
}
```

Se lee:

**Empleado es una Persona.**

`Persona` es la clase base.

`Empleado` es la clase derivada o subclase.

La idea de modelado es colocar en `Persona` aquello que es común y en `Empleado` solamente lo específico.

```text
Persona
├── name
├── LastName
└── comportamiento común
        │
        ▼
Empleado
├── Legajo
├── Antiguedad
└── comportamiento específico
```

En lugar de copiar en `Empleado` todo el código de `Persona`, se reutiliza mediante herencia.

---

## 11. Ejemplo de `Empleado` realizado en clase

```csharp
public class Empleado : Persona
{
    public int Legajo { get; set; }
    public int Antiguedad { get; set; }

    public double CalcularBonoAntiguedad()
    {
        return Antiguedad * 1.25;
    }
}
```

`Empleado` agrega:

- `Legajo`;
- `Antiguedad`;
- `CalcularBonoAntiguedad()`.

Pero además puede utilizar el comportamiento público heredado de `Persona`.

La intención del profesor fue mostrar:

```text
lo común        → Persona
lo específico   → Empleado
```

y evitar copiar y pegar código.

---

## 12. `private` y `protected` en una jerarquía

Un punto importante de la explicación fue que un atributo `private` de `Persona` no puede ser accedido directamente desde `Empleado`.

Por ejemplo, si `name` es:

```csharp
private string name;
```

`Empleado` no debería manipular directamente `name`.

Debe utilizar la forma de acceso definida por `Persona`, por ejemplo:

```csharp
GetName()
```

o una property pública/protegida.

Si realmente se necesita permitir que las subclases accedan directamente a ese miembro, aparece `protected`.

```csharp
protected string name;
```

La idea que transmitió el profesor fue:

- `private` → lo administra directamente la propia clase;
- `protected` → también puede ser accedido por las clases de la jerarquía;
- `public` → puede ser utilizado desde cualquier parte habilitada.

No se debe pasar a `protected` automáticamente: primero hay que preguntarse si la subclase realmente necesita ese acceso directo.

---

## 13. Herencia simple

C# utiliza **herencia simple de clases**.

Una clase puede heredar de una sola clase base.

```csharp
public class Empleado : Persona
{
}
```

`Empleado` no puede heredar simultáneamente de otra segunda clase.

Sin embargo, una clase base puede tener muchas subclases:

```text
          Persona
          /    \
         /      \
   Empleado   Proveedor
```

Y una subclase puede volver a tener sus propias subclases.

La restricción es:

**cada clase tiene una sola clase padre directa.**

---

## 14. Código de `Program.cs` conservado de la clase

El código entregado muestra la evolución de la demostración.

Las líneas comentadas representan versiones anteriores que fueron reemplazadas por mecanismos nuevos.

```csharp
Persona unaPersona = new Persona("pepe", "loco");

// unaPersona.SetName("    gastón     ");

// unaPersona.LastName = "    ricchi";

string apellido = unaPersona.LastName;

Console.WriteLine("Hola " + unaPersona.GetName() + " !");
Console.WriteLine("Hola " + unaPersona.LastName + ", " + unaPersona.GetName() + " !");

// String interpolation
unaPersona = new Persona();

unaPersona.SetName("Juancito");

Console.WriteLine($"Hola {unaPersona.LastName}, {unaPersona.GetName()} !");

Empleado unEmpleado = new Empleado();

unEmpleado
```

La última línea quedó incompleta porque la demostración continuaba mostrando qué miembros ofrecía `Empleado`.

No debe interpretarse como código terminado.

---

## 15. Sintaxis incidental que apareció durante la clase

Aunque no era el objetivo principal, se utilizaron algunas herramientas de C#.

### String interpolation

```csharp
Console.WriteLine($"Hola {unaPersona.LastName}, {unaPersona.GetName()} !");
```

Permite insertar expresiones dentro de una cadena utilizando `{ }`.

### `Trim()`

Se utilizó para mostrar por qué conviene que la modificación del estado pase por el objeto.

```csharp
this.name = name.Trim();
```

Elimina espacios al comienzo y al final.

### `ToUpper()`

Se utilizó como ejemplo de transformación que podría realizar un getter antes de devolver un valor.

### `var`

El profesor mostró brevemente que C# puede inferir el tipo local:

```csharp
var unEmpleado = new Empleado();
```

Fue una demostración secundaria, no el contenido central de la clase.

---

## 16. Temas que aparecieron como adelanto, pero todavía no quedaron desarrollados

Durante las preguntas y la explicación de herencia aparecieron conceptos de clases posteriores.

### Sobreescritura / redefinición

El profesor adelantó que una subclase puede redefinir un comportamiento heredado y mencionó:

```csharp
virtual
override
```

Pero aclaró que se verá con mayor profundidad después.

**Estado: ADELANTO.**

### Clases y métodos abstractos

Se utilizó el ejemplo de `FiguraGeometrica` para anticipar que puede existir una clase general cuyo comportamiento concreto se defina en las subclases.

También mencionó que una clase como `Persona` podría llegar a ser abstracta dependiendo del modelo.

**Estado: ADELANTO.**

### Upcasting

Se mostró conceptualmente que un objeto `Empleado` puede ser observado mediante una variable de tipo `Persona`, porque:

**un Empleado es una Persona.**

Esto abre posteriormente la puerta al polimorfismo.

**Estado: INTRODUCCIÓN CONCEPTUAL, no tema desarrollado todavía.**

### Constructores en herencia

Se mencionó que una subclase deberá relacionar su constructor con el constructor de la clase base.

El profesor dejó explícitamente esta parte para una clase posterior.

**Estado: PENDIENTE.**

---

## 17. Qué quedó firme al terminar la Clase 3

Al finalizar esta clase deberíamos poder explicar y reconocer:

1. por qué los atributos se mantienen privados;
2. qué función cumplen getters y setters;
3. qué es una property y cómo se usa;
4. cómo crear un objeto con `new`;
5. qué significa que una variable referencia a un objeto;
6. para qué sirve un constructor;
7. la diferencia entre constructor vacío y constructor con parámetros;
8. qué ocurre con el constructor vacío al declarar otro constructor;
9. para qué se usa `this`;
10. qué significa sobrecargar un método;
11. cómo se distingue una sobrecarga por sus parámetros;
12. qué significa que una clase herede de otra;
13. por qué `Empleado : Persona` representa que **Empleado es una Persona**;
14. qué código se reutiliza mediante herencia;
15. la diferencia práctica entre `private`, `protected` y `public` dentro de una jerarquía;
16. que C# admite herencia simple de clases.

---

## 18. Idea central de la clase

La Clase 3 conecta dos objetivos.

Primero:

```text
ENCAPSULAMIENTO
atributos privados
        ↓
getters / setters / properties
        ↓
el objeto controla su estado
```

Después:

```text
REUTILIZACIÓN
características comunes
        ↓
clase base
        ↓
herencia
        ↓
subclases con comportamiento específico
```

El salto conceptual de la clase es pasar de **crear una clase aislada** a empezar a pensar en **objetos que administran su propio estado y clases que se relacionan mediante una jerarquía**.
