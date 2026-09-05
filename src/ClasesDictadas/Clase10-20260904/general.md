## 2) `General.md` — explicación didáctica

````md
# Clase `General`

## 1. ¿Qué representa?

`General` representa uno de los tipos concretos de asistentes
que pueden inscribirse al evento.

La relación con `Asistente` es de herencia:

```text
General ES UN Asistente
```
````

Por eso la clase se declara:

```csharp
public class General : Asistente
```

---

## 2. ¿Qué hereda de `Asistente`?

`General` reutiliza todo lo que ya fue definido en la clase base.

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
       General
```

`General` no necesita volver a declarar DNI ni Nombre.

Esos datos ya pertenecen a `Asistente`.

---

## 3. Constructor

El constructor es:

```csharp
public General(int documento, string nombre)
    : base(documento, nombre)
{
}
```

Para crear un `General` necesitamos:

*documento;
*nombre.

Pero esos dos datos son responsabilidad de `Asistente`.

Por eso se utiliza:

```csharp
base(documento, nombre)
```

`base` permite llamar al constructor de la clase padre.

Conceptualmente:

```text
new General(1234, "Juan")
        |
        v
constructor General
        |
        v
base(1234, "Juan")
        |
        v
constructor Asistente
        |
        +-- DNI = 1234
        +-- Nombre = "Juan"
```

El cuerpo del constructor de `General` queda vacío porque
no tiene ningún dato adicional que inicializar.

---

## 4. Sobreescritura de `InformarBeneficio()`

En `Asistente` se declaró:

```csharp
public abstract string InformarBeneficio();
```

Esto significa que cada subclase concreta debe resolver
ese comportamiento.

`General` lo implementa así:

```csharp
public override string InformarBeneficio()
{
    return "Acceso a las charlas";
}
```

La palabra:

```csharp
override
```

indica que estamos implementando o redefiniendo
el comportamiento declarado en la clase base.

---

## 5. Polimorfismo

Este método participa directamente del polimorfismo
del ejercicio.

Podemos trabajar con una variable del tipo `Asistente`:

```csharp
Asistente asistente = new General(1234, "Juan");
```

y realizar:

```csharp
asistente.InformarBeneficio();
```

La respuesta será:

```text
Acceso a las charlas
```

Aunque la variable sea tratada como `Asistente`,
el objeto real es un `General`.

Por eso se ejecuta la implementación de `General`.

---

## 6. Particularidad de `General`

A diferencia de otras subclases:

```text
VIP
   +-- regalo

Orador
   +-- tema
```

`General` no agrega nuevos atributos.

Todo su estado ya está cubierto por `Asistente`:

```text
General
   |
   +-- DNI
   +-- Nombre
```

Su característica particular está en su comportamiento:

```text
InformarBeneficio()
        |
        v
"Acceso a las charlas"
```

---

## 7. Responsabilidad de `General`

### Qué tiene

No agrega atributos propios.

Hereda de `Asistente`:

```text
DNI
Nombre
```

### Qué sabe hacer

Implementa su forma particular de:

```text
InformarBeneficio()
```

---

## 8. Idea central

`General` muestra una de las formas más simples
de una subclase:

```text
Asistente
    ▲
    |
 General
    |
    +-- no agrega estado
    |
    +-- especializa comportamiento
            |
            v
     InformarBeneficio()
```

El objetivo principal de esta clase dentro del ejercicio
es participar de la jerarquía y responder de manera propia
al mismo mensaje que reciben los demás tipos de asistentes.

```

```
