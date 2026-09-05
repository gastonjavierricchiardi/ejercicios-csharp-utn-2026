## 1) `General.cs` — mismo código, comentado

```csharp
/*
    =========================================================
    GENERAL
    =========================================================

    General representa uno de los tipos concretos
    de asistentes del evento.

    General ES UN Asistente, por eso hereda de Asistente.
*/
public class General : Asistente
{
    /*
        =====================================================
        CONSTRUCTOR
        =====================================================

        Para crear un asistente General necesitamos:

            - documento
            - nombre

        Estos datos ya pertenecen a Asistente.

        Por eso el constructor de General los recibe
        y los envía al constructor de la clase base
        mediante base(documento, nombre).
    */
    public General(int documento, string nombre)
        : base(documento, nombre)
    {
    }


    /*
        =====================================================
        INFORMAR BENEFICIO
        =====================================================

        Asistente declaró InformarBeneficio()
        como un método abstracto.

        Por eso General está obligado a implementar
        su propia versión.

        En este caso, el beneficio específico del
        asistente General es:

            "Acceso a las charlas"
    */
    public override string InformarBeneficio()
    {
        return "Acceso a las charlas";
    }
}