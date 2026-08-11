En C# se llama **método `Main`** y es el **punto de entrada** del programa.

El equivalente a tu estructura de TypeScript sería:

```csharp
public class Program
{
    public static void Main()
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
public class Articulo
{
    // 1. ATRIBUTOS

    // 2. CONSTRUCTOR

    // 3. PROPIEDADES / GETTERS Y SETTERS

    // 4. MÉTODOS (Comportamiento)
}
```

Mientras que `Program.cs` queda para el punto de entrada:

```csharp
public class Program
{
    public static void Main()
    {
        // Crear objetos y probar el ejercicio
    }
}
```

---

# Windows

## POWERSHELL

```

$salida = "dump_EJ11.txt"

@(
  "PWD: $((Get-Location).Path)"
  "Fecha: $(Get-Date -Format o)"
  ""
  "ARCHIVOS INCLUIDOS:"
  (Get-ChildItem -Recurse -Filter *.cs | ForEach-Object { " - $($_.FullName)" })
  ""
  "========================================"
  ""
  (Get-ChildItem -Recurse -Filter *.cs | ForEach-Object {
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

### CMD

**cd c:\Users\gasto\OneDrive\DropBox\vcs\proyecto-ts\src\00EJercicios**
**cd c:\Users\gasto\Dropbox\vcs\proyecto-ts\src\00EJERCICIOS\00EJ02**

```

(
  echo PWD: %cd%
  for /f "delims=" %I in ('powershell -NoProfile -Command "Get-Date -Format o"') do echo Fecha: %I
  echo(
  echo ARCHIVOS INCLUIDOS:
  for /r %f in (*.ts) do echo - %f
  echo(
  echo ========================================
  echo(
  for /r %f in (*.ts) do (
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
  find . -type f -name '*.ts' -print0 \
    | sort -z \
    | xargs -0 -I{} printf " - %s\n" "{}"

  printf "\n========================================\n\n"

  find . -type f -name '*.ts' -print0 \
    | sort -z \
    | while IFS= read -r -d '' f; do
        printf "===== %s =====\n" "$f"
        nl -ba "$f"
        printf "\n"
      done
) > dump_20EJ01_GPS.txt

```
