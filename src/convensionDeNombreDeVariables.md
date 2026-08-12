### 1. Qué significa `camelCase`

`camelCase` significa:

- primera palabra empieza en minúscula;
- cada palabra siguiente empieza en mayúscula;
- sin espacios;
- sin guiones ni `_`.

```text
nombre
apellido
nombreCompleto
arteMarcial
airConditioner
numeroDocumento
```

En cambio:

```text
_nombreCompleto
```

es **camelCase con prefijo `_`**, que es otra convención posible para campos privados, pero el `_` no forma parte de camelCase.

### 2. Qué está usando la cátedra

En el material oficial, los atributos privados aparecen **sin `_`**:

```csharp
private string name;
private string lastname;
```

y los parámetros también usan camelCase:

```csharp
public void SetName(string name)
{
    this.name = name;
}
```

Ahí `this` resuelve perfectamente la coincidencia:

```text
this.name  → atributo del objeto
name       → parámetro recibido
```

El PDF incluso explica específicamente que `this` permite distinguir el miembro de la clase de la variable/parámetro homónimo. El apunte de Clase 1 repite el mismo criterio con `private string name;`.

Entonces, **para nuestra cursada 2026 conviene adoptar el estilo de la cátedra**:

```csharp
private string nombre;
private string apellido;

public void SetNombre(string nombre)
{
    this.nombre = nombre;
}
```

en vez de:

```csharp
private string _nombre;
```

### 3. Mapa corto de convenciones que vemos hasta ahora

```text
camelCase
→ atributos privados: nombreCompleto
→ parámetros: nombreCompleto
→ variables locales: visitanteActual

PascalCase
→ clases: Persona, Visitante
→ métodos: Presentarse(), GetNombre(), ControlarDocumento()

MAYÚSCULAS_CON_GUION_BAJO
→ constantes según el material: BAUD_RATE_9600
```

Así que sí: **desde ahora propondría dejar de usar `_nombre`, `_apellido`, `_dni`, etc., y seguir `nombre`, `apellido`, `dni`, usando `this.nombre` cuando haga falta distinguir el atributo del parámetro.** Esto además nos alinea directamente con los ejemplos oficiales 2026.
