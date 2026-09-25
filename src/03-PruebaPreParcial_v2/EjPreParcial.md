# Ejercicio pre parcial

Una empresa de alquiler de vehículos desea desarrollar una aplicación para administrar sus vehículos y calcular el costo de los alquileres.

Cada vehículo posee: patente, marca, modelo y precio base por día.

La empresa trabaja con distintos tipos de vehículos:

Auto: tiene un costo adicional fijo de $2.000 por día.

Camioneta: tiene un costo adicional de $5.000 por día y un límite de kilómetros incluidos.

Moto: tiene un costo adicional de $1.000 por día.

El costo de un alquiler se calcula de la siguiente manera:

> costo = días × precio base + adicionales

En el caso de las camionetas, si durante el alquiler se supera el límite de kilómetros incluidos, se deben cobrar $500 por cada kilómetro excedente.

Además, algunos vehículos pueden ser utilizados para realizar entregas. Para ello deben cumplir con un contrato que permita conocer la capacidad de carga del vehículo y una descripción del vehículo.

La empresa debe permitir:

- Registrar vehículos.
- Buscar un vehículo a partir de su patente.
- Registrar un alquiler indicando el vehículo, la cantidad de días y los kilómetros recorridos.
- Calcular el costo total de un alquiler.
- Registrar una entrega indicando el vehículo y el peso de la carga.
- Verificar si un vehículo puede realizar una entrega. Si la carga supera su capacidad, deberá informarse mediante una excepción.
- Consultar todos los vehículos registrados.
- Evitar registrar dos vehículos con la misma patente.

**Desarrolle:**
una aplicación de consola que permita administrar la información y pruebe distintos escenarios, incluyendo alquileres de los distintos vehículos, búsqueda de vehículos, registro de vehículos duplicados y una entrega que supere la capacidad permitida.

---
