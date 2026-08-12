# Ejercicio - Práctica 1er Parcial: Mueblería

Los empleados de una mueblería necesitan una aplicación que los asista en su operatoria diaria de venta de muebles. La mueblería vende muebles de todo tipo: sillas, mesas, placares, mesas de luz, mesas ratonas, etc.

De cada mueble se conoce:
* **Nombre**
* **Precio unitario**
* **Stock** (cantidad que la mueblería posee)

Cuando la mueblería realiza una venta, la misma puede estar compuesta por una cantidad *X* de muebles de distintos tipos. Los muebles son enviados al comprador mediante un flete perteneciente a la misma mueblería.

---

## 💰 Cálculo del Precio Final de Venta

El precio final de la venta se compone de:

### 1. Precio Base de Productos
`Precio unitario * Cantidad` de cada mueble.

---

### 2. Recargo por Volumen (Mesas y Placares)
Algunos muebles, como las mesas (de todo tipo) y los placares, ocupan un volumen considerable dentro del flete, por lo que su precio varía en función del volumen ocupado.

#### **Cálculo del Volumen:**
* **Mesa redonda:** $V = \pi \cdot r^2 \cdot h$ *(donde $r$ es el radio de la tabla y $h$ la altura de la mesa)*
* **Mesa cuadrada:** $V = L^2 \cdot h$ *(donde $L$ es el lado de la tabla y $h$ la altura de la mesa)*
* **Mesa rectangular:** $V = L_1 \cdot L_2 \cdot h$ *(donde $L_1$ y $L_2$ son los lados de la tabla y $h$ la altura de la mesa)*
* **Placares:** El volumen se obtiene igual que en las mesas rectangulares ($V = L_1 \cdot L_2 \cdot h$).

#### **Adicionales en Base al Volumen:**
* **Si $v < 1\text{ m}^3$:** Se le adiciona un **20%** a su valor unitario.
* **Si $1\text{ m}^3 \le v \le 2\text{ m}^3$:** Se le adiciona un **50%** a su valor unitario.
* **Si $v > 2\text{ m}^3$:** Se le adiciona un **75%** a su valor unitario.

---

### 3. Recargo por Tiempo de Carga del Flete
Por último, la mueblería le suma al monto total de la venta un monto fijo que depende del tiempo que le lleve cargar el flete:
* **Tiempo $> 1\text{ hs}$ (60 min):** Se le suma **$10.000** al monto total.
* **Tiempo $> 3\text{ hs}$ (180 min):** Se le suma **$100.000** al monto total.
* **En otros casos ($\le 1\text{ hs}$):** Se suma **$0**.

---

## 🎯 Requerimientos

1. **Diagrama de clases:** Diagrama de clases completo de la solución.
2. **Codificación:** Codificar los métodos necesarios para obtener el precio total de una venta.
3. **Ejemplo de uso:** Desarrolle un breve código de ejemplo, mostrando el uso de la aplicación.

---

## ⚠️ Consideraciones

* **Punto de entrada para la venta:** El punto de entrada para el punto 2 debe ser el método `realizarVenta(muebles) -> number`.
* **Control de stock:** En caso de no contar con la cantidad de muebles requerida, se deberá arrojar un error que indique lo sucedido.
* **Clase Cronómetro:** Asuma que existe la clase `Cronometro` con 2 métodos estáticos:
  * `iniciar(): void`
  * `detener(): number` *(Devuelve la cantidad de minutos transcurridos desde que se inició)*
