# Respuestas erradas

## Auto evaluación 1

### Pregunta 5

**¿Qué ocurre al compilar el siguiente código?**

```CS

public class Puerta
{
    private bool abierta;
}

public class Program
{
static void Main()
    {
        Puerta p = new Puerta();
        p.abierta = true;
    }
}
```

a. Compila y ejecuta sin inconvenientes, porque p es una instancia de Puerta

b. Falla la compilación, porque falta declarar el constructor de `Puerta`

c. Compila, pero el valor asignado se pierde al finalizar Main

d. Falla la compilación, porque abierta es privado y no es accesible desde Program

> Mi respuesta: **B**

> **RESPUESTA CORRECTA:** Ref.: apunte pág 9-10. El compilador es el que hace cumplir el encapsulamiento.
> la respuesta correcta es: **falla la compilación, porque `abierta` es private y no es accesible desde `Program`.**

### Pregunta 7

Selecciona todas las afirmaciones correctas sobre este código.

```CS
public class Puerta
{
    private bool abierta;

    public void Abrir() { abierta = true; }
    public bool EstaAbierta() { return abieerta; }
}
```

a. La clase no respeta el encapsulamiento porque tiene funciones públicas.

b. El atributo `abierta` sólo puede modificarse desde dentro de la clase.

c. El comportamiento de la clase queda expuesto mediante funciones públicas.

d. Cualquier clase puede escribir directamente sobre abierta.

> Mi respuesta: **D**

> **RESPUESTA CORRECTA:** Ref.: apunte pág 9-10. Atributos restringidos y comportamiento público es la forma habitual de encapsular.
> la respuesta correcta es: **El atributo abierto sólo puede modificarse desde dentro de la clase, el comportamiento de la clase queda expuesto mediante funciones públicas.**

---

## Auto evaluación 2

### Pregunta 3

Al relizar un **upcasting** implicito como `person employee = new Employee();`, ¿qué sucede con el acceso a los miembros de la subclase?

```Csharp
Person employee = new Employee(); // Upcasting implicito
employee.SayHi();
class Person
{
    public virtual void SayHi()
    {
        Console.WriteLine("Hola, soy una persona.");
    }
}

class Employee : Person
{
    public void SayBye()
    {
        Console.WriteLine("Adiós, soy un empleado.");
    }
}
```

a. El comportamiento del objeto `employee` cambia a ser puramente el de un `Person`
b. Solo se puede acceder a los mienbros de `Person`, perdiendo el acceso a los miembros característicos de `Employee`
c. Se puede acceder a todos los miembros de `Employee`
d. Se crea una nueva copia del objeto en memoria

> **Mi respuesta:** Ref.: **A**

> **RESPUESRTA CORRECTA:** Solo se puede acceder a los miembros de `Person`, perdiendo acceso a los miembros característicos de `Employee`

### Pregunta 13

¿Qué elementos de la "firma" de un constructor lo diferencia de cualquier otra función de la clase?

a. Debe recibir obligatoriamente parámetros de tipo string.
b. la ausencia total de tipo de dato de retorno.
c. Su nombre siempre debe comenzar con la palabra this.
d. Debe ser declarado cómo estatico.

> **Mi respuesta:** **C**

> **RESPUESTA CORRECTA:** La ausencia total de un tipo de dato de retorno.

## Auto evaluación 3

### Pregunta 5

¿En que escenario el uso de `base` para invocar al constructor se vuelve mandatario en una subclase?

a. Cuando la clase hija no tiene atributos propios.
b. Cuando la subclase no define ningún constructor.
c. Cuando la clase padre presenta al menos un constructor personalizado.
d. Siempre que la subclase sobrecargue un método.

> **Mi respuesta:** **B**

> **RESPUESTA CORRECTA:** cuando la clase padre presenta al menos un constructor personalizado.

### Pregunta 8

¿Cuál es la importancia del upcasting en la programación orientada a objetos?

a. Fuerza de implementación de interfaces.
b. Produce una nueva reasignación de memoria para el objeto.
c. Permite modificar los miembros de la clase base.
d. Habilita el tratamiento de los objetos de un modo mas genérico.

> **Mi respuesta:** **C**

> **RESPUESTA CORRECTA:** Habilita el tratamiento de los objetos de un modo más generico.

### Pregunta 2.1

¿Cuál es uno de los motivos por los que se puede considerar la sobreescritura de un método para extender funcionalidad?

