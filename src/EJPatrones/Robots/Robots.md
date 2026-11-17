# Robots

El laboratorio Kokumo Technologies está desarrollando el prototipo de un robot soldado cuyo
sistemas de armamento, defensa y tracción puede ser personalizado para que se adapte mejor
a cada situación.
El robot, llamado KT-2020, tiene las siguientes características:
Número de serie: KT-2020-P
Potencia de tracción base (PTB): 10 hp
Tracción: cualquiera de las dos opciones desarrolladas.
Resistencia: un valor arbitrario que indica el estado de salud del robot.
Los sistemas de tracción disponibles son:
Rueda de caucho: ideal para entornos urbanos, su uso le resta 1 hp al PTB y permite el
rodado de hasta 100 km; cuando se gasta, debe reemplazarse.
Oruga: para todo tipo de terreno, le permite avanzar hasta 400 km antes de requerir
reemplazo y resta 3 hp al PTB. Incorpora sensores Meke-M0 que le permiten conocer la
temperatura.
Los sistemas de armamento disponibles son:
Granadas: restan 35 puntos de Resistencia al objetivo.
Rayo laser: resta 20 puntos de Resistencia al objetivo.
Espada: resta 3 puntos de Resistencia al objetivo.
Considerar que cada vez que un robot ataca a otro, sus sistemas de tracción se deterioran en
un 2%. La contienda finaliza cuando la resistencia de alguno de los robots llega a 0 (cero) o
debe cambiar su sistema de tracción.
El laboratorio, en su afan de probar el funcionamiento y resistencia de sus robots nos pide
desarrollar una aplicación que permita instanciar 2 robots con distintas características y simular
un combate entre los mismos. La aplicación debe informar cual fue el robot que resultó ganador
de la contienda.

# Parte 2

La empresa detectó a raíz de las pruebas realizadas, que muchos robots explotaban como
consecuencia del sobrecalentamiento que sufrían en sus sistemas de tracción. Estos
sobrecalentamientos eran producido por fallas de medición en los sensores de temperatura.
En base a esto decidieron implementar sistemas de medición de temperatura nuevos. A
diferencia de los anteriores, son digitales con lo que logran una mayor precisión, pero están
fabricados por una empresa norteamericana que no se rige por el sistema métrico-decimal, por
lo que los valores de temperatura son devueltos en escala Farenheit (°F), mientras que los
robots fabricados por la empresa procesar los datos de temperatura en escala Celcius (°C).
Se nos solicita que realicemos los ajustes correspondientes sin modificar lo ya implementado
en los robots.
