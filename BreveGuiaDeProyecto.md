# Base del proyecto — Ejercicios C# Programación II UTN 2026

## Objetivo

Organizar los ejercicios de Programación II en una única solución .NET 10, utilizando la misma estructura tanto en Windows como en Zorin OS.

La estructura general del repositorio es:

```text
ejercicios-csharp-utn-2026/
├── EjerciciosCSharpUtn2026.slnx
├── .gitignore
├── .vscode/
│   └── settings.json
└── src/
    └── Guia01/
        ├── EJ01/
        ├── EJ02/
        ├── EJ03/
        └── ...
```

---

# 1. Solución principal

El repositorio utiliza una única solución:

```text
EjerciciosCSharpUtn2026.slnx
```

Con .NET 10, el comando utilizado en este proyecto es:

```bash
dotnet new sln --name EjerciciosCSharpUtn2026
```

En el entorno utilizado durante la cursada, este comando genera:

```text
EjerciciosCSharpUtn2026.slnx
```

La solución `.slnx` agrupa todos los proyectos correspondientes a los ejercicios.

---

# 2. Organización de los ejercicios

Los ejercicios se almacenan dentro de:

```text
src/
└── Guia01/
```

Cada ejercicio tiene su propia carpeta:

```text
src/
└── Guia01/
    ├── EJ01/
    ├── EJ02/
    ├── EJ03/
    └── ...
```

Cada ejercicio es un proyecto independiente de consola.

Ejemplo:

```text
EJ01/
├── 01EJ01.csproj
└── Program.cs
```

Por lo tanto:

```text
EJ01 → 01EJ01.csproj
EJ02 → 01EJ02.csproj
EJ03 → 01EJ03.csproj
...
```

Regla general:

> Un ejercicio = una carpeta `EJXX` = un proyecto `.csproj`.

---

# 3. Terminal integrada de Visual Studio Code

Visual Studio Code puede utilizar distintas terminales según el sistema operativo.

## Windows

En Windows se viene utilizando PowerShell.

Ejemplo de prompt:

```text
PS C:\vcs\ejercicios-csharp-utn-2026>
```

Las rutas normalmente se escriben con `\`:

```text
.\src\Guia01\EJ08
```

## Zorin OS

En Zorin OS, la terminal integrada de Visual Studio Code utiliza Bash.

Ejemplo de prompt:

```text
gaston@gaston-Latitude-3410:~/vcs/ejercicios-csharp-utn-2026$
```

Aunque la terminal esté abierta dentro de Visual Studio Code, sigue siendo Bash sobre Linux.

Las rutas deben escribirse con `/`:

```text
./src/Guia01/EJ08
```

No utilizar en Bash:

```text
.\src\Guia01\EJ08
```

porque `\` tiene un significado especial para la shell y puede producir una ruta distinta de la esperada.

---

# 4. Raíz del repositorio

Los comandos de creación, agregado a la solución y ejecución se realizan desde la raíz del repositorio.

## Windows

```text
C:\vcs\ejercicios-csharp-utn-2026
```

## Zorin OS

```text
/home/gaston/vcs/ejercicios-csharp-utn-2026
```

También puede verse abreviado en Bash como:

```text
~/vcs/ejercicios-csharp-utn-2026
```

Para comprobar la ubicación actual:

```bash
pwd
```

---

# 5. Crear un ejercicio en Windows

Ejemplo para crear `EJ08` desde PowerShell:

```powershell
dotnet new console --name 01EJ08 --output .\src\Guia01\EJ08 --framework net10.0
```

El comando crea:

```text
src/
└── Guia01/
    └── EJ08/
        ├── 01EJ08.csproj
        ├── Program.cs
        └── obj/
```

Donde:

- `01EJ08.csproj` es el archivo de proyecto.
- `Program.cs` es el archivo inicial generado por la plantilla.
- `obj/` es generado automáticamente por .NET.

---

# 6. Crear un ejercicio en Zorin OS

Ejemplo validado para crear `EJ08` desde Bash:

```bash
dotnet new console --name 01EJ08 --output ./src/Guia01/EJ08 --framework net10.0
```

Salida validada:

```text
La plantilla "Aplicación de consola" se creó correctamente.