a. Para duplicar completamente el código de la clase base.
b. Para evitar el uso de estructuras.
c. Para reemplazar el código de la clase padre por completo sin referencia al original.
d. Para utilizar la palabra `base` y hacer referencia a la implementación de la clase padre más un adicional funcional.

> **Mi respuesta:** **C**

> **RESPUESTA CORRECTA:** Para utilizar la palabra `base` y hacer referencia a la implementación de la clase padre más un adicional funcional.

### Pregunta 2.5

¿Cómo se define la sobreescritura (overriding) en la programación orientada a objetos?

a. La relación de una nueva clase sin relación con las existentes.
b. La capacidad de tener múltiples funciones con el mismo nombre y diferentes parámetros.
c. El acceso directo a los atributos privados de la clase padre.
d. La práctica de invalidar un miembro público o protegido declarado en una clase padre para que tome precedencia la implementación de la subclase.

> **Mi respuesta:** **B**

> **RESPUESTA CORRECTA:** La práctica de invalidar un miembro público o protegido declarado en una clase padre para que tome precedencia la implementación de la subclase.

### Pregunta 2.8

¿Qué ocurre al hacer upcasting de un objeto _Employee_ a _Person_?

a. El objeto deja de tener los miembros de `Employee` de forma permanente.
b. No es posible, hay que castear explicitamente siempre
c. Se pierde acceso a los miembros propios de `Employee`, pero el objeto sigue siendo el mismo en memoria.
d. Se reasigna memoria y se crea un nuevo objeto `Person`

> **Mi respuesta:** **D**

> **RESPUESTA CORRECTA:** Se pierde acceso a los miembros propios de `Employee`, pero el objeto sigue siendo el mismo en memoria.

## Auto evaluación 4

### Pregunta 1

¿Cuál es la diferencia entre un array y una List<T> respecto a su tamaño.

a. El array tiene un tamaño fijo definido al crearlo; List<T> puede crecer o achicarse dinámicamente.
b. Ambos cambian de tamaño automáticamente de la misma forma
c. Ambos tienen tamaño fijo una vez creados
d. El array puede cambiar de tamaño automáticamente, el List<T> no

> **Mi respuesta:** **B**

> **RESPUESTA CORRECTA:** El array tiene un tamaño fijo definido al crearlo; List<T> puede crecer o achicarse dinámicamente.

### Pregunta 5

Cuando una List<T> supera su capacidad interna y hay que agregar un elemento más, ¿qué ocurre internamente?

a. No ocurre nada especial; List<T> nunca tiene límite de capacidad interna
b. Se pierde el primer elemento de la lista para hacer lugar
c. La lista reserva un nuevo array interno más grande y copia los elementos existentes, lo cual tiene un costo en recursos
d. Se lanza una excepción y no se agregar el nuevo elemento

> **Mi respuesta:** **A**

> **RESPUESTA CORRECTA:** La lista reserva un nuevo array interno más grande y copia los elementos existentes, lo cual tiene un costo en recursos

### Pregunta 9

¿Cómo se accede al tercer elemento (posición de indice 2) de una List<T> llamada lista?

a. lista->2
b. lista[2]
c. lista(2)
d. lista.Get(2)

> **Mi respuesta:** **C**

> **RESPUESTA CORRECTA:** lista[2]

### Pregunta 14

¿Qué ocurre si dentro de un foreach que recorre una List<T> se intenta hacer Add() o Remove() sobre esa misma lista?

a. El programa no compila
b. Se agrega o elimina sin ningún problema
c. El foreach simplemente ignora la modificación y sigue recorriendo la lista original
d. Se lanza una excepción invalidOperationException porque la colección fue modificada mientras enumeraba

> **Mi respuesta:** **B**

> **RESPUESTA CORRECTA:** Se lanza una excepción invalidOperationException porque la colección fue modificada mientras enumeraba

### 4.1

> **Mi respuesta:** **D**

> **RESPUESTA CORRECTA:**

> **Mi respuesta:** **D**

> **RESPUESTA CORRECTA:**

> **Mi respuesta:** **D**

> **RESPUESTA CORRECTA:**

> **Mi respuesta:** **D**

> **RESPUESTA CORRECTA:**

> **Mi respuesta:** **D**

> **RESPUESTA CORRECTA:**

> **Mi respuesta:** **D**

> **RESPUESTA CORRECTA:**
