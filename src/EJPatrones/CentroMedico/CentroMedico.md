# Ejercicio - Centro Médico

El Servicio de Emergencias de Vicente López, está organizado como una jerarquía de bases sanitarias.
Los tipos de bases sanitarias son 3:

- Hospitales
- Unidades de Atención Primaria (UAP)
- Unidades Administrativas (UA)

Algunas de estas bases, como por ejemplo los hospitales, realmente disponen de personal y ambulancias; otras, como las UAP
sólo disponen de personal de atención médica y por último las denominadas UA son bases sanitarias que agrupan un conjunto
de bases.

Por ejemplo la UA "Vicente López Centro", agrupa el Hospital Dr. Bernardo Houssay y el Hospital J. Ubaldo Carrea.
Para la situación planteada, nos interesa modelar los siguientes datos y comportamiento:

1. Nombre de cada base, cantidad de ambulancias, tiempo medio de asistencia. La cantidad de ambulancias y el tiempo
   medio de asistencia debe poder ser modificado en tiempo de ejecución.
2. Las UA deben permitir agregar y/o eliminar Hospitales y UAP.
3. Todas las bases deben permitir obtener la dirección.
4. Número de ambulancias, que en el caso de las UA es la suma de las ambulancias disponibles en las bases que las
   componen en ese momento.
5. Tiempo medio de asistencia, que en el caso de las UA es la media de los tiempos medios de asistencia registrados en las
   bases que las componen en ese momento.
