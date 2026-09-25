using System;

public class Ambiente
{
    // 1. CAMPOS / ATRIBUTOS

    private string tipo;
    private double ancho;
    private double largo;
    private bool luminoso;


    // 2. CONSTRUCTOR

    public Ambiente(
        string tipo,
        double ancho,
        double largo,
        bool luminoso)
    {
        this.tipo = tipo;
        this.ancho = ancho;
        this.largo = largo;
        this.luminoso = luminoso;
    }


    // 3. PROPIEDADES / GETTERS Y SETTERS

    public string Tipo
    {
        get { return tipo; }
    }

    public double Ancho
    {
        get { return ancho; }
    }

    public double Largo
    {
        get { return largo; }
    }

    public bool Luminoso
    {
        get { return luminoso; }
    }


    // 4. MÉTODOS

    public bool EstaCompleto()
    {
        return tipo != null
            && tipo != ""
            && ancho > 0
            && largo > 0;
    }
}