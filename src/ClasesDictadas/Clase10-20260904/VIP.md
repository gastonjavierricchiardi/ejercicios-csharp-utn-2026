## 1) `VIP.cs` — mismo código, comentado

```csharp
/*
    =========================================================
    VIP
    =========================================================

    VIP representa otro tipo concreto de asistente.

    VIP ES UN Asistente, por eso hereda de Asistente.

    A diferencia de General, VIP agrega un dato propio:
    el regalo elegido.
*/
public class VIP : Asistente
{
    /*
        =====================================================
        REGALO
        =====================================================

        Este atributo pertenece específicamente a VIP.

        Se mantiene privado para respetar el encapsulamiento.
    */
    private string regalo;


    /*
        =====================================================
        CONSTRUCTOR
        =====================================================

        Para crear un VIP necesitamos:

            - documento
            - nombre
            - regalo

        documento y nombre pertenecen a Asistente.

        regalo pertenece específicamente a VIP.
    */
    public VIP(int documento, string nombre, string regalo)
        : base(documento, nombre)
    {
        /*
            El constructor de la clase base ya se encargó
            de guardar documento y nombre.

            Acá solamente inicializamos el dato particular
            de VIP.
        */
        this.Regalo = regalo;
    }


    /*
        =====================================================
        PROPERTY REGALO
        =====================================================

        Permite leer y modificar el atributo privado regalo.
    */
    public string Regalo
    {
        get { return regalo; }
        set { regalo = value; }
    }


    /*
        =====================================================
        INFORMAR BENEFICIO
        =====================================================

        Asistente declaró InformarBeneficio()
        como abstracto.

        VIP implementa su propia respuesta.

        Sus beneficios son:

            - acceso a todas las charlas;
            - acceso al backstage;
            - un regalo.
    */
    public override string InformarBeneficio()
    {
        return "Acceso a todas las charlas, acceso al backstage y con un regalo " + regalo;
    }
}
```

---

## 2) `VIP.md` — explicación didáctica

````md
# Clase `VIP`

## 1. ¿Qué representa?

`VIP` representa uno de los tipos concretos de asistentes
del evento.

La relación con `Asistente` es de herencia:

```text
VIP ES UN Asistente
```
````

Por eso se declara:

```csharp
public class VIP : Asistente
```

---

## 2. ¿Qué reutiliza de `Asistente`?

`VIP` hereda las características comunes definidas
en la clase base.

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
         VIP
```

No necesita volver a declarar ni DNI ni Nombre.

---

## 3. ¿Qué agrega `VIP`?

A diferencia de `General`, `VIP` sí tiene
un dato particular:

```csharp
private string regalo;
```

Ese atributo representa el regalo elegido
por el asistente VIP.

Conceptualmente:

```text
Asistente
   |
   +-- DNI
   +-- Nombre
   |
   v
  VIP
   |
   +-- regalo
```

---

## 4. Encapsulamiento de `regalo`

El atributo se mantiene privado:

```csharp
private string regalo;
```

Y se accede mediante la property:

```csharp
public string Regalo
{
    get { return regalo; }
    set { regalo = value; }
}
```

El `get` permite leer el regalo.

El `set` permite modificarlo.

---

## 5. Constructor

El constructor es:

```csharp
public VIP(int documento, string nombre, string regalo)
    : base(documento, nombre)
{
    this.Regalo = regalo;
}
```

Para crear un VIP necesitamos tres datos:

```text
documento
nombre
regalo
```

Pero no todos pertenecen a la misma clase.

```text
Asistente
   +-- documento
   +-- nombre

VIP
   +-- regalo
```

Por eso el constructor se reparte responsabilidades.

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

Después vuelve al constructor de `VIP`, que ejecuta:

```csharp
this.Regalo = regalo;
```

Conceptualmente:

```text
new VIP(987, "Juan", "Un termo")
          |
          v
     constructor VIP
          |
          v
base(987, "Juan")
          |
          v
 constructor Asistente
          |
          +-- DNI = 987
          +-- Nombre = "Juan"
          |
          v
 vuelve a VIP
          |
          v
 Regalo = "Un termo"
```

---

## 7. `InformarBeneficio()`

`Asistente` obliga a las subclases a resolver:

```csharp
public abstract string InformarBeneficio();
```

`VIP` implementa ese comportamiento así:

```csharp
public override string InformarBeneficio()
{
    return "Acceso a todas las charlas, acceso al backstage y con un regalo " + regalo;
}
```

La respuesta incluye tanto beneficios fijos
como un dato propio del objeto:

```text
Acceso a todas las charlas
+
Acceso al backstage
+
Regalo elegido
```

---

## 8. Polimorfismo

Podemos trabajar con un objeto VIP
tratándolo como `Asistente`:

```csharp
Asistente asistente =
    new VIP(987, "Juan", "Un termo");
```

Y hacer:

```csharp
asistente.InformarBeneficio();
```

Aunque la variable sea de tipo `Asistente`,
el objeto real es `VIP`.

Por eso se ejecuta:

```text
VIP.InformarBeneficio()
```

Ese es el comportamiento polimórfico buscado
por el ejercicio.

---

## 9. Diferencia con `General`

Hasta ahora tenemos:

```text
                Asistente
                    ▲
          ┌─────────┴─────────┐
          |                   |
       General               VIP
          |                   |
     sin atributos        regalo
      propios
```

Ambos responden al mismo método:

```text
InformarBeneficio()
```

pero cada uno lo resuelve de una manera diferente.

```text
General
   |
   v
"Acceso a las charlas"


VIP
   |
   v
"Acceso a todas las charlas,
 backstage y regalo..."
```

---

## 10. Responsabilidad de `VIP`

### Qué tiene

Hereda:

```text
DNI
Nombre
```

Agrega:

```text
Regalo
```

### Qué sabe hacer

Implementa:

```text
InformarBeneficio()
```

utilizando además su información particular,
el regalo elegido.

---

## 11. Idea central

`VIP` muestra cómo una subclase puede:

```text
Asistente
    ▲
    |
   VIP
    |
    +-- reutilizar estado común
    |      DNI
    |      Nombre
    |
    +-- agregar estado propio
    |      Regalo
    |
    +-- especializar comportamiento
           InformarBeneficio()
```

En esta clase aparecen juntas dos ideas importantes:

- reutilizar lo común mediante herencia;
- agregar lo particular en la subclase.

```

```
