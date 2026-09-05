## 1) `Orador.cs` — mismo código, comentado

```csharp
/*
    =========================================================
    ORADOR
    =========================================================

    Orador representa otro tipo concreto de asistente.

    Orador ES UN Asistente, por eso hereda de Asistente.

    Además de los datos comunes, agrega un dato propio:
    el tema de la charla que tiene asignada.
*/
public class Orador : Asistente
{
    /*
        =====================================================
        TEMA
        =====================================================

        Este atributo pertenece específicamente al Orador.

        Se mantiene privado para respetar el encapsulamiento.
    */
    private string tema;


    /*
        =====================================================
        CONSTRUCTOR
        =====================================================

        Para crear un Orador necesitamos:

            - documento
            - nombre
            - tema

        documento y nombre pertenecen a Asistente.

        tema pertenece específicamente a Orador.
    */
    public Orador(int documento, string nombre, string tema)
        : base(documento, nombre)
    {
        /*
            El constructor de Asistente ya inicializó
            documento y nombre.

            Acá inicializamos el dato particular
            del Orador.
        */
        Tema = tema;
    }


    /*
        =====================================================
        PROPERTY TEMA
        =====================================================

        Permite leer y modificar el atributo privado tema.
    */
    public string Tema
    {
        get { return tema; }
        set { tema = value; }
    }


    /*
        =====================================================
        INFORMAR BENEFICIO
        =====================================================

        Asistente declaró InformarBeneficio()
        como método abstracto.

        Orador implementa su propia respuesta.

        En este caso informa:

            - acceso total;
            - el tema de la charla asignada.
    */
    public override string InformarBeneficio()
    {
        return "Acceso total y dará la charla de " + tema;
    }
}
```

## 2) `Orador.md` — explicación didáctica

````md
# Clase `Orador`

## 1. ¿Qué representa?

`Orador` representa uno de los tipos concretos
de asistentes del evento.

La relación con `Asistente` es de herencia:

```text
Orador ES UN Asistente
```
````

Por eso se declara:

```csharp
public class Orador : Asistente
```

---

## 2. ¿Qué reutiliza de `Asistente`?

`Orador` hereda las características comunes
definidas en la clase base.

Conceptualmente:

```text
Asistente
   |
   +-- DNI
   +-- Nombre
   +-- Equals()
   +-- GetHashCode()
   +-- InformarBeneficio()
          |
          v
       Orador
```

No necesita volver a declarar DNI ni Nombre.

---

## 3. ¿Qué agrega `Orador`?

`Orador` tiene un dato particular:

```csharp
private string tema;
```

Ese atributo representa el tema de la charla
que tiene asignada.

Conceptualmente:

```text
Asistente
   |
   +-- DNI
   +-- Nombre
   |
   v
 Orador
   |
   +-- tema
```

---

## 4. Encapsulamiento de `tema`

El atributo se mantiene privado:

```csharp
private string tema;
```

Y se accede mediante la property:

```csharp
public string Tema
{
    get { return tema; }
    set { tema = value; }
}
```

El `get` permite leer el tema.

El `set` permite modificarlo.

---

## 5. Constructor

El constructor es:

```csharp
public Orador(int documento, string nombre, string tema)
    : base(documento, nombre)
{
    Tema = tema;
}
```

Para crear un Orador necesitamos tres datos:

```text
documento
nombre
tema
```

Pero no todos pertenecen a la misma clase.

```text
Asistente
   +-- documento
   +-- nombre

Orador
   +-- tema
```

Por eso el constructor reparte responsabilidades.

---

## 6. Uso de `base`

Esta parte:

```csharp
: base(documento, nombre)
```

llama al constructor de `Asistente`.

Ese constructor se encarga de inicializar:

```text
DNI
Nombre
```

Después vuelve al constructor de `Orador`, que ejecuta:

```csharp
Tema = tema;
```

Conceptualmente:

```text
new Orador(123, "Leonardo", "POO")
              |
              v
       constructor Orador
              |
              v
   base(123, "Leonardo")
              |
              v
    constructor Asistente
              |
              +-- DNI = 123
              +-- Nombre = "Leonardo"
              |
              v
       vuelve a Orador
              |
              v
          Tema = "POO"
```

---

## 7. `InformarBeneficio()`

`Asistente` declaró:

```csharp
public abstract string InformarBeneficio();
```

Cada subclase debe resolver ese comportamiento.

`Orador` lo implementa así:

```csharp
public override string InformarBeneficio()
{
    return "Acceso total y dará la charla de " + tema;
}
```

La respuesta combina:

```text
beneficio fijo
+
dato propio del Orador
```

Es decir:

```text
"Acceso total"
+
tema de la charla
```

---

## 8. Polimorfismo

Podemos trabajar con un Orador
tratándolo como `Asistente`:

```csharp
Asistente asistente =
    new Orador(123, "Leonardo", "POO");
```

Y hacer:

```csharp
asistente.InformarBeneficio();
```

La respuesta será la definida por `Orador`:

```text
Acceso total y dará la charla de POO
```

Aunque la variable sea de tipo `Asistente`,
el objeto real es `Orador`.

Por eso se ejecuta:

```text
Orador.InformarBeneficio()
```

---

## 9. Comparación con las otras subclases

Hasta ahora tenemos:

```text
                 Asistente
                     ▲
          ┌──────────┼──────────┐
          |          |          |
       General      VIP      Orador
          |          |          |
      sin dato     regalo      tema
       propio
```

Los tres entienden el mismo mensaje:

```text
InformarBeneficio()
```

pero cada uno responde de manera diferente.

```text
General
   |
   v
Acceso a las charlas


VIP
   |
   v
Charlas + backstage + regalo


Orador
   |
   v
Acceso total + tema de charla
```

---

## 10. Responsabilidad de `Orador`

### Qué tiene

Hereda:

```text
DNI
Nombre
```

Agrega:

```text
Tema
```

### Qué sabe hacer

Implementa:

```text
InformarBeneficio()
```

utilizando además su información particular,
el tema de la charla.

---

## 11. Idea central

`Orador` muestra la misma estructura conceptual
que `VIP`:

```text
Asistente
    ▲
    |
  Orador
    |
    +-- reutiliza estado común
    |      DNI
    |      Nombre
    |
    +-- agrega estado propio
    |      Tema
    |
    +-- especializa comportamiento
           InformarBeneficio()
```

La diferencia es solamente cuál es el dato
y cuál es el comportamiento particular
de esta subclase.

```

```
