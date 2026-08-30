# Windows Application Control bloquea los ejecutables .NET locales

## Problema detectado

En Windows, al intentar ejecutar normalmente un ejercicio C# mediante:

```powershell
dotnet run --project .\01EJ14.csproj
```

Windows mostró una notificación indicando que una directiva de **Control de aplicaciones** había bloqueado el archivo generado por .NET.

La ejecución desde PowerShell confirmó que no se trataba solamente de una advertencia:

```text
Unhandled exception: An error occurred trying to start process
'...\bin\Debug\net10.0\01EJ14.exe'

Una directiva de Control de aplicaciones bloqueó este archivo.
```

---

# 1. Diagnóstico

Se verificó la firma digital del ejecutable generado por .NET:

```powershell
Get-AuthenticodeSignature ".\bin\Debug\net10.0\01EJ14.exe" |
    Format-List Status, StatusMessage, Path
```

El resultado fue:

```text
Status : NotSigned
```

Por lo tanto, se comprobó que el ejecutable local generado por el proyecto no posee firma digital.

Conceptualmente:

```text
01EJ14.exe
    ↓
ejecutable generado localmente por .NET
    ↓
no posee firma digital
    ↓
Windows Application Control
    ↓
BLOQUEADO
```

## Estado validado

```text
EJ14 compila                         ✅
El código C# funciona                ✅
.NET funciona                        ✅
La aplicación puede ejecutarse       ✅
01EJ14.exe está NotSigned            ✅
Windows bloquea ese appHost .exe     ✅
```

Por lo tanto:

> El problema no estaba en el código C# del ejercicio.

---

# 2. Qué es el appHost en este caso

Al compilar una aplicación de consola, .NET puede generar un ejecutable específico del proyecto:

```text
bin\Debug\net10.0\01EJ14.exe
```

Ese ejecutable actúa como **appHost** de la aplicación.

En esta máquina Windows, ese `.exe` local no firmado es bloqueado por la política de Control de aplicaciones.

El problema puede representarse así:

```text
dotnet run
    ↓
compila el proyecto
    ↓
genera / utiliza 01EJ14.exe
    ↓
Windows Application Control
    ↓
BLOQUEADO
```

---

# 3. Prueba sin utilizar el appHost

Para comprobar si el problema estaba específicamente relacionado con ese ejecutable, se ejecutó:

```powershell
dotnet run --project .\01EJ14.csproj -p:UseAppHost=false
```

Resultado:

```text
Velocidad: 4,9 m/s, altura: 95 m, herramienta: Sensor infrarrojo
```

La aplicación funcionó correctamente.

Esto permitió aislar el problema:

```text
Código C#
   ↓
compilación
   ↓
DLL de la aplicación
   ↓
host dotnet
   ↓
FUNCIONA ✅
```

mientras que:

```text
01EJ14.exe
(appHost)
   ↓
Windows Application Control
   ↓
BLOQUEADO ❌
```

---

# 4. Solución provisoria

Si el problema aparece en un proyecto determinado, puede ejecutarse temporalmente:

```powershell
dotnet run --project .\01EJ14.csproj -p:UseAppHost=false
```

La propiedad:

```text
UseAppHost=false
```

se aplica solamente a esa ejecución.

No modifica permanentemente el archivo `.csproj`.

Esta prueba fue realizada y quedó:

```text
VALIDADA ✅
```

---

# 5. Primera alternativa persistente: modificar el .csproj

Una posibilidad es agregar la propiedad directamente dentro del proyecto.

Archivo original:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <RootNamespace>_01EJ14</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

Se podría agregar:

```xml
<UseAppHost>false</UseAppHost>
```

quedando:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <RootNamespace>_01EJ14</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <UseAppHost>false</UseAppHost>
  </PropertyGroup>

