Hay algo importante: el profesor no presenta los constructores `private` como una práctica habitual, sino como un mecanismo especial para controlar la creación de objetos.

## 1. ¿Qué significa que un constructor sea `private`?

En la clase del 23/10/2026, mientras resolvía Singleton, Andrés explica que cambiar la visibilidad del constructor impide crear objetos desde otras clases.

En otras palabras, si tenemos:

```
public class Configuracion
{
    private Configuracion()
    {
    }
}
```

Desde `Program.cs` no podemos hacer:

```
Configuracion config = new Configuracion(); // NO COMPILA
```

¿Por qué? Porque `Program` está intentando acceder a un constructor que solo puede utilizarse desde el interior de `Configuracion`.

Pero hay una distinción fundamental:

El constructor `private` no impide que la propia clase cree sus objetos. Impide que otras clases invoquen ese constructor.

Este es el mecanismo que utiliza el profesor en Singleton.

## 2. ¿Entonces cómo creamos el objeto?

Ahí aparece la segunda parte de su explicación.

Si ninguna clase externa puede llamar al constructor, necesitamos que `Configuracion` proporcione un mecanismo para obtener su instancia.

El profesor utiliza:

```
public static Configuracion GetInstance()
```

¿Por qué `static`?

Porque todavía no tenemos ningún objeto sobre el cual llamar al método. Necesitamos poder invocarlo directamente desde la clase:

```
Configuracion config = Configuracion.GetInstance();
```

Y para conservar esa instancia, utiliza un atributo también estático:

```
private static Configuracion instancia;
```

El código final del profesor es:

```
public class Configuracion
{
    private static Configuracion instancia;

    public string Idioma { get; set; }
    public string Nombre { get; set; }

    private Configuracion()
    {
        Idioma = "es";
    }

    public static Configuracion GetInstance()
    {
        if (instancia == null)
        {
            instancia = new Configuracion();
        }

        return instancia;
    }
}
```

Prestá atención a esto:

```
instancia = new Configuracion();
```

¡La propia clase sí puede llamar a su constructor privado!

Por lo tanto, el conjunto funciona así:

- `private Configuracion()` impide la creación desde afuera.
- `private static Configuracion instancia` guarda la referencia.
- `public static GetInstance()` controla cuándo crearla y devuelve siempre la misma.

El profesor comprobó ese comportamiento mediante el depurador y la comparación `config1 == config2`.

Configuracion.cs

## 3. ¿Qué pasa con la herencia? Acá está lo más interesante.

Durante la clase, un alumno planteó que un miembro `private` podía utilizarse desde la propia clase y sus herederas.

Leonardo corrigió expresamente esa afirmación.

Explicó que una subclase tampoco puede acceder al constructor privado de la clase base.

Para comprobarlo hizo una prueba en vivo: intentó crear una clase derivada de `Configuracion`, pero el código no compilaba porque la subclase no podía acceder al constructor de su clase padre.

Esto se relaciona directamente con lo que habíamos estudiado sobre `private`, `protected` y herencia.

| Visibilidad del constructor | Desde la propia clase | Desde una subclase | Desde otra clase |
| --------------------------- | --------------------- | ------------------ | ---------------- |
| `private`                   | Sí                    | No                 | No               |
| `protected`                 | Sí                    | Sí                 | No               |
| `public`                    | Sí                    | Sí                 | Sí               |

Tabla conceptual para constructores; pueden existir otras restricciones según la clase y sus constructores disponibles.

Importante: técnicamente, los constructores no se sobrescriben con `override`. La subclase debe poder invocar algún constructor accesible de la clase base. En el ejemplo docente, el único constructor de `Configuracion` es privado y por eso la herencia normal no compila.

## 4. ¿Y por qué habló de `sealed`?

Esto apareció tanto en la clase teórica del 20/10 como en la práctica del 23/10.

Andrés probó agregar `sealed` a la clase y observó que cambiaba el mensaje del compilador: ahora decía directamente que la clase no podía heredarse por estar sellada.

Su conclusión práctica fue que `sealed` no era indispensable para el ejemplo, aunque le parecía razonable utilizarlo para expresar que no se desea heredar de esa clase.

De hecho, en el archivo `Configuracion.cs` que nos entregaste no lo agregó.

Por eso debemos diferenciar:

VALIDADO: el docente explicó y aplicó el constructor privado.

VALIDADO: demostró que una subclase no podía utilizar ese constructor.

VALIDADO: `sealed` fue discutido, pero no incorporado a la implementación final.

## 5. Un detalle adicional: ¿constructor con parámetros o vacío?

También revisé esta decisión porque aparece en nuestro UML.

Inicialmente, Andrés dibujó un constructor privado con parámetros:

```
private Configuracion(string lang, string name)
```

Pero cuando empezó a programar advirtió que eso obligaría a proporcionar valores al crear la instancia mediante `GetInstance()`.

Decidió simplificarlo:

```
private Configuracion()
{
    Idioma = "es";
}
```

La elección de dejarlo sin parámetros no está relacionada con que sea `private`: es una decisión separada sobre cómo inicializar el objeto.&#x20;

