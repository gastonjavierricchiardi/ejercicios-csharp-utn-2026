/*
    =========================================================
    VIP
    =========================================================

    VIP representa otro tipo concreto de asistente.

    VIP ES UN Asistente, por eso hereda de Asistente.

    A diferencia de General, VIP agrega un dato propio:
    el regalo elegido.
*/
public class VIP : Asistente
{
    /*
        =====================================================
        REGALO
        =====================================================

        Este atributo pertenece específicamente a VIP.

        Se mantiene privado para respetar el encapsulamiento.
    */
    private string regalo;


    /*
        =====================================================
        CONSTRUCTOR
        =====================================================

        Para crear un VIP necesitamos:

            - documento
            - nombre
            - regalo

        documento y nombre pertenecen a Asistente.

        regalo pertenece específicamente a VIP.
    */
    public VIP(int documento, string nombre, string regalo)
        : base(documento, nombre)
    {
        /*
            El constructor de la clase base ya se encargó
            de guardar documento y nombre.

            Acá solamente inicializamos el dato particular
            de VIP.
        */
        this.Regalo = regalo;
    }


    /*
        =====================================================
        PROPERTY REGALO
        =====================================================

        Permite leer y modificar el atributo privado regalo.
    */
    public string Regalo
    {
        get { return regalo; }
        set { regalo = value; }
    }


    /*
        =====================================================
        INFORMAR BENEFICIO
        =====================================================

        Asistente declaró InformarBeneficio()
        como abstracto.

        VIP implementa su propia respuesta.

        Sus beneficios son:

            - acceso a todas las charlas;
            - acceso al backstage;
            - un regalo.
    */
    public override string InformarBeneficio()
    {
        return "Acceso a todas las charlas, acceso al backstage y con un regalo " + regalo;
    }
}