</Project>
```

Entonces sería posible volver al comando habitual:

```powershell
dotnet run --project .\01EJ14.csproj
```

sin escribir manualmente:

```text
-p:UseAppHost=false
```

en cada ejecución.

---

# 6. Problema de modificar todos los .csproj

El repositorio contiene muchos ejercicios:

```text
EJ01
EJ02
EJ03
...
EJ14
EJ15
...
```

Agregar manualmente:

```xml
<UseAppHost>false</UseAppHost>
```

en cada archivo `.csproj` produciría una modificación repetitiva.

Además, el repositorio se utiliza tanto en:

```text
Windows
```

como en:

```text
Zorin / Linux
```

El problema detectado corresponde al entorno Windows.

Por lo tanto, se decidió no modificar individualmente todos los proyectos.

---

# 7. Solución adoptada: Directory.Build.props

.NET / MSBuild permite definir propiedades comunes para todos los proyectos ubicados debajo de una determinada carpeta mediante un archivo especial llamado:

```text
Directory.Build.props
```

Se creó el archivo en la raíz del repositorio:

```text
ejercicios-csharp-utn-2026/
│
├── Directory.Build.props
├── EjerciciosCSharpUtn2026.slnx
│
└── src/
    └── Guia01/
        ├── EJ01/
        ├── EJ02/
        ├── ...
        └── EJ14/
```

El archivo debe llamarse exactamente:

```text
Directory.Build.props
```

---

# 8. Contenido de Directory.Build.props

Se configuró:

```xml
<Project>

  <!--
    En Windows evitamos generar/utilizar el appHost .exe,
    porque Windows Application Control puede bloquear
    los ejecutables locales no firmados de los ejercicios.

    En Linux/Zorin esta configuración no se aplica.
  -->
  <PropertyGroup Condition="'$(OS)' == 'Windows_NT'">
    <UseAppHost>false</UseAppHost>
  </PropertyGroup>

</Project>
```

La condición:

```xml
Condition="'$(OS)' == 'Windows_NT'"
```

hace que:

```text
Windows
    ↓
UseAppHost = false
```

pero:

```text
Linux / Zorin
    ↓
la propiedad NO se aplica
    ↓
se mantiene el comportamiento normal de .NET
```

---

# 9. Ventaja de la configuración global

A partir de esta configuración ya no es necesario agregar:

```xml
<UseAppHost>false</UseAppHost>
```

dentro de cada:

```text
01EJ01.csproj
01EJ02.csproj
01EJ03.csproj
...
```

Todos los proyectos ubicados debajo de la raíz del repositorio pueden heredar la configuración de:

```text
Directory.Build.props
```

En Windows:

```text
Directory.Build.props
        ↓
todos los EJXX
        ↓
UseAppHost=false
```

En Zorin:

```text
Directory.Build.props
        ↓
la condición Windows_NT no se cumple
        ↓
UseAppHost=false no se aplica
```

---

# 10. El .csproj del ejercicio vuelve a quedar normal

Después de adoptar `Directory.Build.props`, `01EJ14.csproj` puede permanecer sin la propiedad específica:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <RootNamespace>_01EJ14</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>
</Project>
```

No necesita contener:

```xml
<UseAppHost>false</UseAppHost>
```

porque esa configuración proviene de:

```text
Directory.Build.props
```

---

# 11. Flujo normal para crear futuros ejercicios

No cambia el procedimiento habitual para crear proyectos.

Ejemplo:

```powershell
dotnet new console --name 01EJ15 --output .\src\Guia01\EJ15 --framework net10.0

dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Guia01\EJ15\01EJ15.csproj

dotnet run --project ".\src\Guia01\EJ15\01EJ15.csproj"
```

No es necesario modificar manualmente el nuevo `.csproj`.

En Windows, el proyecto heredará:

```text
UseAppHost=false
```

desde:

```text
Directory.Build.props
```

En Zorin/Linux esa propiedad no se aplicará.

---

# 12. Validación realizada

Después de crear `Directory.Build.props` y retirar la configuración específica del `01EJ14.csproj`, el proyecto volvió a ejecutarse correctamente en Windows.

Salida:

```text
Velocidad: 4,9 m/s, altura: 95 m, herramienta: Sensor infrarrojo
```

Ya no apareció el bloqueo:

```text
Una directiva de Control de aplicaciones bloqueó este archivo.
```

Por lo tanto, la solución global mediante:

```text
Directory.Build.props
```

queda:

```text
VALIDADA EN WINDOWS ✅
```

---

# 13. Advertencia de Code Runner: problema separado

Durante una prueba apareció esta advertencia:

```text
Program.cs parece ser una aplicación basada en archivos,
pero se pasó como argumento al proyecto...
```

Esto ocurrió porque VS Code / Code Runner ejecutó algo parecido a:

```powershell
dotnet run "C:\...\EJ14\Program.cs"
```

El programa igualmente funcionó.

Esta advertencia:

```text
NO está relacionada con Windows Application Control.
```

Son dos problemas diferentes.

## Problema 1

```text
Windows Application Control
→ bloqueaba el appHost .exe
→ RESUELTO con Directory.Build.props
```

## Problema 2

```text
Code Runner agrega Program.cs como argumento
→ genera una advertencia
→ PENDIENTE
```

Para los proyectos multiarchivo, el comando correcto continúa siendo:

```powershell
dotnet run --project .\01EJ14.csproj
```

o desde la raíz:

```powershell
dotnet run --project ".\src\Guia01\EJ14\01EJ14.csproj"
```

---

# 14. Qué NO fue necesario modificar

Para resolver el bloqueo NO fue necesario:

```text
desactivar Smart App Control                 ❌
desactivar Windows Application Control       ❌
cambiar ExecutionPolicy de PowerShell        ❌
firmar manualmente los ejercicios            ❌
modificar el código C#                       ❌
agregar la propiedad a cada .csproj          ❌
```

La solución adoptada fue:

```text
Directory.Build.props
        ↓
solo en Windows
        ↓
UseAppHost=false
```

---

# 15. Regla rápida para diagnosticar este problema

Si un ejercicio muestra:

```text
Una directiva de Control de aplicaciones bloqueó este archivo.
```

primero verificar la firma:

```powershell
Get-AuthenticodeSignature ".\bin\Debug\net10.0\PROYECTO.exe" |
    Format-List Status, StatusMessage, Path
```

Si aparece:

```text
Status : NotSigned
```

probar:

```powershell
dotnet run --project .\PROYECTO.csproj -p:UseAppHost=false
```

Si funciona:

```text
código / proyecto          → OK
appHost .exe local         → bloqueado
```

Si el repositorio ya contiene:

```text
Directory.Build.props
```

con la configuración global de Windows, normalmente bastará ejecutar:

```powershell
dotnet run --project .\PROYECTO.csproj
```

---

# 16. Rutina recomendada de ejecución

Para ejercicios con varias clases:

```powershell
dotnet run --project .\01EJXX.csproj
```

Desde la raíz del repositorio:

```powershell
dotnet run --project ".\src\Guia01\EJXX\01EJXX.csproj"
```

Evitar como flujo habitual:

```powershell
dotnet run Program.cs
```

porque los ejercicios actuales son proyectos multiarchivo.

---

# 17. Estado final

## VALIDADO

```text
Causa localizada:
Windows bloqueaba el appHost .exe local no firmado.

Prueba:
dotnet run --project .\01EJ14.csproj -p:UseAppHost=false

Resultado:
FUNCIONÓ.

Solución adoptada:
Directory.Build.props

Condición:
solo Windows_NT.

Configuración:
UseAppHost=false.

Resultado:
los proyectos pueden ejecutarse sin modificar
individualmente cada .csproj.

Zorin/Linux:
la configuración específica no se aplica.
```

## PENDIENTE INDEPENDIENTE

```text
Advertencia de Code Runner al agregar Program.cs
como argumento a dotnet run.
```

Este pendiente no afecta al funcionamiento del proyecto ni forma parte del problema de Windows Application Control.

---

# Resumen final

```text
WINDOWS
   ↓
Directory.Build.props
   ↓
Condition = Windows_NT
   ↓
UseAppHost = false
   ↓
dotnet ejecuta la aplicación sin depender
del .exe appHost bloqueado
   ↓
FUNCIONA ✅


ZORIN / LINUX
   ↓
Condition Windows_NT = false
   ↓
UseAppHost=false no se aplica
   ↓
comportamiento normal de .NET ✅
```

> **Estado: SOLUCIÓN VALIDADA EN EJ14 SOBRE WINDOWS.**
>
> Se adopta `Directory.Build.props` como configuración central del repositorio para evitar modificar individualmente todos los archivos `.csproj`.
