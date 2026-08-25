/* /src/Guia01/EJ13/Program.cs
Gastón Ricchiardi(Gastonj@hotmail.com)
13. El laboratorio Kokumo Technologies está desarrollando el prototipo de un robot explorador cuyo sistema de tracción puede ser personalizado para que se adapte mejor al terreno.
    El robot, llamado **KT-2020**, tiene las siguientes características:
    - **Número de serie:** KT-2020-P
    - **Potencia de tracción base (PTB):** 10 hp
    - **Tracción:** cualquiera de las dos opciones desarrolladas.

    Los sistemas de tracción disponibles son:
    - **Rueda de caucho:** ideal para entornos urbanos, su uso le resta 1 hp al PTB y permite el rodado de hasta 100 km; cuando se gasta, debe reemplazarse.
    - **Oruga:** para todo tipo de terreno, le permite avanzar hasta 400 km antes de requerir reemplazo y resta 3 hp al PTB. Incorpora sensores Meke-MO que le permiten conocer la temperatura.

    Analizar, diseñar, diagramar las relaciones e implementar el código.
    Crear instancias de cada una de las clases y asignarle al robot los distintos sistemas de tracción, procurando mostrar por pantalla los siguientes datos entre las distintas asignaciones:
    Número de serie, potencia de tracción final, tipo de tracción, cuánto puede avanzar y datos sobre cualquier característica adicional que posea.
*/

public class Program
{
    static void Main(string[] args)
    {

        SistemaDeTraccion objUnSistemaDeTraccion = new Caucho();

        Robot objMiRobot = new Robot(objUnSistemaDeTraccion, "KT-2020-P");

        Console.WriteLine(objMiRobot.GetInfo());

        Console.WriteLine("Ahora le cambiamos el sistema de tracción");

        objMiRobot.SistemaDeTraccion = new Oruga();

        Console.WriteLine(objMiRobot.GetInfo());

    }
}