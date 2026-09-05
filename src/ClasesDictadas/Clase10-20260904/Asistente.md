# Clase `Asistente`

## 1. ¿Qué representa?

`Asistente` representa lo que tienen en común todas las personas
inscriptas al evento.

En el ejercicio existen tres tipos concretos:

- `General`
- `VIP`
- `Orador`

Todos ellos **son un Asistente**, por lo que aparece una relación
de herencia.

---

## 2. ¿Por qué es abstracta?

La clase se declara:

```csharp
public abstract class Asistente
```

No necesitamos crear un asistente genérico.

No tendría sentido hacer:

```csharp
Asistente asistente = new Asistente(...);
```

Lo que realmente vamos a crear son objetos `General`, `VIP`
u `Orador`.

`Asistente` concentra el estado y comportamiento común de toda
la jerarquía.

---

## 3. Estado común

Todo asistente tiene:

```csharp
private int dni;
private string nombre;
```

Los atributos son privados.

Esto respeta el criterio de encapsulamiento:

> El objeto es responsable de administrar su propio estado.

El acceso exterior se realiza mediante properties.

---

## 4. Properties

Para el DNI:

```csharp
public int DNI
{
    get { return dni; }
    set { dni = value; }
}
```

Y para el nombre:

```csharp
public string Nombre
{
    get { return nombre; }
    set { nombre = value; }
}
```

El `get` permite leer el valor.

El `set` permite modificarlo.

Entonces tenemos:

```text
afuera del objeto
      |
      v
    DNI / Nombre
      |
      v
dni / nombre privados
```

---

## 5. Constructor

El constructor es:

```csharp
public Asistente(int documento, string nombre)
{
    this.Nombre = nombre;
    this.DNI = documento;
}
```

Para que exista un asistente necesitamos conocer desde el comienzo:

- su DNI;
- su nombre.

Las clases hijas podrán utilizar este constructor mediante `base`.

Por ejemplo:

```csharp
public General(int documento, string nombre)
    : base(documento, nombre)
{
}
```

---

## 6. `InformarBeneficio()`

La clase declara:

```csharp
public abstract string InformarBeneficio();
```

Sabemos que **todo asistente debe poder informar sus beneficios**,
pero todavía no sabemos cuál será la respuesta.

Eso depende del objeto concreto.

```text
             Asistente
                 |
        InformarBeneficio()
                 |
       ---------------------
       |         |         |
    General     VIP      Orador
```

Por ejemplo:

```text
General -> acceso a las charlas

VIP -> acceso a las charlas,
       backstage y regalo

Orador -> acceso total
          y tema de su charla
```

Entonces podemos realizar el mismo llamado:

```csharp
asistente.InformarBeneficio();
```

y obtener distintas respuestas según el objeto real.

Ese es el comportamiento polimórfico buscado por el ejercicio.

---

## 7. `Equals()`

La clase redefine:

```csharp
public override bool Equals(object? obj)
{
    return ((Asistente)obj).DNI == this.DNI;
}
```

La decisión tomada es considerar iguales a dos asistentes
cuando tienen el mismo DNI.

Conceptualmente:

```text
Asistente A
DNI = 123

Asistente B
DNI = 123

        ↓

son considerados iguales
```

No interesa que sean dos objetos diferentes en memoria.

Para este criterio, lo que determina la identidad es el DNI.

---

## 8. `GetHashCode()`

También se redefine:

```csharp
public override int GetHashCode()
{
    return this.DNI;
}
```

El código hash se obtiene utilizando el mismo dato que usamos
para determinar igualdad: el DNI.

Esto es especialmente importante porque en `Evento` se utiliza:

```csharp
HashSet<Asistente>
```

El `HashSet` necesita determinar si un asistente ya se encuentra
dentro del conjunto.

Por eso `Equals()` y `GetHashCode()` trabajan juntos.

```text
                Asistente
                    |
                    | DNI
                    v
        -------------------------
        |                       |
     Equals()              GetHashCode()
        |                       |
        -----------+-------------
                   |
                   v
           HashSet<Asistente>
             sin repetidos
```

---

## 9. Responsabilidad de `Asistente`

Hasta este punto, `Asistente` sabe:

### Qué tiene

```text
DNI
Nombre
```

### Qué sabe hacer

```text
Determinar igualdad por DNI
Generar su hash a partir del DNI
Informar sus beneficios
```

Pero `Asistente` solamente define que el comportamiento
`InformarBeneficio()` debe existir.

Las clases `General`, `VIP` y `Orador` serán responsables
de decidir **cómo** informar sus propios beneficios.

---

## 10. Idea central

La clase concentra tres conceptos importantes trabajados
en el ejercicio:

```text
Asistente
   |
   +-- encapsulamiento
   |      DNI / Nombre
   |
   +-- herencia
   |      General / VIP / Orador
   |
   +-- polimorfismo
   |      InformarBeneficio()
   |
   +-- igualdad
          Equals()
          GetHashCode()
          ↓
      HashSet<Asistente>
```

Esta clase constituye la base sobre la que después trabajará
`Evento`.

```

**Nota para nuestros apuntes:** mantuve `Equals()` exactamente como quedó en el código de clase. Más adelante podemos analizar qué ocurre si `obj` es `null` o no es un `Asistente`, pero **no lo modificaría ahora** porque estaríamos alterando el fuente que estamos estudiando.
```
