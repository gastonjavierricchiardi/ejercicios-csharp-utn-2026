# Ejercicio 3: Celulares y Personas

## 📌 Consigna
Implementar una aplicación donde se represente a personas que hablan entre sí por celulares.

### Personas y Dispositivos Iniciales:
* **Juliana** tiene un **Motorola G5**.
* **Catalina** tiene un **iPhone**.

---

## 🔋 Reglas de Negocio y Batería
* **Batería Máxima:** Todos los celulares tienen un máximo de **5 puntos** de batería.
* **Consumo de Batería por Llamada:**
  * **Motorola G5:** Pierde **0,25 puntos** fijamente por cada llamada (independientemente de la duración).
  * **iPhone:** Pierde **0,1% de la duración de la llamada** en puntos de batería (ej. una llamada de 100 segundos consume $100 \times 0.001 = 0.1$ puntos de batería).

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
* **Atributos:**
  * `Nombre` (string)
  * `Celular` (referencia a la interfaz/clase base `ICelular` o `Celular`)
* **Métodos:**
  * `LlamarA(Persona destinatario, int duracionSegundos)`
  * `TieneCelularApagado()`: bool
  * `RecargarCelular()`

### 2. Jerarquía de Celulares (`ICelular` / `Celular`)
* **Clase Abstracta / Interfaz `Celular`**
  * Atributo: `Bateria` (double, máx 5.0)
  * Métodos:
    * `RealizarLlamada(int duracionSegundos)` (abstracto/virtual)
    * `Recargar()`
    * `EstaApagado()`: bool

* **`MotorolaG5`** (hereda de `Celular`)
  * `RealizarLlamada(int duracion)` $\rightarrow$ Batería -= 0.25

* **`IPhone`** (hereda de `Celular`)
  * `RealizarLlamada(int duracion)` $\rightarrow$ Batería -= (duracion * 0.001)