Procesando acciones posteriores a la creación...
Restaurando /home/gaston/vcs/ejercicios-csharp-utn-2026/src/Guia01/EJ08/01EJ08.csproj:
Restauración realizada correctamente.
```

La estructura creada es la misma que en Windows:

```text
src/
└── Guia01/
    └── EJ08/
        ├── 01EJ08.csproj
        ├── Program.cs
        └── obj/
```

La diferencia no está en .NET ni en el proyecto, sino en la sintaxis de las rutas utilizada por la shell.

---

# 7. Diferencia importante entre PowerShell y Bash

## PowerShell

```powershell
.\src\Guia01\EJ08
```

## Bash / Zorin OS

```bash
./src/Guia01/EJ08
```

Ejemplo de un error real producido al utilizar sintaxis de PowerShell dentro de Bash:

```bash
dotnet new console --name 01EJ07 --output .\src\Guia01\EJ08 --framework net10.0 --force
```

Bash interpretó los caracteres `\` y terminó generando una carpeta incorrecta en la raíz:

```text
.srcGuia01EJ08/
```

Además, en ese comando se había indicado:

```text
--name 01EJ07
```

aunque se intentaba crear `EJ08`.

El resultado fue:

```text
.srcGuia01EJ08/
├── 01EJ07.csproj
├── Program.cs
└── obj/
```

La forma correcta en Zorin OS es:

```bash
dotnet new console --name 01EJ08 --output ./src/Guia01/EJ08 --framework net10.0
```

---

# 8. Agregar el ejercicio a la solución

Crear el proyecto no significa que automáticamente pertenezca a la solución.

Hay que agregarlo explícitamente.

## Windows / PowerShell

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Guia01\EJ08\01EJ08.csproj
```

## Zorin OS / Bash

```bash
dotnet sln ./EjerciciosCSharpUtn2026.slnx add ./src/Guia01/EJ08/01EJ08.csproj
```

En ambos casos, el objetivo es el mismo:

```text
EjerciciosCSharpUtn2026.slnx
└── src/Guia01/EJ08/01EJ08.csproj
```

---

# 9. Comprobar los proyectos de la solución

Para ver qué proyectos contiene la solución:

## Windows / PowerShell

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx list
```

## Zorin OS / Bash

```bash
dotnet sln ./EjerciciosCSharpUtn2026.slnx list
```

Ejemplo de salida:

```text
Proyectos
---------
src/Guia01/EJ01/01EJ01.csproj
src/Guia01/EJ02/01EJ02.csproj
src/Guia01/EJ03/01EJ03.csproj
...
src/Guia01/EJ08/01EJ08.csproj
```

Este comando es solamente de comprobación.

No forma parte de los tres pasos obligatorios para crear y ejecutar un ejercicio.

---

# 10. Ejecutar un ejercicio

Para los ejercicios del repositorio se utiliza el proyecto `.csproj`.

## Windows / PowerShell

```powershell
dotnet run --project ".\src\Guia01\EJ08\01EJ08.csproj"
```

## Zorin OS / Bash

```bash
dotnet run --project ./src/Guia01/EJ08/01EJ08.csproj
```

La ejecución inicial del proyecto recién creado mostró:

```text
Hello, World!
```

Esto confirma que el proyecto fue creado, restaurado y ejecutado correctamente.

---

# 11. Regla `--project` para ejercicios multiarchivo

Los ejercicios pueden contener varias clases:

```text
EJ08/
├── 01EJ08.csproj
├── Program.cs
├── Clase1.cs
├── Clase2.cs
└── ...
```

Por esta razón, el flujo vigente del repositorio es:

```bash
dotnet run --project <ruta-al-csproj>
```

El `.csproj` compila conjuntamente los archivos `.cs` pertenecientes al proyecto.

No utilizar `dotnet run --file Program.cs` cuando `Program.cs` depende de clases definidas en otros archivos.

---

# 12. Secuencia operativa completa — Windows

## Esto es lo que hay que ejecutar

Ejemplo para crear `EJ08`:

```powershell

