# Justificación de modelado — Ejercicio 17

Para resolver el ejercicio modelé una clase `Objeto`, ya que todos los elementos analizados por el scanner comparten la misma información básica: material, volumen y una colección de objetos contenidos.

El material se representó mediante el `enum Material` porque la consigna establece un conjunto cerrado de valores posibles.

Cada `Objeto` administra internamente una `List<Objeto>`. Esto permite representar tanto objetos simples como estructuras anidadas, por ejemplo una Mamushka con varios niveles. La clase permite agregar elementos mediante `AgregarContenido()` y consultar si posee elementos mediante `TieneContenido()`.

No se crearon clases distintas para `Simple`, `Contenedor`, `Contenido` y `Sambuchito`, porque no representan distintos tipos de objeto sino distintas clasificaciones según su situación. Por este motivo se utilizó el `enum TipoObjeto`.

La responsabilidad de determinar esa clasificación quedó en la clase `Analizador`. Para hacerlo tiene en cuenta si el objeto contiene elementos y si, durante el recorrido, se encuentra dentro de otro objeto.

El recorrido se realiza de forma recursiva, permitiendo analizar objetos contenidos dentro de otros sin limitar previamente la cantidad de niveles.

La relación de `Objeto` consigo mismo se representó como una agregación de `0..*`, ya que un objeto puede contener cero o muchos objetos y los objetos contenidos pueden existir independientemente del contenedor. Por ejemplo, el botiquín puede analizarse solo y también puede formar parte del contenido de una bolsa.

No se utilizaron herencia ni interfaces porque no existe en la consigna una necesidad concreta que justifique incorporarlas.
