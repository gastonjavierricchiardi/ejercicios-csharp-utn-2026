# Breve guía del proyecto — Programación II C# UTN 2026

## Estado validado: 11/09/2026

---

# 1. Objetivo

Este repositorio contiene el trabajo de la cursada 2026 de Programación II utilizando C# y .NET 10.

El repositorio utiliza varias soluciones `.slnx`, cada una destinada a agrupar un conjunto determinado de proyectos.

Las soluciones principales son:

```text
AECsharp.slnx
ClasesCSharpUtn2026.slnx
EjerciciosCSharpUtn2026.slnx
```

La idea general es:

```text
REPOSITORIO
│
├── AECsharp.slnx
│   └── Autoevaluaciones
│
├── ClasesCSharpUtn2026.slnx
│   └── Clases dictadas
│
└── EjerciciosCSharpUtn2026.slnx
    ├── Guía 01
    ├── Herencia
    └── Otros ejercicios
```

Una solución puede contener muchos proyectos `.csproj`.

Cada proyecto continúa siendo independiente y puede compilarse o ejecutarse por separado.

---

# 2. Estructura general del repositorio

La estructura principal es:

```text
ejercicios-csharp-utn-2026/
│
├── AECsharp.slnx
├── ClasesCSharpUtn2026.slnx
├── EjerciciosCSharpUtn2026.slnx
│
├── .gitignore
│
├── .vscode/
│   └── settings.json
│
└── src/
    │
    ├── AutoEvaluaciones/
    │   ├── 01-AE/
    │   ├── 02-AE/
    │   ├── 03-AE/
    │   ├── 04-AE/
    │   ├── 05-AE/
    │   └── 06-AE/
    │
    ├── ClasesDictadas/
    │
    ├── Guia01/
    │   ├── EJ01/
    │   ├── EJ02/
    │   ├── ...
    │   └── EJ39/
    │
    ├── Herencia/
    │
    └── Micros/
```

---

# 3. Regla general de organización

Para los ejercicios independientes se utiliza:

```text
un ejercicio
      ↓
una carpeta
      ↓
un proyecto .csproj
```

Ejemplo:

```text
src/
└── Guia01/
    └── EJ13/
        ├── 01EJ13.csproj
        └── Program.cs
```

Regla:

> Un ejercicio independiente = una carpeta `EJXX` = un proyecto `.csproj`.

El proyecto puede contener posteriormente tantos archivos `.cs` como sean necesarios.

Ejemplo:

```text
EJXX/
├── 01EJXX.csproj
├── Program.cs
├── Clase1.cs
├── Clase2.cs
└── ...
```

Todos esos archivos pertenecen al mismo proyecto.

---

# 4. Solución de ejercicios

La solución principal destinada a ejercicios es:

```text
EjerciciosCSharpUtn2026.slnx
```

Actualmente contiene proyectos correspondientes a:

```text
src/Guia01/
src/Herencia/
src/Micros/
```

Una sola solución puede contener muchos proyectos independientes.

Esto fue validado mediante:

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx list
```

La solución reconoce actualmente los proyectos de la Guía 01 desde:

```text
EJ01
...
EJ39
```

con la excepción de `EJ05`.

También contiene proyectos de Herencia y Micros.

---

# 5. Caso particular de EJ05

Dentro del estado actual del proyecto:

> `EJ05` está incluido conceptualmente en `EJ04`.

Por lo tanto:

```text
src/Guia01/EJ05/
```

puede contener material del ejercicio, pero actualmente:

> NO posee un proyecto `.csproj` independiente.

No crear un proyecto para `EJ05` salvo que esta decisión cambie expresamente.

---

# 6. Solución de autoevaluaciones

Las autoevaluaciones utilizan:

```text
AECsharp.slnx
```

Actualmente contiene:

```text
src/AutoEvaluaciones/01-AE/01-AE.csproj
src/AutoEvaluaciones/02-AE/02-AE.csproj
src/AutoEvaluaciones/03-AE/03-AE.csproj
src/AutoEvaluaciones/04-AE/04-AE.csproj
src/AutoEvaluaciones/05-AE/05-AE.csproj
src/AutoEvaluaciones/06-AE/06-AE.csproj
```

Cada autoevaluación es un proyecto independiente.

Ejemplo:

```text
AutoEvaluaciones/
└── 03-AE/
    ├── 03-AE.csproj
    └── Program.cs
