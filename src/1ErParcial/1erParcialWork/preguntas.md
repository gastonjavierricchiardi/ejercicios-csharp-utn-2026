# Algunas de las preguntas que pude registrar de la etapa oral

## Envio.cs

> porque pusistes protected al constructor ?

> en el método abstracto:

public abstract double CalcularCosto(); // Abstracto

en Documentacion.cs
public override double CalcularCosto()
{
double costoDistancia = Kilometros \* TarifaPorKilometro;
return costoDistancia + ADICIONAL_FIJO;
}

en CargaPesada()
public override double CalcularCosto()
{
double costoDistancia = Kilometros _ TarifaPorKilometro;
double costoPeso = Peso _ COSTO_POR_KILO;
double costoTotal = costoDistancia + costoPeso;

        if (Peso > pesoMaximoAdmitido)
        {
            costoTotal += RECARGO_EXCESO;
        }

        return costoTotal;
    }

en CargaPesada.cs
public override double CalcularCosto()
{
double costoDistancia = Kilometros _ TarifaPorKilometro;
double costoPeso = Peso _ COSTO_POR_KILO;

        return costoDistancia + costoPeso;
    }

Los tres comparten:
double costoDistancia = Kilometros \* TarifaPorKilometro;

cómo podríamos haber resuelto ?

Y explicame bien el tema de como se usa :base por favor.

---

Sí. Acá hay tres temas distintos y conviene separarlos.

Primero, una corrección mínima: el último `CalcularCosto()` que pegaste parece ser el de **`Paquete`**, no otro `CargaPesada`, porque calcula distancia + peso y no aplica el límite ni el recargo.

### 1. ¿Por qué el constructor de `Envio` es `protected`?

Nuestro constructor es aproximadamente:

```csharp
protected Envio(
    int numeroGuia,
    string destino,
    double kilometros,
    double peso,
    double tarifaPorKilometro)
{
    ...
}
```

La razón es:

> `Envio` concentra la inicialización de los datos comunes, pero esos datos deben ser inicializados por sus clases hijas.

`protected` permite que lo utilicen:

```text
Documentacion
Paquete
CargaPesada
```

porque heredan de `Envio`, pero no lo deja expuesto como un constructor para cualquier clase externa.

Y sí: **esto está directamente en el material oficial de la cursada**. La Unidad 1 tiene este ejemplo:

```csharp
public abstract class Vehicle
{
    private Engine engine;
    private AirConditioner airConditioner;

    protected Vehicle(Engine engine, AirConditioner airConditioner)
    {
        ...
    }
}
```

Además, la cátedra define `protected` justamente como accesible desde la clase y sus subclases.
La justificación corta sería:

> “Lo hicimos `protected` porque el constructor de `Envio` lo necesitan sus subclases para inicializar la parte común heredada, pero no necesito exponerlo al resto del programa.”

Ojo con esto: **no es `protected` simplemente porque `Envio` sea abstracta**. Lo importante es quién necesita acceder al constructor.

---

### 2. `abstract` en `Envio` y `override` en las hijas

Tenemos:

```csharp
public abstract double CalcularCosto();
```

Eso significa:

> `Envio` establece que todo envío debe poder calcular su costo, pero no puede definir una fórmula única.

Porque:

```text
Documentacion → distancia + adicional fijo

Paquete → distancia + peso * 300

CargaPesada → distancia + peso * 200
              + posible recargo
```

Entonces `Envio` define **qué operación existe**, y cada clase concreta define **cómo la resuelve**.

La cátedra usa exactamente esta estructura:

```csharp
public abstract class Shape
{
    public abstract double Area();
}

public class Rectangle : Shape
{
    public override double Area()
    {
        ...
    }
}
```

y aclara que los métodos abstractos deben ser implementados/sobrescritos por las subclases.

La frase oral:

> “`Envio` obliga a todos los tipos concretos a implementar `CalcularCosto()`, pero cada uno lo hace con su propia regla de negocio.”

---

### 3. La repetición de `costoDistancia`