23 GMT20261023-Consolidado.md

## Conclusión para nuestra cursada

Si tuviera que resumir lo que quiere que comprendamos Andrés, sería:

Un constructor `private` sirve para impedir que otras clases creen directamente objetos mediante ese constructor, dejando el control de la instanciación dentro de la propia clase.

En Singleton lo utilizamos porque necesitamos controlar la creación y devolver una referencia compartida.

Pero algo que conviene recordar:

Un constructor privado, por sí solo, no implementa Singleton. Necesitamos además el mecanismo que administra y devuelve la única instancia.

Y me parece especialmente interesante una aclaración de Andrés: durante la clase dijo que hasta ese momento prácticamente nunca habían utilizado constructores privados. Es decir, Singleton fue la ocasión concreta en la que nos mostró para qué podían servir.

Esa es la interpretación que dejaría como VALIDADA para Programación II 2026, sin agregar complejidades que el profesor todavía no pidió.

---

¡Ahhh, ahora sí! 😄 Ahí está exactamente de dónde venía la confusión.

En el parcial usamos un constructor `protected`, mientras que en Singleton el profesor utilizó uno `private`.

Y la diferencia es fundamental cuando trabajamos con herencia.

## 1. En el parcial: `protected Envio(...)`

Tu clase `Envio` es abstracta:

```
public abstract class Envio
{
    protected Envio(
        int numeroGuia,
        string destino,
        double kilometros,
        double peso,
        double tarifaPorKilometro)
    {
        // Inicialización de atributos
    }

    public abstract double CalcularCosto();
}
```

Como `Envio` es abstracta, no podemos instanciarla directamente:

```
Envio envio = new Envio(...); // NO COMPILA
```

Sin embargo, sus clases hijas necesitan poder ejecutar ese constructor para inicializar los atributos heredados.

Por eso lo declaramos `protected`.

Por ejemplo, una clase derivada puede utilizar:

```
public class EnvioTerrestre : Envio
{
    public EnvioTerrestre(
        int numeroGuia,
        string destino,
        double kilometros,
        double peso,
        double tarifaPorKilometro)
        : base(numeroGuia, destino, kilometros, peso, tarifaPorKilometro)
    {
    }

    public override double CalcularCosto()
    {
        return Kilometros * TarifaPorKilometro;
    }
}
```

Ejemplo ilustrativo para mostrar `base(...)`, no una reconstrucción de la solución oficial del parcial.

La parte importante es:

```
: base(numeroGuia, destino, kilometros, peso, tarifaPorKilometro)
```

Esa llamada funciona porque el constructor de `Envio` es `protected`.

## 2. En Singleton: `private Configuracion()`

```
public class Configuracion
{
    private Configuracion()
    {
    }
}
```

Acá el objetivo es diferente: impedir que otras clases creen directamente una configuración.

Y eso incluye a las clases derivadas: una clase hija no puede invocar ese constructor privado.

## 3. Comparación directa

|                                            | `protected Envio(...)`         | `private Configuracion()`           |
| ------------------------------------------ | ------------------------------ | ----------------------------------- |
| ¿Lo usa la propia clase?                   | Sí                             | Sí                                  |
| ¿Lo puede invocar una clase hija?          | Sí                             | No                                  |
| ¿Lo puede invocar cualquier clase externa? | No                             | No                                  |
| Objetivo en el ejercicio                   | Inicializar el estado heredado | Controlar la creación de instancias |

Hay una distinción adicional:

- `abstract` impide instanciar directamente una clase.
- `protected` permite que las clases derivadas invoquen el constructor.
- `private` restringe la invocación del constructor a la propia clase.

La clave: en el parcial queríamos que las clases hijas pudieran construir su parte heredada; en Singleton queríamos impedir que otras clases tuvieran acceso directo a la construcción de `Configuracion`.

Tu recuerdo del parcial era correcto. Lo que cambió fue la intención del diseño, y por eso cambió el modificador de acceso.

VALIDADO: esta distinción coincide con lo trabajado por la cátedra sobre constructores, herencia y Singleton.¡Ahhh, ahora sí! 😄 Ahí está exactamente de dónde venía la confusión.

En el parcial usamos un constructor `protected`, mientras que en Singleton el profesor utilizó uno `private`.

Y la diferencia es fundamental cuando trabajamos con herencia.

## 1. En el parcial: `protected Envio(...)`

Tu clase `Envio` es abstracta:

```
public abstract class Envio
{
    protected Envio(
        int numeroGuia,
        string destino,
        double kilometros,
        double peso,
        double tarifaPorKilometro)
    {
        // Inicialización de atributos
    }

    public abstract double CalcularCosto();
}
```

Como `Envio` es abstracta, no podemos instanciarla directamente:

```
Envio envio = new Envio(...); // NO COMPILA
```

Sin embargo, sus clases hijas necesitan poder ejecutar ese constructor para inicializar los atributos heredados.

Por eso lo declaramos `protected`.

Por ejemplo, una clase derivada puede utilizar:

```
public class EnvioTerrestre : Envio
{
    public EnvioTerrestre(
        int numeroGuia,
        string destino,
        double kilometros,
        double peso,
        double tarifaPorKilometro)
        : base(numeroGuia, destino, kilometros, peso, tarifaPorKilometro)
    {
    }

    public override double CalcularCosto()
    {
        return Kilometros * TarifaPorKilometro;
    }
}
```

Ejemplo ilustrativo para mostrar `base(...)`, no una reconstrucción de la solución oficial del parcial.

La parte importante es:

```
: base(numeroGuia, destino, kilometros, peso, tarifaPorKilometro)
```

Esa llamada funciona porque el constructor de `Envio` es `protected`.

## 2. En Singleton: `private Configuracion()`

```
public class Configuracion
{
    private Configuracion()
    {
    }
}
```

Acá el objetivo es diferente: impedir que otras clases creen directamente una configuración.

Y eso incluye a las clases derivadas: una clase hija no puede invocar ese constructor privado.

## 3. Comparación directa

|                                            | `protected Envio(...)`         | `private Configuracion()`           |
| ------------------------------------------ | ------------------------------ | ----------------------------------- |
| ¿Lo usa la propia clase?                   | Sí                             | Sí                                  |
| ¿Lo puede invocar una clase hija?          | Sí                             | No                                  |
| ¿Lo puede invocar cualquier clase externa? | No                             | No                                  |
| Objetivo en el ejercicio                   | Inicializar el estado heredado | Controlar la creación de instancias |

Hay una distinción adicional:

- `abstract` impide instanciar directamente una clase.
- `protected` permite que las clases derivadas invoquen el constructor.
- `private` restringe la invocación del constructor a la propia clase.

La clave: en el parcial queríamos que las clases hijas pudieran construir su parte heredada; en Singleton queríamos impedir que otras clases tuvieran acceso directo a la construcción de `Configuracion`.

Tu recuerdo del parcial era correcto. Lo que cambió fue la intención del diseño, y por eso cambió el modificador de acceso.

VALIDADO: esta distinción coincide con lo trabajado por la cátedra sobre constructores, herencia y Singleton.¡Ahhh, ahora sí! 😄 Ahí está exactamente de dónde venía la confusión.

En el parcial usamos un constructor `protected`, mientras que en Singleton el profesor utilizó uno `private`.

Y la diferencia es fundamental cuando trabajamos con herencia.

## 1. En el parcial: `protected Envio(...)`

Tu clase `Envio` es abstracta:

```
public abstract class Envio
{
    protected Envio(
        int numeroGuia,
        string destino,
        double kilometros,
        double peso,
        double tarifaPorKilometro)
    {
        // Inicialización de atributos
    }

    public abstract double CalcularCosto();
}
```

Como `Envio` es abstracta, no podemos instanciarla directamente:

```
Envio envio = new Envio(...); // NO COMPILA
```

Sin embargo, sus clases hijas necesitan poder ejecutar ese constructor para inicializar los atributos heredados.

Por eso lo declaramos `protected`.

Por ejemplo, una clase derivada puede utilizar:

```
public class EnvioTerrestre : Envio
{
    public EnvioTerrestre(
        int numeroGuia,
        string destino,
        double kilometros,
        double peso,
        double tarifaPorKilometro)
        : base(numeroGuia, destino, kilometros, peso, tarifaPorKilometro)
    {
    }

    public override double CalcularCosto()
    {
        return Kilometros * TarifaPorKilometro;
    }
}
```

Ejemplo ilustrativo para mostrar `base(...)`, no una reconstrucción de la solución oficial del parcial.

La parte importante es:

```
: base(numeroGuia, destino, kilometros, peso, tarifaPorKilometro)
```

Esa llamada funciona porque el constructor de `Envio` es `protected`.

## 2. En Singleton: `private Configuracion()`

```
public class Configuracion
{
    private Configuracion()
    {
    }
}
```

Acá el objetivo es diferente: impedir que otras clases creen directamente una configuración.

Y eso incluye a las clases derivadas: una clase hija no puede invocar ese constructor privado.

## 3. Comparación directa

|                                            | `protected Envio(...)`         | `private Configuracion()`           |
| ------------------------------------------ | ------------------------------ | ----------------------------------- |
| ¿Lo usa la propia clase?                   | Sí                             | Sí                                  |
| ¿Lo puede invocar una clase hija?          | Sí                             | No                                  |
| ¿Lo puede invocar cualquier clase externa? | No                             | No                                  |
| Objetivo en el ejercicio                   | Inicializar el estado heredado | Controlar la creación de instancias |

Hay una distinción adicional:

- `abstract` impide instanciar directamente una clase.
- `protected` permite que las clases derivadas invoquen el constructor.
- `private` restringe la invocación del constructor a la propia clase.

La clave: en el parcial queríamos que las clases hijas pudieran construir su parte heredada; en Singleton queríamos impedir que otras clases tuvieran acceso directo a la construcción de `Configuracion`.

Tu recuerdo del parcial era correcto. Lo que cambió fue la intención del diseño, y por eso cambió el modificador de acceso.

VALIDADO: esta distinción coincide con lo trabajado por la cátedra sobre constructores, herencia y Singleton.