dotnet new console --name 01EJ12 --output .\src\Guia01\EJ12 --framework net10.0

dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Guia01\EJ12\01EJ12.csproj

dotnet run --project ".\src\Guia01\EJ12\01EJ12.csproj"

```

Los tres pasos son:

1. `dotnet new console` → crea el proyecto.
2. `dotnet sln ... add` → agrega el proyecto a la solución.
3. `dotnet run --project` → compila y ejecuta el ejercicio completo.

---

# 13. Secuencia operativa completa — Zorin OS

Ejemplo validado para crear `EJ08`:

```bash

dotnet new console --name Herencia01_figurasGeometricas --output ./src/Herencia/Herencia01_figurasGeometricas --framework net10.0

dotnet sln ./EjerciciosCSharpUtn2026.slnx add ./src/Herencia/Herencia01_figurasGeometricas/Herencia01_figurasGeometricas.csproj


dotnet run --project ./src/Herencia/Herencia01_figurasGeometricas/Herencia01_figurasGeometricas.csproj


```

Los tres pasos son exactamente los mismos conceptualmente:

```text
dotnet new console
        ↓
dotnet sln ... add
        ↓
dotnet run --project
```

Lo que cambia entre Windows y Zorin OS es principalmente la forma de escribir las rutas.

---

# 14. Comando de comprobación adicional en Zorin OS

Para comprobar la estructura del repositorio:

```bash
pwd
ls -la
find . -maxdepth 4 -type f -name "*.csproj" | sort
```

Ejemplo de proyectos detectados durante la validación:

```text
./src/Guia01/EJ01/01EJ01.csproj
./src/Guia01/EJ02/01EJ02.csproj
./src/Guia01/EJ03/01EJ03.csproj
./src/Guia01/EJ04/01EJ04.csproj
./src/Guia01/EJ06/01EJ06.csproj
./src/Guia01/EJ07/01EJ07.csproj
```

Después de crear `EJ08`, también debe aparecer:

```text
./src/Guia01/EJ08/01EJ08.csproj
```

---

# 15. Sobre `--force`

El parámetro:

```text
--force
```

permite que `dotnet new` fuerce la creación aunque pueda sobrescribir archivos existentes.

No es necesario utilizarlo para crear normalmente un ejercicio nuevo cuya carpeta todavía no existe.

Flujo recomendado para un ejercicio nuevo:

```bash
dotnet new console --name 01EJ08 --output ./src/Guia01/EJ08 --framework net10.0
```

Usar `--force` solamente de manera consciente cuando realmente se quiera sobrescribir contenido existente.

---

# 16. Estructura general del repositorio

Modelo esperado:

```text
ejercicios-csharp-utn-2026/
│
├── EjerciciosCSharpUtn2026.slnx
├── .gitignore
├── .vscode/
│   └── settings.json
│
└── src/
    └── Guia01/
        ├── EJ01/
        │   └── 01EJ01.csproj
        │
        ├── EJ02/
        │   └── 01EJ02.csproj
        │
        ├── EJ03/
        │   └── 01EJ03.csproj
        │
        ├── EJ04/
        │   └── 01EJ04.csproj
        │
        ├── EJ06/
        │   └── 01EJ06.csproj
        │
        ├── EJ07/
        │   └── 01EJ07.csproj
        │
        └── EJ08/
            └── 01EJ08.csproj