```

Para comprobar los proyectos registrados:

```powershell
dotnet sln .\AECsharp.slnx list
```

---

# 7. Solución de clases dictadas

Las clases de codeo poseen su propia solución:

```text
ClasesCSharpUtn2026.slnx
```

Los proyectos correspondientes se encuentran principalmente dentro de:

```text
src/ClasesDictadas/
```

La intención es mantener separados:

```text
Ejercicios
Autoevaluaciones
Clases dictadas
```

aunque todos convivan dentro del mismo repositorio Git.

Para verificar qué proyectos pertenecen actualmente a esta solución:

```powershell
dotnet sln .\ClasesCSharpUtn2026.slnx list
```

---

# 8. Raíz del repositorio

Salvo que se indique expresamente lo contrario, los comandos de esta guía se ejecutan desde la raíz del repositorio.

## Windows

```text
C:\vcs\ejercicios-csharp-utn-2026
```

Ejemplo de prompt:

```text
PS C:\vcs\ejercicios-csharp-utn-2026>
```

## Zorin OS

```text
/home/gaston/vcs/ejercicios-csharp-utn-2026
```

También puede aparecer como:

```text
~/vcs/ejercicios-csharp-utn-2026
```

---

# 9. PowerShell vs Bash

La estructura del proyecto es la misma en ambos sistemas.

Lo que cambia principalmente es la sintaxis utilizada para las rutas.

## Windows / PowerShell

```text
.\src\Guia01\EJ13
```

## Zorin OS / Bash

```text
./src/Guia01/EJ13
```

No utilizar automáticamente sintaxis de PowerShell dentro de Bash.

Ejemplo incorrecto en Bash:

```text
.\src\Guia01\EJ13
```

porque `\` posee significado especial para la shell.

---

# 10. Crear un ejercicio nuevo — Windows

Todos los comandos siguientes suponen estar parado en:

```text
C:\vcs\ejercicios-csharp-utn-2026
```

Ejemplo para crear `EJ40`:

```powershell
dotnet new console --name 01EJ40 --output .\src\Guia01\EJ40 --framework net10.0
```

Esto crea principalmente:

```text
src/
└── Guia01/
    └── EJ40/
        ├── 01EJ40.csproj
        ├── Program.cs
        └── obj/
```

Donde:

- `01EJ40.csproj` es el proyecto.
- `Program.cs` es el archivo inicial generado por la plantilla.
- `obj/` es generado automáticamente por .NET.

---

# 11. Crear un ejercicio nuevo — Zorin OS

Desde la raíz del repositorio:

```bash
dotnet new console --name 01EJ40 --output ./src/Guia01/EJ40 --framework net10.0
```

La estructura resultante es equivalente:

```text
src/
└── Guia01/
    └── EJ40/
        ├── 01EJ40.csproj
        ├── Program.cs
        └── obj/
```

---

# 12. Agregar un ejercicio a la solución

Crear el proyecto no significa que automáticamente pertenezca a una solución.

Debe agregarse explícitamente.

## Windows / PowerShell

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Guia01\EJ40\01EJ40.csproj
```

## Zorin OS / Bash

```bash
dotnet sln ./EjerciciosCSharpUtn2026.slnx add ./src/Guia01/EJ40/01EJ40.csproj
```

Después de hacerlo:

```text
EjerciciosCSharpUtn2026.slnx
        │
        └── src/Guia01/EJ40/01EJ40.csproj
```

---

# 13. Ejecutar un ejercicio

Para los ejercicios de este repositorio se ejecuta el proyecto `.csproj`.

## Windows / PowerShell

```powershell
dotnet run --project ".\src\Guia01\EJ40\01EJ40.csproj"
```

## Zorin OS / Bash

```bash
dotnet run --project ./src/Guia01/EJ40/01EJ40.csproj
```

---

# 14. Secuencia estándar para crear un ejercicio

El flujo normal es:

```text
CREAR PROYECTO
      ↓
AGREGAR A LA SOLUCIÓN
      ↓
DESARROLLAR EL EJERCICIO
      ↓
EJECUTAR EL PROYECTO
```

## Windows / PowerShell

```powershell
dotnet new console --name 01EJ40 --output .\src\Guia01\EJ40 --framework net10.0

dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Guia01\EJ40\01EJ40.csproj

dotnet run --project ".\src\Guia01\EJ40\01EJ40.csproj"
```

## Zorin OS / Bash

```bash
dotnet new console --name 01EJ40 --output ./src/Guia01/EJ40 --framework net10.0

dotnet sln ./EjerciciosCSharpUtn2026.slnx add ./src/Guia01/EJ40/01EJ40.csproj

dotnet run --project ./src/Guia01/EJ40/01EJ40.csproj
```

---

# 15. Ejercicios multiarchivo

Un proyecto puede contener varias clases.

Ejemplo:

```text
EJXX/
├── 01EJXX.csproj
├── Program.cs
├── Persona.cs
├── Empleado.cs
└── Empresa.cs
```

Todos los archivos `.cs` pertenecientes al proyecto se compilan conjuntamente.

Por esta razón, el flujo vigente es:

```text
dotnet run --project <ruta-al-csproj>
```

Ejemplo:

```powershell
dotnet run --project ".\src\Guia01\EJ13\01EJ13.csproj"
```

---

# 16. Regla sobre `dotnet run --file`

`dotnet run --file` solamente tiene sentido cuando el archivo es completamente autocontenido.

No utilizar:

```text
dotnet run --file Program.cs
```

cuando `Program.cs` depende de clases que se encuentran en otros archivos `.cs`.

Ejemplo:

```text
Program.cs
Vehiculo.cs
```

deben ejecutarse mediante el proyecto:

```powershell
dotnet run --project ".\src\Guia01\EJ02\01EJ02.csproj"
```

---

# 17. Comprobar los proyectos de una solución

Para listar los proyectos registrados:

## Ejercicios

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx list
```

## Autoevaluaciones

```powershell
dotnet sln .\AECsharp.slnx list
```

## Clases

```powershell
dotnet sln .\ClasesCSharpUtn2026.slnx list
```

Este comando no compila.

Solamente muestra qué proyectos pertenecen a la solución.

---

# 18. Restaurar una solución

Para restaurar todos los proyectos incluidos en una solución:

```powershell
dotnet restore .\EjerciciosCSharpUtn2026.slnx
```

Resultado esperado cuando todo está correctamente referenciado:

```text
Restauración completada
```

La restauración permite detectar, entre otras cosas:

- referencias a proyectos inexistentes;
- rutas incorrectas;
- problemas relacionados con restauración de paquetes.

---

# 19. Compilar una solución completa

Es posible compilar todos los proyectos registrados en la solución mediante:

```powershell
dotnet build .\EjerciciosCSharpUtn2026.slnx
```

Esto intenta compilar todos los `.csproj` incluidos.

Ejemplo conceptual:

```text
EjerciciosCSharpUtn2026.slnx
│
├── EJ01 → compila
├── EJ02 → compila
├── EJ03 → compila
├── ...
└── EJXX → compila
```

Si uno de los ejercicios contiene código incompleto o un error de compilación:

```text
dotnet build solución
```

puede finalizar con error.

Eso no significa automáticamente que la solución esté mal configurada.

Puede significar simplemente que uno de los proyectos individuales todavía no compila.

Por ejemplo, un ejercicio aún no desarrollado puede no poseer un punto de entrada válido y producir:

```text
CS5001
```

La solución puede seguir siendo estructuralmente correcta.

---

# 20. Diferencia entre solución y proyecto

Es importante distinguir:

```text
SOLUCIÓN
EjerciciosCSharpUtn2026.slnx
```

de:

```text
PROYECTO
01EJ13.csproj
```

La solución:

```text
agrupa proyectos
```

El proyecto:

```text
agrupa los archivos que forman un programa
```

Modelo:

```text
EjerciciosCSharpUtn2026.slnx
│
├── 01EJ01.csproj
├── 01EJ02.csproj
├── 01EJ03.csproj
├── ...
└── 01EJ39.csproj
```

Los proyectos continúan siendo independientes entre sí salvo que explícitamente se configure una referencia entre proyectos.

---

# 21. Una solución puede contener múltiples proyectos

Sí.

Ese es precisamente el esquema utilizado en este repositorio.

Fue validado con:

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx list
```

y:

```powershell
dotnet build .\EjerciciosCSharpUtn2026.slnx
```

La solución de ejercicios posee actualmente múltiples proyectos independientes.

Por lo tanto:

> No es necesario crear una solución distinta para cada ejercicio.

La organización utilizada es:

```text
UNA SOLUCIÓN DE EJERCICIOS
          │
          ├── ejercicio 1 → proyecto
          ├── ejercicio 2 → proyecto
          ├── ejercicio 3 → proyecto
          └── ...
```

---

# 22. Proyectos especiales dentro de la solución de ejercicios

`EjerciciosCSharpUtn2026.slnx` no contiene solamente `Guia01`.

También puede agrupar otros ejercicios de la materia.

Actualmente existen proyectos dentro de:

```text
src/Herencia/
```

y:

```text
src/Micros/
```

Esto es válido porque una solución puede organizar múltiples proyectos aunque estén ubicados en carpetas diferentes del repositorio.

Ejemplo conceptual:

```text
EjerciciosCSharpUtn2026.slnx
│
├── src/Guia01/EJ01/...
├── src/Guia01/EJ02/...
├── src/Herencia/Herencia01_figurasGeometricas/...
├── src/Herencia/Herencia02_sueldos/...
├── src/Herencia/Herencia03_celulares/...
└── src/Micros/...
```

---

# 23. Crear un proyecto especial

No todos los ejercicios necesariamente utilizan el formato `EJXX`.

Por ejemplo, Micros utiliza:

```text
src/Micros/
```

con un proyecto propio.

El procedimiento sigue siendo exactamente el mismo:

```powershell
dotnet new console --name EJMicros --output .\src\Micros --framework net10.0

dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Micros\EJMicros.csproj

dotnet run --project ".\src\Micros\EJMicros.csproj"
```

La regla importante no es el nombre de la carpeta.

La regla es:

> Cada ejercicio independiente debe poseer su propio proyecto `.csproj`.

---

# 24. Crear una Autoevaluación

Las autoevaluaciones utilizan `AECsharp.slnx`.

Ejemplo para una futura `07-AE`:

## Windows / PowerShell

```powershell
dotnet new console --name 07-AE --output .\src\AutoEvaluaciones\07-AE --framework net10.0

dotnet sln .\AECsharp.slnx add .\src\AutoEvaluaciones\07-AE\07-AE.csproj

dotnet run --project ".\src\AutoEvaluaciones\07-AE\07-AE.csproj"
```

## Zorin OS / Bash

```bash
dotnet new console --name 07-AE --output ./src/AutoEvaluaciones/07-AE --framework net10.0

dotnet sln ./AECsharp.slnx add ./src/AutoEvaluaciones/07-AE/07-AE.csproj

dotnet run --project ./src/AutoEvaluaciones/07-AE/07-AE.csproj
```

---

# 25. Crear varios proyectos en cascada

Cuando se necesite crear una cantidad grande de ejercicios puede utilizarse PowerShell.

Ejemplo conceptual:

```powershell
foreach ($n in 40..45) {
    $ej = "EJ{0:D2}" -f $n
    $proyecto = "01EJ{0:D2}" -f $n

    dotnet new console --name $proyecto --output "./src/Guia01/$ej" --framework net10.0
    dotnet sln "./EjerciciosCSharpUtn2026.slnx" add "./src/Guia01/$ej/$proyecto.csproj"
}
```

IMPORTANTE:

> Este comando supone estar parado en la raíz del repositorio.

Antes de ejecutar un proceso en cascada conviene verificar:

```powershell
Get-Location
```

y confirmar que el resultado sea:

```text
C:\vcs\ejercicios-csharp-utn-2026
```

Esto evita crear proyectos accidentalmente en una ubicación incorrecta.

---

# 26. Sobre `--force`

El parámetro:

```text
--force
```

permite que `dotnet new` sobrescriba contenido existente.

No debe utilizarse normalmente al crear un ejercicio nuevo.

Ejemplo recomendado:

```powershell
dotnet new console --name 01EJ40 --output .\src\Guia01\EJ40 --framework net10.0
```

Utilizar:

```text
--force
```

solamente cuando se haya decidido conscientemente sobrescribir archivos existentes.

---

# 27. Archivos `.slnx`

Las soluciones actuales utilizan el formato:

```text
.slnx
```

Ejemplo:

```text
EjerciciosCSharpUtn2026.slnx
AECsharp.slnx
ClasesCSharpUtn2026.slnx
```

Estas soluciones se generan mediante:

```powershell
dotnet new sln --name NombreSolucion
```

En el entorno utilizado durante la cursada, .NET genera el archivo `.slnx`.

Ejemplo:

```powershell
dotnet new sln --name AECsharp
```

genera:

```text
AECsharp.slnx
```

---

# 28. Preferir `dotnet sln` para administrar la solución

Para agregar proyectos:

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx add <proyecto.csproj>
```

Para listar:

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx list
```

