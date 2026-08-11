# Ejercicio 2: Cálculo de Sueldos

## 📌 Consigna
Una empresa desea crear un programa para calcular el sueldo de sus empleados. 

### Fórmula General
$$\text{Sueldo Total} = \text{Sueldo Neto} + \text{Bono Presentismo} + \text{Bono Resultado}$$

---

## 💼 Categorías de Empleados (Sueldo Neto)
* **Gerente:** $100.000
* **Administrativo:** $40.000
* **Operador:** $10.500
* **Cadete:** $1.000

---

## 🎁 Bonos por Presentismo

### **Bono A:**
* **$1.000** si el empleado no faltó nunca (0 faltas).
* **$450** si el empleado faltó 1 única vez.
* **$0** en cualquier otro caso (2 o más faltas).

### **Bono B:**
* Siempre suma **$500** (o valor fijo configurado).

---

## 🎯 Bonos por Resultados

1. **Objetivo Cumplido (100%):** 10% sobre el sueldo neto del empleado.
2. **Objetivo Parcial (80%):** $800 fijos.
3. **Otro caso (<80%):** $0.

---

## 🏗️ Propuesta de Diseño Orientado a Objetos (POO)

### 1. Jerarquía de Empleados
* **Clase Abstracta / Base `Empleado`**
  * Atributos: `Nombre`, `CantidadFaltas`, `PorcentajeObjetivoAlcanzado`
  * Propiedad/Método Abstracto: `SueldoNeto`
  * Métodos de asignación/cálculo de bonos.

### 2. Bonos (Patrón Strategy / Polimorfismo)
* **`IBonoPresentismo` / `BonoPresentismo`**
  * `BonoPresentismoA`
  * `BonoPresentismoB`
* **`IBonoResultado` / `BonoResultado`**
  * `BonoResultadoPorcentaje` (10%)
  * `BonoResultadoFijo` ($800)
  * `BonoResultadoNulo` ($0)

---

## 🧪 Escenarios de Prueba
1. **Gerente** sin faltas (Bono A) y con objetivo 100% cumplido:
   * Sueldo Neto: $100.000
   * Presentismo A (0 faltas): $1.000
   * Resultado (100%): $10.000
   * **Total:** $111.000

2. **Administrativo** con 1 falta (Bono A) y 80% de objetivo:
   * Sueldo Neto: $40.000
   * Presentismo A (1 falta): $450
   * Resultado (80%): $800
   * **Total:** $41.250

3. **Operador** con 2 faltas (Bono B) y 50% de objetivo:
   * Sueldo Neto: $10.500
   * Presentismo B: $500
   * Resultado (<80%): $0
   * **Total:** $11.000