```

## EJ05

Dentro del estado actual del proyecto:

> `EJ05` está incluido en `EJ04`.

Por lo tanto, no existe como proyecto independiente salvo que esta decisión cambie expresamente en el futuro.

---

# 17. Comandos base — resumen rápido

## Windows / PowerShell

```powershell
dotnet new console --name 01EJ08 --output .\src\Guia01\EJ08 --framework net10.0
dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Guia01\EJ08\01EJ08.csproj
dotnet run --project ".\src\Guia01\EJ08\01EJ08.csproj"
dotnet sln .\EjerciciosCSharpUtn2026.slnx list
```

## Zorin OS / Bash

```bash
dotnet new console --name 01EJ08 --output ./src/Guia01/EJ08 --framework net10.0
dotnet sln ./EjerciciosCSharpUtn2026.slnx add ./src/Guia01/EJ08/01EJ08.csproj
dotnet run --project ./src/Guia01/EJ08/01EJ08.csproj
dotnet sln ./EjerciciosCSharpUtn2026.slnx list
```

---

# 18. Plantilla genérica para un ejercicio nuevo

Para crear `EJXX`, reemplazar `XX` por el número correspondiente.

Ejemplo conceptual:

```text
EJ08
└── 01EJ08.csproj
```

## Windows / PowerShell

```powershell
dotnet new console --name 01EJ08 --output .\src\Guia01\EJ08 --framework net10.0
dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Guia01\EJ08\01EJ08.csproj
dotnet run --project ".\src\Guia01\EJ08\01EJ08.csproj"
```

## Zorin OS / Bash

```bash

dotnet new console --name 01EJ10 --output ./src/Guia01/EJ10 --framework net10.0

dotnet sln ./EjerciciosCSharpUtn2026.slnx add ./src/Guia01/EJ10/01EJ10.csproj

dotnet run --project ./src/Guia01/EJ10/01EJ10.csproj

```

Para clases de codeo:

```
dotnet new console --name clase03 --output ./src/Clase03 --framework net10.0

dotnet new sln --name ClasesCSharpUtn2026

dotnet sln ./ClasesCSharpUtn2026.slnx add ./src/Clase03/clase03.csproj

dotnet run --project ./src/Clase03/clase03.csproj

```

---

# 19. Archivos generados que no se versionan

.NET genera carpetas como:

```text
bin/
obj/
```

Estas carpetas contienen artefactos de compilación y restauración.

La regla del repositorio es no versionarlas.

El `.gitignore` debe contemplarlas, por ejemplo:

```gitignore
**/bin/
**/obj/
```

Antes de publicar cambios puede comprobarse el estado con:

```bash
git status
```

El mismo comando funciona tanto en PowerShell como en Bash.

---

# 20. Repositorio público y seguridad

El repositorio del proyecto es público.

Por lo tanto, los archivos versionados no deben contener:

- contraseñas;
- tokens;
- claves privadas;
- secretos de APIs;
- credenciales;
- archivos de configuración con información sensible.

Las rutas locales utilizadas en esta guía sirven solamente como referencia del entorno de desarrollo.

Antes de realizar un commit conviene comprobar:

```bash
git status
```

y revisar qué archivos serán incorporados.

---

# 21. Regla corta

> **Un ejercicio = una carpeta `EJXX` = un proyecto `.csproj`.**
>
> Todos los proyectos pertenecen a una única solución:
>
> `EjerciciosCSharpUtn2026.slnx`

Flujo:

```text
dotnet new console
        ↓
dotnet sln ... add
        ↓
dotnet run --project
```

Windows / PowerShell:

```text
.\src\Guia01\EJXX
```

Zorin OS / Bash:

```text
./src/Guia01/EJXX
```

---

# 22. Estado validado en ambos sistemas

## Windows

Se validó el trabajo con:

- PowerShell;
- solución `.slnx`;
- proyectos independientes `.csproj`;
- ejecución mediante `dotnet run --project`.

## Zorin OS

Se validó desde la terminal integrada de Visual Studio Code:

```text
gaston@gaston-Latitude-3410:~/vcs/ejercicios-csharp-utn-2026$
```

La secuencia validada para `EJ08` fue:

```bash
dotnet new console --name 01EJ08 --output ./src/Guia01/EJ08 --framework net10.0
dotnet sln ./EjerciciosCSharpUtn2026.slnx add ./src/Guia01/EJ08/01EJ08.csproj
dotnet run --project ./src/Guia01/EJ08/01EJ08.csproj
```

Resultado final:

```text
Hello, World!
```

Por lo tanto, el mismo repositorio y la misma solución pueden utilizarse desde ambos sistemas respetando la sintaxis de rutas correspondiente a cada shell.
