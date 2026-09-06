# Ejercicio - Micros Empresarios

ACME S.A. tiene una planta modelo en una bucólica zona rural lejos del tráfago urbano.

Para que la gente pueda llegar a la planta, la empresa tiene varios micros contratados. En cada micro entran **n** pasajeros sentados y **m** parados, donde **n** y **m** son particulares de cada micro (no son todos los micros iguales).

---

## 🚌 Criterios para Subirse al Micro

La gente no es toda igual, por lo que para subirse a un micro se fijan en distintas cosas:

- **Apurados:** Se suben siempre.
- **Claustrofóbicos:** Se suben sólo si el micro tiene más de 120 m³ de volumen (se sabe el volumen de cada micro).
- **Fiacas:** Se suben sólo si entran sentados.
- **Moderados:** Se suben sólo si quedan al menos **x** lugares libres (no importa si sentados o parados), donde **x** es particular de cada persona moderada.
- **Obsecuentes:** Toman la misma decisión que tomaría su jefe (de cada empleado se sabe quién es su jefe, que es otro empleado).

---

## 🎯 Requerimientos de Modelado

Modelar los micros y las personas de forma tal que:

1. **Consulta de jefe:** Se pueda preguntarle a una persona si es jefe.
2. **Validación de ingreso:** Se pueda preguntarle a un micro si se puede subir a una persona, para lo cual tienen que darse dos condiciones:
   - Que haya lugar en el micro.
   - Que la persona acepte ir en el micro.
3. **Subir pasajero:** Se pueda hacer subir una persona a un micro. Si no puede, debe tirar error.
4. **Bajar pasajero:** Se pueda hacer bajar una persona de un micro. Si no se puede (porque está vacío), debe tirar error.
5. **Primer pasajero:** Se pueda preguntarle a un micro quién fue el primero que se subió (`null` si está vacío).

---

# Análisis:
