Ejercicio - Laberintos
Se desea crear un motor gráfico que permita crear los escenarios para un video juego donde el personaje principal debe ir
atravesando distintos laberintos.
El juego dispone de 2 versiones. En la primer versión, los distintos laberintos están conformados todos por los mismos
materiales, hay laberintos cuyas paredes pueden estar hechas de arbustos, otros de tablas de madera y otros cuyas paredes
son de piedra.
Según el nivel donde se encuentre el personaje, la complejidad del laberinto será mayor, es decir, tendrá mayor cantidad de
habitaciones. Una habitación es un bloque de cuatro paredes del mismo material, sin techo y con 1 puerta como mínimo. Por
ejemplo, si el personaje se encuentra en el nivel 1, el laberinto tendrá 10 habitaciones como mínimo, si se encuentra en el nivel
2, el laberinto tendá 14 habitaciones como mínimo, etc. Estos valores deben ser configurables.
La dificultad puede ser fácil, intermedio o difícil.
De cada habitación se conoce:
Id: alfanumérico
Habitación anterior. Todas tienen habitación previa excepto la primera.
Habitación siguiente. Todas tienen habitación siguiente excepto la ultima.
Tener en cuenta que cada pared debe poder responder:
Si es atravesable o no. Esto depende de si posee una abertura o puerta o no.
En la segunda versión del juego, los diseñadores decidieron:
agregar habitaciones cuyas paredes son de agua. Una pared de agua, a diferencia de todas las otras existentes, pueden
ser atravesadas por el jugador y no puede poseer una puerta.
Agregar laberintos modernos donde las habitaciones pueden estar conformadas por distintos tipos de paredes. Habrá
laberintos con 1 pared de cada tipo y otros menos versátiles con 2 paredes de cada tipo.
Se pide
a. Crear la o las clases que permitan obtener un Laberinto teniendo en cuenta las distintas situaciones planteadas. b. Crear la
clase Personaje que pueda:

1. Recorrer un laberinto. Cada vez que atraviesa una habitación debe registrarla.
2. Responder cuántas habitaciones recorrió.
3. En qué habitación se encuentra.
4. Logró salir o no del laberinto.
