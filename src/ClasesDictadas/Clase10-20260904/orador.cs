/*
    =========================================================
    ORADOR
    =========================================================

    Orador representa otro tipo concreto de asistente.

    Orador ES UN Asistente, por eso hereda de Asistente.

    Además de los datos comunes, agrega un dato propio:
    el tema de la charla que tiene asignada.
*/
public class Orador : Asistente
{
    /*
        =====================================================
        TEMA
        =====================================================

        Este atributo pertenece específicamente al Orador.

        Se mantiene privado para respetar el encapsulamiento.
    */
    private string tema;


    /*
        =====================================================
        CONSTRUCTOR
        =====================================================

        Para crear un Orador necesitamos:

            - documento
            - nombre
            - tema

        documento y nombre pertenecen a Asistente.

        tema pertenece específicamente a Orador.
    */
    public Orador(int documento, string nombre, string tema)
        : base(documento, nombre)
    {
        /*
            El constructor de Asistente ya inicializó
            documento y nombre.

            Acá inicializamos el dato particular
            del Orador.
        */
        Tema = tema;
    }


    /*
        =====================================================
        PROPERTY TEMA
        =====================================================

        Permite leer y modificar el atributo privado tema.
    */
    public string Tema
    {
        get { return tema; }
        set { tema = value; }
    }


    /*
        =====================================================
        INFORMAR BENEFICIO
        =====================================================

        Asistente declaró InformarBeneficio()
        como método abstracto.

        Orador implementa su propia respuesta.

        En este caso informa:

            - acceso total;
            - el tema de la charla asignada.
    */
    public override string InformarBeneficio()
    {
        return "Acceso total y dará la charla de " + tema;
    }
}