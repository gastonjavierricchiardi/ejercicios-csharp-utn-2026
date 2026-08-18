# Ejercicio - Sueldos en bruto

Una empresa desea crear un programa para calcular el sueldo de sus empleados.

> La fórmula para calcular el sueldo de un empleado es la siguiente:

`Sueldo = neto + bonopresentismo + bonoresultado`

Los **empleados** pueden categorizarse en:

|       Cargo        | Sueldo neto |
| :----------------: | :---------: |
|    **Gerente**     |   100000    |
| **Administrativo** |    40000    |
|    **Operador**    |    10500    |
|     **Cadete**     |    1000     |

Existen **2 bonos** por presentismo.

| bonoA (monto) |              motivo              | bonoB |
| :-----------: | :------------------------------: | ----- |
|     $1000     |  si el empleado no faltó nunca.  | 500   |
|     $450      | si el empleado faltó 1 única vez | 500   |
|      $0       |     en cualquier otro caso.      | 500   |

> El bono B siempre suma $500 (cero pesos).

El bono por **resultados** ofrece 3 posibilidades:

- 10% sobre el sueldo neto en caso de objetivo cumplido
- $800 fijos en caso de cumplir el 80& del objetivo
- $0 (cero pesos) en cualquier otro caso.

Desarrolle una aplicación que permita calcular el sueldo de un empleado. Pruebe distintos escenarios.

---

# Ejercicio - Sueldos (Análisis):

Una empresa desea crear un programa para calcular el sueldo de sus empleados. La fórmula para calcular el sueldo de un empleado es la siguiente:

`Sueldo = neto + bonopresentismo + bonoresultado`

Los **empleados** pueden categorizarse en:

- **Gerente**. Sueldo neto 100000
- **Administrativo**. Sueldo neto 40000
- **Operador**. Sueldo neto 10500
- **Cadete**. Sueldo neto 1000

Existen 2 bonos por presentismo.

**El bono A asigna:**

- $1000 si el empleado no faltó nunca.
- $450 si el empleado faltó 1 única vez
- $0 en cualquier otro caso.

**El bono B** siempre suma $500 (cero pesos).

El bono por resultados ofrece 3 posibilidades:

- 10% sobre el sueldo neto en caso de objetivo cumplido
- $800 fijos en caso de cumplir el 80& del objetivo
- $0 (cero pesos) en cualquier otro caso.

Desarrolle una aplicación que permita calcular el sueldo de un empleado. Pruebe distintos escenarios.

---
