// EJ22
using System;
public class Ley
{
    // 1. CAMPOS / ATRIBUTOS
    private int folio;
    private DateTime emision;
    private string desarrollo;
    private string firmante;

    public Ley(
        int folio,
        DateTime emision,
        string desarrollo,
        string firmante
    )
    {
        this.folio = folio;
        this.emision = emision;
        this.desarrollo = desarrollo;
        this.firmante = firmante;
    }

    public string Firmante
    {
        get { return firmante; }
        //set { firmante = value; }
    }
    public string Desarrollo
    {
        get { return desarrollo; }
        //set { desarrollo = value; }
    }
    public DateTime Emision
    {
        get { return emision; }
        //set { emision = value; }
    }
    public int Folio
    {
        get { return folio; }
        //set { folio = value; }
    }





    // Estado interno del objeto.
    // Normalmente private.

    // 2. CONSTRUCTOR
    // Recibe los datos necesarios al crear el objeto.

    // 3. PROPIEDADES / GETTERS Y SETTERS
    // Formas de exponer o modificar el estado.

    // 4. MÉTODOS
    // Comportamiento del objeto.
}