Sí. Acá viste algo real:

```csharp
double costoDistancia = Kilometros * TarifaPorKilometro;
```

está repetido en las tres clases.

**Nuestro código actual es correcto**, porque cada subtipo resuelve explícitamente su fórmula completa.

Pero perfectamente podríamos haber puesto la parte común en `Envio`:

```csharp
protected double CalcularCostoDistancia()
{
    return Kilometros * TarifaPorKilometro;
}
```

Entonces `Documentacion` podría hacer:

```csharp
public override double CalcularCosto()
{
    double costoDistancia = CalcularCostoDistancia();

    return costoDistancia + ADICIONAL_FIJO;
}
```

`Paquete`:

```csharp
public override double CalcularCosto()
{
    double costoDistancia = CalcularCostoDistancia();
    double costoPeso = Peso * COSTO_POR_KILO;

    return costoDistancia + costoPeso;
}
```

y `CargaPesada`:

```csharp
public override double CalcularCosto()
{
    double costoDistancia = CalcularCostoDistancia();
    double costoPeso = Peso * COSTO_POR_KILO;
    double costoTotal = costoDistancia + costoPeso;

    if (Peso > pesoMaximoAdmitido)
    {
        costoTotal += RECARGO_EXCESO;
    }

    return costoTotal;
}
```

Eso sería defendible porque el cálculo por distancia **es realmente comportamiento común a todos los envíos**.

La respuesta si te preguntaran por qué no lo hicimos:

> “Se podría haber extraído el cálculo de distancia a un método `protected` en `Envio` para evitar repetición. En la solución entregada preferimos mantener explícita la fórmula completa en cada subtipo, porque era simple y fácil de seguir.”

No diría que nuestra solución es “mejor”; simplemente **las dos son posibles**. El material, además, enfatiza reutilizar código cuando está bien estructurado.

---

### 4. Ahora sí: ¿qué hace exactamente `: base(...)`?

Este es el punto importante.

Supongamos:

```csharp
public class Paquete : Envio
{
    public Paquete(
        int numeroGuia,
        string destino,
        double kilometros,
        double peso,
        double tarifaPorKilometro)
        : base(
            numeroGuia,
            destino,
            kilometros,
            peso,
            tarifaPorKilometro)
    {
        ...
    }
}
```

Cuando hacés:

```csharp
Paquete paquete = new Paquete(
    1002,
    "Cordoba",
    500,
    10,
    12
);
```

el flujo conceptual es:

```text
new Paquete(...)
      ↓
constructor de Paquete
      ↓
: base(...)
      ↓
constructor de Envio
      ↓
inicializa:
numeroGuia
destino
kilometros
peso
tarifaPorKilometro
      ↓
vuelve al constructor de Paquete
      ↓
inicializa lo propio de Paquete
```

Es decir, `Paquete` recibe todos los datos, pero dice:

> “Estos cinco datos pertenecen a la parte `Envio` que yo heredé; se los paso al constructor de `Envio` para que él los inicialice.”

La cátedra muestra exactamente:

```csharp
public Employee(string name)
    : base(name)
{
}
```

y lo comenta como **“llamada al constructor de la clase padre”**. :chatgpt-content-reference{index="4"}

Esto es fundamental:

```text
: Envio
```

significa:

> `Paquete` **hereda** de `Envio`.

Mientras que:

```text
: base(...)
```

dentro del constructor significa:

> llamá al **constructor de `Envio`**.

No son lo mismo.

Y tampoco significa que `Paquete` “hereda el constructor”. El constructor de `Paquete` **llama** al constructor de la base para inicializar la parte heredada.

La frase que me guardaría:

> “`base(...)` llama al constructor de la clase padre. `Paquete` recibe los datos y le pasa a `Envio` los que corresponden al estado común; primero se inicializa la parte base y después continúa el constructor de `Paquete`.”

Eso está 100% dentro del material de Unidad 1, no es algo que agregamos por afuera.

Y como criterio general, la materia viene enfatizando que el código debe ser entendible, no simplemente funcionar.
