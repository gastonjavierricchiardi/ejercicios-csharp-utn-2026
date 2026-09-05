/*
    =========================================================
    ASISTENTE
    =========================================================

    Asistente es la clase base de la jerarquía.

    Es abstracta porque representa lo que tienen en común
    todos los asistentes, pero en este ejercicio no vamos
    a crear objetos que sean simplemente "Asistente".

    Las clases concretas serán:
        - General
        - VIP
        - Orador
*/
public abstract class Asistente
{
    /*
        =====================================================
        DNI
        =====================================================

        El estado interno se guarda en un atributo privado.
    */
    private int dni;


    /*
        Property pública para acceder al DNI.

        get -> permite leer el valor.
        set -> permite modificar el valor.
    */
    public int DNI
    {
        get { return dni; }
        set { dni = value; }
    }


    /*
        =====================================================
        NOMBRE
        =====================================================

        Igual que con dni, el atributo queda encapsulado
        dentro de la clase.
    */
    private string nombre;


    /*
        Property pública para acceder al nombre.
    */
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }


    /*
        =====================================================
        EQUALS
        =====================================================

        Equals() viene definido originalmente en object.

        Acá se redefine para establecer cuándo dos asistentes
        deben considerarse iguales.

        La decisión tomada en este ejercicio es:

            dos asistentes son iguales si tienen el mismo DNI.

        Esto será importante cuando Evento utilice
        HashSet<Asistente>.
    */
    public override bool Equals(object? obj)
    {
        return ((Asistente)obj).DNI == this.DNI;
    }


    /*
        =====================================================
        GETHASHCODE
        =====================================================

        GetHashCode() también viene de object.

        Se redefine utilizando el DNI.

        Esto acompaña el criterio usado en Equals():

            igualdad de asistentes -> mismo DNI

        HashSet utiliza Equals() y GetHashCode() para poder
        determinar si un elemento ya se encuentra registrado.
    */
    public override int GetHashCode()
    {
        return this.DNI;
    }


    /*
        =====================================================
        CONSTRUCTOR
        =====================================================

        Todo Asistente necesita tener al momento de crearse:

            - documento
            - nombre

        El constructor recibe esos datos y los guarda
        en las properties correspondientes.
    */
    public Asistente(int documento, string nombre)
    {
        this.Nombre = nombre;
        this.DNI = documento;
    }


    /*
        =====================================================
        COMPORTAMIENTO POLIMÓRFICO
        =====================================================

        Todos los asistentes deben poder informar
        sus beneficios.

        Pero Asistente NO define cómo hacerlo.

        Cada subclase deberá implementar este método
        según corresponda:

            General -> sus beneficios
            VIP     -> sus beneficios
            Orador  -> sus beneficios

        Por eso el método también es abstracto.
    */
    public abstract string InformarBeneficio();
}