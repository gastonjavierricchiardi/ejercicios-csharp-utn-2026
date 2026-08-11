# Guía de Ejercicios: Herencia y Polimorfismo

Este documento reúne la guía completa de ejercicios prácticos orientados a objetos con enfoque en **Herencia**, **Polimorfismo** y **Encapsulamiento**.

---

# Ejercicio 1: Figuras Geométricas

## 📌 Consigna

Desarrollar una aplicación que permita conocer el área y el perímetro de un **triángulo**, de un **cuadrado** y de un **círculo**.

### Requerimientos:

- Cada figura posee un **nombre** y un **color**.
- La aplicación debe permitir obtener para cada una de las figuras su:
  - Nombre
  - Color
  - Perímetro
  - Área
- **Prueba:** Crear por lo menos una figura de cada tipo y mostrar el resultado de invocar a sus métodos.
- **Polimorfismo:** Implementar la solución utilizando polimorfismo para tratar a las distintas figuras de manera uniforme.

---

## 🏗️ Propuesta de Diseño Orientado a Objetos (POO)

### Jerarquía de Clases

1. **Clase Abstracta `FiguraGeometrica`**
   - **Atributos / Propiedades:**
     - `Nombre` (string)
     - `Color` (string)
   - **Métodos Abstractos:**
     - `CalcularArea()`: double
     - `CalcularPerimetro()`: double
   - **Métodos Concretos:**
     - `ObtenerInformacion()`: Devuelve nombre, color, área y perímetro.

2. **Subclases Concretas:**
   - **`Cuadrado`** (hereda de `FiguraGeometrica`)
     - Atributo adicional: `Lado` (double)
     - Implementación de `CalcularArea()`: $Lado^2$
     - Implementación de `CalcularPerimetro()`: $4 \times Lado$
   - **`Triangulo`** (hereda de `FiguraGeometrica`)
     - Atributos adicionales: `Base` (double), `Altura` (double), `LadoA` (double), `LadoB` (double), `LadoC` (double)
     - Implementación de `CalcularArea()`: $\frac{Base \times Altura}{2}$
     - Implementación de `CalcularPerimetro()`: $LadoA + LadoB + LadoC$
   - **`Circulo`** (hereda de `FiguraGeometrica`)
     - Atributo adicional: `Radio` (double)
     - Implementación de `CalcularArea()`: $\pi \times Radio^2$
     - Implementación de `CalcularPerimetro()`: $2 \times \pi \times Radio$

---

## 🧪 Casos de Prueba Sugeridos

- **Cuadrado:** Lado = 4 cm, Color = "Rojo" $\rightarrow$ Área = 16 $\text{cm}^2$, Perímetro = 16 cm.
- **Triángulo:** Base = 3 cm, Altura = 4 cm, Lados = (3, 4, 5) cm, Color = "Azul" $\rightarrow$ Área = 6 $\text{cm}^2$, Perímetro = 12 cm.
- **Círculo:** Radio = 5 cm, Color = "Verde" $\rightarrow$ Área $\approx$ 78.54 $\text{cm}^2$, Perímetro $\approx$ 31.42 cm.

---

# Ejercicio 2: Cálculo de Sueldos

## 📌 Consigna

Una empresa desea crear un programa para calcular el sueldo de sus empleados.

### Fórmula General

$$\text{Sueldo Total} = \text{Sueldo Neto} + \text{Bono Presentismo} + \text{Bono Resultado}$$

---

## 💼 Categorías de Empleados (Sueldo Neto)

- **Gerente:** $100.000
- **Administrativo:** $40.000
- **Operador:** $10.500
- **Cadete:** $1.000

---

## 🎁 Bonos por Presentismo

### **Bono A:**

- **$1.000** si el empleado no faltó nunca (0 faltas).
- **$450** si el empleado faltó 1 única vez.
- **$0** en cualquier otro caso (2 o más faltas).

### **Bono B:**

- Siempre suma **$500** (o valor fijo configurado).

---

## 🎯 Bonos por Resultados

