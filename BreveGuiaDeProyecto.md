# Base del proyecto — Ejercicios C# Programación II UTN 2026

## Objetivo

Organizar los ejercicios de Programación II en una única solución .NET 10.

La estructura general será:

```text
ejercicios-csharp-utn-2026/
├── EjerciciosCSharpUtn2026.slnx
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

En .NET 10, el comando:

```powershell
dotnet new sln --name EjerciciosCSharpUtn2026
```

crea por defecto:

```text
EjerciciosCSharpUtn2026.slnx
```

No es necesario indicar manualmente el formato.

La solución `.slnx` agrupará todos los proyectos correspondientes a los ejercicios.

---

# 2. Organización de los ejercicios

Los ejercicios se almacenan dentro de:

```text
src/
└── Guia01/
```

Cada ejercicio tendrá su propia carpeta:

```text
src/
└── Guia01/
    ├── EJ01/
    ├── EJ02/
    ├── EJ03/
    └── ...
```

Cada ejercicio será un proyecto independiente de consola.

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

---

# 3. Crear un ejercicio

Los comandos se ejecutan desde la raíz del repositorio:

```text
C:\vcs\ejercicios-csharp-utn-2026
```

Ejemplo para crear `EJ01`:

```powershell
dotnet new console --name 01EJ01 --output .\src\Guia01\EJ01 --framework net10.0
```

El comando crea:

```text
src/
└── Guia01/
    └── EJ01/
        ├── 01EJ01.csproj
        ├── Program.cs
        └── obj/
```

Donde:

- `01EJ01.csproj` es el archivo de proyecto.
- `Program.cs` es el archivo inicial generado por la plantilla.
- `obj/` es generado automáticamente por .NET.

---

# 4. Agregar el ejercicio a la solución

Crear el proyecto no significa que automáticamente pertenezca a la solución.

Hay que agregarlo:

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Guia01\EJ01\01EJ01.csproj
```

Resultado:

```text
Se ha agregado el proyecto "src\Guia01\EJ01\01EJ01.csproj" a la solución.
```

---

# 5. Comprobar los proyectos de la solución

Para ver qué proyectos contiene la solución:

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx list
```

Antes de agregar un proyecto, el resultado puede ser:

```text
No se han encontrado proyectos en la solución.
```

Después de agregar `EJ01`:

```text
Proyectos
---------
src\Guia01\EJ01\01EJ01.csproj
```

Esto confirma que:

```text
EjerciciosCSharpUtn2026.slnx
└── src\Guia01\EJ01\01EJ01.csproj
```

---

# 6. Estructura comprobada hasta este punto

```text
ejercicios-csharp-utn-2026/
│
├── EjerciciosCSharpUtn2026.slnx
│
├── .vscode/
│   └── settings.json
│
└── src/
    └── Guia01/
        └── EJ01/
            ├── 01EJ01.csproj
            ├── Program.cs
            └── obj/
```

---

# 7. Regla base del repositorio

> Una solución `.slnx` contiene todos los ejercicios.
>
> Cada ejercicio es un proyecto independiente `.csproj`.
>
> Cada proyecto se encuentra dentro de su propia carpeta `EJXX`.

Modelo:

```text
EjerciciosCSharpUtn2026.slnx
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
        └── ...
```

---

# 8. Comandos base comprobados

Para crear un ejercicio:

```powershell
dotnet new console --name 01EJ01 --output .\src\Guia01\EJ01 --framework net10.0
```

Para agregarlo a la solución:

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Guia01\EJ01\01EJ01.csproj
```

Para ejecutar el proyecto:

```powershell
dotnet run --project ".\src\Guia01\EJ01\01EJ01.csproj"
```

Para comprobar los proyectos registrados en la solución, cuando sea necesario:

```powershell
dotnet sln .\EjerciciosCSharpUtn2026.slnx list
```

Por lo tanto, la secuencia operativa para cada ejercicio es:

```text
dotnet new console
        ↓
dotnet sln ... add
        ↓
dotnet run --project
```

## El comando `dotnet sln ... list` es únicamente de comprobación y no forma parte de los tres pasos obligatorios para crear y ejecutar cada ejercicio.

# 9. Resumen operativo para cada ejercicio nuevo

Ejemplo: crear `EJ03`.

Desde la raíz del repositorio:

```text
C:\vcs\ejercicios-csharp-utn-2026
```

Ejecutar:

```powershell
dotnet new console --name 01EJ03 --output .\src\Guia01\EJ03 --framework net10.0
dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Guia01\EJ03\01EJ03.csproj
dotnet run --project ".\src\Guia01\EJ03\01EJ03.csproj"
```

Los tres pasos son:

1. `dotnet new console` → crea el proyecto del ejercicio.
2. `dotnet sln ... add` → agrega el proyecto a la solución `.slnx`.
3. `dotnet run --project` → compila y ejecuta el ejercicio completo.

Para `EJ04`:

```powershell
dotnet new console --name 01EJ04 --output .\src\Guia01\EJ04 --framework net10.0
dotnet sln .\EjerciciosCSharpUtn2026.slnx add .\src\Guia01\EJ04\01EJ04.csproj
dotnet run --project ".\src\Guia01\EJ04\01EJ04.csproj"
```

Para `EJ05`, se cambia `04` por `05`, y así sucesivamente.

---

# 10. Regla corta

> **Un ejercicio = una carpeta `EJXX` = un proyecto `.csproj`.**
>
> Todos los proyectos pertenecen a una única solución:
>
> `EjerciciosCSharpUtn2026.slnx`
>
> Para cada ejercicio nuevo:
>
> `dotnet new console` → `dotnet sln add` → `dotnet run --project`
