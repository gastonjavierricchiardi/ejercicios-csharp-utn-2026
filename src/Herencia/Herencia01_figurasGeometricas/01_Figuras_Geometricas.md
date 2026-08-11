# Ejercicio 1: Figuras Geométricas

## 📌 Consigna
Desarrollar una aplicación que permita conocer el área y el perímetro de un **triángulo**, de un **cuadrado** y de un **círculo**. 

### Requerimientos:
* Cada figura posee un **nombre** y un **color**.
* La aplicación debe permitir obtener para cada una de las figuras su:
  * Nombre
  * Color
  * Perímetro
  * Área
* **Prueba:** Crear por lo menos una figura de cada tipo y mostrar el resultado de invocar a sus métodos.
* **Polimorfismo:** Implementar la solución utilizando polimorfismo para tratar a las distintas figuras de manera uniforme.

---

## 🏗️ Propuesta de Diseño Orientado a Objetos (POO)

### Jerarquía de Clases
1. **Clase Abstracta `FiguraGeometrica`**
   * **Atributos / Propiedades:**
     * `Nombre` (string)
     * `Color` (string)
   * **Métodos Abstractos:**
     * `CalcularArea()`: double
     * `CalcularPerimetro()`: double
   * **Métodos Concretos:**
     * `ObtenerInformacion()`: Devuelve nombre, color, área y perímetro.

2. **Subclases Concretas:**
   * **`Cuadrado`** (hereda de `FiguraGeometrica`)
     * Atributo adicional: `Lado` (double)
     * Implementación de `CalcularArea()`: $Lado^2$
     * Implementación de `CalcularPerimetro()`: $4 \times Lado$
   * **`Triangulo`** (hereda de `FiguraGeometrica`)
     * Atributos adicionales: `Base` (double), `Altura` (double), `LadoA` (double), `LadoB` (double), `LadoC` (double)
     * Implementación de `CalcularArea()`: $\frac{Base \times Altura}{2}$
     * Implementación de `CalcularPerimetro()`: $LadoA + LadoB + LadoC$
   * **`Circulo`** (hereda de `FiguraGeometrica`)
     * Atributo adicional: `Radio` (double)
     * Implementación de `CalcularArea()`: $\pi \times Radio^2$
     * Implementación de `CalcularPerimetro()`: $2 \times \pi \times Radio$

---

## 🧪 Casos de Prueba Sugeridos
* **Cuadrado:** Lado = 4 cm, Color = "Rojo" $\rightarrow$ Área = 16 $\text{cm}^2$, Perímetro = 16 cm.
* **Triángulo:** Base = 3 cm, Altura = 4 cm, Lados = (3, 4, 5) cm, Color = "Azul" $\rightarrow$ Área = 6 $\text{cm}^2$, Perímetro = 12 cm.
* **Círculo:** Radio = 5 cm, Color = "Verde" $\rightarrow$ Área $\approx$ 78.54 $\text{cm}^2$, Perímetro $\approx$ 31.42 cm.