1. **Objetivo Cumplido (100%):** 10% sobre el sueldo neto del empleado.
2. **Objetivo Parcial (80%):** $800 fijos.
3. **Otro caso (<80%):** $0.

---

## 🏗️ Propuesta de Diseño Orientado a Objetos (POO)

### 1. Jerarquía de Empleados

- **Clase Abstracta / Base `Empleado`**
  - Atributos: `Nombre`, `CantidadFaltas`, `PorcentajeObjetivoAlcanzado`
  - Propiedad/Método Abstracto: `SueldoNeto`
  - Métodos de asignación/cálculo de bonos.

### 2. Bonos (Patrón Strategy / Polimorfismo)

- **`IBonoPresentismo` / `BonoPresentismo`**
  - `BonoPresentismoA`
  - `BonoPresentismoB`
- **`IBonoResultado` / `BonoResultado`**
  - `BonoResultadoPorcentaje` (10%)
  - `BonoResultadoFijo` ($800)
  - `BonoResultadoNulo` ($0)

---

## 🧪 Escenarios de Prueba

1. **Gerente** sin faltas (Bono A) y con objetivo 100% cumplido:
   - Sueldo Neto: $100.000
   - Presentismo A (0 faltas): $1.000
   - Resultado (100%): $10.000
   - **Total:** $111.000

2. **Administrativo** con 1 falta (Bono A) y 80% de objetivo:
   - Sueldo Neto: $40.000
   - Presentismo A (1 falta): $450
   - Resultado (80%): $800
   - **Total:** $41.250

3. **Operador** con 2 faltas (Bono B) y 50% de objetivo:
   - Sueldo Neto: $10.500
   - Presentismo B: $500
   - Resultado (<80%): $0
   - **Total:** $11.000

---

# Ejercicio 3: Celulares y Personas

## 📌 Consigna

Implementar una aplicación donde se represente a personas que hablan entre sí por celulares.

### Personas y Dispositivos Iniciales:

- **Juliana** tiene un **Motorola G5**.
- **Catalina** tiene un **iPhone**.

---

## 🔋 Reglas de Negocio y Batería

- **Batería Máxima:** Todos los celulares tienen un máximo de **5 puntos** de batería.
- **Consumo de Batería por Llamada:**
  - **Motorola G5:** Pierde **0,25 puntos** fijamente por cada llamada (independientemente de la duración).
  - **iPhone:** Pierde **0,1% de la duración de la llamada** en puntos de batería (ej. una llamada de 100 segundos consume $100 \times 0.001 = 0.1$ puntos de batería).

---

## 🎯 Requerimientos del Sistema

Al finalizar cada llamada realizada entre los personajes, se debe poder:

1. **Conocer la cantidad de batería** restante de cada celular.
2. **Saber si un celular está apagado** (batería $\le 0$).
3. **Recargar un celular** para que vuelva a tener su batería completa (5 puntos).
4. **Saber si Juliana tiene el celular apagado** y si **Catalina tiene el celular apagado**.

---

## 🏗️ Propuesta de Diseño Orientado a Objetos (POO)

### 1. Clase `Persona`

- **Atributos:**
  - `Nombre` (string)
  - `Celular` (referencia a la interfaz/clase base `ICelular` o `Celular`)
- **Métodos:**
  - `LlamarA(Persona destinatario, int duracionSegundos)`
  - `TieneCelularApagado()`: bool
  - `RecargarCelular()`

### 2. Jerarquía de Celulares (`ICelular` / `Celular`)

- **Clase Abstracta / Interfaz `Celular`**
  - Atributo: `Bateria` (double, máx 5.0)
  - Métodos:
    - `RealizarLlamada(int duracionSegundos)` (abstracto/virtual)
    - `Recargar()`
    - `EstaApagado()`: bool

- **`MotorolaG5`** (hereda de `Celular`)
  - `RealizarLlamada(int duracion)` $\rightarrow$ Batería -= 0.25

- **`IPhone`** (hereda de `Celular`)
  - `RealizarLlamada(int duracion)` $\rightarrow$ Batería -= (duracion \* 0.001)