La administración normal de la solución debe realizarse mediante las herramientas de `.NET`.

No modificar manualmente el `.slnx` como procedimiento rutinario.

---

# 29. Diagnóstico de referencias incorrectas en `.slnx`

Si `dotnet restore` informa que un proyecto registrado no existe, puede buscarse la referencia.

Ejemplo validado:

```powershell
Select-String -Path .\EjerciciosCSharpUtn2026.slnx -Pattern "texto-a-buscar"
```

Durante la cursada se detectó una referencia incorrecta como:

```text
src/Guia01/EJ14/01EJ14.csproj.old2
```

cuando el proyecto real era:

```text
src/Guia01/EJ14/01EJ14.csproj
```

Luego de corregir exclusivamente esa referencia:

```powershell
dotnet restore .\EjerciciosCSharpUtn2026.slnx
```

finalizó correctamente.

Regla:

> Ante un problema de solución, primero diagnosticar la referencia exacta antes de modificar archivos.

---

# 30. Comandos de diagnóstico principales

Desde la raíz del repositorio:

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx list

dotnet restore .\EjerciciosCSharpUtn2026.slnx

dotnet build .\EjerciciosCSharpUtn2026.slnx
```

Cada comando responde una pregunta diferente:

```text
sln list
→ ¿Qué proyectos pertenecen a la solución?

restore
→ ¿Las referencias y restauraciones de los proyectos son válidas?

build
→ ¿Compilan actualmente todos los proyectos?
```

---

# 31. Visual Studio Code

El repositorio contiene:

```text
.vscode/settings.json
```

Actualmente se utiliza Visual Studio Code para trabajar sobre el repositorio completo.

En Windows, la terminal integrada utilizada es PowerShell.

En Zorin OS, la terminal integrada utilizada es Bash.

Para proyectos C# multiarchivo se recomienda trabajar directamente contra el `.csproj`.

Ejemplo:

```powershell
dotnet run --project ".\src\Guia01\EJ13\01EJ13.csproj"
```

Esto evita depender de la ejecución aislada del archivo abierto actualmente en el editor.

---

# 32. `bin/` y `obj/`

.NET genera automáticamente carpetas como:

```text
bin/
obj/
```

Estas carpetas contienen:

- archivos compilados;
- archivos temporales;
- información de restauración;
- artefactos generados por .NET.

No forman parte del código fuente del ejercicio.

---

# 33. `.gitignore`

La regla del repositorio es no versionar:

```text
bin/
obj/
```

El `.gitignore` debe contemplar:

```gitignore
**/bin/
**/obj/
```

También pueden ignorarse otros artefactos locales cuando corresponda.

---

# 34. Verificar Git antes de publicar

Antes de realizar un commit:

```powershell
git status
```

o en Bash:

```bash
git status
```

Debe revisarse qué archivos serán incorporados al repositorio.

---

# 35. Repositorio público y seguridad

El repositorio es público.

No deben versionarse:

- contraseñas;
- tokens;
- claves privadas;
- secretos de API;
- credenciales;
- archivos que contengan información sensible.

Las rutas locales incluidas en esta guía solamente documentan el entorno de desarrollo utilizado durante la cursada.

---

# 36. Windows — comandos principales

Desde:

```text
C:\vcs\ejercicios-csharp-utn-2026
```

Crear proyecto:

```powershell
dotnet new console --name 01EJ40 --output .\src\Guia01\EJ40 --framework net10.0
```

Agregarlo:

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Guia01\EJ40\01EJ40.csproj
```

Ejecutarlo:

```powershell
dotnet run --project ".\src\Guia01\EJ40\01EJ40.csproj"
```

Listar proyectos:

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx list
```

Restaurar solución:

```powershell
dotnet restore .\EjerciciosCSharpUtn2026.slnx
```

Compilar solución:

```powershell
dotnet build .\EjerciciosCSharpUtn2026.slnx
```

---

# 37. Zorin OS — comandos principales

Desde:

```text
~/vcs/ejercicios-csharp-utn-2026
```

Crear proyecto:

```bash
dotnet new console --name 01EJ40 --output ./src/Guia01/EJ40 --framework net10.0
```

Agregarlo:

```bash
dotnet sln ./EjerciciosCSharpUtn2026.slnx add ./src/Guia01/EJ40/01EJ40.csproj
```

Ejecutarlo:

```bash
dotnet run --project ./src/Guia01/EJ40/01EJ40.csproj
```

Listar proyectos:

```bash
dotnet sln ./EjerciciosCSharpUtn2026.slnx list
```

Restaurar:

```bash
dotnet restore ./EjerciciosCSharpUtn2026.slnx
```

Compilar:

```bash
dotnet build ./EjerciciosCSharpUtn2026.slnx
```

---

# 38. Comprobaciones adicionales en Zorin OS

Ubicación actual:

```bash
pwd
```

Archivos de la carpeta:

```bash
ls -la
```

Buscar proyectos:

```bash
find . -maxdepth 4 -type f -name "*.csproj" | sort
```

Esto permite comprobar físicamente qué proyectos existen en el repositorio.

---

# 39. Flujo recomendado del repositorio

Para un ejercicio:

```text
1. Crear proyecto
      ↓
