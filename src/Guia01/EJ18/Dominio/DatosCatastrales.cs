using System;

public class DatosCatastrales
{
    // 1. CAMPOS / ATRIBUTOS

    private string provincia;
    private string barrio;
    private string calle;
    private int altura;
    private string codigoPostal;


    // 2. CONSTRUCTOR

    public DatosCatastrales(
        string provincia,
        string barrio,
        string calle,
        int altura,
        string codigoPostal)
    {
        this.provincia = provincia;
        this.barrio = barrio;
        this.calle = calle;
        this.altura = altura;
        this.codigoPostal = codigoPostal;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS

    public string Provincia
    {
        get { return provincia; }
    }

    public string Barrio
    {
        get { return barrio; }
    }

    public string Calle
    {
        get { return calle; }
    }

    public int Altura
    {
        get { return altura; }
    }

    public string CodigoPostal
    {
        get { return codigoPostal; }
    }


    // 4. MÉTODOS
    public bool EstaCompleto()
    {
        return provincia != null
            && provincia != ""
            && barrio != null
            && barrio != ""
            && calle != null
            && calle != ""
            && altura > 0
            && codigoPostal != null
            && codigoPostal != "";
    }
}