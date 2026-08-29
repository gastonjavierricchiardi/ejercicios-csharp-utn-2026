En C# se llama **método `Main`** y es el **punto de entrada** del programa.

El equivalente a tu estructura de TypeScript sería:

```csharp
public class Program
{
    public static void Main()
    //static void Main(string[] args)
    {
    }
}
```

Comparación directa:

```text
TypeScript                    C#
--------------------------------------------------
function main(): void         static void Main()
main();                       no hace falta llamarlo
export {};                    no hace falta
```

En C#, `Main()` lo ejecuta automáticamente .NET al iniciar el programa.

Y dentro de una **clase común** como `Articulo`, tu orden puede mantenerse igual:

```csharp
public class Clase
{
    // 1. CAMPOS / ATRIBUTOS
    // Estado interno del objeto.
    // Normalmente private.

    // 2. CONSTRUCTOR
    // Recibe los datos necesarios al crear el objeto.

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // Formas de exponer o modificar el estado.

    // 4. MÉTODOS
    // Comportamiento del objeto.
}


```

Mientras que `Program.cs` queda para el punto de entrada:

```csharp
public class Program
{
    public static void Main()
    //static void Main(string[] args)
    {
        // Crear objetos y probar el ejercicio
    }
}
```

---

Sí. Acá conviene **ajustarnos al apunte**.

1. Las dos formas son válidas, pero tienen distinta firma:

```csharp
static void Main()
```

→ `Main` sin parámetros.

```csharp
static void Main(string[] args)
```

→ `Main` recibe un parámetro llamado `args`, que es un arreglo de `string` con argumentos que podrían llegar al iniciar el programa.

El material oficial usa consistentemente `static void Main(string[] args)`.

2. Nosotros veníamos usando:

```csharp
public class Program
{
    public static void Main()
    {
    }
}
```

porque también funciona y quedó como convención inicial del proyecto. Pero ese `public` tampoco es necesario para que `Main` sea punto de entrada.

3. **Para alinearnos desde ahora con la cátedra**, yo dejaría nuestra plantilla así:

```csharp
public class Program
{
    static void Main(string[] args)
    {
        // Crear objetos y probar el ejercicio
    }
}
```

Y ojo con lo que acabamos de estudiar: **`args` es un parámetro**, no un atributo de `Program`.

---

1. La estructura didáctica más correcta sería:

```csharp
public class Clase
{
    // 1. CAMPOS / ATRIBUTOS
    // Estado interno del objeto.
    // Normalmente private.

    // 2. CONSTRUCTOR
    // Recibe los datos necesarios al crear el objeto.

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // Formas de exponer o modificar el estado.

    // 4. MÉTODOS
    // Comportamiento del objeto.
}
```

La cátedra justamente viene trabajando atributos privados, constructor, getters/setters o properties y métodos.

2. Lo que te estaba mezclando es **parámetro vs atributo**:

```csharp
private int faltas; // ATRIBUTO / CAMPO: queda guardado en el objeto

public Empleado(int faltas) // PARÁMETRO: existe durante esta llamada
{
    this.faltas = faltas;
}

public double CalcularBono(double objetivo) // objetivo es PARÁMETRO
{
    // objetivo se usa acá y después desaparece
}
```

La regla visual:

```text
ATRIBUTO / CAMPO
→ pertenece al objeto
→ conserva su valor

PARÁMETRO
→ entra a un constructor o método
→ sirve para esa ejecución
→ no queda guardado salvo que lo asignemos a un atributo/property
```

`this.faltas = faltas` muestra exactamente esa diferencia: izquierda = miembro del objeto; derecha = parámetro.

3. Entonces para **nuestro ejercicio de Sueldos**:

```text
faltas
→ ATRIBUTO de Empleado
→ porque es estado del empleado

objetivo
→ PARÁMETRO de CalcularSueldo / CalcularBonoResultado
→ porque por ahora solo lo necesitamos para hacer ese cálculo
```

Y algo importante: **los parámetros no son un “5.º sector” de la clase**. Viven dentro de la firma del constructor o de los métodos.

Así que yo actualizaría nuestro machete definitivamente a:

```text
1. CAMPOS / ATRIBUTOS
2. CONSTRUCTOR
3. PROPIEDADES / GETTERS Y SETTERS
4. MÉTODOS
```

Ese sí lo podemos tomar como base C# para seguir.

---

# Windows

## POWERSHELL

### Mejorado sin basura CS

```

$salida = "dump_EJ13.txt"

# Solo archivos .cs reales del proyecto.
# Excluye carpetas generadas por .NET: bin y obj.
$archivos = Get-ChildItem -Path . -Recurse -File -Filter *.cs |
    Where-Object {
        $_.FullName -notmatch '\\(bin|obj)\\'
    } |
    Sort-Object FullName

@(
    "PWD: $((Get-Location).Path)"
    "Fecha: $(Get-Date -Format o)"
    ""
    "ARCHIVOS INCLUIDOS:"
    ($archivos | ForEach-Object {
        " - $($_.FullName)"
    })
    ""
    "========================================"
    ""
    ($archivos | ForEach-Object {
        "===== $($_.FullName) ====="

        $n = 0
        Get-Content $_.FullName -Encoding UTF8 | ForEach-Object {
            $n++
            "{0}: {1}" -f $n, $_
        }

        ""
    })
) | Set-Content -Path $salida -Encoding UTF8


```

###############################

## CMD

### Mejorado sin Basura CS

**cd c:\Users\gasto\OneDrive\DropBox\vcs\proyecto-ts\src\00EJercicios**
**cd c:\Users\gasto\Dropbox\vcs\proyecto-ts\src\00EJERCICIOS\00EJ02**

```

(
  echo PWD: %cd%
  for /f "delims=" %I in ('powershell -NoProfile -Command "Get-Date -Format o"') do echo Fecha: %I
  echo(
  echo ARCHIVOS INCLUIDOS:
  for /f "delims=" %f in ('dir /s /b *.cs ^| findstr /i /v /c:"\obj\" /c:"\bin\"') do echo - %f
  echo(
  echo ========================================
  echo(
  for /f "delims=" %f in ('dir /s /b *.cs ^| findstr /i /v /c:"\obj\" /c:"\bin\"') do (
    echo ===== %f =====
    findstr /n "^" "%f"
    echo(
  )
) > dump_03enunciados.txt

```

---

=====-----=====

# Zorin OS:

=====-----=====

## Movimiento entre carpetas

### Mejorado sin basura CS

cd "Dropbox/vcs/proyecto-ts/src/18EJXX/18EJ02"
cd "proyecto-ts/src/01EJXX/01EJ17"
cd "Dropbox/vcs/proyecto-ts/src/EJ_PARCIAL/EJPARCIAL03"
cd "Dropbox/vcs/proyecto-ts/src/000EJERCICIOS/00EJ04"
cd "vcs/proyecto-ts/src/000EJERCICIOS/00EJ05"

cd ~/vcs/proyecto-ts/src/09EJ_trenes

cd ~/vcs/proyecto-ts/src/Practica\ de\ enunciados/03enunciados

### Impresión de archivos entregables

```
(
  printf "PWD: %s\n" "$(pwd)"
  printf "Fecha: %s\n\n" "$(date -Is)"

  printf "ARCHIVOS INCLUIDOS:\n"
  find . -type f -name '*.cs' \
    ! -path '*/bin/*' \
    ! -path '*/obj/*' \
    -print0 \
    | sort -z \
    | xargs -0 -I{} printf " - %s\n" "{}"

  printf "\n========================================\n\n"

  find . -type f -name '*.cs' \
    ! -path '*/bin/*' \
    ! -path '*/obj/*' \
    -print0 \
    | sort -z \
    | while IFS= read -r -d '' f; do
        printf "===== %s =====\n" "$f"
        nl -ba "$f"
        printf "\n"
      done
) > dump_Ejercicio14.txt

```