2. Agregar proyecto a la solución
      ↓
3. Trabajar archivos .cs
      ↓
4. Ejecutar proyecto
      ↓
5. Validar
```

No es necesario recompilar toda la solución cada vez que se trabaja sobre un único ejercicio.

Normalmente alcanza con:

```powershell
dotnet run --project ".\src\Guia01\EJXX\01EJXX.csproj"
```

El `build` completo de la solución queda disponible como comprobación general.

---

# 40. Según el profesor Andrés

La indicación registrada del profesor para organizar los primeros ejercicios es:

> La forma correcta es seguir los pasos que están indicados en la guía “Configuración Solución y aplicación de Consola .Net en VS Code”.
>
> Para los primeros ejercicios, podés crear una solución y una aplicación de consola de la siguiente manera.
>
> Abrí una terminal y copiá y pegá los siguientes comandos:

```bash
# Crear la carpeta de trabajo

mkdir ConsoleSolution

cd ConsoleSolution

# Crear la solución

dotnet new sln --name ConsoleSolution

# Crear el proyecto de consola

dotnet new console --name ConsoleApp --output src/ConsoleApp --framework net10.0

# Agregar el proyecto a la solución

dotnet sln add src/ConsoleApp/ConsoleApp.csproj
```

La estructura resultante es:

```text
ConsoleSolution
│
├── ConsoleSolution.slnx
│
└── src
    └── ConsoleApp
        ├── ConsoleApp.csproj
        └── Program.cs
```

La idea principal indicada por el profesor es:

> Cada ejercicio debe tener su propio proyecto para mantener separados los archivos y configuraciones de ejercicios diferentes.

El repositorio actual mantiene ese principio y lo amplía agrupando muchos de esos proyectos dentro de soluciones temáticas.

---

# 41. Estado actual validado

## Soluciones

```text
EjerciciosCSharpUtn2026.slnx
AECsharp.slnx
ClasesCSharpUtn2026.slnx
```

## Autoevaluaciones

Actualmente:

```text
01-AE
02-AE
03-AE
04-AE
05-AE
06-AE
```

pertenecen a:

```text
AECsharp.slnx
```

## Guía 01

Actualmente existen carpetas desde:

```text
EJ01
```

hasta:

```text
EJ39
```

`EJ05` no posee proyecto independiente.

Los restantes ejercicios creados poseen su correspondiente `.csproj`.

## Ejercicios adicionales

La solución de ejercicios también contiene proyectos correspondientes a:

```text
Herencia
Micros
```

---

# 42. Regla final

La estructura del repositorio queda resumida así:

```text
REPOSITORIO
│
├── AECsharp.slnx
│   └── múltiples proyectos de AutoEvaluaciones
│
├── ClasesCSharpUtn2026.slnx
│   └── múltiples proyectos de clases dictadas
│
└── EjerciciosCSharpUtn2026.slnx
    └── múltiples proyectos de ejercicios
```

Y dentro de cada solución:

```text
UNA SOLUCIÓN
     ↓
MUCHOS PROYECTOS
     ↓
CADA PROYECTO ES INDEPENDIENTE
```

Para ejercicios:

```text
un ejercicio independiente
        ↓
una carpeta
        ↓
un .csproj
        ↓
uno o varios archivos .cs
```

Flujo base:

```text
dotnet new console
        ↓
dotnet sln ... add
        ↓
dotnet run --project
```

Comprobación general:

```text
dotnet sln ... list
        ↓
dotnet restore
        ↓
dotnet build
```

> La solución organiza los proyectos.
>
> El proyecto organiza y compila los archivos de cada ejercicio.
>
> Tener múltiples proyectos dentro de una misma solución es el funcionamiento esperado del repositorio.
